using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiSan
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        int mode;
        public frmNguoiDung()
        {
            InitializeComponent();
            //dtpNgaySinh.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void LoadDsNguoiDung()
        {
            List<NGUOIDUNG> dsNguoiDung = db.NGUOIDUNGs.ToList();
            List<NGUOIDUNG> nguoiDungs = dsNguoiDung.Select(x => new NGUOIDUNG
            {
                TaiKhoan = x.TaiKhoan,
                MatKhau = Ultils.AES_Descrypt(x.MatKhau),
                PhanQuyen = x.PhanQuyen,
                HoTen = x.HoTen,
                NgaySinh = x.NgaySinh,
                DienThoai = x.DienThoai
            }).ToList();
            
            gcNguoiDung.DataSource = nguoiDungs;
        }

        private void DienThongTin(int index)
        {
            txtTaiKhoan.Text = gvNguoiDung.GetRowCellValue(index, "TaiKhoan").ToString();
            txtMatKhau.Text = gvNguoiDung.GetRowCellValue(index, "MatKhau").ToString();
            cboPhanQuyen.Text = gvNguoiDung.GetRowCellValue(index, "PhanQuyen").ToString();
            txtHoTen.Text = gvNguoiDung.GetRowCellValue(index, "HoTen").ToString();
            string ngaySinh = gvNguoiDung.GetRowCellValue(index, "NgaySinh").ToString();
            DateTime dtNgaySinh = DateTime.Parse(ngaySinh);
            dtpNgaySinh.Text = dtNgaySinh.Day.ToString("d2") + "/" + dtNgaySinh.Month.ToString("d2") + "/" + dtNgaySinh.Year;
            txtDienThoai.Text = gvNguoiDung.GetRowCellValue(index, "DienThoai").ToString();
        }
        private void NguoiDung_Load(object sender, EventArgs e)
        {
            //dtpNgaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            //dtpNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy";
            if(gvNguoiDung.SelectedRowsCount > 0)
            {
                int index = gvNguoiDung.FocusedRowHandle;
                DienThongTin(index);
            }
            LoadDsNguoiDung();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            AnHien(false);
        }

        private void AnHien(bool value)
        {
            txtTaiKhoan.Enabled = value;
            txtMatKhau.Enabled = value;
            cboPhanQuyen.Enabled = value;
            txtHoTen.Enabled = value;
            dtpNgaySinh.Enabled = value;
            txtDienThoai.Enabled = value;
        }

        private void Empty()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cboPhanQuyen.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            txtDienThoai.Text = "";
        }

        private void KhoaChucNang(bool value)
        {
            btnThem.Enabled = value;
            btnSua.Enabled = value;
            btnXoa.Enabled = value;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 1;
            KhoaChucNang(false);
            AnHien(true);
            Empty();
            txtTaiKhoan.Focus();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void gvNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = e.FocusedRowHandle;
            DienThongTin(index);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(mode == 1)
            {
                if(txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && cboPhanQuyen.Text != "")
                {
                    NGUOIDUNG KiemTraND = db.NGUOIDUNGs.SingleOrDefault(record => record.TaiKhoan == txtTaiKhoan.Text.Trim());
                    if(KiemTraND == null)
                    {
                        if (Functions.KiemTraSDT(txtDienThoai.Text.Trim()))
                        {
                            try
                            {
                                string mkEnsrypted = Ultils.AES_Encrypt(txtMatKhau.Text.Trim());
                                NGUOIDUNG nguoidung = new NGUOIDUNG();
                                nguoidung.TaiKhoan = txtTaiKhoan.Text.Trim();
                                nguoidung.MatKhau = mkEnsrypted;
                                nguoidung.PhanQuyen = cboPhanQuyen.Text;
                                nguoidung.HoTen = txtHoTen.Text.Trim();
                                nguoidung.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                                nguoidung.DienThoai = txtDienThoai.Text.Trim();
                                db.NGUOIDUNGs.InsertOnSubmit(nguoidung);
                                db.SubmitChanges();
                                MessageBox.Show("Thêm người dùng thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                                NguoiDung_Load(sender, e);
                                KhoaChucNang(true);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Thêm người dùng thất bại: "  +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Nhập sai số điện thoại",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            txtDienThoai.Text = "";
                            txtDienThoai.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tài Khoản đã có trong hệ thống",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        Empty();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Hãy điền đầy đủ thông tin Tài Khoản, Mật khẩu, Phân quyền",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            else
            {
                if (Functions.KiemTraSDT(txtDienThoai.Text.Trim()))
                {
                    try
                    {
                        string mkEnsrypted = Ultils.AES_Encrypt(txtMatKhau.Text.Trim());
                        NGUOIDUNG nguoidung = db.NGUOIDUNGs.SingleOrDefault(record => record.TaiKhoan == txtTaiKhoan.Text.Trim());
                        nguoidung.MatKhau = mkEnsrypted;
                        nguoidung.PhanQuyen = cboPhanQuyen.Text;
                        nguoidung.HoTen = txtHoTen.Text.Trim();
                        nguoidung.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                        nguoidung.DienThoai = txtDienThoai.Text.Trim();
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        NguoiDung_Load(sender, e);
                        KhoaChucNang(true);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Sửa người dùng thất bại: " +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                    }
                }
                else
                {
                    MessageBox.Show(
                                "Nhập sai số điện thoại",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                    txtDienThoai.Focus();
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 0;
            AnHien(true);
            txtTaiKhoan.Enabled = false;
            KhoaChucNang(false);
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng?",
                "Xóa người dùng",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if( result == DialogResult.OK )
            {
                try
                {
                    NGUOIDUNG nguoidung = db.NGUOIDUNGs.SingleOrDefault(record => record.TaiKhoan == txtTaiKhoan.Text.Trim());
                    db.NGUOIDUNGs.DeleteOnSubmit(nguoidung);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                    LoadDsNguoiDung();
                }
                catch(Exception ex )
                {
                    MessageBox.Show("Xóa người dùng thất bại: " +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result;
            if (mode == 1)
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Thêm người dùng?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            else
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Cập nhật người dùng?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            if(result == DialogResult.OK )
            {
                AnHien(false);
                KhoaChucNang(true);
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                NguoiDung_Load(sender, e);
            }
        }
    }
}