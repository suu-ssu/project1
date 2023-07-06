using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SQL_QLTrasua;

namespace SQL_QLTrasua
{
    public partial class QuanLyTKNV : Form
    {
        //
        SqlConnection cnt;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable t = new DataTable();

        //
        SqlCommand cmd1;
        SqlDataAdapter adt1 = new SqlDataAdapter();
        DataTable t1 = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_QuanTraSua;Integrated Security=True";

        public QuanLyTKNV()
        {
            cnt = new SqlConnection(str);

            InitializeComponent();
        }

        //
        void loadData()
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select * from CV_NHANVIEN";

            adt.SelectCommand = cmd;
            t.Clear();
            adt.Fill(t);
            dataGridView1.DataSource = t;
        }

        //
        void loadDataQL()
        {
            cmd1 = cnt.CreateCommand();
            cmd1.CommandText = "select * from QUANLY";

            adt1.SelectCommand = cmd1;
            t1.Clear();
            adt1.Fill(t1);
            dataGridView2.DataSource = t1;
        }

        //
        private void btThemNV_Click(object sender, EventArgs e)
        {
            cnt.Open();
            if (kTMa(txtMaNV.Text))
            {
                cmd = cnt.CreateCommand();
                cmd.CommandText = "insert into CV_NHANVIEN values('" + txtMaNV.Text + "', '" + txtPass.Text + "')";
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo");
            }
            cnt.Close();
        }

        //
        private void btSuaNV_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd = cnt.CreateCommand();
            cmd.CommandText = "update CV_NHANVIEN set MatKhauNV = '" + txtPass.Text + "' where MaNV = '" + txtMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            cnt.Close();
        }

        //
        private void btXoaNV_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd = cnt.CreateCommand();
            cmd.CommandText = "delete from CV_NHANVIEN where MaNV = '" + txtMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            cnt.Close();
        }

        //
        private void QuanLyTKNV_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataQL();
        }

        //
        bool kTMa(string ma)
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select count(*) from CV_NHANVIEN where MaNV = '" + ma + "'";
            int count = (int)cmd.ExecuteScalar();

            if (count >= 1)
                return false;
            return true;
        }

        //
        bool kTMaQL(string ma)
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select count(*) from QUANLY where MaQL = '" + ma + "'";
            int count = (int)cmd.ExecuteScalar();

            if (count >= 1)
                return false;
            return true;
        }

        //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;

            int i;
            i = dataGridView1.CurrentRow.Index;

            txtMaNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtPass.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            
        }

        //
        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Text = "";
            txtPass.Text = "";
            txtMaNV.Focus();
        }

        //
        private void btThemQL_Click(object sender, EventArgs e)
        {
            cnt.Open();
            if (kTMaQL(txtMaQL.Text))
            {
                cmd1 = cnt.CreateCommand();
                cmd1.CommandText = "insert into QUANLY values('" + txtMaQL.Text + "', '" + txtPassQL.Text + "')";
                cmd1.ExecuteNonQuery();
                loadDataQL();
                MessageBox.Show("Thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã quản lý đã tồn tại!", "Thông báo");
            }
            cnt.Close();
        }

        //
        private void btSuaQL_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd1 = cnt.CreateCommand();
            cmd1.CommandText = "update QUANLY set MatKhauQL = '" + txtPassQL.Text + "' where MaQL = '" + txtMaQL.Text + "'";
            cmd1.ExecuteNonQuery();
            loadDataQL();
            cnt.Close();
        }

        //
        private void btXoaQL_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd1 = cnt.CreateCommand();
            cmd1.CommandText = "delete from QUANLY where MaQL = '" + txtMaQL.Text + "'";
            cmd1.ExecuteNonQuery();
            loadDataQL();
            cnt.Close();
        }

        //
        private void btLamMoiQL_Click(object sender, EventArgs e)
        {
            txtMaQL.ReadOnly = false;
            txtMaQL.Text = "";
            txtPassQL.Text = "";
            txtMaQL.Focus();
        }

        //
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQL.ReadOnly = true;

            int i;
            i = dataGridView2.CurrentRow.Index;

            txtMaQL.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtPassQL.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

        




    }
}
