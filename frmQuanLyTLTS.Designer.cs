namespace QuanLyTaiSan
{
    partial class frmQuanLyTLTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTLTS));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcDSTS = new DevExpress.XtraGrid.GridControl();
            this.gvDSTS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThanhLy = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtTinhTrang = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTS = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDSTS);
            this.layoutControl1.Controls.Add(this.txtTinhTrang);
            this.layoutControl1.Controls.Add(this.txtSoLuong);
            this.layoutControl1.Controls.Add(this.txtDonGia);
            this.layoutControl1.Controls.Add(this.txtMaTS);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(660, 267);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcDSTS
            // 
            this.gcDSTS.Location = new System.Drawing.Point(12, 64);
            this.gcDSTS.MainView = this.gvDSTS;
            this.gcDSTS.MenuManager = this.barManager1;
            this.gcDSTS.Name = "gcDSTS";
            this.gcDSTS.Size = new System.Drawing.Size(636, 171);
            this.gcDSTS.TabIndex = 8;
            this.gcDSTS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSTS});
            this.gcDSTS.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gcDSTS_FocusedViewChanged);
            // 
            // gvDSTS
            // 
            this.gvDSTS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTL,
            this.MaTS,
            this.DonGia,
            this.SoLuong,
            this.TinhTrang});
            this.gvDSTS.GridControl = this.gcDSTS;
            this.gvDSTS.Name = "gvDSTS";
            this.gvDSTS.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDSTS_FocusedRowChanged);
            // 
            // MaTL
            // 
            this.MaTL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTL.AppearanceCell.Options.UseFont = true;
            this.MaTL.AppearanceCell.Options.UseTextOptions = true;
            this.MaTL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MaTL.Caption = "Mã thanh lý";
            this.MaTL.FieldName = "MaTL";
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 0;
            // 
            // MaTS
            // 
            this.MaTS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTS.AppearanceCell.Options.UseFont = true;
            this.MaTS.Caption = "Mã tài sản";
            this.MaTS.FieldName = "MaTS";
            this.MaTS.Name = "MaTS";
            this.MaTS.OptionsColumn.AllowEdit = false;
            this.MaTS.Visible = true;
            this.MaTS.VisibleIndex = 1;
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
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
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
            this.SoLuong.OptionsColumn.AllowEdit = false;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrang.AppearanceCell.Options.UseFont = true;
            this.TinhTrang.Caption = "Tình trạng";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.OptionsColumn.AllowEdit = false;
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 4;
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
            this.btnXoa,
            this.btnThanhLy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThanhLy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Caption = "Thanh Lý";
            this.btnThanhLy.Id = 2;
            this.btnThanhLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhLy.ImageOptions.Image")));
            this.btnThanhLy.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhLy.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThanhLy_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa tài sản đã thanh lý";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(660, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 307);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(660, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 267);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(660, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 267);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(432, 38);
            this.txtTinhTrang.MenuManager = this.barManager1;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Properties.Appearance.Options.UseFont = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(216, 22);
            this.txtTinhTrang.StyleController = this.layoutControl1;
            this.txtTinhTrang.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(88, 38);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(215, 22);
            this.txtSoLuong.StyleController = this.layoutControl1;
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(432, 12);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Size = new System.Drawing.Size(216, 22);
            this.txtDonGia.StyleController = this.layoutControl1;
            this.txtDonGia.TabIndex = 5;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Location = new System.Drawing.Point(88, 12);
            this.txtMaTS.MenuManager = this.barManager1;
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTS.Properties.Appearance.Options.UseFont = true;
            this.txtMaTS.Size = new System.Drawing.Size(215, 22);
            this.txtMaTS.StyleController = this.layoutControl1;
            this.txtMaTS.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(660, 267);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtMaTS;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(295, 26);
            this.layoutControlItem1.Text = "Mã tài sản:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 227);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(640, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtDonGia;
            this.layoutControlItem2.Location = new System.Drawing.Point(344, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(296, 26);
            this.layoutControlItem2.Text = "Đơn giá:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtSoLuong;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(295, 26);
            this.layoutControlItem3.Text = "Số lượng:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtTinhTrang;
            this.layoutControlItem4.Location = new System.Drawing.Point(344, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(296, 26);
            this.layoutControlItem4.Text = "Tình trạng:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gcDSTS;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(640, 175);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(295, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(49, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(295, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(49, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmQuanLyTLTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 307);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuanLyTLTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thanh lý tài sản";
            this.Load += new System.EventHandler(this.frmQuanLyTLTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraGrid.GridControl gcDSTS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSTS;
        private DevExpress.XtraEditors.TextEdit txtTinhTrang;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtMaTS;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.Columns.GridColumn MaTS;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraBars.BarButtonItem btnThanhLy;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
    }
}