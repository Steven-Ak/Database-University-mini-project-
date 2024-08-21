namespace Project_DB_V2
{
    partial class Queries
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
            this.carTotalCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStrip = new System.Windows.Forms.Panel();
            this.panelq = new System.Windows.Forms.Panel();
            this.labelq = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelStrip.SuspendLayout();
            this.panelq.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carTotalCostToolStripMenuItem,
            this.customerCarsToolStripMenuItem,
            this.branchEmployeesToolStripMenuItem,
            this.employeesServicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1566, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carTotalCostToolStripMenuItem
            // 
            this.carTotalCostToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.carTotalCostToolStripMenuItem.Name = "carTotalCostToolStripMenuItem";
            this.carTotalCostToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.carTotalCostToolStripMenuItem.Text = "Car Total Cost";
            this.carTotalCostToolStripMenuItem.Click += new System.EventHandler(this.carTotalCostToolStripMenuItem_Click);
            // 
            // customerCarsToolStripMenuItem
            // 
            this.customerCarsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerCarsToolStripMenuItem.Name = "customerCarsToolStripMenuItem";
            this.customerCarsToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.customerCarsToolStripMenuItem.Text = "Customer Cars";
            this.customerCarsToolStripMenuItem.Click += new System.EventHandler(this.customerCarsToolStripMenuItem_Click);
            // 
            // branchEmployeesToolStripMenuItem
            // 
            this.branchEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.branchEmployeesToolStripMenuItem.Name = "branchEmployeesToolStripMenuItem";
            this.branchEmployeesToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.branchEmployeesToolStripMenuItem.Text = "Branch Employees";
            this.branchEmployeesToolStripMenuItem.Click += new System.EventHandler(this.branchEmployeesToolStripMenuItem_Click);
            // 
            // employeesServicesToolStripMenuItem
            // 
            this.employeesServicesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.employeesServicesToolStripMenuItem.Name = "employeesServicesToolStripMenuItem";
            this.employeesServicesToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.employeesServicesToolStripMenuItem.Text = "Employees Services";
            this.employeesServicesToolStripMenuItem.Click += new System.EventHandler(this.employeesServicesToolStripMenuItem_Click);
            // 
            // panelStrip
            // 
            this.panelStrip.Controls.Add(this.panelq);
            this.panelStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStrip.Location = new System.Drawing.Point(0, 33);
            this.panelStrip.Name = "panelStrip";
            this.panelStrip.Size = new System.Drawing.Size(1566, 616);
            this.panelStrip.TabIndex = 1;
            // 
            // panelq
            // 
            this.panelq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelq.Controls.Add(this.labelq);
            this.panelq.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelq.Location = new System.Drawing.Point(0, 0);
            this.panelq.Name = "panelq";
            this.panelq.Size = new System.Drawing.Size(1566, 62);
            this.panelq.TabIndex = 0;
            // 
            // labelq
            // 
            this.labelq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelq.AutoSize = true;
            this.labelq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelq.ForeColor = System.Drawing.Color.White;
            this.labelq.Location = new System.Drawing.Point(638, 16);
            this.labelq.Name = "labelq";
            this.labelq.Size = new System.Drawing.Size(78, 29);
            this.labelq.TabIndex = 0;
            this.labelq.Text = "Query";
            // 
            // Queries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 649);
            this.Controls.Add(this.panelStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Queries";
            this.Text = "Queries";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelStrip.ResumeLayout(false);
            this.panelq.ResumeLayout(false);
            this.panelq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carTotalCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesServicesToolStripMenuItem;
        private System.Windows.Forms.Panel panelStrip;
        private System.Windows.Forms.Panel panelq;
        private System.Windows.Forms.Label labelq;
    }
}