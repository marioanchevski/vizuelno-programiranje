namespace Filijala
{
    partial class DodadiAvtomobil
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJacina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(16, 34);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(224, 20);
            this.tbMarka.TabIndex = 1;
            this.tbMarka.Validating += new System.ComponentModel.CancelEventHandler(this.tbMarka_Validating);
            // 
            // nudCena
            // 
            this.nudCena.Location = new System.Drawing.Point(16, 81);
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(224, 20);
            this.nudCena.TabIndex = 2;
            this.nudCena.Validating += new System.ComponentModel.CancelEventHandler(this.nudCena_Validating);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(16, 174);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(102, 27);
            this.btnDodadi.TabIndex = 3;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // tbJacina
            // 
            this.tbJacina.Location = new System.Drawing.Point(16, 130);
            this.tbJacina.Name = "tbJacina";
            this.tbJacina.Size = new System.Drawing.Size(224, 20);
            this.tbJacina.TabIndex = 6;
            this.tbJacina.Validating += new System.ComponentModel.CancelEventHandler(this.tbJacina_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Јачина во kW";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(135, 174);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(105, 27);
            this.btnOtkazi.TabIndex = 7;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodadiAvtomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 213);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.tbJacina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.nudCena);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label1);
            this.Name = "DodadiAvtomobil";
            this.Text = "DodadiAvtomobil";
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJacina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}