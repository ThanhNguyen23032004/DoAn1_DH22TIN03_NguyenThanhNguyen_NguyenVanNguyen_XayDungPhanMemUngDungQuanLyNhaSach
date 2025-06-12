using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyNhaSach
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            anPanel();
        }

        private void anPanel()
        {
            pn_HeThong.Visible = false;
            pn_DanhMuc.Visible = false;
            pn_QLyNhap.Visible = false;
            pn_QLyXuat.Visible = false;
            pn_BaoCao.Visible = false;
            pn_GiaoHang.Visible = false;
        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {
            anPanel();
            pn_HeThong.Visible = true;
        }

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            anPanel();
            pn_DanhMuc.Visible = true;
        }

        private void btn_QLyNhap_Click(object sender, EventArgs e)
        {
            anPanel();
            pn_QLyNhap.Visible = true;
        }

        private void btn_QLyXuat_Click(object sender, EventArgs e)
        {
            anPanel();
            pn_QLyXuat .Visible = true;
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            anPanel();
            pn_BaoCao .Visible = true;
        }

        private void btn_GiaoHang_Click(object sender, EventArgs e)
        {
            anPanel();
            pn_GiaoHang .Visible = true;
        }
    }
}
