namespace Project_DB_V2
{
    partial class Reports
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerCarReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelr = new System.Windows.Forms.Panel();
            this.labelr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.managerBranchReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelr.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerCarReportToolStripMenuItem,
            this.managerBranchReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerCarReportToolStripMenuItem
            // 
            this.customerCarReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerCarReportToolStripMenuItem.Name = "customerCarReportToolStripMenuItem";
            this.customerCarReportToolStripMenuItem.Size = new System.Drawing.Size(194, 29);
            this.customerCarReportToolStripMenuItem.Text = "Customer Car Report";
            this.customerCarReportToolStripMenuItem.Click += new System.EventHandler(this.customerCarReportToolStripMenuItem_Click);
            // 
            // panelr
            // 
            this.panelr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelr.Controls.Add(this.labelr);
            this.panelr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelr.Location = new System.Drawing.Point(0, 33);
            this.panelr.Name = "panelr";
            this.panelr.Size = new System.Drawing.Size(904, 74);
            this.panelr.TabIndex = 1;
            // 
            // labelr
            // 
            this.labelr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelr.AutoSize = true;
            this.labelr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelr.Location = new System.Drawing.Point(389, 22);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(86, 29);
            this.labelr.TabIndex = 0;
            this.labelr.Text = "Report";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 376);
            this.panel1.TabIndex = 2;
            // 
            // managerBranchReportToolStripMenuItem
            // 
            this.managerBranchReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.managerBranchReportToolStripMenuItem.Name = "managerBranchReportToolStripMenuItem";
            this.managerBranchReportToolStripMenuItem.Size = new System.Drawing.Size(214, 29);
            this.managerBranchReportToolStripMenuItem.Text = "Manager Branch Report";
            this.managerBranchReportToolStripMenuItem.Click += new System.EventHandler(this.managerBranchReportToolStripMenuItem_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelr.ResumeLayout(false);
            this.panelr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelr;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.ToolStripMenuItem customerCarReportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managerBranchReportToolStripMenuItem;
    }
}