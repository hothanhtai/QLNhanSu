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

namespace QLNHANSU
{
    public partial class frm_PhongBan : Form
    {
        public frm_PhongBan()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\QLNHANSU\QLNHANSU\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "INSERT INTO PHONGBAN VALUES(N'" + txt_mapb.Text + "',N'" + txt_tenpb.Text + "',N'" + txt_ghichu.Text + "')";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\QLNHANSU\QLNHANSU\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "UPDATE PHONGBAN SET TENPHONGBAN = N'"+txt_tenpb.Text+"',GHICHU = N'"+txt_ghichu.Text+"' WHERE MAPB = N'"+txt_mapb.Text+"'";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Update thành công");
            }
            else
            {
                MessageBox.Show("Update thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\QLNHANSU\QLNHANSU\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "DELETE FROM PHONGBAN WHERE MAPB = N'"+txt_mapb.Text+"'";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
