using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmQuanLyTLTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        public frmQuanLyTLTS()
        {
            InitializeComponent();
        }

        private void frmQuanLyTLTS_Load(object sender, EventArgs e)
        {
            List<THANHLYT> dsTaiSan = db.THANHLYTs.ToList();
            gcDSTS.DataSource = dsTaiSan;
        }

        private void gcDSTS_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }

        private void gvDSTS_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = e.FocusedRowHandle;
            txtMaTS.Text = gvDSTS.GetRowCellValue(index, "MaTS").ToString();
            txtDonGia.Text = gvDSTS.GetRowCellValue(index, "DonGia").ToString();
            txtSoLuong.Text = gvDSTS.GetRowCellValue(index, "SoLuong").ToString();
            txtTinhTrang.Text = gvDSTS.GetRowCellValue(index, "TinhTrang").ToString();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả tài sản đã thanh lý?",
                "Xóa tài sản",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.OK)
            {
                List<THANHLYT> dsTaiSan = db.THANHLYTs.Where(record => record.TinhTrang == "Đã thanh lý").ToList();
                try
                {
                    db.THANHLYTs.DeleteAllOnSubmit(dsTaiSan);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    frmQuanLyTLTS_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThanhLy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gvDSTS.SelectedRowsCount > 0)
            {
                int index = gvDSTS.FocusedRowHandle;
                string tinhTrang = gvDSTS.GetRowCellValue(index, "TinhTrang").ToString();
                if(tinhTrang.Equals("Chờ thanh lý"))
                {
                    THANHLYT taiSanTL = db.THANHLYTs.SingleOrDefault(record => record.MaTL == int.Parse(gvDSTS.GetRowCellValue(index, "MaTL").ToString()));
                    taiSanTL.TinhTrang = "Đã thanh lý";
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thanh lý thất bại: " + ex.Message);
                    }

                    DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn thanh lý tài sản?",
                        "In hóa đơn",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question
                        );
                    if (result == DialogResult.OK)
                    {
                        frmHDThanhLyTS hdThanhLy = new frmHDThanhLyTS();
                        int dongia = int.Parse(gvDSTS.GetRowCellValue(index, "DonGia").ToString());
                        int soluong = int.Parse(gvDSTS.GetRowCellValue(index, "SoLuong").ToString());
                        hdThanhLy.TongCong(dongia, soluong);
                        string maTS = gvDSTS.GetRowCellValue(index, "MaTS").ToString();
                        var hoadon = db.HoaDonThanhLyTS(maTS);
                        hdThanhLy.DataSource = hoadon;
                        foreach(DevExpress.XtraReports.Parameters.Parameter param in hdThanhLy.Parameters)
                        {
                            param.Visible = false;
                        }
                        ReportPrintTool printTool = new ReportPrintTool(hdThanhLy);
                        printTool.ShowPreviewDialog();
                    }
                }
                else if(tinhTrang.Equals("Đã thanh lý"))
                {
                    DialogResult result = MessageBox.Show("Tài sản đã thanh lý. Bạn có muốn xóa tài sản?",
                        "Xóa",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question
                        );
                    if(result == DialogResult.OK)
                    {
                        THANHLYT taiSanTL = db.THANHLYTs.SingleOrDefault(record => record.MaTL == int.Parse(gvDSTS.GetRowCellValue(index, "MaTL").ToString()));
                        try
                        {
                            db.THANHLYTs.DeleteOnSubmit(taiSanTL);
                            db.SubmitChanges();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        frmQuanLyTLTS_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách không có tài sản nào",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
    }
}