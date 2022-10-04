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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\QLNHANSU\QLNHANSU\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "DELETE FROM NHANVIEN WHERE MANV = N'"+txt_manv.Text+"'";
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\QLNHANSU\QLNHANSU\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "INSERT INTO NHANVIEN VALUES(N'"+txt_manv.Text+"',N'"+txt_hoten.Text+"',CONVERT(DATETIME,N'"+dt_ngayvaocoquan.Text+"',103),N'"+txt_diachi.Text+"',N'"+cb_tenpb.SelectedItem+"')";
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

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\QLNHANSU\QLNHANSU\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "SELECT TENPB FROM PHONGBAN";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            SqlDataReader doc = comm.ExecuteReader();
            while (doc.Read())
            {
                cb_tenpb.Items.Add(doc["TENPB"]);
            }
            cnn.Close();
        }

        private void btm_sua_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\QLNHANSU\QLNHANSU\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "UPDATE NHANVIEN SET HOTEN = N'"+txt_hoten.Text+"',NGAYVAOCOQUAN = CONVERT(DATETIME,N'"+dt_ngayvaocoquan.Text+"',103),DIACHI = N'"+txt_diachi.Text+"',MAPB = N'"+cb_tenpb.SelectedItem+"' WHERE MANV = N'"+txt_manv.Text+"'";
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
