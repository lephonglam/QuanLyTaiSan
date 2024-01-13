using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiSan
{
    public partial class frmTaiSan : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        public frmTaiSan()
        {
            InitializeComponent();
        }

        private void LoadTaiSan()
        {
            gcDanhSachTaiSan.DataSource = null;
            List<TAISAN> taisans = db.TAISANs.ToList();
            foreach (TAISAN taisan in taisans)
            {
                db.Refresh(RefreshMode.OverwriteCurrentValues, taisan);
            }
            gcDanhSachTaiSan.DataSource = taisans;
        }

        private void frmTaiSan_Load(object sender, EventArgs e)
        {
            LoadTaiSan();
        }

        private void btnTaiDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadTaiSan();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTS frmThemTS = new frmThemTS();
            frmThemTS.MdiParent = this.MdiParent;
            frmThemTS.Show();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gvDanhSachTaiSan.SelectedRowsCount > 0)
            {
                int index = gvDanhSachTaiSan.FocusedRowHandle;
                SQLHelper.MaTS = gvDanhSachTaiSan.GetRowCellValue(index, "MaTS").ToString();
            }
            else
            {
                SQLHelper.MaTS = null;
            }
            frmCapNhatTS frmCapNhatTS = new frmCapNhatTS();
            frmCapNhatTS.MdiParent=this.MdiParent;
            frmCapNhatTS.Show();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gvDanhSachTaiSan.SelectedRowsCount > 0)
            {
                int index = gvDanhSachTaiSan.FocusedRowHandle;
                string maTS = gvDanhSachTaiSan.GetRowCellValue(index, "MaTS").ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài sản mã " + maTS,
                    "Xóa tài sản",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if(result == DialogResult.OK )
                {
                    try
                    {
                        TAISAN taisan = db.TAISANs.SingleOrDefault(record => record.MaTS == maTS);
                        db.TAISANs.DeleteOnSubmit(taisan);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa tài sản thành công!");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Xóa tài sản thất bại: " +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có tài sản trong danh sách");
            }
        }

        private void btnThanhLy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gvDanhSachTaiSan.SelectedRowsCount > 0)
            {
                int index = gvDanhSachTaiSan.FocusedRowHandle;
                SQLHelper.MaTS = gvDanhSachTaiSan.GetRowCellValue(index, "MaTS").ToString();
            }
            else
            {
                SQLHelper.MaTS = null;
            }
            frmThemTLTS frmThemTLTS = new frmThemTLTS();
            frmThemTLTS.MdiParent = this.MdiParent;
            frmThemTLTS.Show();
        }

        private void frmTaiSan_Activated(object sender, EventArgs e)
        {
            
        }
    }
}