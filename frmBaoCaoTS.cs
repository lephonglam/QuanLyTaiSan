using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyTaiSan
{
    public partial class frmBaoCaoTS : DevExpress.XtraReports.UI.XtraReport
    {
        private GridControl gridControl;
        public GridControl GridControl
        {
            set 
            { 
                gridControl = value;
                pccReport.PrintableComponent = gridControl;
            }
            get
            {
                return gridControl;
            }
        }
        public frmBaoCaoTS()
        {
            InitializeComponent();
        }

        private void lblThoiGian_BeforePrint(object sender, CancelEventArgs e)
        {
            lblThoiGian.Text = string.Format("Phước Hòa, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }
    }
}
