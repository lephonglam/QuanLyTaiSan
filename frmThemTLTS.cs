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
    public partial class frmThemTLTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        private TAISAN taisan;
        public frmThemTLTS()
        {
            InitializeComponent();
        }

        private void frmThanhLyTS_Load(object sender, EventArgs e)
        {
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
            if(SQLHelper.MaTS != null)
            {
                taisan = db.TAISANs.SingleOrDefault(record => record.MaTS == SQLHelper.MaTS);
                txtMaTS.Text = taisan.MaTS;
                txtTenTS.Text = taisan.TenTS;
                txtDVT.Text = taisan.DVT;
                txtDonGia.Text = taisan.DonGia.ToString();
                txtSoLuong.Text = taisan.SoLuong.ToString();
                txtNgayNhap.Text = taisan.NgayNhap.ToString();
                txtMaLoai.Text = taisan.MaLoai;
                txtMaNguon.Text = taisan.MaNguon;
                txtMaXuatXu.Text = taisan.MaXuatXu;
                txtMaBP.Text = taisan.MaBP;
                txtTinhTrang.Text = taisan.TinhTrang;
                txtMaTS.Enabled = false;
                txtTenTS.Enabled = false;
                txtDVT.Enabled = false;
                txtDonGia.Enabled = false;
                txtNgayNhap.Enabled = false;
                txtMaLoai.Enabled = false;
                txtMaNguon.Enabled = false;
                txtMaXuatXu.Enabled = false;
                txtMaBP.Enabled = false;
                txtTinhTrang.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Functions.KTDinhDangSo(txtSoLuong.Text.Trim()))
            {
                int soLuongTL = int.Parse(txtSoLuong.Text.Trim());
                int soLuongTS = taisan.SoLuong;
                if(soLuongTL <= soLuongTS)
                {
                    THANHLYT taiSanTL = new THANHLYT();
                    taiSanTL.MaTS = taisan.MaTS;
                    taiSanTL.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                    taiSanTL.TinhTrang = "Chờ thanh lý";
                    int tgNhap = taisan.NgayNhap.Year;
                    int tgHienTai = DateTime.Now.Year;
                    LOAITAISAN loaiTS = db.TAISANs.Join(db.LOAITAISANs, ts => ts.MaLoai, lts => lts.MaLoai,
                    (ts,lts) => lts).FirstOrDefault();
                    int khauhao = int.Parse(loaiTS.KhauHao.ToString());
                    taiSanTL.DonGia = (taisan.DonGia - (taisan.DonGia*khauhao/100))*(tgHienTai - tgNhap);
                    try
                    {
                        db.THANHLYTs.InsertOnSubmit(taiSanTL);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm tài sản vào danh sách thanh lý thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm tài sản vào danh sách thanh lý thất bại: " +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                    }
                    if(soLuongTL == soLuongTS)
                    {
                        try
                        {
                            db.TAISANs.DeleteOnSubmit(taisan);
                            db.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa tài sản có mã " + taisan.MaTS + " thất bại: " +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                        }
                    }
                    else
                    {
                        try
                        {
                            taisan.SoLuong = soLuongTS - soLuongTL;
                            db.SubmitChanges();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Cập nhật số lượng tài sản có mã " + taisan.MaTS + " thất bại: " +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Số lượng tài sản thanh lý vượt quá tài sản hiện có",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            else
            {
                MessageBox.Show("Nhập số lượng không đúng",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                txtSoLuong.Focus();
            }
        }
    }
}