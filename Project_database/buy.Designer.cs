namespace Project_database
{
    partial class buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_report = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_price2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.viewreport = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.E_id = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.L_date = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.E_Lname = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.E_Fname = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewreport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_price);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_pname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สินค้า";
            // 
            // txt_pid
            // 
            this.txt_pid.Location = new System.Drawing.Point(108, 38);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(196, 24);
            this.txt_pid.TabIndex = 10;
            this.txt_pid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pid_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "บาท";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(105, 180);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(0, 18);
            this.lbl_price.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "ราคา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "ชิ้น";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(108, 133);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "จำนวน";
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.Location = new System.Drawing.Point(105, 88);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(0, 18);
            this.lbl_pname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสสินค้า";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_report);
            this.groupBox2.Controls.Add(this.bt_cancel);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lbl_change);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.money);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_price2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(379, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "สรุปการสั่งซื้อ";
            // 
            // bt_report
            // 
            this.bt_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_report.Location = new System.Drawing.Point(53, 180);
            this.bt_report.Name = "bt_report";
            this.bt_report.Size = new System.Drawing.Size(100, 34);
            this.bt_report.TabIndex = 17;
            this.bt_report.Text = "สรุปรายการขาย";
            this.bt_report.UseVisualStyleBackColor = true;
            this.bt_report.Click += new System.EventHandler(this.bt_report_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_cancel.Location = new System.Drawing.Point(173, 180);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(100, 34);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "ยกเลิก";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(253, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 18);
            this.label16.TabIndex = 16;
            this.label16.Text = "บาท";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.BackColor = System.Drawing.Color.White;
            this.lbl_change.ForeColor = System.Drawing.Color.Green;
            this.lbl_change.Location = new System.Drawing.Point(170, 135);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(16, 18);
            this.lbl_change.TabIndex = 15;
            this.lbl_change.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "เงินทอน";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "บาท";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(129, 86);
            this.money.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 24);
            this.money.TabIndex = 12;
            this.money.ValueChanged += new System.EventHandler(this.money_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "จำนวนเงิน";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "บาท";
            // 
            // lbl_price2
            // 
            this.lbl_price2.AutoSize = true;
            this.lbl_price2.BackColor = System.Drawing.Color.White;
            this.lbl_price2.ForeColor = System.Drawing.Color.Red;
            this.lbl_price2.Location = new System.Drawing.Point(170, 43);
            this.lbl_price2.Name = "lbl_price2";
            this.lbl_price2.Size = new System.Drawing.Size(16, 18);
            this.lbl_price2.TabIndex = 1;
            this.lbl_price2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "ราคาสินค้า";
            // 
            // viewreport
            // 
            this.viewreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewreport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewreport.Location = new System.Drawing.Point(308, 277);
            this.viewreport.Name = "viewreport";
            this.viewreport.Size = new System.Drawing.Size(394, 207);
            this.viewreport.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.E_id);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.L_date);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.E_Lname);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.E_Fname);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(26, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 216);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลพนักงาน";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(33, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 18);
            this.label23.TabIndex = 7;
            this.label23.Text = "รหัสพนักงาน";
            // 
            // E_id
            // 
            this.E_id.AutoSize = true;
            this.E_id.Location = new System.Drawing.Point(127, 40);
            this.E_id.Name = "E_id";
            this.E_id.Size = new System.Drawing.Size(80, 18);
            this.E_id.TabIndex = 6;
            this.E_id.Text = "รหัสพนักงาน";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 18);
            this.label22.TabIndex = 5;
            this.label22.Text = "วันขาย";
            // 
            // L_date
            // 
            this.L_date.AutoSize = true;
            this.L_date.Location = new System.Drawing.Point(105, 160);
            this.L_date.Name = "L_date";
            this.L_date.Size = new System.Drawing.Size(0, 18);
            this.L_date.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 18);
            this.label19.TabIndex = 3;
            this.label19.Text = "นามสกุล";
            // 
            // E_Lname
            // 
            this.E_Lname.AutoSize = true;
            this.E_Lname.Location = new System.Drawing.Point(105, 118);
            this.E_Lname.Name = "E_Lname";
            this.E_Lname.Size = new System.Drawing.Size(55, 18);
            this.E_Lname.TabIndex = 2;
            this.E_Lname.Text = "นามสกุล";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 18);
            this.label18.TabIndex = 1;
            this.label18.Text = "ชื่อ";
            // 
            // E_Fname
            // 
            this.E_Fname.AutoSize = true;
            this.E_Fname.Location = new System.Drawing.Point(105, 79);
            this.E_Fname.Name = "E_Fname";
            this.E_Fname.Size = new System.Drawing.Size(24, 18);
            this.E_Fname.TabIndex = 0;
            this.E_Fname.Text = "ชื่อ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.viewreport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ขาย";
            this.Load += new System.EventHandler(this.buy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewreport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_price2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView viewreport;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_report;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label E_id;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label E_Lname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label E_Fname;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.Label L_date;
        private System.Windows.Forms.Timer timer1;
    }
}