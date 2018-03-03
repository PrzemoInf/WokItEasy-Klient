using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;//watek
using System.Data.OleDb;//access


namespace Client
{
    public partial class Form1 : Form
    {
        List<Skladnik> l_Skladnik = new List<Skladnik>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            ASCIIEncoding asen = new ASCIIEncoding();
            TcpClient tcpclnt = new TcpClient();
            tcpclnt.Connect(IPBox.Text, 8001);
            Stream stm = tcpclnt.GetStream();
            string str;
            byte[] ba;
            byte[] bb;
            string tekst;
            int k;
            do
            {
                str = "L";//Przesłanie komunikatu o checi zalogowania
                ba = asen.GetBytes(str);
                stm.Write(ba, 0, ba.Length);
                bb = new byte[100];
                k = stm.Read(bb, 0, 100);
                tekst = "";
                for (int i = 0; i < k; i++) tekst += (Convert.ToChar(bb[i]));
            } while (tekst != "OK");//potwierdzenie od serwera o przyjeciu checi logowania
            

            str = textBox1.Text + " " + textBox2.Text;//login i hasło
            ba = asen.GetBytes(str);
            stm.Write(ba, 0, ba.Length);
            bb = new byte[100];
            k = stm.Read(bb, 0, 100);
            tekst = "";
            for (int i = 0; i < k; i++)tekst+= (Convert.ToChar(bb[i]));
            if (tekst == "C")
            {
                using (var output = File.Create(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\WokItEasy1.txt")))
                {
                    var buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stm.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                }
                sr = new StreamReader(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\WokItEasy1.txt"));
                string text = sr.ReadLine();
                int ilosc = Convert.ToInt32(text);
                for (int i = 0; i < ilosc; i++)
                {
                    text = sr.ReadLine();
                    string[] splited = text.Split(' ');
                    Skladnik skladnik = new Skladnik();
                    skladnik.IdSM = Convert.ToInt32(splited[0]);
                    skladnik.NazwaSM = splited[1];
                    skladnik.RodzajSM = splited[2];
                    skladnik.CenaSM = Convert.ToDouble(splited[3]);
                    l_Skladnik.Add(skladnik);
                }
                foreach (var skladnik in l_Skladnik)
                {
                    tekst = skladnik.NazwaSM + "\t Cena: " + skladnik.CenaSM;
                    ProductList.Items.Add(tekst);
                }
                OrderBox.Visible = true;
                ProductList.Visible = true;
                Dodaj.Visible = true;
                Delete.Visible = true;
                SendOrder.Visible = true;

            } 
            else if (tekst == "W") MessageBox.Show("Niepoprawne dane");
            tcpclnt.Close();
            
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            OrderBox.Items.Add(ProductList.Text);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //OrderBox.Items.Remove(OrderBox.SelectedIndex);
            if (this.OrderBox.SelectedIndex >= 0)
                this.OrderBox.Items.RemoveAt(this.OrderBox.SelectedIndex);
        }

        private void SendOrder_Click(object sender, EventArgs e)
        {
            ASCIIEncoding asen = new ASCIIEncoding();
            TcpClient tcpclnt = new TcpClient();
            tcpclnt.Connect("127.0.0.1", 8001);
            Stream stm = tcpclnt.GetStream();
            string str;
            byte[] ba;
            byte[] bb;
            string tekst;
            int k;
            do
            {
                str = "O";//Przesłanie komunikatu o checi przeslania zamowienia
                ba = asen.GetBytes(str);
                stm.Write(ba, 0, ba.Length);
                bb = new byte[100];
                k = stm.Read(bb, 0, 100);
                tekst = "";
                for (int i = 0; i < k; i++) tekst += (Convert.ToChar(bb[i]));
            } while (tekst != "OK");//potwierdzenie od serwera o przyjeciu checi logowania
            do
            {
                str = Convert.ToString(OrderBox.Items.Count);//wysłanie komunikatu o ilosci elementów w zamówieniu
                ba = asen.GetBytes(str);
                stm.Write(ba, 0, ba.Length);
                bb = new byte[100];
                k = stm.Read(bb, 0, 100);
                tekst = "";
                for (int i = 0; i < k; i++) tekst += (Convert.ToChar(bb[i]));
            } while (tekst != "OK");//potwierdzenie od serwera o przyjeciu ilosci elementów
            string text="";
            for (int i = 0; i <(OrderBox.Items.Count);i++)// przesył zamówień
            {
                text = OrderBox.Items[i].ToString();
                string[] split = text.Split('\t');
                //MessageBox.Show(split[0]);
                int id = -1;
                foreach(var skladnik in l_Skladnik)//ustalanie id produktu
                {
                    if (skladnik.NazwaSM == split[0] && id < 0)
                    {
                        id = skladnik.IdSM;
                        //MessageBox.Show(Convert.ToString(id));
                        break;
                    }
                    
                    
                    
                }
                
                do//przesył id produktu
                {
                    str = Convert.ToString(id);
                    ba = asen.GetBytes(str);
                    stm.Write(ba, 0, ba.Length);
                    bb = new byte[100];
                    k = stm.Read(bb, 0, 100);
                    tekst = "";
                    for (int j = 0; j < k; j++) tekst += (Convert.ToChar(bb[j]));
                } while (tekst != "OK");
                
            }
            tcpclnt.Close();
        }
    }
}
