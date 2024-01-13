namespace QuanLyTaiSan
{
    partial class frmBaoCaoTS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.pccReport = new DevExpress.XtraReports.UI.PrintableComponentContainer();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblThoiGian = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pccReport});
            this.Detail.Name = "Detail";
            // 
            // pccReport
            // 
            this.pccReport.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pccReport.Name = "pccReport";
            this.pccReport.SizeF = new System.Drawing.SizeF(650F, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.lblThoiGian,
            this.xrLabel1});
            this.PageHeader.HeightF = 100F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 22F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(36.45833F, 64.50005F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(576.0417F, 35.49997F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "BÁO CÁO TÌNH HÌNH TÀI SẢN ĐƠN VỊ";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.LocationFloat = new DevExpress.Utils.PointFloat(351.0417F, 10.00001F);
            this.lblThoiGian.Multiline = true;
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblThoiGian.SizeF = new System.Drawing.SizeF(275F, 23F);
            this.lblThoiGian.Text = "lblThoiGian";
            this.lblThoiGian.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.lblThoiGian_BeforePrint);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 10.00001F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(201.0417F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Trường THCS Phước Hòa";
            // 
            // frmBaoCaoTS
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel lblThoiGian;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.PrintableComponentContainer pccReport;
    }
}
