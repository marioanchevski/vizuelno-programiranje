namespace Lab3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.tbGolema = new System.Windows.Forms.TextBox();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.tbSredna = new System.Windows.Forms.TextBox();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.tbMala = new System.Windows.Forms.TextBox();
            this.Додатоци = new System.Windows.Forms.GroupBox();
            this.cbKecap = new System.Windows.Forms.CheckBox();
            this.cbSirenje = new System.Windows.Forms.CheckBox();
            this.cbFeferoni = new System.Windows.Forms.CheckBox();
            this.tbKecap = new System.Windows.Forms.TextBox();
            this.tbFeferoni = new System.Windows.Forms.TextBox();
            this.tbSirenje = new System.Windows.Forms.TextBox();
            this.Пијалок = new System.Windows.Forms.GroupBox();
            this.tbPivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVkupnoPivo = new System.Windows.Forms.TextBox();
            this.tbVkupnoG = new System.Windows.Forms.TextBox();
            this.tbVkupnoSok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCenaPivo = new System.Windows.Forms.TextBox();
            this.tbCenaG = new System.Windows.Forms.TextBox();
            this.tbCenaSok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGaziran = new System.Windows.Forms.TextBox();
            this.tbSok = new System.Windows.Forms.TextBox();
            this.сд = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbZaVrakanje = new System.Windows.Forms.TextBox();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.tbNaplateno = new System.Windows.Forms.TextBox();
            this.с = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDesertCena = new System.Windows.Forms.TextBox();
            this.Име = new System.Windows.Forms.Label();
            this.lbDeserti = new System.Windows.Forms.ListBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnNaracaj = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDesertIme = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Додатоци.SuspendLayout();
            this.Пијалок.SuspendLayout();
            this.сд.SuspendLayout();
            this.с.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGolema);
            this.groupBox1.Controls.Add(this.tbGolema);
            this.groupBox1.Controls.Add(this.rbSredna);
            this.groupBox1.Controls.Add(this.tbSredna);
            this.groupBox1.Controls.Add(this.rbMala);
            this.groupBox1.Controls.Add(this.tbMala);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(6, 96);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(63, 17);
            this.rbGolema.TabIndex = 6;
            this.rbGolema.TabStop = true;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // tbGolema
            // 
            this.tbGolema.Location = new System.Drawing.Point(105, 93);
            this.tbGolema.Name = "tbGolema";
            this.tbGolema.Size = new System.Drawing.Size(100, 20);
            this.tbGolema.TabIndex = 7;
            this.tbGolema.Text = "500";
            this.tbGolema.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(6, 59);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(62, 17);
            this.rbSredna.TabIndex = 4;
            this.rbSredna.TabStop = true;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // tbSredna
            // 
            this.tbSredna.Location = new System.Drawing.Point(105, 56);
            this.tbSredna.Name = "tbSredna";
            this.tbSredna.Size = new System.Drawing.Size(100, 20);
            this.tbSredna.TabIndex = 5;
            this.tbSredna.Text = "300";
            this.tbSredna.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Location = new System.Drawing.Point(6, 22);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(52, 17);
            this.rbMala.TabIndex = 2;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // tbMala
            // 
            this.tbMala.Location = new System.Drawing.Point(105, 19);
            this.tbMala.Name = "tbMala";
            this.tbMala.Size = new System.Drawing.Size(100, 20);
            this.tbMala.TabIndex = 3;
            this.tbMala.Text = "200";
            this.tbMala.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // Додатоци
            // 
            this.Додатоци.Controls.Add(this.cbKecap);
            this.Додатоци.Controls.Add(this.cbSirenje);
            this.Додатоци.Controls.Add(this.cbFeferoni);
            this.Додатоци.Controls.Add(this.tbKecap);
            this.Додатоци.Controls.Add(this.tbFeferoni);
            this.Додатоци.Controls.Add(this.tbSirenje);
            this.Додатоци.Location = new System.Drawing.Point(408, 31);
            this.Додатоци.Name = "Додатоци";
            this.Додатоци.Size = new System.Drawing.Size(229, 133);
            this.Додатоци.TabIndex = 1;
            this.Додатоци.TabStop = false;
            this.Додатоци.Text = "Додатоци";
            // 
            // cbKecap
            // 
            this.cbKecap.AutoSize = true;
            this.cbKecap.Location = new System.Drawing.Point(6, 90);
            this.cbKecap.Name = "cbKecap";
            this.cbKecap.Size = new System.Drawing.Size(56, 17);
            this.cbKecap.TabIndex = 16;
            this.cbKecap.Text = "Кечап";
            this.cbKecap.UseVisualStyleBackColor = true;
            this.cbKecap.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // cbSirenje
            // 
            this.cbSirenje.AutoSize = true;
            this.cbSirenje.Location = new System.Drawing.Point(6, 55);
            this.cbSirenje.Name = "cbSirenje";
            this.cbSirenje.Size = new System.Drawing.Size(105, 17);
            this.cbSirenje.TabIndex = 15;
            this.cbSirenje.Text = "Екстра сирење";
            this.cbSirenje.UseVisualStyleBackColor = true;
            this.cbSirenje.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // cbFeferoni
            // 
            this.cbFeferoni.AutoSize = true;
            this.cbFeferoni.Location = new System.Drawing.Point(6, 19);
            this.cbFeferoni.Name = "cbFeferoni";
            this.cbFeferoni.Size = new System.Drawing.Size(81, 17);
            this.cbFeferoni.TabIndex = 14;
            this.cbFeferoni.Text = "Феферони";
            this.cbFeferoni.UseVisualStyleBackColor = true;
            this.cbFeferoni.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // tbKecap
            // 
            this.tbKecap.Location = new System.Drawing.Point(115, 90);
            this.tbKecap.Name = "tbKecap";
            this.tbKecap.Size = new System.Drawing.Size(100, 20);
            this.tbKecap.TabIndex = 13;
            this.tbKecap.Text = "20";
            this.tbKecap.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // tbFeferoni
            // 
            this.tbFeferoni.Location = new System.Drawing.Point(115, 16);
            this.tbFeferoni.Name = "tbFeferoni";
            this.tbFeferoni.Size = new System.Drawing.Size(100, 20);
            this.tbFeferoni.TabIndex = 9;
            this.tbFeferoni.Text = "40";
            this.tbFeferoni.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // tbSirenje
            // 
            this.tbSirenje.Location = new System.Drawing.Point(115, 53);
            this.tbSirenje.Name = "tbSirenje";
            this.tbSirenje.Size = new System.Drawing.Size(100, 20);
            this.tbSirenje.TabIndex = 11;
            this.tbSirenje.Text = "30";
            this.tbSirenje.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // Пијалок
            // 
            this.Пијалок.Controls.Add(this.tbPivo);
            this.Пијалок.Controls.Add(this.label2);
            this.Пијалок.Controls.Add(this.tbVkupnoPivo);
            this.Пијалок.Controls.Add(this.tbVkupnoG);
            this.Пијалок.Controls.Add(this.tbVkupnoSok);
            this.Пијалок.Controls.Add(this.label1);
            this.Пијалок.Controls.Add(this.tbCenaPivo);
            this.Пијалок.Controls.Add(this.tbCenaG);
            this.Пијалок.Controls.Add(this.tbCenaSok);
            this.Пијалок.Controls.Add(this.label9);
            this.Пијалок.Controls.Add(this.label5);
            this.Пијалок.Controls.Add(this.label4);
            this.Пијалок.Controls.Add(this.label3);
            this.Пијалок.Controls.Add(this.tbGaziran);
            this.Пијалок.Controls.Add(this.tbSok);
            this.Пијалок.Location = new System.Drawing.Point(18, 181);
            this.Пијалок.Name = "Пијалок";
            this.Пијалок.Size = new System.Drawing.Size(619, 146);
            this.Пијалок.TabIndex = 17;
            this.Пијалок.TabStop = false;
            this.Пијалок.Text = "Пијалок";
            // 
            // tbPivo
            // 
            this.tbPivo.Location = new System.Drawing.Point(177, 109);
            this.tbPivo.Name = "tbPivo";
            this.tbPivo.Size = new System.Drawing.Size(100, 20);
            this.tbPivo.TabIndex = 32;
            this.tbPivo.Text = "0";
            this.tbPivo.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Вкупно";
            // 
            // tbVkupnoPivo
            // 
            this.tbVkupnoPivo.Location = new System.Drawing.Point(467, 109);
            this.tbVkupnoPivo.Name = "tbVkupnoPivo";
            this.tbVkupnoPivo.ReadOnly = true;
            this.tbVkupnoPivo.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoPivo.TabIndex = 30;
            // 
            // tbVkupnoG
            // 
            this.tbVkupnoG.Location = new System.Drawing.Point(467, 47);
            this.tbVkupnoG.Name = "tbVkupnoG";
            this.tbVkupnoG.ReadOnly = true;
            this.tbVkupnoG.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoG.TabIndex = 28;
            // 
            // tbVkupnoSok
            // 
            this.tbVkupnoSok.Location = new System.Drawing.Point(467, 77);
            this.tbVkupnoSok.Name = "tbVkupnoSok";
            this.tbVkupnoSok.ReadOnly = true;
            this.tbVkupnoSok.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoSok.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Цена";
            // 
            // tbCenaPivo
            // 
            this.tbCenaPivo.Location = new System.Drawing.Point(323, 109);
            this.tbCenaPivo.Name = "tbCenaPivo";
            this.tbCenaPivo.ReadOnly = true;
            this.tbCenaPivo.Size = new System.Drawing.Size(100, 20);
            this.tbCenaPivo.TabIndex = 26;
            this.tbCenaPivo.Text = "80";
            // 
            // tbCenaG
            // 
            this.tbCenaG.Location = new System.Drawing.Point(323, 47);
            this.tbCenaG.Name = "tbCenaG";
            this.tbCenaG.ReadOnly = true;
            this.tbCenaG.Size = new System.Drawing.Size(100, 20);
            this.tbCenaG.TabIndex = 24;
            this.tbCenaG.Text = "60";
            // 
            // tbCenaSok
            // 
            this.tbCenaSok.Location = new System.Drawing.Point(323, 77);
            this.tbCenaSok.Name = "tbCenaSok";
            this.tbCenaSok.ReadOnly = true;
            this.tbCenaSok.Size = new System.Drawing.Size(100, 20);
            this.tbCenaSok.TabIndex = 25;
            this.tbCenaSok.Text = "70";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Количина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Пиво";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Сок од јаболко / портокал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Кока кола / Фанта / Спрајт";
            // 
            // tbGaziran
            // 
            this.tbGaziran.Location = new System.Drawing.Point(177, 47);
            this.tbGaziran.Name = "tbGaziran";
            this.tbGaziran.Size = new System.Drawing.Size(100, 20);
            this.tbGaziran.TabIndex = 9;
            this.tbGaziran.Text = "0";
            this.tbGaziran.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // tbSok
            // 
            this.tbSok.Location = new System.Drawing.Point(177, 77);
            this.tbSok.Name = "tbSok";
            this.tbSok.Size = new System.Drawing.Size(100, 20);
            this.tbSok.TabIndex = 11;
            this.tbSok.Text = "0";
            this.tbSok.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // сд
            // 
            this.сд.Controls.Add(this.label6);
            this.сд.Controls.Add(this.label7);
            this.сд.Controls.Add(this.label8);
            this.сд.Controls.Add(this.tbZaVrakanje);
            this.сд.Controls.Add(this.tbVkupno);
            this.сд.Controls.Add(this.tbNaplateno);
            this.сд.Location = new System.Drawing.Point(408, 404);
            this.сд.Name = "сд";
            this.сд.Size = new System.Drawing.Size(229, 133);
            this.сд.TabIndex = 23;
            this.сд.TabStop = false;
            this.сд.Text = "Наплата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "За враќање";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Наплатено";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Вкупно за плаќање";
            // 
            // tbZaVrakanje
            // 
            this.tbZaVrakanje.Location = new System.Drawing.Point(115, 90);
            this.tbZaVrakanje.Name = "tbZaVrakanje";
            this.tbZaVrakanje.Size = new System.Drawing.Size(100, 20);
            this.tbZaVrakanje.TabIndex = 13;
            // 
            // tbVkupno
            // 
            this.tbVkupno.Location = new System.Drawing.Point(115, 16);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.Size = new System.Drawing.Size(100, 20);
            this.tbVkupno.TabIndex = 9;
            // 
            // tbNaplateno
            // 
            this.tbNaplateno.Location = new System.Drawing.Point(115, 53);
            this.tbNaplateno.Name = "tbNaplateno";
            this.tbNaplateno.Size = new System.Drawing.Size(100, 20);
            this.tbNaplateno.TabIndex = 11;
            this.tbNaplateno.TextChanged += new System.EventHandler(this.rbMala_CheckedChanged_1);
            // 
            // с
            // 
            this.с.Controls.Add(this.label10);
            this.с.Controls.Add(this.tbDesertCena);
            this.с.Controls.Add(this.Име);
            this.с.Controls.Add(this.lbDeserti);
            this.с.Controls.Add(this.btnOtkazi);
            this.с.Controls.Add(this.btnNaracaj);
            this.с.Controls.Add(this.label12);
            this.с.Controls.Add(this.tbDesertIme);
            this.с.Location = new System.Drawing.Point(18, 349);
            this.с.Name = "с";
            this.с.Size = new System.Drawing.Size(350, 188);
            this.с.TabIndex = 24;
            this.с.TabStop = false;
            this.с.Text = "Десерт";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Цена";
            // 
            // tbDesertCena
            // 
            this.tbDesertCena.Location = new System.Drawing.Point(221, 96);
            this.tbDesertCena.Name = "tbDesertCena";
            this.tbDesertCena.Size = new System.Drawing.Size(100, 20);
            this.tbDesertCena.TabIndex = 28;
            // 
            // Име
            // 
            this.Име.AutoSize = true;
            this.Име.Location = new System.Drawing.Point(157, 59);
            this.Име.Name = "Име";
            this.Име.Size = new System.Drawing.Size(29, 13);
            this.Име.TabIndex = 27;
            this.Име.Text = "Име";
            // 
            // lbDeserti
            // 
            this.lbDeserti.FormattingEnabled = true;
            this.lbDeserti.Location = new System.Drawing.Point(3, 35);
            this.lbDeserti.Name = "lbDeserti";
            this.lbDeserti.Size = new System.Drawing.Size(106, 134);
            this.lbDeserti.TabIndex = 26;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(133, 149);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 23);
            this.btnOtkazi.TabIndex = 25;
            this.btnOtkazi.Text = "Dodadi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnNaracaj
            // 
            this.btnNaracaj.Location = new System.Drawing.Point(239, 149);
            this.btnNaracaj.Name = "btnNaracaj";
            this.btnNaracaj.Size = new System.Drawing.Size(100, 23);
            this.btnNaracaj.TabIndex = 24;
            this.btnNaracaj.Text = "Izbrisi";
            this.btnNaracaj.UseVisualStyleBackColor = true;
            this.btnNaracaj.Click += new System.EventHandler(this.btnNaracaj_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Цена на десерт";
            // 
            // tbDesertIme
            // 
            this.tbDesertIme.Location = new System.Drawing.Point(221, 52);
            this.tbDesertIme.Name = "tbDesertIme";
            this.tbDesertIme.Size = new System.Drawing.Size(100, 20);
            this.tbDesertIme.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 573);
            this.Controls.Add(this.с);
            this.Controls.Add(this.сд);
            this.Controls.Add(this.Пијалок);
            this.Controls.Add(this.Додатоци);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Нарачка на пица";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Додатоци.ResumeLayout(false);
            this.Додатоци.PerformLayout();
            this.Пијалок.ResumeLayout(false);
            this.Пијалок.PerformLayout();
            this.сд.ResumeLayout(false);
            this.сд.PerformLayout();
            this.с.ResumeLayout(false);
            this.с.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.TextBox tbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.TextBox tbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.TextBox tbMala;
        private System.Windows.Forms.GroupBox Додатоци;
        private System.Windows.Forms.CheckBox cbKecap;
        private System.Windows.Forms.CheckBox cbSirenje;
        private System.Windows.Forms.CheckBox cbFeferoni;
        private System.Windows.Forms.TextBox tbKecap;
        private System.Windows.Forms.TextBox tbFeferoni;
        private System.Windows.Forms.TextBox tbSirenje;
        private System.Windows.Forms.GroupBox Пијалок;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVkupnoPivo;
        private System.Windows.Forms.TextBox tbVkupnoG;
        private System.Windows.Forms.TextBox tbVkupnoSok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCenaPivo;
        private System.Windows.Forms.TextBox tbCenaG;
        private System.Windows.Forms.TextBox tbCenaSok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGaziran;
        private System.Windows.Forms.TextBox tbSok;
        private System.Windows.Forms.GroupBox сд;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbZaVrakanje;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.TextBox tbNaplateno;
        private System.Windows.Forms.GroupBox с;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDesertCena;
        private System.Windows.Forms.Label Име;
        private System.Windows.Forms.ListBox lbDeserti;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnNaracaj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDesertIme;
        private System.Windows.Forms.TextBox tbPivo;
    }
}

