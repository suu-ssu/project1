namespace SQL_QLTrasua
{ 
    partial class ThongKe
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
            this.btLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_maHD = new System.Windows.Forms.ComboBox();
            this.btLoc = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_ngay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_tongtienhd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLoad.ForeColor = System.Drawing.Color.LightSalmon;
            this.btLoad.Location = new System.Drawing.Point(11, 69);
            this.btLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(110, 29);
            this.btLoad.TabIndex = 45;
            this.btLoad.Text = "Load Hóa Đơn";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(8, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thống kê doanh thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.LightSalmon;
            this.label6.Location = new System.Drawing.Point(156, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mã Hóa Đơn";
            // 
            // cbb_maHD
            // 
            this.cbb_maHD.FormattingEnabled = true;
            this.cbb_maHD.Location = new System.Drawing.Point(250, 69);
            this.cbb_maHD.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_maHD.Name = "cbb_maHD";
            this.cbb_maHD.Size = new System.Drawing.Size(123, 21);
            this.cbb_maHD.TabIndex = 49;
            // 
            // btLoc
            // 
            this.btLoc.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLoc.ForeColor = System.Drawing.Color.LightSalmon;
            this.btLoc.Location = new System.Drawing.Point(377, 69);
            this.btLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(101, 27);
            this.btLoc.TabIndex = 50;
            this.btLoc.Text = "Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 102);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(704, 194);
            this.listView1.TabIndex = 51;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã HD";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày tạo";
            this.columnHeader12.Width = 74;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Mã Sản Phẩm";
            this.columnHeader13.Width = 84;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Mã Nhân Viên";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Đơn giá";
            this.columnHeader15.Width = 85;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Số Lượng";
            this.columnHeader16.Width = 92;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Tổng Tiền";
            this.columnHeader17.Width = 95;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.Location = new System.Drawing.Point(339, 423);
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.Size = new System.Drawing.Size(150, 20);
            this.txt_doanhthu.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // cb_thang
            // 
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_thang.Location = new System.Drawing.Point(339, 336);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(121, 21);
            this.cb_thang.TabIndex = 57;
            // 
            // cb_nam
            // 
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Location = new System.Drawing.Point(339, 364);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(121, 21);
            this.cb_nam.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Năm";
            // 
            // cb_ngay
            // 
            this.cb_ngay.FormattingEnabled = true;
            this.cb_ngay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_ngay.Location = new System.Drawing.Point(339, 309);
            this.cb_ngay.Name = "cb_ngay";
            this.cb_ngay.Size = new System.Drawing.Size(121, 21);
            this.cb_ngay.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.LightSalmon;
            this.label8.Location = new System.Drawing.Point(282, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "Doanh Thu Quán";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tình trạng ";
            this.columnHeader1.Width = 74;
            // 
            // txt_tongtienhd
            // 
            this.txt_tongtienhd.Location = new System.Drawing.Point(615, 76);
            this.txt_tongtienhd.Name = "txt_tongtienhd";
            this.txt_tongtienhd.Size = new System.Drawing.Size(100, 20);
            this.txt_tongtienhd.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.LightSalmon;
            this.button2.Location = new System.Drawing.Point(509, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 50;
            this.button2.Text = "Tổng Tiền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.txt_tongtienhd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_nam);
            this.Controls.Add(this.cb_ngay);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_doanhthu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.cbb_maHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem tour";
            this.Load += new System.EventHandler(this.XemTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_maHD;
        private System.Windows.Forms.Button btLoc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_ngay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txt_tongtienhd;
        private System.Windows.Forms.Button button2;
    }
}