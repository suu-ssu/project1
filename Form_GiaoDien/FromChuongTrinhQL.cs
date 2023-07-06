using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_QLTrasua
{
    public partial class FromChuongTrinhQL : Form
    {
        public FromChuongTrinhQL()
        {
            InitializeComponent();
        }

        

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.ShowDialog(); // Không thể thao tác lên cha
        }

       
            

        

        

        

        
        // Chữ di chuyển
        int x = 22, y = 40, a = 1;
        Random rd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbNhanVien.Location = new Point(x, y);

                if (x > 700)
                {
                    a = -1;
                    lbNhanVien.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
                if (x < 22)
                {
                    a = 1;
                    lbNhanVien.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void quảnLýTàiKhoảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTKNV f = new QuanLyTKNV();
            f.ShowDialog();
        }


        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn f = new LogIn();
            f.Show();
            this.Hide();
        }

        //
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTKNV f = new QuanLyTKNV();
            f.ShowDialog();
        
        }

 
         private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien f = new QuanLyNhanVien();
            f.ShowDialog(); 
        }

      

        private void FromChuongTrinhQL_Load(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            TroGiup f = new TroGiup();
            f.ShowDialog();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MENU f = new MENU();
            f.ShowDialog();
            
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Kho f = new QL_Kho();
            f.ShowDialog();
        }


        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            f.ShowDialog();
        }

  

    }
}
