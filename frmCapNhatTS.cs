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
    public partial class frmCapNhatTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        
        public frmCapNhatTS()
        {
            InitializeComponent();
        }

        private bool KTThongTin()
        {
            if(txtMaTS.Text != "" && txtTenTS.Text != "" && txtDonGia.Text != "" && txtSoLuong.Text != ""
                && txtDVT.Text != "" && dtpNgayNhap.Text != "" && cboMaBoPhan.Text != "" && cboMaLoai.Text != ""
                && cboMaNguon.Text != "" && cboMaXuatXu.Text != "" && cboTinhTrang.Text != "")
            {
                return true;
            }
            return false;
        }

        private void frmCapNhatTS_Load(object sender, EventArgs e)
        {
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
            txtMaTS.Enabled = false;
            if(SQLHelper.MaTS != null)
            {
                txtMaTS.Text = SQLHelper.MaTS;
                TAISAN taisan = db.TAISANs.SingleOrDefault(record => record.MaTS == SQLHelper.MaTS);
                txtTenTS.Text = taisan.TenTS;
                txtDVT.Text = taisan.DVT;
                txtDonGia.Text = taisan.DonGia.ToString();
                txtSoLuong.Text = taisan.SoLuong.ToString();
                DateTime ngayNhap = taisan.NgayNhap;
                dtpNgayNhap.Text = ngayNhap.Day.ToString("d2") + "/" + ngayNhap.Month.ToString("d2") + "/" + ngayNhap.Year;
                cboMaLoai.Text = taisan.MaLoai;
                cboMaNguon.Text = taisan.MaNguon;
                cboMaXuatXu.Text = taisan.MaXuatXu;
                cboMaBoPhan.Text = taisan.MaBP;
                cboTinhTrang.Text = taisan.TinhTrang;
            }
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
            
            List<LOAITAISAN> loaiTaiSans = db.LOAITAISANs.ToList();
            foreach(LOAITAISAN loaiTS in loaiTaiSans)
            {
                cboMaLoai.Properties.Items.Add(loaiTS.MaLoai);
            }
            List<NGUONQUY> nguonQuys = db.NGUONQUYs.ToList();
            foreach(NGUONQUY nguonQuy in nguonQuys)
            {
                cboMaNguon.Properties.Items.Add(nguonQuy.MaNguon);
            }
            List<XUATXU> xuatXus = db.XUATXUs.ToList();
            foreach(XUATXU xuatXu in xuatXus)
            {
                cboMaXuatXu.Properties.Items.Add(xuatXu.MaXuatXu);
            }
            List<BOPHAN> boPhans = db.BOPHANs.ToList();
            foreach(BOPHAN boPhan in boPhans)
            {
                cboMaBoPhan.Properties.Items.Add(boPhan.MaBP);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                if (Functions.KTDinhDangSo(txtDonGia.Text))
                {
                    if (Functions.KTDinhDangSo(txtSoLuong.Text))
                    {
                        try
                        {
                            TAISAN taisan = db.TAISANs.SingleOrDefault(record => record.MaTS == SQLHelper.MaTS);
                            taisan.TenTS = txtTenTS.Text.Trim();
                            taisan.DVT = txtDVT.Text.Trim();
                            taisan.DonGia = int.Parse(txtDonGia.Text.Trim());
                            taisan.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                            taisan.NgayNhap = DateTime.Parse(dtpNgayNhap.Text);
                            taisan.MaNguon = cboMaNguon.Text;
                            taisan.MaLoai = cboMaLoai.Text;
                            taisan.MaBP = cboMaBoPhan.Text;
                            taisan.MaXuatXu = cboMaXuatXu.Text;
                            taisan.TinhTrang = cboTinhTrang.Text;
                            db.SubmitChanges();
                            MessageBox.Show("Cập nhật tài sản thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Cập nhật tài sản thất bại: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai số lượng",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                        txtSoLuong.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai đơn giá",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    txtDonGia.Focus();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
        }
    }
}