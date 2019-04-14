namespace Airplanes
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
            this.lbAerodromi = new System.Windows.Forms.ListBox();
            this.tbNajskapa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodadiA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDestinacii = new System.Windows.Forms.ListBox();
            this.btnIzbrisiA = new System.Windows.Forms.Button();
            this.btnDodadiD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProsecna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAerodromi
            // 
            this.lbAerodromi.FormattingEnabled = true;
            this.lbAerodromi.Location = new System.Drawing.Point(38, 36);
            this.lbAerodromi.Name = "lbAerodromi";
            this.lbAerodromi.Size = new System.Drawing.Size(239, 225);
            this.lbAerodromi.TabIndex = 0;
            this.lbAerodromi.SelectedIndexChanged += new System.EventHandler(this.lbAerodromi_SelectedIndexChanged);
            // 
            // tbNajskapa
            // 
            this.tbNajskapa.Enabled = false;
            this.tbNajskapa.Location = new System.Drawing.Point(6, 30);
            this.tbNajskapa.Name = "tbNajskapa";
            this.tbNajskapa.Size = new System.Drawing.Size(224, 20);
            this.tbNajskapa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Аеродроми";
            // 
            // btnDodadiA
            // 
            this.btnDodadiA.Location = new System.Drawing.Point(38, 279);
            this.btnDodadiA.Name = "btnDodadiA";
            this.btnDodadiA.Size = new System.Drawing.Size(239, 23);
            this.btnDodadiA.TabIndex = 3;
            this.btnDodadiA.Text = "Додади аеродром";
            this.btnDodadiA.UseVisualStyleBackColor = true;
            this.btnDodadiA.Click += new System.EventHandler(this.btnDodadiA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дестинации";
            // 
            // lbDestinacii
            // 
            this.lbDestinacii.FormattingEnabled = true;
            this.lbDestinacii.Location = new System.Drawing.Point(299, 36);
            this.lbDestinacii.Name = "lbDestinacii";
            this.lbDestinacii.Size = new System.Drawing.Size(239, 225);
            this.lbDestinacii.TabIndex = 4;
            // 
            // btnIzbrisiA
            // 
            this.btnIzbrisiA.Enabled = false;
            this.btnIzbrisiA.Location = new System.Drawing.Point(38, 313);
            this.btnIzbrisiA.Name = "btnIzbrisiA";
            this.btnIzbrisiA.Size = new System.Drawing.Size(239, 23);
            this.btnIzbrisiA.TabIndex = 6;
            this.btnIzbrisiA.Text = "Избриши аеродром";
            this.btnIzbrisiA.UseVisualStyleBackColor = true;
            this.btnIzbrisiA.Click += new System.EventHandler(this.btnIzbrisiA_Click);
            // 
            // btnDodadiD
            // 
            this.btnDodadiD.Enabled = false;
            this.btnDodadiD.Location = new System.Drawing.Point(38, 347);
            this.btnDodadiD.Name = "btnDodadiD";
            this.btnDodadiD.Size = new System.Drawing.Size(239, 23);
            this.btnDodadiD.TabIndex = 7;
            this.btnDodadiD.Text = "Додади дестинација";
            this.btnDodadiD.UseVisualStyleBackColor = true;
            this.btnDodadiD.Click += new System.EventHandler(this.btnDodadiD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbProsecna);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNajskapa);
            this.groupBox1.Location = new System.Drawing.Point(302, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 101);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // tbProsecna
            // 
            this.tbProsecna.Enabled = false;
            this.tbProsecna.Location = new System.Drawing.Point(6, 71);
            this.tbProsecna.Name = "tbProsecna";
            this.tbProsecna.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbProsecna.Size = new System.Drawing.Size(224, 20);
            this.tbProsecna.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Најскапа дестинација";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodadiD);
            this.Controls.Add(this.btnIzbrisiA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDestinacii);
            this.Controls.Add(this.btnDodadiA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAerodromi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAerodromi;
        private System.Windows.Forms.TextBox tbNajskapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodadiA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDestinacii;
        private System.Windows.Forms.Button btnIzbrisiA;
        private System.Windows.Forms.Button btnDodadiD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProsecna;
        private System.Windows.Forms.Label label3;
    }
}

