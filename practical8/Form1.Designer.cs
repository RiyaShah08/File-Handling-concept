namespace practical8
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pASTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELECTALLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKMARKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fONTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(747, 439);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.fORMATToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.nToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.nToolStripMenuItem.Text = "FILE";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUTToolStripMenuItem,
            this.cOPYToolStripMenuItem,
            this.pASTEToolStripMenuItem,
            this.rEDOToolStripMenuItem,
            this.uNDOToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sELECTALLToolStripMenuItem1,
            this.bOOKMARKToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.cUTToolStripMenuItem.Text = "CUT";
            this.cUTToolStripMenuItem.Click += new System.EventHandler(this.cUTToolStripMenuItem_Click);
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.cOPYToolStripMenuItem.Text = "COPY";
            this.cOPYToolStripMenuItem.Click += new System.EventHandler(this.cOPYToolStripMenuItem_Click);
            // 
            // pASTEToolStripMenuItem
            // 
            this.pASTEToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pASTEToolStripMenuItem.Name = "pASTEToolStripMenuItem";
            this.pASTEToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.pASTEToolStripMenuItem.Text = "PASTE";
            this.pASTEToolStripMenuItem.Click += new System.EventHandler(this.pASTEToolStripMenuItem_Click);
            // 
            // rEDOToolStripMenuItem
            // 
            this.rEDOToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rEDOToolStripMenuItem.Name = "rEDOToolStripMenuItem";
            this.rEDOToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.rEDOToolStripMenuItem.Text = "REDO";
            this.rEDOToolStripMenuItem.Click += new System.EventHandler(this.rEDOToolStripMenuItem_Click);
            // 
            // uNDOToolStripMenuItem
            // 
            this.uNDOToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.uNDOToolStripMenuItem.Name = "uNDOToolStripMenuItem";
            this.uNDOToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.uNDOToolStripMenuItem.Text = "UNDO";
            this.uNDOToolStripMenuItem.Click += new System.EventHandler(this.uNDOToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.deleteToolStripMenuItem.Text = "DELETE";
            // 
            // sELECTALLToolStripMenuItem1
            // 
            this.sELECTALLToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sELECTALLToolStripMenuItem1.Name = "sELECTALLToolStripMenuItem1";
            this.sELECTALLToolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.sELECTALLToolStripMenuItem1.Text = "SELECT ALL";
            this.sELECTALLToolStripMenuItem1.Click += new System.EventHandler(this.sELECTALLToolStripMenuItem1_Click);
            // 
            // bOOKMARKToolStripMenuItem
            // 
            this.bOOKMARKToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bOOKMARKToolStripMenuItem.Name = "bOOKMARKToolStripMenuItem";
            this.bOOKMARKToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.bOOKMARKToolStripMenuItem.Text = "BOOKMARK";
            // 
            // fORMATToolStripMenuItem
            // 
            this.fORMATToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOLORToolStripMenuItem,
            this.fONTToolStripMenuItem});
            this.fORMATToolStripMenuItem.Name = "fORMATToolStripMenuItem";
            this.fORMATToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.fORMATToolStripMenuItem.Text = "FORMAT";
            // 
            // cOLORToolStripMenuItem
            // 
            this.cOLORToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cOLORToolStripMenuItem.Name = "cOLORToolStripMenuItem";
            this.cOLORToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cOLORToolStripMenuItem.Text = "COLOR";
            this.cOLORToolStripMenuItem.Click += new System.EventHandler(this.cOLORToolStripMenuItem_Click);
            // 
            // fONTToolStripMenuItem
            // 
            this.fONTToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fONTToolStripMenuItem.Name = "fONTToolStripMenuItem";
            this.fONTToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.fONTToolStripMenuItem.Text = "FONT";
            this.fONTToolStripMenuItem.Click += new System.EventHandler(this.fONTToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 467);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pASTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORMATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fONTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELECTALLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bOOKMARKToolStripMenuItem;
    }
}

