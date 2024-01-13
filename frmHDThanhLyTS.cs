using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyTaiSan
{
    public partial class frmHDThanhLyTS : DevExpress.XtraReports.UI.XtraReport
    {
        public frmHDThanhLyTS()
        {
            InitializeComponent();
            lplThoiGian.Text = string.Format("Phước Hòa, ngày {0} tháng {1} năm {2}", DateTime.Now.Day.ToString("d2"),
                DateTime.Now.Month.ToString("d2"), DateTime.Now.Year.ToString());
        }

        public void TongCong(int dongia, int soluong)
        {
            pTongCong.Value = Convert.ToString(dongia * soluong) + " đồng";
        }
    }
}
