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
using Excel = Microsoft.Office.Interop.Excel;
namespace QuanLyTaiSan
{
    public partial class frmXuatTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        public frmXuatTS()
        {
            InitializeComponent();
        }

        private void frmXuatTS_Load(object sender, EventArgs e)
        {
            txtMaTS.Enabled = false;
            txtTenTS.Enabled = false;
            txtDVT.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            txtNgayNhap.Enabled = false;
            txtMaLoai.Enabled = false;
            txtMaNguon.Enabled = false;
            txtMaXuatXu.Enabled = false;
            txtMaBP.Enabled = false;
            txtTinhTrang.Enabled = false;
            db = new LinqToQLTSDataContext();
            List<TAISAN> dsTaiSan = db.TAISANs.ToList();
            gcDanhSachTaiSan.DataSource = dsTaiSan;
        }

        private void gvDanhSachTaiSan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = gvDanhSachTaiSan.FocusedRowHandle;
            txtMaTS.Text = gvDanhSachTaiSan.GetRowCellValue(index, "MaTS").ToString();
            txtTenTS.Text = gvDanhSachTaiSan.GetRowCellValue(index, "TenTS").ToString();
            txtDVT.Text = gvDanhSachTaiSan.GetRowCellValue(index, "DVT").ToString();
            txtSoLuong.Text = gvDanhSachTaiSan.GetRowCellValue(index, "SoLuong").ToString();
            txtDonGia.Text = gvDanhSachTaiSan.GetRowCellValue(index, "DonGia").ToString();
            txtNgayNhap.Text = gvDanhSachTaiSan.GetRowCellValue(index, "NgayNhap").ToString();
            txtMaLoai.Text = gvDanhSachTaiSan.GetRowCellValue(index, "MaLoai").ToString();
            txtMaNguon.Text = gvDanhSachTaiSan.GetRowCellValue(index, "MaNguon").ToString();
            txtMaXuatXu.Text = gvDanhSachTaiSan.GetRowCellValue(index, "MaXuatXu").ToString();
            txtMaBP.Text = gvDanhSachTaiSan.GetRowCellValue(index, "MaBP").ToString();
            txtTinhTrang.Text = gvDanhSachTaiSan.GetRowCellValue(index, "TinhTrang").ToString();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook;
            Excel.Worksheet exSheet;
            Excel.Range exRange;

            exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["A1:Z300"].Font.Name = "Times New Roman";
            exRange.Range["A1:C3"].Font.Size = 10;
            exRange.Range["A1:C3"].Font.Bold = true;
            exRange.Range["A1:C3"].Font.Color = Color.Blue;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;

            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Trường THCS Phước Hòa";

            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Phước Hòa - Tuy Phước - Bình Định";

            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = "Điện thoại:";

            exRange.Range["D2:F2"].Font.Size = 18;
            exRange.Range["D2:F2"].Font.Bold = true;
            exRange.Range["D2:F2"].Font.Color = Color.Red;
            exRange.Range["D2:F2"].MergeCells = true;
            exRange.Range["D2:F2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["D2:F2"].Value = "THẺ TÀI SẢN";

            exRange.Range["D6:E19"].Font.Size = 14;

            exRange.Range["B6:B6"].Value = "Mã tài sản:";
            exRange.Range["C6:E6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = txtMaTS.Text.Trim();

            exRange.Range["B7:B7"].Value = "Tên tài sản:";
            exRange.Range["C7:E7"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:E7"].Font.Bold = true;
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = txtTenTS.Text.Trim();

            exRange.Range["B8:B8"].Value = "Đơn vị tính:";
            exRange.Range["C8:E8"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = txtDVT.Text.Trim();

            exRange.Range["B9:B9"].Value = "Số lượng:";
            exRange.Range["C9:E9"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = txtSoLuong.Text.Trim();

            exRange.Range["B10:B10"].Value = "Đơn giá:";
            exRange.Range["C10:E10"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C10:E10"].MergeCells = true;
            exRange.Range["C10:E10"].Value = txtDonGia.Text.Trim();

            exRange.Range["B11:B11"].Value = "Ngày nhập:";
            exRange.Range["C11:E11"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:E11"].MergeCells = true;
            exRange.Range["C11:E11"].Value = txtNgayNhap.Text.Trim();

            exRange.Range["B12:B12"].Value = "Mã loại:";
            exRange.Range["C12:E12"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C12:E12"].MergeCells = true;
            exRange.Range["C12:E12"].Value = txtMaLoai.Text.Trim();

            exRange.Range["B13:B13"].Value = "Mã xuất xứ:";
            exRange.Range["C13:E13"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C13:E13"].MergeCells = true;
            exRange.Range["C13:E13"].Value = txtMaXuatXu.Text.Trim();

            exRange.Range["B14:B14"].Value = "Mã nguồn:";
            exRange.Range["C14:E14"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C14:E14"].MergeCells = true;
            exRange.Range["C14:E14"].Value = txtMaNguon.Text.Trim();

            exRange.Range["B15:B15"].Value = "Mã bộ phận:";
            exRange.Range["C15:E15"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C15:E15"].MergeCells = true;
            exRange.Range["C15:E15"].Value = txtMaBP.Text.Trim();

            exRange.Range["B16:B16"].Value = "Tình trạng:";
            exRange.Range["C16:E16"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C16:E16"].MergeCells = true;
            exRange.Range["C16:E16"].Value = txtTinhTrang.Text.Trim();

            exRange.Range["B21:G27"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["B21:B21"].Value = "Hiệu trưởng";
            exRange.Range["B22:B22"].Value = "(Ký tên, đóng dấu)";
            exRange.Range["G21:G21"].Value = "Kế toán";
            exRange.Range["G22:G22"].Value = "(Ký tên)";

            exSheet.Name = "Hoa don";
            exApp.Visible = true;
        }
    }
}