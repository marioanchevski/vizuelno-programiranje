namespace lab06
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
            this.components = new System.ComponentModel.Container();
            this.lblVreme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbIgrac = new System.Windows.Forms.TextBox();
            this.tbOperand1 = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbOperand2 = new System.Windows.Forms.TextBox();
            this.tbRez = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(126, 188);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(34, 13);
            this.lblVreme.TabIndex = 0;
            this.lblVreme.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Играч";
            // 
            // btnPogodi
            // 
            this.btnPogodi.Enabled = false;
            this.btnPogodi.Location = new System.Drawing.Point(313, 82);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(75, 23);
            this.btnPogodi.TabIndex = 2;
            this.btnPogodi.Text = "Погоди";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 149);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // tbIgrac
            // 
            this.tbIgrac.Location = new System.Drawing.Point(53, 22);
            this.tbIgrac.Name = "tbIgrac";
            this.tbIgrac.Size = new System.Drawing.Size(132, 20);
            this.tbIgrac.TabIndex = 4;
            // 
            // tbOperand1
            // 
            this.tbOperand1.Enabled = false;
            this.tbOperand1.Location = new System.Drawing.Point(15, 84);
            this.tbOperand1.Name = "tbOperand1";
            this.tbOperand1.Size = new System.Drawing.Size(65, 20);
            this.tbOperand1.TabIndex = 5;
            // 
            // tbOperator
            // 
            this.tbOperator.Enabled = false;
            this.tbOperator.Location = new System.Drawing.Point(86, 84);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(26, 20);
            this.tbOperator.TabIndex = 6;
            // 
            // tbOperand2
            // 
            this.tbOperand2.Enabled = false;
            this.tbOperand2.Location = new System.Drawing.Point(120, 84);
            this.tbOperand2.Name = "tbOperand2";
            this.tbOperand2.Size = new System.Drawing.Size(65, 20);
            this.tbOperand2.TabIndex = 8;
            // 
            // tbRez
            // 
            this.tbRez.Location = new System.Drawing.Point(228, 84);
            this.tbRez.Name = "tbRez";
            this.tbRez.Size = new System.Drawing.Size(65, 20);
            this.tbRez.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поени";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Преостанато време";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 216);
            this.progressBar2.Maximum = 60;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(373, 23);
            this.progressBar2.TabIndex = 13;
            this.progressBar2.Value = 60;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Нова игра";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Исклучи";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(57, 133);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(0, 13);
            this.lblPoeni.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Најдобри";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRez);
            this.Controls.Add(this.tbOperand2);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbOperand1);
            this.Controls.Add(this.tbIgrac);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVreme);
            this.Name = "Form1";
            this.Text = "Math Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbIgrac;
        private System.Windows.Forms.TextBox tbOperand1;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbOperand2;
        private System.Windows.Forms.TextBox tbRez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Button button1;
    }
}

