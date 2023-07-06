using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SQL_QLTrasua
{
    public partial class LogIn : Form
    {
        // khởi tạo
        SqlConnection cnt;
        string str = @"Data Source=LAPTOP-G8JORSUG\SQLEXPRESS02;Initial Catalog=QL_QuanTraSua;Integrated Security=True";

        public LogIn()
        {
            cnt = new SqlConnection(str);
            cnt.Open();
            InitializeComponent();
        }

        //int excute()
        //{
        //    return;
        //}    
            

        // Button Log in
        private void btLog_Click(object sender, EventArgs e)
        {
            if (cnt.State == ConnectionState.Closed)
            {
                cnt.Open();
            }
            string tk = txtNhap.Text;
            string mk = txtPass.Text;

            
                // Điều kiện click vào quản lý thì vào quyền quản lý
                if (rdbQL.Checked)
                {
                    string query = "Select * from QUANLY where MaQL = '" + tk + "' and MatKhauQL = '" + mk + "'";
                    SqlCommand cmd = new SqlCommand(query, cnt);
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        //
                        FromChuongTrinhQL f = new FromChuongTrinhQL();
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                        //f.ShowDialog(); //kéo thả from đăng kí k được
                        f.Show();
                        this.Hide(); //ẩn phần đăng ký
                    }
                    else
                    {
                        MessageBox.Show("Mã hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK);
                    }
                    if (cnt.State == ConnectionState.Open)
                    {
                        cnt.Close();
                    }
                    rd.Close();
                }
            
            
            
           

                // Điều kiện click vào nhân viên thì vào quyền nhân viên
                if (rdbNV.Checked)
                {
                    string query1 = "Select * from CV_NHANVIEN where MaNV = '" + tk + "' and MatKhauNV = '" + mk + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, cnt);
                    SqlDataReader rd1 = cmd1.ExecuteReader();

                    if (rd1.Read())
                    {
                        //
                        FromChuongTrinh f = new FromChuongTrinh();
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                        //f.ShowDialog(); //kéo thả from đăng kí k được
                        f.Show();
                        this.Hide(); //ẩn phần đăng ký
                    }
                    else
                    {
                        MessageBox.Show("Mã hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK);
                    }
                    if (cnt.State == ConnectionState.Open)
                    {
                        cnt.Close();
                    }
                    rd1.Close();
                }
            }
        

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Chữ di chuyển
        int x = 12, y = 9, a = 1;
        Random rd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbLog.Location = new Point(x, y);

                if (x > 200)
                {
                    a = -1;
                    lbLog.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
                if (x < 12)
                {
                    a = 1;
                    lbLog.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        



    }
}
