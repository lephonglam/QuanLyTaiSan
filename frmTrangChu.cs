using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraReports.Configuration;
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
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private void TaiGiaoDien()
        {
            SkinHelper.InitSkinPaletteGallery(skinPaletteRibbonGalleryBarItem1);
            string skinName = Properties.Settings.Default.ApplicationSkinName;
            string pallet = Properties.Settings.Default.ApplicationPalletName;
            if (!string.IsNullOrEmpty(pallet))
            {
                UserLookAndFeel.Default.SetSkinStyle(skinName, pallet);
            }
            else
            {
                UserLookAndFeel.Default.SetSkinStyle(skinName);
            }
        }

        private void LuuGiaoDien()
        {
            Properties.Settings.Default.ApplicationSkinName = UserLookAndFeel.Default.ActiveSkinName;
            Properties.Settings.Default.ApplicationPalletName = UserLookAndFeel.Default.ActiveSvgPaletteName;
            Properties.Settings.Default.Save();
        }
        public frmTrangChu()
        {
            InitializeComponent();
            TaiGiaoDien();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (SQLHelper.PhanQuyen == "admin")
            {
                btnNguoiDung.Enabled = true;
            }
            else
            {
                btnNguoiDung.Enabled = false;
            }

            beiTaiKhoan.EditValue = SQLHelper.Hoten;
        }

        private void MoForm(Type ftype)
        {
            foreach(Form form in MdiChildren)
            {
                if(form.GetType() == ftype)
                {
                    form.Activate();
                    return;
                }
            }
            Form frm = (Form)Activator.CreateInstance(ftype);
            frm.MdiParent = this;
            frm.Show();
        }

        //private Form OpenForm(Type ftype)
        //{
        //    foreach(Form form in MdiChildren)
        //    {
        //        if (form.GetType() == ftype)
        //        {
        //            return form;
        //        }
        //    }
        //    return null;
        //}

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn Đăng xuất?",
                "Đăng xuất",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if( result == DialogResult.OK )
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
                this.Close();
            }
        }

        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmNguoiDung));
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmDoiMatKhau));
        }

        private void btnQuanLyTaiSan_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmTaiSan));
        }

        private void btnBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmLapBaoCaoTS));
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmThongKeTS));
        }

        private void btnThanhLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmQuanLyTLTS));
        }

        private void btnNhapTaiSan_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmNhapTS));
        }

        private void btnXuatTaiSan_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmXuatTS));
        }

        private void btnTimKiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmTimKiemTS));
        }

        private void btnLoaiTS_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmLoaiTaiSan));
        }

        private void btnXuatXu_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmXuatXu));
        }

        private void btnNguonQuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmNguonQuy));
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoForm(typeof(frmBoPhan));
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LuuGiaoDien();
            Application.Exit();
        }
    }
}