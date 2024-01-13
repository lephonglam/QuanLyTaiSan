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
    public partial class frmThemTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        public frmThemTS()
        {
            InitializeComponent();
        }

        private bool KTThongTin()
        {
            if (txtMaTS.Text != "" && txtTenTS.Text != "" && txtDonGia.Text != "" && txtSoLuong.Text != ""
                && txtDVT.Text != "" && dtpNgayNhap.Text != "" && cboMaBoPhan.Text != "" && cboMaLoai.Text != ""
                && cboMaNguon.Text != "" && cboMaXuatXu.Text != "" && cboTinhTrang.Text != "")
            {
                return true;
            }
            return false;
        }

        private void frmThemTS_Load(object sender, EventArgs e)
        {
            txtMaTS.Focus();
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
                TAISAN ktTaiSan = db.TAISANs.SingleOrDefault(record => record.MaTS == txtMaTS.Text.Trim());
                if(ktTaiSan == null)
                {
                    if (Functions.KTDinhDangSo(txtDonGia.Text.Trim()))
                    {
                        if (Functions.KTDinhDangSo(txtSoLuong.Text.Trim()))
                        {
                            try
                            {
                                TAISAN taisan = new TAISAN();
                                taisan.MaTS = txtMaTS.Text.Trim();
                                taisan.TenTS = txtTenTS.Text.Trim();
                                taisan.DonGia = int.Parse(txtDonGia.Text.Trim());
                                taisan.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                                taisan.DVT = txtDVT.Text.Trim();
                                taisan.NgayNhap = DateTime.Parse(dtpNgayNhap.Text);
                                taisan.MaNguon = cboMaNguon.Text;
                                taisan.MaLoai = cboMaLoai.Text;
                                taisan.MaXuatXu = cboMaXuatXu.Text;
                                taisan.MaBP = cboMaBoPhan.Text;
                                taisan.TinhTrang = cboTinhTrang.Text;
                                db.TAISANs.InsertOnSubmit(taisan);
                                db.SubmitChanges();
                                MessageBox.Show("Thêm tài sản thành công!",
                                    "Thêm tài sản",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                                this.Close();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Thêm tài sản thất bại: " +
                                    ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
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
                    MessageBox.Show("Tài sản đã có trong danh sách",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    txtMaTS.Text = "";
                    txtMaTS.Focus();
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