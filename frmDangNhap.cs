using DevExpress.Utils.DirectXPaint.DirectComposition;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiSan
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        private bool hide = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
            btnMatKhau.ImageOptions.Image = imageCollection1.Images[1];
            txtMatKhau.Properties.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string mkEncrypted = Ultils.AES_Encrypt(txtMatKhau.Text.Trim());
            NGUOIDUNG nguoidung = db.NGUOIDUNGs.SingleOrDefault(record => record.TaiKhoan == txtTaiKhoan.Text.Trim()
            && record.MatKhau == mkEncrypted);
            if(nguoidung != null)
            {
                SQLHelper.TaiKhoan = txtTaiKhoan.Text.Trim();
                SQLHelper.MatKhau = txtMatKhau.Text.Trim();
                SQLHelper.PhanQuyen = nguoidung.PhanQuyen;
                SQLHelper.Hoten = nguoidung.HoTen;
                //MessageBox.Show("Chào mừng " + nguoidung.HoTen + " đăng nhập vào hệ thống!");
                frmTrangChu frmTrangChu = new frmTrangChu();
                frmTrangChu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai Tài khoản hoặc Mật khẩu",
                    "Lỗi đăng nhập", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (hide)
            {
                btnMatKhau.ImageOptions.Image = imageCollection1.Images[1];
                txtMatKhau.Properties.PasswordChar = '*';
                hide = false;
            }
            else
            {
                btnMatKhau.ImageOptions.Image = imageCollection1.Images[0];
                txtMatKhau.Properties.PasswordChar = '\0';
                hide = true;
            }
        }
    }
}