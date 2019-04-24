namespace CSE_DEPT
{
    partial class FrmMenu
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
            this.mnuStrMenu = new System.Windows.Forms.MenuStrip();
            this.tsMnuIteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrMnuItemLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrMnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrMnuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrMnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrMnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrMnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlStrlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuStrMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrMenu
            // 
            this.mnuStrMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnuIteFile,
            this.tlstrMnuItemView,
            this.tlstrMnuHelp});
            this.mnuStrMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuStrMenu.Name = "mnuStrMenu";
            this.mnuStrMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuStrMenu.TabIndex = 1;
            this.mnuStrMenu.Text = "menuStrip1";
            // 
            // tsMnuIteFile
            // 
            this.tsMnuIteFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrMnuItemLogIn,
            this.toolStripMenuItem2,
            this.tlstrMnuItemExit});
            this.tsMnuIteFile.Name = "tsMnuIteFile";
            this.tsMnuIteFile.Size = new System.Drawing.Size(44, 24);
            this.tsMnuIteFile.Text = "&File";
            // 
            // tlstrMnuItemLogIn
            // 
            this.tlstrMnuItemLogIn.Name = "tlstrMnuItemLogIn";
            this.tlstrMnuItemLogIn.Size = new System.Drawing.Size(216, 26);
            this.tlstrMnuItemLogIn.Text = "&Log In";
            this.tlstrMnuItemLogIn.Click += new System.EventHandler(this.tlstrMnuItemLogIn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // tlstrMnuItemExit
            // 
            this.tlstrMnuItemExit.Name = "tlstrMnuItemExit";
            this.tlstrMnuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.tlstrMnuItemExit.Size = new System.Drawing.Size(216, 26);
            this.tlstrMnuItemExit.Text = "&Exit";
            this.tlstrMnuItemExit.Click += new System.EventHandler(this.tlstrMnuItemExit_Click);
            // 
            // tlstrMnuItemView
            // 
            this.tlstrMnuItemView.Name = "tlstrMnuItemView";
            this.tlstrMnuItemView.Size = new System.Drawing.Size(53, 24);
            this.tlstrMnuItemView.Text = "&View";
            // 
            // tlstrMnuHelp
            // 
            this.tlstrMnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrMnuItemHelp,
            this.toolStripMenuItem1,
            this.tlstrMnuItemAbout});
            this.tlstrMnuHelp.Name = "tlstrMnuHelp";
            this.tlstrMnuHelp.Size = new System.Drawing.Size(53, 24);
            this.tlstrMnuHelp.Text = "&Help";
            // 
            // tlstrMnuItemHelp
            // 
            this.tlstrMnuItemHelp.Name = "tlstrMnuItemHelp";
            this.tlstrMnuItemHelp.Size = new System.Drawing.Size(133, 26);
            this.tlstrMnuItemHelp.Text = "&Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // tlstrMnuItemAbout
            // 
            this.tlstrMnuItemAbout.Name = "tlstrMnuItemAbout";
            this.tlstrMnuItemAbout.Size = new System.Drawing.Size(133, 26);
            this.tlstrMnuItemAbout.Text = "&Abaout";
            this.tlstrMnuItemAbout.Click += new System.EventHandler(this.tlstrMnuItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrlblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlStrlblStatus
            // 
            this.tlStrlblStatus.Name = "tlStrlblStatus";
            this.tlStrlblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuStrMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuStrMenu;
            this.Name = "FrmMenu";
            this.Text = "CSE DEPT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuStrMenu.ResumeLayout(false);
            this.mnuStrMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMnuIteFile;
        private System.Windows.Forms.ToolStripMenuItem tlstrMnuItemLogIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlStrlblStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tlstrMnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem tlstrMnuItemView;
        private System.Windows.Forms.ToolStripMenuItem tlstrMnuHelp;
        private System.Windows.Forms.ToolStripMenuItem tlstrMnuItemHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tlstrMnuItemAbout;
    }
}