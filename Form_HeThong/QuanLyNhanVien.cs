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
    public partial class QuanLyNhanVien : Form
    {
        //
        SqlConnection cnt;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable t = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_quantrasua;Integrated Security=True";
        public QuanLyNhanVien()
        {
            cnt = new SqlConnection(str);

            InitializeComponent();
        }

        //
        void loadData()
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select * from NHANVIEN";
            adt.SelectCommand = cmd;
            t.Clear();
            adt.Fill(t);
            dataGridView1.DataSource = t;
        }

        //
        bool kTMa(string ma)
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select count(*) from NHANVIEN where MaNhanVien = '" + ma + "'";
            int count = (int)cmd.ExecuteScalar();

            if (count >= 1)
                return false;
            return true;
        }

        
        
        //
        private void btLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }


        //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true; // chi cho phep doc, k duoc chinh sua

            int i;
            i = dataGridView1.CurrentRow.Index;

            txtMaNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDate.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_Chucvu.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_MucLuong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_NgayCong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_luong.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
           
        }

        private void capnhatluong()
        {
    
            cmd = cnt.CreateCommand();
            cmd.CommandText = "exec capnhatluong_nv";
            cmd.ExecuteNonQuery();
            loadData();
        }
       

        //
        private void btThem_Click(object sender, EventArgs e)
        {
            cnt.Open();
            if (kTMa(txtMaNV.Text) == true )
            {
      
                SqlCommand command = new SqlCommand("insert into NHANVIEN values (@manv,@tennv,@ngaysinh,@chucvu,@mucluong,@ngaycong,@luong)", cnt);
                command.Parameters.AddWithValue("@manv", txtMaNV.Text);
                command.Parameters.AddWithValue("@tennv", txtTenNV.Text);
                command.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txtDate.Text));
                command.Parameters.AddWithValue("@chucvu", txt_Chucvu.Text);
                command.Parameters.AddWithValue("@mucluong", txt_MucLuong.Text);
                command.Parameters.AddWithValue("@ngaycong", txt_NgayCong.Text);
                command.Parameters.AddWithValue("@luong", txt_luong.Text);
                command.ExecuteNonQuery();
                capnhatluong();
                MessageBox.Show("Thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã  nhân viên đã tồn tại!", "Thông báo");
            }
            cnt.Close();
        }

        //
        private void btSua_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd = cnt.CreateCommand();
            cmd.CommandText = "update NHANVIEN set HoTen = N'" + txtTenNV.Text + "', NgaySinh = '" + txtDate.Text + "', ChucVu = N'" + txt_Chucvu.Text + "', MucLuong='"+txt_MucLuong.Text+"', NgayCong='"+txt_NgayCong.Text+ "' where MaNhanVien = '" + txtMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            capnhatluong();
            cnt.Close();
        }

        //
        private void btXoa_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd = cnt.CreateCommand();
            cmd.CommandText = "delete from NHANVIEN where MaNhanVien = '" + txtMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            cnt.Close();
        }

        //
        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtTenNV.Text = "";
            txtDate.Text = "";
            txt_Chucvu.Text = "";
            txt_MucLuong.Text = "";
            txt_NgayCong.Text = "";
            txt_luong.Text = "";
            txtMaNV.Focus();
        }

        //
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
