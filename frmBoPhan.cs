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
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        private int mode;
        public frmBoPhan()
        {
            InitializeComponent();
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            AnHien(false);
            KhoaChucNang(true);
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if (gvDanhSach.SelectedRowsCount > 0)
            {
                int index = gvDanhSach.FocusedRowHandle;
                txtMaBP.Text = gvDanhSach.GetRowCellValue(index, "MaBP").ToString();
                txtTenBP.Text = gvDanhSach.GetRowCellValue(index, "TenBP").ToString();
                txtChucNang.Text = gvDanhSach.GetRowCellValue(index, "ChucNang").ToString();
            }
            List<BOPHAN> dsBoPhan = db.BOPHANs.ToList();
            gcDanhSach.DataSource = dsBoPhan;
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = gvDanhSach.FocusedRowHandle;
            txtMaBP.Text = gvDanhSach.GetRowCellValue(index, "MaBP").ToString();
            txtTenBP.Text = gvDanhSach.GetRowCellValue(index, "TenBP").ToString();
            txtChucNang.Text = gvDanhSach.GetRowCellValue(index, "ChucNang").ToString();
        }

        private void AnHien(bool value)
        {
            txtMaBP.Enabled = value;
            txtTenBP.Enabled = value;
            txtChucNang.Enabled = value;
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
            txtMaBP.Text = "";
            txtTenBP.Text = "";
            txtChucNang.Text = "";
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
            txtMaBP.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 0;
            AnHien(true);
            KhoaChucNang(false);
            txtMaBP.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(mode == 1)
            {
                string ma = txtMaBP.Text.Trim();
                string ten = txtTenBP.Text.Trim();
                string chucnang = txtChucNang.Text.Trim();
                if (ma != "" && ten != "")
                {
                    BOPHAN ktBoPhan = db.BOPHANs.SingleOrDefault(record => record.MaBP == ma);
                    if (ktBoPhan == null)
                    {
                        try
                        {
                            BOPHAN bophan = new BOPHAN();
                            bophan.MaBP = ma;
                            bophan.TenBP = ten;
                            bophan.ChucNang = chucnang;
                            db.BOPHANs.InsertOnSubmit(bophan);
                            db.SubmitChanges();
                            MessageBox.Show("Thêm thành công!",
                                "Thêm bộ phận",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                            AnHien(false);
                            KhoaChucNang(true);
                            frmBoPhan_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thêm bộ phận thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bộ phận đã có trong danh sách",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                        Empty();
                        txtMaBP.Focus();
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
                string ma = txtMaBP.Text.Trim();
                string ten = txtTenBP.Text.Trim();
                string chucnang = txtChucNang.Text.Trim();
                if (ma != "")
                {
                    BOPHAN bophan = db.BOPHANs.SingleOrDefault(record => record.MaBP == ma);
                    try
                    {
                        bophan.TenBP = ten;
                        bophan.ChucNang = chucnang;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!",
                            "Sửa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        AnHien(false);
                        KhoaChucNang(true);
                        frmBoPhan_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa bộ phận sản thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn bộ phận cần sửa",
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
                    "Xóa Bộ phận",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.OK)
                {
                    string ma = txtMaBP.Text.Trim();
                    List<TAISAN> dsTaiSan = db.TAISANs.Where(record => record.MaBP == ma).ToList();
                    if(dsTaiSan != null)
                    {
                        try
                        {
                            db.TAISANs.DeleteAllOnSubmit(dsTaiSan);
                            db.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa tài sản có mã bộ phận " + ma + " thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        }
                    }
                    
                    try
                    {
                        BOPHAN bophan = db.BOPHANs.SingleOrDefault(record => record.MaBP == ma);
                        db.BOPHANs.DeleteOnSubmit(bophan);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!",
                            "Xóa bộ phận",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        frmBoPhan_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa bộ phận thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách bộ phận trống",
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
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Thêm bộ phận?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            else
            {
                result = MessageBox.Show("Bạn có chắc chắn muốn hủy Cập nhật bộ phận?",
                "Hủy",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            }
            if (result == DialogResult.OK)
            {
                frmBoPhan_Load(sender, e);
            }
        }
    }
}