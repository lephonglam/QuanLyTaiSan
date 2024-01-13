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
    public partial class frmTimKiemTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
        public frmTimKiemTS()
        {
            InitializeComponent();
        }

        private void frmTimKiemTS_Load(object sender, EventArgs e)
        {
            List<TAISAN> dsTaiSan = db.TAISANs.ToList();
            gcDanhSachTS.DataSource = dsTaiSan;
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            List<TAISAN> tkTaiSan;
            string timkiem = cboTimKiem.Text.Trim();
            string tukhoa = txtTuKhoa.Text.Trim();
            switch(timkiem)
            {
                case "Mã tài sản":
                    tkTaiSan = db.TAISANs.Where(record => record.MaTS == tukhoa).ToList();
                    break;
                case "Tên tài sản":
                    tkTaiSan = db.TAISANs.Where(record => record.TenTS.Contains(tukhoa)).ToList();
                    break;
                case "Đơn giá":
                    tkTaiSan = db.TAISANs.Where(record => record.DonGia == int.Parse(tukhoa)).ToList();
                    break;
                case "Mã loại":
                    tkTaiSan = db.TAISANs.Where(record => record.MaLoai == tukhoa).ToList();
                    break;
                case "Mã xuất xứ":
                    tkTaiSan = db.TAISANs.Where(record => record.MaXuatXu == tukhoa).ToList();
                    break;
                case "Mã nguồn":
                    tkTaiSan = db.TAISANs.Where(record => record.MaNguon == tukhoa).ToList();
                    break;
                case "Mã bộ phận":
                    tkTaiSan = db.TAISANs.Where(record => record.MaBP == tukhoa).ToList();
                    break;
                case "Tình trạng":
                    tkTaiSan = db.TAISANs.Where(record => record.TinhTrang == tukhoa).ToList();
                    break;
                default:
                    tkTaiSan = db.TAISANs.ToList();
                    break;
            }
            gcDanhSachTS.DataSource = tkTaiSan;
        }
    }
}