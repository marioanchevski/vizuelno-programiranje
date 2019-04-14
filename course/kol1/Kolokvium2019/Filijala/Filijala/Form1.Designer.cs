namespace Filijala
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
            this.btnAddF = new System.Windows.Forms.Button();
            this.lbFilijali = new System.Windows.Forms.ListBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.btnDelF = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.lbAvtomobili = new System.Windows.Forms.ListBox();
            this.btnPrebaraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddA);
            this.groupBox1.Controls.Add(this.btnDelF);
            this.groupBox1.Controls.Add(this.btnAddF);
            this.groupBox1.Controls.Add(this.lbFilijali);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Филијали";
            // 
            // btnAddF
            // 
            this.btnAddF.Location = new System.Drawing.Point(6, 304);
            this.btnAddF.Name = "btnAddF";
            this.btnAddF.Size = new System.Drawing.Size(266, 27);
            this.btnAddF.TabIndex = 0;
            this.btnAddF.Text = "Додади филијала";
            this.btnAddF.UseVisualStyleBackColor = true;
            this.btnAddF.Click += new System.EventHandler(this.btnAddF_Click);
            // 
            // lbFilijali
            // 
            this.lbFilijali.FormattingEnabled = true;
            this.lbFilijali.Location = new System.Drawing.Point(6, 19);
            this.lbFilijali.Name = "lbFilijali";
            this.lbFilijali.Size = new System.Drawing.Size(266, 277);
            this.lbFilijali.TabIndex = 1;
            this.lbFilijali.SelectedIndexChanged += new System.EventHandler(this.lbFilijali_SelectedIndexChanged);
            // 
            // tbCena
            // 
            this.tbCena.Enabled = false;
            this.tbCena.Location = new System.Drawing.Point(6, 387);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(266, 20);
            this.tbCena.TabIndex = 2;
            // 
            // btnDelF
            // 
            this.btnDelF.Location = new System.Drawing.Point(6, 338);
            this.btnDelF.Name = "btnDelF";
            this.btnDelF.Size = new System.Drawing.Size(266, 27);
            this.btnDelF.TabIndex = 2;
            this.btnDelF.Text = "Избриши филијала";
            this.btnDelF.UseVisualStyleBackColor = true;
            this.btnDelF.Click += new System.EventHandler(this.btnDelF_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(6, 374);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(266, 27);
            this.btnAddA.TabIndex = 3;
            this.btnAddA.Text = "Додади автомобил";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPrebaraj);
            this.groupBox2.Controls.Add(this.btnRezerviraj);
            this.groupBox2.Controls.Add(this.tbCena);
            this.groupBox2.Controls.Add(this.lbAvtomobili);
            this.groupBox2.Location = new System.Drawing.Point(323, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 413);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автомобили";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(6, 304);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(266, 27);
            this.btnRezerviraj.TabIndex = 3;
            this.btnRezerviraj.Text = "Резервирај автомобил";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // lbAvtomobili
            // 
            this.lbAvtomobili.FormattingEnabled = true;
            this.lbAvtomobili.Location = new System.Drawing.Point(6, 19);
            this.lbAvtomobili.Name = "lbAvtomobili";
            this.lbAvtomobili.Size = new System.Drawing.Size(266, 277);
            this.lbAvtomobili.TabIndex = 1;
            // 
            // btnPrebaraj
            // 
            this.btnPrebaraj.Location = new System.Drawing.Point(6, 337);
            this.btnPrebaraj.Name = "btnPrebaraj";
            this.btnPrebaraj.Size = new System.Drawing.Size(266, 27);
            this.btnPrebaraj.TabIndex = 4;
            this.btnPrebaraj.Text = "Пребарај најевтин";
            this.btnPrebaraj.UseVisualStyleBackColor = true;
            this.btnPrebaraj.Click += new System.EventHandler(this.btnPrebaraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цена од резервирани автомобили";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.Button btnDelF;
        private System.Windows.Forms.Button btnAddF;
        private System.Windows.Forms.ListBox lbFilijali;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrebaraj;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.ListBox lbAvtomobili;
    }
}

