namespace OTOPARK_OTOMASYONU06
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TC = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.Soyadı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AraçTipi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plaka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC
            // 
            this.TC.Location = new System.Drawing.Point(270, 131);
            this.TC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TC.MaxLength = 11;
            this.TC.Name = "TC";
            this.TC.ShortcutsEnabled = false;
            this.TC.Size = new System.Drawing.Size(178, 30);
            this.TC.TabIndex = 0;
            this.TC.Text = "0";
            this.TC.TextChanged += new System.EventHandler(this.TC_TextChanged);
            this.TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TC_KeyPress);
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(44, 131);
            this.Telefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Telefon.MaxLength = 11;
            this.Telefon.Name = "Telefon";
            this.Telefon.ShortcutsEnabled = false;
            this.Telefon.Size = new System.Drawing.Size(178, 30);
            this.Telefon.TabIndex = 6;
            this.Telefon.TextChanged += new System.EventHandler(this.Telefon_TextChanged);
            this.Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefon_KeyPress);
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.Location = new System.Drawing.Point(44, 71);
            this.KullanıcıAdı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            this.KullanıcıAdı.ShortcutsEnabled = false;
            this.KullanıcıAdı.Size = new System.Drawing.Size(178, 30);
            this.KullanıcıAdı.TabIndex = 7;
            this.KullanıcıAdı.TextChanged += new System.EventHandler(this.KullanıcıAdı_TextChanged);
            this.KullanıcıAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KullanıcıAdı_KeyPress);
            // 
            // Soyadı
            // 
            this.Soyadı.Location = new System.Drawing.Point(270, 71);
            this.Soyadı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Soyadı.Name = "Soyadı";
            this.Soyadı.ShortcutsEnabled = false;
            this.Soyadı.Size = new System.Drawing.Size(178, 30);
            this.Soyadı.TabIndex = 8;
            this.Soyadı.TextChanged += new System.EventHandler(this.Soyadı_TextChanged);
            this.Soyadı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Soyadı_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "İsim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AraçTipi);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.plaka);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Soyadı);
            this.groupBox1.Controls.Add(this.KullanıcıAdı);
            this.groupBox1.Controls.Add(this.Telefon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TC);
            this.groupBox1.Location = new System.Drawing.Point(424, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(462, 474);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AraçTipi
            // 
            this.AraçTipi.Location = new System.Drawing.Point(270, 283);
            this.AraçTipi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AraçTipi.MaxLength = 1;
            this.AraçTipi.Name = "AraçTipi";
            this.AraçTipi.ShortcutsEnabled = false;
            this.AraçTipi.Size = new System.Drawing.Size(178, 30);
            this.AraçTipi.TabIndex = 20;
            this.AraçTipi.TextChanged += new System.EventHandler(this.AraçTipi_TextChanged_1);
            this.AraçTipi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AraçTipi_KeyPress_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "1-Motor",
            "2-Otomobil",
            "3-Kamyon,İş Makinesi",
            "4-Tır,Minibüs,Kamyonet"});
            this.listBox1.Location = new System.Drawing.Point(270, 341);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 96);
            this.listBox1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(168, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "Kullanıcı Kaydet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Araç Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Plaka";
            // 
            // plaka
            // 
            this.plaka.Location = new System.Drawing.Point(44, 283);
            this.plaka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plaka.MaxLength = 11;
            this.plaka.Name = "plaka";
            this.plaka.ShortcutsEnabled = false;
            this.plaka.Size = new System.Drawing.Size(178, 30);
            this.plaka.TabIndex = 16;
            this.plaka.TextChanged += new System.EventHandler(this.plaka_TextChanged);
            this.plaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plaka_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(44, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Araç Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "T.C Kimlik Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 145);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.MaxLength = 11;
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(296, 30);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(82, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sorgula";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "MÜŞTERİ SORGULAMA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(61, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = " T.C Kimlik Numarası";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(900, 494);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TC;
        private TextBox Telefon;
        private TextBox KullanıcıAdı;
        private TextBox Soyadı;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label7;
        private Label label6;
        private TextBox plaka;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Label label5;
        private ListBox listBox1;
        private Label label8;
        private TextBox AraçTipi;
    }
}