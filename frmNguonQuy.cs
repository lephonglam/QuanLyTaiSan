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
    public partial class frmNguonQuy : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        private int mode;
        public frmNguonQuy()
        {
            InitializeComponent();
        }

        private void frmNguonQuy_Load(object sender, EventArgs e)
        {
            AnHien(false);
            KhoaChucNang(true);
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if (gvDanhSach.SelectedRowsCount > 0)
            {
                int index = gvDanhSach.FocusedRowHandle;
                txtMaNguon.Text = gvDanhSach.GetRowCellValue(index, "MaNguon").ToString();
                txtTenNguon.Text = gvDanhSach.GetRowCellValue(index, "TenNguon").ToString();
            }
            List<NGUONQUY> dsNguonQuy = db.NGUONQUYs.ToList();
            gcDanhSach.DataSource = dsNguonQuy;
        }

        private void AnHien(bool value)
        {
            txtMaNguon.Enabled = value;
            txtTenNguon.Enabled = value;
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
            txtMaNguon.Text = "";
            txtTenNguon.Text = "";
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = gvDanhSach.FocusedRowHandle;
            txtMaNguon.Text = gvDanhSach.GetRowCellValue(index, "MaNguon").ToString();
            txtTenNguon.Text = gvDanhSach.GetRowCellValue(index, "TenNguon").ToString();
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
            txtMaNguon.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 0;
            AnHien(true);
            KhoaChucNang(false);
            txtMaNguon.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(mode == 1)
            {
                string ma = txtMaNguon.Text.Trim();
                string ten = txtTenNguon.Text.Trim();
                if (ma != "" && ten != "")
                {
                    NGUONQUY ktNguonQuy = db.NGUONQUYs.SingleOrDefault(record => record.MaNguon == ma);
                    if(ktNguonQuy == null)
                    {
                        try
                        {
                            NGUONQUY nguonquy = new NGUONQUY();
                            nguonquy.MaNguon = ma;
                            nguonquy.TenNguon = ten;
                            db.NGUONQUYs.InsertOnSubmit(nguonquy);
                            db.SubmitChanges();
                            MessageBox.Show("Thêm thành công!",
                                "Thêm nguồn quỹ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                            AnHien(false);
                            KhoaChucNang(true);
                            frmNguonQuy_Load(sender, e);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Thêm nguồn quỹ thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nguồn quỹ đã có trong danh sách",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                        Empty();
                        txtMaNguon.Focus();
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
            else if(mode == 0)
            {
                string ma = txtMaNguon.Text.Trim();
                string ten = txtTenNguon.Text.Trim();
                if (ma != "")
                {
                    NGUONQUY nguonquy = db.NGUONQUYs.SingleOrDefault(record => record.MaNguon == ma);
                    try
                    {
                        nguonquy.MaNguon = ma;
                        nguonquy.TenNguon = ten;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!",
                            "Sửa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        AnHien(false);
                        KhoaChucNang(true);
                        frmNguonQuy_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa nguồn quỹ thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn nguồn quỹ cần sửa",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result;
            if (mode == 1)
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Thêm nguồn quỹ?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            else
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Cập nhật nguồn quỹ?",
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
                frmNguonQuy_Load(sender, e);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gvDanhSach.SelectedRowsCount > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
                    "Xóa nguồn quỹ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if(result == DialogResult.OK)
                {
                    string ma = txtMaNguon.Text.Trim();
                    List<TAISAN> dsTaiSan = db.TAISANs.Where(record => record.MaNguon == ma).ToList();
                    if (dsTaiSan != null)
                    {
                        try
                        {
                            db.TAISANs.DeleteAllOnSubmit(dsTaiSan);
                            db.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa tài sản có mã nguồn " + ma + " thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }

                    try
                    {
                        NGUONQUY nguonquy = db.NGUONQUYs.SingleOrDefault(record => record.MaNguon == ma);
                        db.NGUONQUYs.DeleteOnSubmit(nguonquy);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!",
                            "Xóa nguồn quỹ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        frmNguonQuy_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa nguồn quỹ thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách nguồn quỹ trống",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
    }
}