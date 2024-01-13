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
    public partial class frmThongKeTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        public frmThongKeTS()
        {
            InitializeComponent();
        }

        private void frmThongKeTS_Load(object sender, EventArgs e)
        {
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
            List<TAISAN> dsTaiSan = db.TAISANs.ToList();
            gcDanhSachTS.DataSource = dsTaiSan;
            
            List<LOAITAISAN> dsLoaiTS = db.LOAITAISANs.ToList();
            lkLoaiTS.Properties.DataSource = dsLoaiTS;
            lkLoaiTS.Properties.DisplayMember = "TenLoai";
            lkLoaiTS.Properties.ValueMember = "MaLoai";

            List<NGUONQUY> dsNguonQuy = db.NGUONQUYs.ToList();
            lkNguonQuy.Properties.DataSource = dsNguonQuy;
            lkNguonQuy.Properties.DisplayMember = "TenNguon";
            lkNguonQuy.Properties.ValueMember = "MaNguon";

            List<BOPHAN> dsBoPhan = db.BOPHANs.ToList();
            lkBoPhan.Properties.DataSource = dsBoPhan;
            lkBoPhan.Properties.DisplayMember = "TenBP";
            lkBoPhan.Properties.ValueMember = "MaBP";

            lkLoaiTS.Enabled = false;
            lkNguonQuy.Enabled = false;
            lkBoPhan.Enabled = false;
        }

        private void cboNoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboNoiDung.Text == "Loại tài sản")
            {
                lkLoaiTS.Enabled = true;
                lkNguonQuy.Enabled = false;
                lkBoPhan.Enabled = false;
            }
            else if(cboNoiDung.Text == "Nguồn quỹ")
            {
                lkNguonQuy.Enabled = true;
                lkLoaiTS.Enabled = false;
                lkBoPhan.Enabled = false;
            }
            else if(cboNoiDung.Text == "Bộ phận sử dụng")
            {
                lkBoPhan.Enabled = true;
                lkLoaiTS.Enabled = false;
                lkNguonQuy.Enabled = false;
            }
        }

        private void lkLoaiTS_EditValueChanged(object sender, EventArgs e)
        {
            gcDanhSachTS.DataSource = db.TAISANs.Where(record => record.MaLoai == lkLoaiTS.EditValue.ToString()).ToList();
        }

        private void lkNguonQuy_EditValueChanged(object sender, EventArgs e)
        {
            gcDanhSachTS.DataSource = db.TAISANs.Where(record => record.MaNguon == lkNguonQuy.EditValue.ToString()).ToList();
        }

        private void lkBoPhan_EditValueChanged(object sender, EventArgs e)
        {
            gcDanhSachTS.DataSource = db.TAISANs.Where(record => record.MaBP == lkBoPhan.EditValue.ToString()).ToList();
        }
    }
}