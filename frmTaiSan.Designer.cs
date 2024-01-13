namespace QuanLyTaiSan
{
    partial class frmTaiSan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiSan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThanhLy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcDanhSachTaiSan = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachTaiSan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaXuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNguon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTaiSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTaiSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnTaiDuLieu,
            this.btnThanhLy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiDuLieu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThanhLy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnThem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Cập nhật";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnSua.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnXoa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnTaiDuLieu
            // 
            this.btnTaiDuLieu.Caption = "Tải Lại dữ liệu";
            this.btnTaiDuLieu.Id = 3;
            this.btnTaiDuLieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiDuLieu.ImageOptions.Image")));
            this.btnTaiDuLieu.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiDuLieu.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnTaiDuLieu.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiDuLieu.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTaiDuLieu.Name = "btnTaiDuLieu";
            this.btnTaiDuLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiDuLieu_ItemClick);
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Caption = "Thanh lý";
            this.btnThanhLy.Id = 4;
            this.btnThanhLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhLy.ImageOptions.Image")));
            this.btnThanhLy.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhLy.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThanhLy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(961, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 346);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(961, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 306);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(961, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 306);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDanhSachTaiSan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(961, 306);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcDanhSachTaiSan
            // 
            this.gcDanhSachTaiSan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcDanhSachTaiSan.Location = new System.Drawing.Point(12, 12);
            this.gcDanhSachTaiSan.MainView = this.gvDanhSachTaiSan;
            this.gcDanhSachTaiSan.MenuManager = this.barManager1;
            this.gcDanhSachTaiSan.Name = "gcDanhSachTaiSan";
            this.gcDanhSachTaiSan.Size = new System.Drawing.Size(937, 282);
            this.gcDanhSachTaiSan.TabIndex = 4;
            this.gcDanhSachTaiSan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachTaiSan});
            // 
            // gvDanhSachTaiSan
            // 
            this.gvDanhSachTaiSan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTS,
            this.TenTS,
            this.DVT,
            this.SoLuong,
            this.DonGia,
            this.NgayNhap,
            this.MaLoai,
            this.MaXuatXu,
            this.MaNguon,
            this.MaBP,
            this.TinhTrang});
            this.gvDanhSachTaiSan.GridControl = this.gcDanhSachTaiSan;
            this.gvDanhSachTaiSan.Name = "gvDanhSachTaiSan";
            this.gvDanhSachTaiSan.OptionsBehavior.Editable = false;
            // 
            // MaTS
            // 
            this.MaTS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTS.AppearanceCell.Options.UseFont = true;
            this.MaTS.Caption = "Mã tài sản";
            this.MaTS.FieldName = "MaTS";
            this.MaTS.Name = "MaTS";
            this.MaTS.Visible = true;
            this.MaTS.VisibleIndex = 0;
            // 
            // TenTS
            // 
            this.TenTS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTS.AppearanceCell.Options.UseFont = true;
            this.TenTS.Caption = "Tên tài sản";
            this.TenTS.FieldName = "TenTS";
            this.TenTS.Name = "TenTS";
            this.TenTS.Visible = true;
            this.TenTS.VisibleIndex = 1;
            // 
            // DVT
            // 
            this.DVT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.AppearanceCell.Options.UseFont = true;
            this.DVT.Caption = "Đơn vị tính";
            this.DVT.FieldName = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 2;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.AppearanceCell.Options.UseFont = true;
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.AppearanceCell.Options.UseFont = true;
            this.DonGia.AppearanceCell.Options.UseTextOptions = true;
            this.DonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayNhap.AppearanceCell.Options.UseFont = true;
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 5;
            // 
            // MaLoai
            // 
            this.MaLoai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoai.AppearanceCell.Options.UseFont = true;
            this.MaLoai.Caption = "Mã loại";
            this.MaLoai.FieldName = "MaLoai";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Visible = true;
            this.MaLoai.VisibleIndex = 6;
            // 
            // MaXuatXu
            // 
            this.MaXuatXu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaXuatXu.AppearanceCell.Options.UseFont = true;
            this.MaXuatXu.Caption = "Mã xuất xứ";
            this.MaXuatXu.FieldName = "MaXuatXu";
            this.MaXuatXu.Name = "MaXuatXu";
            this.MaXuatXu.Visible = true;
            this.MaXuatXu.VisibleIndex = 7;
            // 
            // MaNguon
            // 
            this.MaNguon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNguon.AppearanceCell.Options.UseFont = true;
            this.MaNguon.Caption = "Mã nguồn";
            this.MaNguon.FieldName = "MaNguon";
            this.MaNguon.Name = "MaNguon";
            this.MaNguon.Visible = true;
            this.MaNguon.VisibleIndex = 8;
            // 
            // MaBP
            // 
            this.MaBP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaBP.AppearanceCell.Options.UseFont = true;
            this.MaBP.Caption = "Mã bộ phận";
            this.MaBP.FieldName = "MaBP";
            this.MaBP.Name = "MaBP";
            this.MaBP.Visible = true;
            this.MaBP.VisibleIndex = 9;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrang.AppearanceCell.Options.UseFont = true;
            this.TinhTrang.Caption = "Tình trạng";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(961, 306);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDanhSachTaiSan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(941, 286);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmTaiSan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 346);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTaiSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Sản";
            this.Activated += new System.EventHandler(this.frmTaiSan_Activated);
            this.Load += new System.EventHandler(this.frmTaiSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTaiSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTaiSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnTaiDuLieu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSachTaiSan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachTaiSan;
        private DevExpress.XtraGrid.Columns.GridColumn MaTS;
        private DevExpress.XtraGrid.Columns.GridColumn TenTS;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn MaXuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn MaNguon;
        private DevExpress.XtraGrid.Columns.GridColumn MaBP;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnThanhLy;
    }
}