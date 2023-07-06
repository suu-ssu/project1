using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_QLTrasua
{
    public partial class QL_Kho : Form
    {
        SqlConnection cnt;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable t = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_quantrasua;Integrated Security=True";
        public QL_Kho()
        {
            cnt = new SqlConnection(str);
            InitializeComponent();
        }
        void loadData()
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select tk.NgayTon,MaNhanVien,MaNVL,SLTon from TONKHONVL as tk,CHITIETKHO as ct where tk.NgayTon = ct.NgayTon";
            adt.SelectCommand = cmd;
            t.Clear();
            adt.Fill(t);
            dgv_kho.DataSource = t;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();
             
            SqlCommand command = new SqlCommand("insert into NhapNguyenLieu  values (@ngaynhap,@manvl,@slnhap)", cnt);
            command.Parameters.AddWithValue("@ngaynhap", DateTime.Parse(txt_ngaynhap.Text));
            command.Parameters.AddWithValue("@manvl", txt_manvl.Text);
            command.Parameters.AddWithValue("@slnhap", txt_slnhap.Text);      
            command.ExecuteNonQuery();
       
            MessageBox.Show("Thành công!", "Thông báo");

            loadData();
            cnt.Close();
        }
    }
}
