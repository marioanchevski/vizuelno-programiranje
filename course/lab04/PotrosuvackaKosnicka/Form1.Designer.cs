namespace PotrosuvackaKosnicka
{
    partial class Form1
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
            this.lbProdukti = new System.Windows.Forms.ListBox();
            this.btnIsprazniP = new System.Windows.Forms.Button();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzbrisiKos = new System.Windows.Forms.Button();
            this.lbKosnicka = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddKos = new System.Windows.Forms.Button();
            this.btnDelKos = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.tbZaliha = new System.Windows.Forms.TextBox();
            this.Залиха = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdukti
            // 
            this.lbProdukti.FormattingEnabled = true;
            this.lbProdukti.Location = new System.Drawing.Point(12, 26);
            this.lbProdukti.Name = "lbProdukti";
            this.lbProdukti.Size = new System.Drawing.Size(215, 290);
            this.lbProdukti.TabIndex = 0;
            this.lbProdukti.SelectedIndexChanged += new System.EventHandler(this.lbProdukti_SelectedIndexChanged);
            // 
            // btnIsprazniP
            // 
            this.btnIsprazniP.Location = new System.Drawing.Point(12, 322);
            this.btnIsprazniP.Name = "btnIsprazniP";
            this.btnIsprazniP.Size = new System.Drawing.Size(215, 23);
            this.btnIsprazniP.TabIndex = 1;
            this.btnIsprazniP.Text = "Испразни ја листата со продукти?";
            this.btnIsprazniP.UseVisualStyleBackColor = true;
            this.btnIsprazniP.Click += new System.EventHandler(this.btnIsprazniP_Click);
            // 
            // tbVkupno
            // 
            this.tbVkupno.Enabled = false;
            this.tbVkupno.Location = new System.Drawing.Point(565, 296);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.Size = new System.Drawing.Size(167, 20);
            this.tbVkupno.TabIndex = 2;
            this.tbVkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Листа на продукти";
            // 
            // btnIzbrisiKos
            // 
            this.btnIzbrisiKos.Location = new System.Drawing.Point(517, 322);
            this.btnIzbrisiKos.Name = "btnIzbrisiKos";
            this.btnIzbrisiKos.Size = new System.Drawing.Size(215, 23);
            this.btnIzbrisiKos.TabIndex = 5;
            this.btnIzbrisiKos.Text = "Избриши ја кошничката?";
            this.btnIzbrisiKos.UseVisualStyleBackColor = true;
            this.btnIzbrisiKos.Click += new System.EventHandler(this.btnIzbrisiKos_Click);
            // 
            // lbKosnicka
            // 
            this.lbKosnicka.FormattingEnabled = true;
            this.lbKosnicka.Location = new System.Drawing.Point(517, 26);
            this.lbKosnicka.Name = "lbKosnicka";
            this.lbKosnicka.Size = new System.Drawing.Size(215, 264);
            this.lbKosnicka.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кошничка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вкупно";
            // 
            // btnAddKos
            // 
            this.btnAddKos.Location = new System.Drawing.Point(238, 223);
            this.btnAddKos.Name = "btnAddKos";
            this.btnAddKos.Size = new System.Drawing.Size(180, 23);
            this.btnAddKos.TabIndex = 8;
            this.btnAddKos.Text = "Додади во кошничка>>";
            this.btnAddKos.UseVisualStyleBackColor = true;
            this.btnAddKos.Click += new System.EventHandler(this.btnAddKos_Click);
            // 
            // btnDelKos
            // 
            this.btnDelKos.Location = new System.Drawing.Point(238, 252);
            this.btnDelKos.Name = "btnDelKos";
            this.btnDelKos.Size = new System.Drawing.Size(262, 23);
            this.btnDelKos.TabIndex = 9;
            this.btnDelKos.Text = "Избриши од кошничка";
            this.btnDelKos.UseVisualStyleBackColor = true;
            this.btnDelKos.Click += new System.EventHandler(this.btnDelKos_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(238, 281);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(262, 23);
            this.btnAddProd.TabIndex = 10;
            this.btnAddProd.Text = "Додади нов продукт";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnDelProd
            // 
            this.btnDelProd.Location = new System.Drawing.Point(238, 310);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(262, 23);
            this.btnDelProd.TabIndex = 11;
            this.btnDelProd.Text = "Избриши продукт";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Залиха);
            this.groupBox1.Controls.Add(this.tbZaliha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbKategorija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Location = new System.Drawing.Point(233, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 175);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Цена";
            // 
            // tbCena
            // 
            this.tbCena.Enabled = false;
            this.tbCena.Location = new System.Drawing.Point(11, 123);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(106, 20);
            this.tbCena.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Категорија";
            // 
            // tbKategorija
            // 
            this.tbKategorija.Enabled = false;
            this.tbKategorija.Location = new System.Drawing.Point(11, 80);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.Size = new System.Drawing.Size(250, 20);
            this.tbKategorija.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Име";
            // 
            // tbIme
            // 
            this.tbIme.Enabled = false;
            this.tbIme.Location = new System.Drawing.Point(11, 40);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(250, 20);
            this.tbIme.TabIndex = 13;
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(425, 225);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(75, 20);
            this.nudKolicina.TabIndex = 13;
            // 
            // tbZaliha
            // 
            this.tbZaliha.Enabled = false;
            this.tbZaliha.Location = new System.Drawing.Point(155, 123);
            this.tbZaliha.Name = "tbZaliha";
            this.tbZaliha.Size = new System.Drawing.Size(106, 20);
            this.tbZaliha.TabIndex = 19;
            // 
            // Залиха
            // 
            this.Залиха.AutoSize = true;
            this.Залиха.Location = new System.Drawing.Point(152, 103);
            this.Залиха.Name = "Залиха";
            this.Залиха.Size = new System.Drawing.Size(43, 13);
            this.Залиха.TabIndex = 20;
            this.Залиха.Text = "Залиха";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 357);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnDelKos);
            this.Controls.Add(this.btnAddKos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzbrisiKos);
            this.Controls.Add(this.lbKosnicka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVkupno);
            this.Controls.Add(this.btnIsprazniP);
            this.Controls.Add(this.lbProdukti);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProdukti;
        private System.Windows.Forms.Button btnIsprazniP;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrisiKos;
        private System.Windows.Forms.ListBox lbKosnicka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddKos;
        private System.Windows.Forms.Button btnDelKos;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKategorija;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Label Залиха;
        private System.Windows.Forms.TextBox tbZaliha;
    }
}

