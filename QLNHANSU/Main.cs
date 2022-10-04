using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_PhongBan"] == null)
            {
                frm_PhongBan pb = new frm_PhongBan();
                pb.MdiParent = this;
                pb.Show();
            }
            else
            {
                Application.OpenForms["frm_PhongBan"].Activate();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nv = new frm_NhanVien();
                nv.MdiParent = this;
                nv.Show();
            }
            else
            {
                Application.OpenForms["frm_NhanVien"].Activate();
            }
        }
    }
}
