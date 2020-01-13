namespace Övning_2._8_Inköpslista
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
            this.tbxVara = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.tbxMängd = new System.Windows.Forms.TextBox();
            this.RbtnLös = new System.Windows.Forms.RadioButton();
            this.RbtnStycksak = new System.Windows.Forms.RadioButton();
            this.lbxVisa = new System.Windows.Forms.ListBox();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLäggtill = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // tbxVara
            // 
            this.tbxVara.Location = new System.Drawing.Point(114, 39);
            this.tbxVara.Name = "tbxVara";
            this.tbxVara.Size = new System.Drawing.Size(100, 20);
            this.tbxVara.TabIndex = 0;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(114, 118);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 1;
            // 
            // tbxMängd
            // 
            this.tbxMängd.Location = new System.Drawing.Point(114, 205);
            this.tbxMängd.Name = "tbxMängd";
            this.tbxMängd.Size = new System.Drawing.Size(100, 20);
            this.tbxMängd.TabIndex = 2;
            // 
            // RbtnLös
            // 
            this.RbtnLös.AutoSize = true;
            this.RbtnLös.Location = new System.Drawing.Point(254, 243);
            this.RbtnLös.Name = "RbtnLös";
            this.RbtnLös.Size = new System.Drawing.Size(59, 17);
            this.RbtnLös.TabIndex = 3;
            this.RbtnLös.TabStop = true;
            this.RbtnLös.Text = "Lösvikt";
            this.RbtnLös.UseVisualStyleBackColor = true;
            // 
            // RbtnStycksak
            // 
            this.RbtnStycksak.AutoSize = true;
            this.RbtnStycksak.Location = new System.Drawing.Point(254, 267);
            this.RbtnStycksak.Name = "RbtnStycksak";
            this.RbtnStycksak.Size = new System.Drawing.Size(69, 17);
            this.RbtnStycksak.TabIndex = 4;
            this.RbtnStycksak.TabStop = true;
            this.RbtnStycksak.Text = "Stycksak";
            this.RbtnStycksak.UseVisualStyleBackColor = true;
            // 
            // lbxVisa
            // 
            this.lbxVisa.FormattingEnabled = true;
            this.lbxVisa.Location = new System.Drawing.Point(523, 12);
            this.lbxVisa.Name = "lbxVisa";
            this.lbxVisa.Size = new System.Drawing.Size(210, 277);
            this.lbxVisa.TabIndex = 5;
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(633, 367);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(100, 20);
            this.tbxSumma.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Summa (Kr)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mängd";
            // 
            // btnLäggtill
            // 
            this.btnLäggtill.Location = new System.Drawing.Point(114, 415);
            this.btnLäggtill.Name = "btnLäggtill";
            this.btnLäggtill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggtill.TabIndex = 11;
            this.btnLäggtill.Text = "Lägg till";
            this.btnLäggtill.UseVisualStyleBackColor = true;
            this.btnLäggtill.Click += new System.EventHandler(this.BtnLäggtill_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(523, 307);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 12;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.Btnremove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnLäggtill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.lbxVisa);
            this.Controls.Add(this.RbtnStycksak);
            this.Controls.Add(this.RbtnLös);
            this.Controls.Add(this.tbxMängd);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxVara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxVara;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.TextBox tbxMängd;
        private System.Windows.Forms.RadioButton RbtnLös;
        private System.Windows.Forms.RadioButton RbtnStycksak;
        private System.Windows.Forms.ListBox lbxVisa;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLäggtill;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

