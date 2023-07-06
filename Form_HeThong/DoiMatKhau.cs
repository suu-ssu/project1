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
    public partial class DoiMatKhau : Form
    {
        SqlConnection cnt;
        SqlCommand cmd;
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_QuanTraSua;Integrated Security=True";

        public DoiMatKhau()
        {
            cnt = new SqlConnection(str);

            InitializeComponent();
        }

        // Kiểm tra mã nhân viên
        bool ktMaNV(string ma)
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select count(*) from CV_NHANVIEN where MaNV = '" + ma + "'";
            int count = (int)cmd.ExecuteScalar();

            if (count != 1)
                return false;
            return true;
        }

        // kiểm tra mật khẩu nhân viên
        bool ktMatKhau(string mk, string ma)
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select count(*) from CV_NHANVIEN where MatKhauNV = '" + mk + "' and MaNV = '" + ma + "'";
            int count = (int)cmd.ExecuteScalar();

            if (count != 1)
                return false;
            return true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            FromChuongTrinh f = new FromChuongTrinh();
            f.Show();
            this.Hide();
        }

        // Button xác nhận đổi mật khẩu thành công
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (cnt.State == ConnectionState.Closed)
            {
                cnt.Open();
            }

            //
            if (ktMatKhau(txtMKCu.Text, txtMa.Text))
            {
                SqlDataAdapter adt = new SqlDataAdapter("select count(*) from CV_NHANVIEN where MaNV = '" + txtMa.Text + "' and MatKhauNV = '" + txtMKCu.Text + "'", cnt);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                //
                if (txtMKMoi.Text == txtMKCu.Text)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    //
                    if (txtMKMoi.Text == txtXacNhan.Text)
                    {
                        SqlDataAdapter adt1 = new SqlDataAdapter("update CV_NHANVIEN set MatKhauNV = '" + txtMKMoi.Text + "' where MaNV = '" + txtMa.Text + "' and MatKhauNV = '" + txtMKCu.Text + "'", cnt);
                        DataTable dt1 = new DataTable();
                        adt1.Fill(dt1);

                        if (cnt.State == ConnectionState.Open)
                        {
                            cnt.Close();
                        }
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                        txtMa.Text = "";
                        txtMKCu.Text = "";
                        txtXacNhan.Text = "";
                        txtMKMoi.Text = "";
                        txtMa.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }


        // Buttton kiểm tra xem mã nhân viên có đúng không
        private void btKT_Click(object sender, EventArgs e)
        {
            if (cnt.State == ConnectionState.Closed)
            {
                cnt.Open();
            }

            // Kiểm tra mã nhân viên
            if (txtMa.Text == "")
            {
                txtMa.Focus();
                MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else if (ktMaNV(txtMa.Text))
            {
                MessageBox.Show("Mã nhân viên đúng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã nhân viên sai", "Thông báo", MessageBoxButtons.OK);
            }

            // Kiểm tra mật khẩu cũ
            if (txtMKCu.Text == "")
            {
                txtMa.Focus();
                MessageBox.Show("Chưa nhập Mật khẩu nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else if (ktMatKhau(txtMKCu.Text, txtMa.Text))
            {
                MessageBox.Show("Mật khẩu nhân viên đúng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mật khẩu nhân viên sai", "Thông báo", MessageBoxButtons.OK);
            }

            if (cnt.State == ConnectionState.Open)
            {
                cnt.Close();
            }
        }
    }
}
