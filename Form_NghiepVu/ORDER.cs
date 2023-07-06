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
    public partial class ORDER : Form
    {
        SqlConnection cnt;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable t = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_quantrasua;Integrated Security=True";
        public ORDER()
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
            dgv_menu.DataSource = t;
        }
        bool kTMa(string ma)
        {
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select count(*) from HOADON where MaHoaDon = '" + ma + "'";
            int count = (int)cmd.ExecuteScalar();

            if (count >= 1)
                return false;
            return true;
        }
        void themhoadon()
        {
            string tinhtrang = "Đã thanh toán";
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();
            if (kTMa(txt_mahd.Text) == true)
            {

                //cmd.Parameters.AddWithValue("@to", DateTime.Parse(txt_ngaytao.Text));         
                SqlCommand command = new SqlCommand("insert into HOADON  values (@mahd, @ngaytao, @tinhtrang)", cnt);
                command.Parameters.AddWithValue("@mahd", txt_mahd.Text);
                command.Parameters.AddWithValue("@ngaytao", DateTime.Parse(txt_ngaytao.Text));
                command.Parameters.AddWithValue("@tinhtrang", cb_tinhtrang.Text);
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!", "Thông báo");
            }
            cnt.Close();
        }
        void loadCBBMaNV()
        {
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();

            string load = "select * from NHANVIEN";

            DataSet ds = new DataSet();
            SqlDataAdapter adt = new SqlDataAdapter(load, cnt);
            adt.Fill(ds);
            cb_manv.DataSource = ds.Tables[0];
            cb_manv.DisplayMember = "MaNhanVien"; // lên trên combobox
            cb_manv.ValueMember = "MaNhanVien"; // biến là mã

        }

        void themchitiethoadon()
        {

            if (cnt.State == ConnectionState.Closed)
                cnt.Open();
                 string manv = cb_manv.Text.ToString();
                int soluong =int.Parse(txt_soluong.Text.ToString());
                int dongia = int.Parse(txt_dongia.Text.ToString());
                int tongtien = soluong * dongia;
                txt_tongtien.Text = tongtien.ToString();
                cmd = cnt.CreateCommand();
                cmd.CommandText = "insert into CHITIETHOADON values('" + txt_mahd.Text + "', N'" + txt_mamon.Text + "','" + manv + "','" + txt_soluong.Text + "','','')";
                cmd.ExecuteNonQuery();
                 MessageBox.Show("Thành công!", "Thông báo");

            cnt.Close();
        }
        //


        private void dgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mamon.ReadOnly = true; // chi cho phep doc, k duoc chinh sua

            int i;
            i = dgv_menu.CurrentRow.Index;

            txt_mamon.Text = dgv_menu.Rows[i].Cells[0].Value.ToString();
            txt_tenmon.Text = dgv_menu.Rows[i].Cells[1].Value.ToString();
            txt_dongia.Text = dgv_menu.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadData();
            loadCBBMaNV();
        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            kTMa(txt_mahd.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themhoadon();
            themchitiethoadon();
        }
    }
}
