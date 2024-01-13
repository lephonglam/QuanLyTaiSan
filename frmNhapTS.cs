using DevExpress.DataAccess.Excel;
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
using OfficeOpenXml;
using System.IO;

namespace QuanLyTaiSan
{
    public partial class frmNhapTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        public frmNhapTS()
        {
            InitializeComponent();
        }

        private void frmNhapTS_Load(object sender, EventArgs e)
        {
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
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

        private void btnChon_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn file";
            openFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void btnNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtDuongDan.Text != "")
            {
                string dongBatDau = txtBatDau.Text.Trim();
                if (Functions.KTDinhDangSo(dongBatDau))
                {
                    try
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(txtDuongDan.Text.Trim())))
                        {
                            ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("MaTS");
                            dataTable.Columns.Add("TenTS");
                            dataTable.Columns.Add("DVT");
                            dataTable.Columns.Add("SoLuong");
                            dataTable.Columns.Add("DonGia");
                            dataTable.Columns.Add("NgayNhap");
                            dataTable.Columns.Add("MaLoai");
                            dataTable.Columns.Add("MaNguon");
                            dataTable.Columns.Add("MaXuatXu");
                            dataTable.Columns.Add("MaBP");
                            dataTable.Columns.Add("TinhTrang");

                            for(int i = int.Parse(dongBatDau); i <= excelWorksheet.Dimension.End.Row; i++)
                            {
                                List<string> listRows = new List<string>();
                                for(int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                                {
                                    listRows.Add(excelWorksheet.Cells[i,j].Value.ToString());
                                }
                                dataTable.Rows.Add(listRows.ToArray());
                            }
                            gcDanhSachTaiSan.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nhập dữ liệu từ file Excel thất bại: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai dòng bắt đầu lấy dữ liệu",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    txtBatDau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn file",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gvDanhSachTaiSan.SelectedRowsCount > 0)
            {
                
                int index = gvDanhSachTaiSan.FocusedRowHandle;
                string maTS = gvDanhSachTaiSan.GetRowCellValue(index, "MaTS").ToString();
                DialogResult result = MessageBox.Show("Bạn có muốn thêm tài sản có mã " + maTS + " vào danh sách?",
                    "Thêm tài sản",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if(result == DialogResult.OK)
                {
                    TAISAN ktTaiSan = db.TAISANs.SingleOrDefault(record => record.MaTS == maTS);
                    if(ktTaiSan == null)
                    {
                        if(Functions.KTDinhDangSo(txtSoLuong.Text.Trim()))
                        {
                            if (Functions.KTDinhDangSo(txtDonGia.Text.Trim()))
                            {
                                try
                                {
                                    TAISAN taisan = new TAISAN();
                                    taisan.MaTS = maTS;
                                    taisan.TenTS = txtTenTS.Text.Trim();
                                    taisan.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                                    taisan.DonGia = int.Parse(txtDonGia.Text.Trim());
                                    taisan.DVT = txtDVT.Text.Trim();
                                    taisan.NgayNhap = DateTime.Parse(txtNgayNhap.Text.Trim());
                                    taisan.MaLoai = txtMaLoai.Text.Trim();
                                    taisan.MaNguon = txtMaNguon.Text.Trim();
                                    taisan.MaXuatXu = txtMaXuatXu.Text.Trim();
                                    taisan.MaBP = txtMaBP.Text.Trim();
                                    taisan.TinhTrang = txtTinhTrang.Text.Trim();
                                    db.TAISANs.InsertOnSubmit(taisan);
                                    db.SubmitChanges();
                                    MessageBox.Show("Thêm tài sản thành công!",
                                    "Thêm tài sản",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Thêm tài sản thất bại: " + ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sai đơn giá. Thêm tài sản thất bại",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai số lượng. Thêm tài sản thất bại",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài sản đã có trong danh sách",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }

                }
            }
            else
            {
                MessageBox.Show("Danh sách tài sản trống",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
    }
}