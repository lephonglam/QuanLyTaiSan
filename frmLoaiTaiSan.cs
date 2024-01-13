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
    public partial class frmLoaiTaiSan : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        private int mode;
        public frmLoaiTaiSan()
        {
            InitializeComponent();
        }

        private void frmLoaiTaiSan_Load(object sender, EventArgs e)
        {
            AnHien(false);
            KhoaChucNang(true);
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            //TH Hủy Thêm Loại tài sản, điền thông tin loại tài sản đang chọn vào textbox
            if (gvDanhSach.SelectedRowsCount > 0)
            {
                int index = gvDanhSach.FocusedRowHandle;
                txtMaLoai.Text = gvDanhSach.GetRowCellValue(index, "MaLoai").ToString();
                txtTenLoai.Text = gvDanhSach.GetRowCellValue(index, "TenLoai").ToString();
                cboKhauHao.Text = gvDanhSach.GetRowCellValue(index, "KhauHao").ToString();
            }
            List<LOAITAISAN> dsLoaiTaiSan = db.LOAITAISANs.ToList();
            gcDanhSach.DataSource = dsLoaiTaiSan;
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = gvDanhSach.FocusedRowHandle;
            txtMaLoai.Text = gvDanhSach.GetRowCellValue(index, "MaLoai").ToString();
            txtTenLoai.Text = gvDanhSach.GetRowCellValue(index, "TenLoai").ToString();
            cboKhauHao.Text = gvDanhSach.GetRowCellValue(index, "KhauHao").ToString();
        }

        private void AnHien(bool value)
        {
            txtMaLoai.Enabled = value;
            txtTenLoai.Enabled = value;
            cboKhauHao.Enabled = value;
        }

        private void KhoaChucNang(bool value)
        {
            btnThem.Enabled = value;
            btnSua.Enabled = value;
            btnLuu.Enabled = value;
            btnXoa.Enabled = value;
            btnHuy.Enabled = value;
        }

        private void Empty()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            cboKhauHao.Text = "";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 1;
            AnHien(true);
            Empty();
            KhoaChucNang(false);
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaLoai.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 0;
            AnHien(true);
            KhoaChucNang(false);
            txtMaLoai.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == 1)
            {
                string ma = txtMaLoai.Text.Trim();
                string ten = txtTenLoai.Text.Trim();
                string khauhao = cboKhauHao.Text.Trim();
                if (ma != "" && ten != "" && khauhao != "")
                {
                    LOAITAISAN ktLoaiTaiSan = db.LOAITAISANs.SingleOrDefault(record => record.MaLoai == ma);
                    if (ktLoaiTaiSan == null)
                    {
                        try
                        {
                            LOAITAISAN loaiTaiSan = new LOAITAISAN();
                            loaiTaiSan.MaLoai = ma;
                            loaiTaiSan.TenLoai = ten;
                            loaiTaiSan.KhauHao = int.Parse(khauhao);
                            db.LOAITAISANs.InsertOnSubmit(loaiTaiSan);
                            db.SubmitChanges();
                            MessageBox.Show("Thêm thành công!",
                                "Thêm loại tài sản",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                            AnHien(false);
                            KhoaChucNang(true);
                            frmLoaiTaiSan_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thêm loại tài sản thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Loại tài sản đã có trong danh sách",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                        Empty();
                        txtMaLoai.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            else if (mode == 0)
            {
                string ma = txtMaLoai.Text.Trim();
                string ten = txtTenLoai.Text.Trim();
                string khauhao = cboKhauHao.Text.Trim();
                if (ma != "")
                {
                    LOAITAISAN loaiTaiSan = db.LOAITAISANs.SingleOrDefault(record => record.MaLoai == ma);
                    try
                    {
                        loaiTaiSan.TenLoai = ten;
                        loaiTaiSan.KhauHao = int.Parse(khauhao);
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!",
                            "Sửa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        AnHien(false);
                        KhoaChucNang(true);
                        frmLoaiTaiSan_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa loại tài sản thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn loại tài sản cần sửa",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvDanhSach.SelectedRowsCount > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
                    "Xóa loại tài sản",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.OK)
                {
                    string ma = txtMaLoai.Text.Trim();
                    List<TAISAN> dsTaiSan = db.TAISANs.Where(record => record.MaLoai == ma).ToList();
                    if (dsTaiSan != null)
                    {
                        try
                        {
                            db.TAISANs.DeleteAllOnSubmit(dsTaiSan);
                            db.SubmitChanges();
                            frmLoaiTaiSan_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa tài sản có mã loại " + ma + " thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }
                    try
                    {
                        LOAITAISAN loaiTaiSan = db.LOAITAISANs.SingleOrDefault(record => record.MaLoai == ma);
                        db.LOAITAISANs.DeleteOnSubmit(loaiTaiSan);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!",
                            "Xóa loại tài sản",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        frmLoaiTaiSan_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa loại tài sản thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách loại tài sản trống",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result;
            if (mode == 1)
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Thêm loại tài sản?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            else
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Cập nhật loại tài sản?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            if (result == DialogResult.OK)
            {
                AnHien(false);
                KhoaChucNang(true);
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                frmLoaiTaiSan_Load(sender, e);
            }
        }
    }
}