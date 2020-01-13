namespace Övning_3._1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljMappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuFun = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.contextMenuFun.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuFun;
            this.button1.Location = new System.Drawing.Point(295, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Välj en färg";
            this.toolTip1.SetToolTip(this.button1, "Väljer en färg\r\n");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "FolderBrowser";
            this.toolTip2.SetToolTip(this.button2, "Öppnar en mapp \r\n");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Välj ett teckensnitt ";
            this.toolTip3.SetToolTip(this.button3, "Väljer en font");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redigeraToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem,
            this.väljMappToolStripMenuItem,
            this.väljTeckensnittToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // väljFärgToolStripMenuItem
            // 
            this.väljFärgToolStripMenuItem.Name = "väljFärgToolStripMenuItem";
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljFärgToolStripMenuItem.Text = "Välj färg";
            this.väljFärgToolStripMenuItem.Click += new System.EventHandler(this.VäljFärgToolStripMenuItem_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.VäljMappToolStripMenuItem_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljTeckensnittToolStripMenuItem.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.VäljTeckensnittToolStripMenuItem_Click);
            // 
            // contextMenuFun
            // 
            this.contextMenuFun.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaToolStripMenuItem,
            this.bbbToolStripMenuItem,
            this.cccToolStripMenuItem});
            this.contextMenuFun.Name = "contextMenuFun";
            this.contextMenuFun.Size = new System.Drawing.Size(96, 70);
            // 
            // aaaToolStripMenuItem
            // 
            this.aaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaasToolStripMenuItem});
            this.aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            this.aaaToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.aaaToolStripMenuItem.Text = "aaa";
            this.aaaToolStripMenuItem.Click += new System.EventHandler(this.AaaToolStripMenuItem_Click);
            // 
            // bbbToolStripMenuItem
            // 
            this.bbbToolStripMenuItem.Name = "bbbToolStripMenuItem";
            this.bbbToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bbbToolStripMenuItem.Text = "bbb";
            // 
            // cccToolStripMenuItem
            // 
            this.cccToolStripMenuItem.Name = "cccToolStripMenuItem";
            this.cccToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cccToolStripMenuItem.Text = "ccc";
            // 
            // aaasToolStripMenuItem
            // 
            this.aaasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaafToolStripMenuItem});
            this.aaasToolStripMenuItem.Name = "aaasToolStripMenuItem";
            this.aaasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aaasToolStripMenuItem.Text = "aaas";
            // 
            // aaafToolStripMenuItem
            // 
            this.aaafToolStripMenuItem.Name = "aaafToolStripMenuItem";
            this.aaafToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aaafToolStripMenuItem.Text = "aaaf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuFun.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljMappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuFun;
        private System.Windows.Forms.ToolStripMenuItem aaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bbbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaafToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

