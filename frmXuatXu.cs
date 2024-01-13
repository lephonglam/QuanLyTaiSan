using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTaiSan
{
    public partial class frmXuatXu : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        private int mode;
        public frmXuatXu()
        {
            InitializeComponent();
        }

        private void frmXuatXu_Load(object sender, EventArgs e)
        {
            AnHien(false);
            KhoaChucNang(true);
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if (gvDanhSach.SelectedRowsCount > 0)
            {
                int index = gvDanhSach.FocusedRowHandle;
                txtMaXuatXu.Text = gvDanhSach.GetRowCellValue(index, "MaXuatXu").ToString();
                txtNoiXuatXu.Text = gvDanhSach.GetRowCellValue(index, "NoiXuatXu").ToString();
            }
            List<XUATXU> dsXuatXu = db.XUATXUs.ToList();
            gcDanhSach.DataSource = dsXuatXu;
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = gvDanhSach.FocusedRowHandle;
            txtMaXuatXu.Text = gvDanhSach.GetRowCellValue(index, "MaXuatXu").ToString();
            txtNoiXuatXu.Text = gvDanhSach.GetRowCellValue(index, "NoiXuatXu").ToString();
        }

        private void AnHien(bool value)
        {
            txtMaXuatXu.Enabled = value;
            txtNoiXuatXu.Enabled = value;
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
            txtMaXuatXu.Text = "";
            txtNoiXuatXu.Text = "";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 1;
            AnHien(true);
            KhoaChucNang(false);
            Empty();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaXuatXu.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 0;
            AnHien(true);
            KhoaChucNang(false);
            txtMaXuatXu.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == 1)
            {
                string ma = txtMaXuatXu.Text.Trim();
                string noiXuatXu = txtNoiXuatXu.Text.Trim();
                if (ma != "" && noiXuatXu != "")
                {
                    XUATXU ktXuatXu = db.XUATXUs.SingleOrDefault(record => record.MaXuatXu == ma);
                    if (ktXuatXu == null)
                    {
                        try
                        {
                            XUATXU xuatxu = new XUATXU();
                            xuatxu.MaXuatXu = ma;
                            xuatxu.NoiXuatXu = noiXuatXu;
                            db.XUATXUs.InsertOnSubmit(xuatxu);
                            db.SubmitChanges();
                            MessageBox.Show("Thêm thành công!",
                                "Thêm xuất xứ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                            AnHien(false);
                            KhoaChucNang(true);
                            frmXuatXu_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thêm xuất xứ thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xuất xứ đã có trong danh sách",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                        Empty();
                        txtMaXuatXu.Focus();
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
                string ma = txtMaXuatXu.Text.Trim();
                string noiXuatXu = txtNoiXuatXu.Text.Trim();
                if (ma != "")
                {
                    XUATXU xuatxu = db.XUATXUs.SingleOrDefault(record => record.MaXuatXu == ma);
                    try
                    {
                        xuatxu.NoiXuatXu = noiXuatXu;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!",
                            "Sửa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        AnHien(false);
                        KhoaChucNang(true);
                        frmXuatXu_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa xuất xứ thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn xuất xứ cần sửa",
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
                    "Xóa xuất xứ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.OK)
                {
                    string ma = txtMaXuatXu.Text.Trim();
                    List<TAISAN> dsTaiSan = db.TAISANs.Where(record => record.MaXuatXu == ma).ToList();
                    if (dsTaiSan != null)
                    {
                        try
                        {
                            db.TAISANs.DeleteAllOnSubmit(dsTaiSan);
                            db.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa tài sản có mã xuất xứ " + ma + " thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }

                    try
                    {
                        XUATXU xuatxu = db.XUATXUs.SingleOrDefault(record => record.MaXuatXu == ma);
                        db.XUATXUs.DeleteOnSubmit(xuatxu);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!",
                            "Xóa xuất xứ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        frmXuatXu_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa xuất xứ thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách xuất xứ trống",
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
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Thêm xuất xứ?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            else
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Cập nhật xuất xứ?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            if (result == DialogResult.OK)
            {
                frmXuatXu_Load(sender, e);
            }
        }
    }
}