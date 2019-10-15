namespace Övningar
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
            this.tbxReg = new System.Windows.Forms.TextBox();
            this.tbxModell = new System.Windows.Forms.TextBox();
            this.tbxMärk = new System.Windows.Forms.TextBox();
            this.lbxVisa = new System.Windows.Forms.ListBox();
            this.cbxTyp = new System.Windows.Forms.ComboBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.rdbAlla = new System.Windows.Forms.RadioButton();
            this.rdbBilar = new System.Windows.Forms.RadioButton();
            this.rdbMC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxReg
            // 
            this.tbxReg.Location = new System.Drawing.Point(208, 46);
            this.tbxReg.Name = "tbxReg";
            this.tbxReg.Size = new System.Drawing.Size(100, 20);
            this.tbxReg.TabIndex = 0;
            // 
            // tbxModell
            // 
            this.tbxModell.Location = new System.Drawing.Point(208, 161);
            this.tbxModell.Name = "tbxModell";
            this.tbxModell.Size = new System.Drawing.Size(100, 20);
            this.tbxModell.TabIndex = 1;
            // 
            // tbxMärk
            // 
            this.tbxMärk.Location = new System.Drawing.Point(208, 103);
            this.tbxMärk.Name = "tbxMärk";
            this.tbxMärk.Size = new System.Drawing.Size(100, 20);
            this.tbxMärk.TabIndex = 2;
            // 
            // lbxVisa
            // 
            this.lbxVisa.FormattingEnabled = true;
            this.lbxVisa.Location = new System.Drawing.Point(519, 46);
            this.lbxVisa.Name = "lbxVisa";
            this.lbxVisa.Size = new System.Drawing.Size(171, 160);
            this.lbxVisa.TabIndex = 3;
            // 
            // cbxTyp
            // 
            this.cbxTyp.FormattingEnabled = true;
            this.cbxTyp.Items.AddRange(new object[] {
            "Bil",
            "MC"});
            this.cbxTyp.Location = new System.Drawing.Point(208, 225);
            this.cbxTyp.Name = "cbxTyp";
            this.cbxTyp.Size = new System.Drawing.Size(121, 21);
            this.cbxTyp.TabIndex = 4;
            this.cbxTyp.SelectedIndexChanged += new System.EventHandler(this.CbxTyp_SelectedIndexChanged);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(208, 346);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(110, 23);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Registera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // rdbAlla
            // 
            this.rdbAlla.AutoSize = true;
            this.rdbAlla.Location = new System.Drawing.Point(519, 282);
            this.rdbAlla.Name = "rdbAlla";
            this.rdbAlla.Size = new System.Drawing.Size(42, 17);
            this.rdbAlla.TabIndex = 6;
            this.rdbAlla.TabStop = true;
            this.rdbAlla.Text = "Alla";
            this.rdbAlla.UseVisualStyleBackColor = true;
            this.rdbAlla.CheckedChanged += new System.EventHandler(this.RdbAlla_CheckedChanged);
            // 
            // rdbBilar
            // 
            this.rdbBilar.AutoSize = true;
            this.rdbBilar.Location = new System.Drawing.Point(605, 282);
            this.rdbBilar.Name = "rdbBilar";
            this.rdbBilar.Size = new System.Drawing.Size(45, 17);
            this.rdbBilar.TabIndex = 7;
            this.rdbBilar.TabStop = true;
            this.rdbBilar.Text = "Bilar";
            this.rdbBilar.UseVisualStyleBackColor = true;
            // 
            // rdbMC
            // 
            this.rdbMC.AutoSize = true;
            this.rdbMC.Location = new System.Drawing.Point(692, 282);
            this.rdbMC.Name = "rdbMC";
            this.rdbMC.Size = new System.Drawing.Size(41, 17);
            this.rdbMC.TabIndex = 8;
            this.rdbMC.TabStop = true;
            this.rdbMC.Text = "MC";
            this.rdbMC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reg-nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Typ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbMC);
            this.Controls.Add(this.rdbBilar);
            this.Controls.Add(this.rdbAlla);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.cbxTyp);
            this.Controls.Add(this.lbxVisa);
            this.Controls.Add(this.tbxMärk);
            this.Controls.Add(this.tbxModell);
            this.Controls.Add(this.tbxReg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxReg;
        private System.Windows.Forms.TextBox tbxModell;
        private System.Windows.Forms.TextBox tbxMärk;
        private System.Windows.Forms.ListBox lbxVisa;
        private System.Windows.Forms.ComboBox cbxTyp;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.RadioButton rdbAlla;
        private System.Windows.Forms.RadioButton rdbBilar;
        private System.Windows.Forms.RadioButton rdbMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

