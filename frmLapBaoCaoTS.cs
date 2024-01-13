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
    public partial class frmLapBaoCaoTS : DevExpress.XtraEditors.XtraForm
    {
        private LinqToQLTSDataContext db;
        public frmLapBaoCaoTS()
        {
            InitializeComponent();
        }

        private void frmLapBaoCaoTS_Load(object sender, EventArgs e)
        {
            db = new LinqToQLTSDataContext(SQLHelper.ConnectString);
            var dsTaiSan = db.TAISANs.Join(db.LOAITAISANs, ts => ts.MaLoai, lts => lts.MaLoai,
                (ts, lts) => new
                {
                    MaTS = ts.MaTS,
                    TenTS = ts.TenTS,
                    DVT = ts.DVT,
                    DonGia = ts.DonGia,
                    SoLuong = ts.SoLuong,
                    NgayNhap = ts.NgayNhap,
                    MaNguon = ts.MaNguon,
                    MaXuatXu = ts.MaXuatXu,
                    MaBP =ts.MaBP,
                    KhauHao = lts.KhauHao,
                    TinhTrang = ts.TinhTrang
                }).ToList();
            gcData.DataSource = dsTaiSan;
        }

        private void btnLapBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvData.BestFitColumns();
            frmBaoCaoTS report = new frmBaoCaoTS();
            report.GridControl = gcData;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                "Thoát",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if ( result == DialogResult.OK )
            {
                this.Close();
            }
        }
    }
}