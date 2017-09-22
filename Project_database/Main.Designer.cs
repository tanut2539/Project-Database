namespace Project_database
{
    partial class Main
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
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.buy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tool
            // 
            this.Tool.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buy,
            this.toolStripSeparator2,
            this.add,
            this.toolStripSeparator1,
            this.edit,
            this.toolStripSeparator3,
            this.Reports,
            this.toolStripSeparator4});
            this.Tool.Location = new System.Drawing.Point(0, 0);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(115, 729);
            this.Tool.TabIndex = 0;
            this.Tool.Text = "tool1";
            // 
            // buy
            // 
            this.buy.Image = global::Project_database.Properties.Resources.buy;
            this.buy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(112, 52);
            this.buy.Text = "ขาย";
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(112, 6);
            // 
            // add
            // 
            this.add.Image = global::Project_database.Properties.Resources.add;
            this.add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 52);
            this.add.Text = "เพิ่ม";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // edit
            // 
            this.edit.Image = global::Project_database.Properties.Resources.edit;
            this.edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(112, 52);
            this.edit.Text = "แก้ไข";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(112, 6);
            // 
            // Reports
            // 
            this.Reports.Image = global::Project_database.Properties.Resources.report;
            this.Reports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(112, 52);
            this.Reports.Text = "รายการขาย";
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(112, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Tool);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบจัดการสินค้า";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripButton buy;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripButton edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}