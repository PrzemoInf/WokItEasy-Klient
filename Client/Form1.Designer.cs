namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.OrderBox = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SendOrder = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "połącz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(13, 13);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(13, 48);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(36, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Hasło";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(16, 114);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(214, 21);
            this.ProductList.TabIndex = 5;
            this.ProductList.Visible = false;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(236, 112);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 9;
            this.Dodaj.Text = "Dodaj>>";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Visible = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // OrderBox
            // 
            this.OrderBox.FormattingEnabled = true;
            this.OrderBox.Location = new System.Drawing.Point(317, 114);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(215, 277);
            this.OrderBox.TabIndex = 10;
            this.OrderBox.Visible = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(236, 141);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "<<Usuń";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SendOrder
            // 
            this.SendOrder.Location = new System.Drawing.Point(236, 358);
            this.SendOrder.Name = "SendOrder";
            this.SendOrder.Size = new System.Drawing.Size(75, 23);
            this.SendOrder.TabIndex = 12;
            this.SendOrder.Text = "Wyślij->";
            this.SendOrder.UseVisualStyleBackColor = true;
            this.SendOrder.Visible = false;
            this.SendOrder.Click += new System.EventHandler(this.SendOrder_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(208, 16);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 13;
            this.IPBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.SendOrder);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.OrderBox);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.ListBox OrderBox;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button SendOrder;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label label1;
    }
}

