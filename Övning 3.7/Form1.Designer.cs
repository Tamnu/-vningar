namespace Övning_3._7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Förnamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efternamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MålH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MålB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMålrikast = new System.Windows.Forms.Button();
            this.tbxMålrikast = new System.Windows.Forms.TextBox();
            this.btnSkjutned = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Förnamn,
            this.Efternamn,
            this.MålH,
            this.MålB});
            this.dataGridView1.Location = new System.Drawing.Point(197, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridView1_UserDeletedRow);
            // 
            // Förnamn
            // 
            this.Förnamn.HeaderText = "Hemmalag";
            this.Förnamn.MinimumWidth = 20;
            this.Förnamn.Name = "Förnamn";
            // 
            // Efternamn
            // 
            this.Efternamn.HeaderText = "Bortalag";
            this.Efternamn.MinimumWidth = 10;
            this.Efternamn.Name = "Efternamn";
            // 
            // MålH
            // 
            this.MålH.HeaderText = "Mål(H)";
            this.MålH.Name = "MålH";
            // 
            // MålB
            // 
            this.MålB.HeaderText = "Mål(B)";
            this.MålB.Name = "MålB";
            // 
            // btnMålrikast
            // 
            this.btnMålrikast.Location = new System.Drawing.Point(305, 299);
            this.btnMålrikast.Name = "btnMålrikast";
            this.btnMålrikast.Size = new System.Drawing.Size(75, 23);
            this.btnMålrikast.TabIndex = 1;
            this.btnMålrikast.Text = "Målrikast";
            this.btnMålrikast.UseVisualStyleBackColor = true;
            this.btnMålrikast.Click += new System.EventHandler(this.BtnMålrikast_Click);
            // 
            // tbxMålrikast
            // 
            this.tbxMålrikast.Location = new System.Drawing.Point(387, 301);
            this.tbxMålrikast.Name = "tbxMålrikast";
            this.tbxMålrikast.Size = new System.Drawing.Size(100, 20);
            this.tbxMålrikast.TabIndex = 2;
            // 
            // btnSkjutned
            // 
            this.btnSkjutned.Location = new System.Drawing.Point(223, 242);
            this.btnSkjutned.Name = "btnSkjutned";
            this.btnSkjutned.Size = new System.Drawing.Size(75, 23);
            this.btnSkjutned.TabIndex = 3;
            this.btnSkjutned.Text = "Skjutned";
            this.btnSkjutned.UseVisualStyleBackColor = true;
            this.btnSkjutned.Click += new System.EventHandler(this.BtnSkjutned_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSkjutned);
            this.Controls.Add(this.tbxMålrikast);
            this.Controls.Add(this.btnMålrikast);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMålrikast;
        private System.Windows.Forms.TextBox tbxMålrikast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Förnamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efternamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MålH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MålB;
        private System.Windows.Forms.Button btnSkjutned;
    }
}

