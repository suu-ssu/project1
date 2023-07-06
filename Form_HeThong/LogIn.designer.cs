namespace SQL_QLTrasua
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.rdbQL = new System.Windows.Forms.RadioButton();
            this.rdbNV = new System.Windows.Forms.RadioButton();
            this.btLog = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbNhap.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhap.ForeColor = System.Drawing.Color.LightSalmon;
            this.lbNhap.Location = new System.Drawing.Point(51, 108);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(93, 23);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập mã:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(152, 105);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(273, 26);
            this.txtNhap.TabIndex = 1;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPass.ForeColor = System.Drawing.Color.LightSalmon;
            this.lbPass.Location = new System.Drawing.Point(46, 160);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(98, 23);
            this.lbPass.TabIndex = 0;
            this.lbPass.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(152, 157);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(273, 26);
            this.txtPass.TabIndex = 2;
            // 
            // rdbQL
            // 
            this.rdbQL.AutoSize = true;
            this.rdbQL.BackColor = System.Drawing.Color.Transparent;
            this.rdbQL.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbQL.ForeColor = System.Drawing.Color.LightSalmon;
            this.rdbQL.Location = new System.Drawing.Point(152, 217);
            this.rdbQL.Name = "rdbQL";
            this.rdbQL.Size = new System.Drawing.Size(101, 27);
            this.rdbQL.TabIndex = 3;
            this.rdbQL.TabStop = true;
            this.rdbQL.Text = "Quản lý";
            this.rdbQL.UseVisualStyleBackColor = false;
            // 
            // rdbNV
            // 
            this.rdbNV.AutoSize = true;
            this.rdbNV.BackColor = System.Drawing.Color.Transparent;
            this.rdbNV.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbNV.ForeColor = System.Drawing.Color.LightSalmon;
            this.rdbNV.Location = new System.Drawing.Point(321, 217);
            this.rdbNV.Name = "rdbNV";
            this.rdbNV.Size = new System.Drawing.Size(120, 27);
            this.rdbNV.TabIndex = 4;
            this.rdbNV.TabStop = true;
            this.rdbNV.Text = "Nhân viên";
            this.rdbNV.UseVisualStyleBackColor = false;
            // 
            // btLog
            // 
            this.btLog.BackColor = System.Drawing.Color.Transparent;
            this.btLog.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLog.ForeColor = System.Drawing.Color.LightSalmon;
            this.btLog.Location = new System.Drawing.Point(152, 291);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(138, 46);
            this.btLog.TabIndex = 5;
            this.btLog.Text = "Đăng nhập";
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExit.ForeColor = System.Drawing.Color.LightSalmon;
            this.btExit.Location = new System.Drawing.Point(321, 291);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(113, 46);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.BackColor = System.Drawing.Color.Transparent;
            this.lbLog.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLog.ForeColor = System.Drawing.Color.LightSalmon;
            this.lbLog.Location = new System.Drawing.Point(12, 22);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(147, 46);
            this.lbLog.TabIndex = 0;
            this.lbLog.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.rdbNV);
            this.Controls.Add(this.rdbQL);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lbNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton rdbQL;
        private System.Windows.Forms.RadioButton rdbNV;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.Timer timer1;
    }
}

