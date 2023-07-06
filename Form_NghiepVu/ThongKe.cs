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

    public partial class ThongKe : Form
    {
        //
        SqlConnection cnt;
        SqlCommand cmd;
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_quantrasua;Integrated Security=True";


        public ThongKe()
        {
            cnt = new SqlConnection(str);

            InitializeComponent();
        }

        //
        void loadData()
        {
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();

            string load = "select hd.MaHoaDon,hd.Ngaytao,ct.MaSanPham,MaNhanVien,DonGia,SoLuong,TongTienHD,TinhTrangThanhToan from HOADON as hd,CHITIETHOADON as ct where hd.MaHoaDon = ct.MaHoaDon";
            SqlCommand cmd = new SqlCommand(load, cnt);
            SqlDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader.GetString(0));
                list.SubItems.Add(reader.GetDateTime(1).ToString());
                list.SubItems.Add(reader.GetString(2));
                list.SubItems.Add(reader.GetString(3));
                list.SubItems.Add(reader.GetInt32(4).ToString());
                list.SubItems.Add(reader.GetInt32(5).ToString());
                list.SubItems.Add(reader.GetInt32(6).ToString());
                list.SubItems.Add(reader.GetString(7));
                listView1.Items.Add(list);

            }

            reader.Close();
            cnt.Close();
        }





        // Load cbbMaHD
        void loadCBBMaHD()
        {
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();

            string load = "select * from HOADON";

            DataSet ds = new DataSet();
            SqlDataAdapter adt = new SqlDataAdapter(load, cnt);
            adt.Fill(ds);
            cbb_maHD.DataSource = ds.Tables[0];
            cbb_maHD.DisplayMember = "MaHoaDon"; // lên trên combobox
            cbb_maHD.ValueMember = "MaHoaDon"; // biến là mã

        }
      




        private void btLoad_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            loadData();
      
        }

        private void XemTour_Load(object sender, EventArgs e)
        {
            loadCBBMaHD();
            loadCBBNam();
        }

        //
        void fiter()
        {
            if (cnt.State == ConnectionState.Closed)
            {
                cnt.Open();
            }

            string selectCBB = cbb_maHD.SelectedValue.ToString();
            string query = "select hd.MaHoaDon,hd.Ngaytao,ct.MaSanPham,MaNhanVien,DonGia,SoLuong,TongTienHD,TinhTrangThanhToan from HOADON as hd,CHITIETHOADON as ct where hd.MaHoaDon = ct.MaHoaDon and hd.MaHoaDon = '" + selectCBB + "' ";
            SqlCommand cmd = new SqlCommand(query, cnt);
            SqlDataReader rd = cmd.ExecuteReader();

            int i = 0;


            while (rd.Read())
            {
                listView1.Items.Add(rd["MaHoaDon"].ToString());             
                listView1.Items[i].SubItems.Add(rd["Ngaytao"].ToString());
                listView1.Items[i].SubItems.Add(rd["MaSanPham"].ToString());
                listView1.Items[i].SubItems.Add(rd["MaNhanVien"].ToString());
                listView1.Items[i].SubItems.Add(rd["Dongia"].ToString());
                listView1.Items[i].SubItems.Add(rd["SoLuong"].ToString());
                listView1.Items[i].SubItems.Add(rd["TongTienHD"].ToString());
                listView1.Items[i].SubItems.Add(rd["TinhTrangThanhToan"].ToString());
                i++;
     

            }

            rd.Close();
            cnt.Close();
        }

        private void btLoc_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            fiter();
            loadtongtien();

        }
        void loadCBBNam()
        {
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();

            string load = "select  distinct YEAR(Ngaytao) as NAM from HOADON";

            DataSet ds = new DataSet();
            SqlDataAdapter adt = new SqlDataAdapter(load, cnt);
            adt.Fill(ds);
            
            cb_nam.DataSource = ds.Tables[0];
            cb_nam.DisplayMember = "NAM"; // lên trên combobox
            cb_nam.ValueMember = "NAM"; // biến là mã

        }

        private void loadtongtien()
        {
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();
            string selectCBB = cbb_maHD.SelectedValue.ToString();
            int tongtientheohd = 0;
            cmd = cnt.CreateCommand();
            cmd.CommandText = "select SUM(TongTienHD) from HOADON,CHITIETHOADON where CHITIETHOADON.MaHoaDon = '" + selectCBB + "' and HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon";
            tongtientheohd = (int)cmd.ExecuteScalar();
            txt_tongtienhd.Text = tongtientheohd.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (cnt.State == ConnectionState.Closed)
                cnt.Open();
            string ngay, thang, nam;
            int DoanhThu = 0;
            if (string.IsNullOrEmpty(cb_ngay.Text) && string.IsNullOrEmpty(cb_thang.Text) && !string.IsNullOrEmpty(cb_nam.Text))
            {
        
                nam = cb_nam.Text;
                cmd = cnt.CreateCommand();
                cmd.CommandText = "select SUM(TongTienHD) from HOADON,CHITIETHOADON where YEAR(Ngaytao) = '" + nam + "' and HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon";
                DoanhThu = (int)cmd.ExecuteScalar();
                txt_doanhthu.Text = DoanhThu.ToString();
            
            }
            if (!string.IsNullOrEmpty(cb_ngay.Text) && !string.IsNullOrEmpty(cb_thang.Text) && !string.IsNullOrEmpty(cb_nam.Text))

            {
                ngay = cb_ngay.Text;
                thang = cb_thang.Text;
                nam = cb_nam.Text;
                cmd = cnt.CreateCommand();
                cmd.CommandText = "select SUM(TongTienHD) from HOADON,CHITIETHOADON  where  HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon and YEAR(Ngaytao) = '" + nam + "' and month(Ngaytao)= '" + thang + " ' and DAY(Ngaytao)= '" + ngay + "'";
                DoanhThu = (int)cmd.ExecuteScalar();
                txt_doanhthu.Text = DoanhThu.ToString();
            }
            if (string.IsNullOrEmpty(cb_ngay.Text) && !string.IsNullOrEmpty(cb_thang.Text) && !string.IsNullOrEmpty(cb_nam.Text))

            {

                thang = cb_thang.Text;
                nam = cb_nam.Text;
                cmd = cnt.CreateCommand();
                cmd.CommandText = "select SUM(TongTienHD) from HOADON,CHITIETHOADON where  HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon and YEAR(Ngaytao) = '" + nam + "' and month(Ngaytao)= '" + thang + " '";
                DoanhThu = (int)cmd.ExecuteScalar();
                txt_doanhthu.Text = DoanhThu.ToString();
            }
        }







    }
}
