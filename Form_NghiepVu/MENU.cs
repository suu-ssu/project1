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
    public partial class MENU : Form
    {
        SqlConnection cnt;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable t = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_quantrasua;Integrated Security=True";
        public MENU()
        {
            cnt = new SqlConnection(str);
            InitializeComponent();
        }
      


        //
        void loadData()
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select * from SANPHAM";
            adt.SelectCommand = cmd;
            t.Clear();
            adt.Fill(t);
            DGV_MENU.DataSource = t;
        }

        //
        bool kTMa(string ma)
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select count(*) from SANPHAM where MaSanPham = '" + ma + "'";
            int count = (int)cmd.ExecuteScalar();

            if (count >= 1)
                return false;
            return true;
        }



        //


        //

        //
  

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            cnt.Open();
            if (kTMa(txt_masp.Text) == true)
            {
                cmd = cnt.CreateCommand();
                cmd.CommandText = "insert into SANPHAM values('" + txt_masp.Text + "', N'" + txt_tensp.Text + "', '" + txt_gia.Text + "')";
                cmd.ExecuteNonQuery();


                MessageBox.Show("Thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã  sản phẩm đã tồn tại!", "Thông báo");
            }
            cnt.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd = cnt.CreateCommand();
            cmd.CommandText = "update SANPHAM set TenSanPham = N'" + txt_tensp.Text + "', DongiaSp = '" + txt_gia.Text + "' where MaSanPham = '" + txt_masp.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            cnt.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            cnt.Open();
            cmd = cnt.CreateCommand();
            cmd.CommandText = "delete from SANPHAM where MaSanPham = '" + txt_masp.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            cnt.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_masp.ReadOnly = false;
            txt_tensp.Text = "";
            txt_gia.Text = "";

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_MENU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masp.ReadOnly = true; // chi cho phep doc, k duoc chinh sua

            int i;
            i = DGV_MENU.CurrentRow.Index;

            txt_masp.Text = DGV_MENU.Rows[i].Cells[0].Value.ToString();
            txt_tensp.Text = DGV_MENU.Rows[i].Cells[1].Value.ToString();
            txt_gia.Text = DGV_MENU.Rows[i].Cells[2].Value.ToString();
        }
    }
}
