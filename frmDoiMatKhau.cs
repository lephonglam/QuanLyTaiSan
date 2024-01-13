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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
            txtTaiKhoan.Text = SQLHelper.TaiKhoan;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhanMK = txtXacNhanMatKhau.Text.Trim();
            if(matKhauCu != "" && matKhauMoi != "" && xacNhanMK != "")
            {
                NGUOIDUNG nguoidung = db.NGUOIDUNGs.SingleOrDefault(record => record.TaiKhoan == taiKhoan 
                && record.MatKhau == Ultils.AES_Encrypt(matKhauCu));
                if(nguoidung != null)
                {
                    if(matKhauMoi.Equals(xacNhanMK))
                    {
                        nguoidung.MatKhau = matKhauMoi;
                        db.SubmitChanges();
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không đúng",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}