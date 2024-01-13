namespace QuanLyTaiSan
{
    partial class frmTimKiemTS
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboTimKiem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcDanhSachTS = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachTS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNguon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaXuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboTimKiem);
            this.layoutControl1.Controls.Add(this.gcDanhSachTS);
            this.layoutControl1.Controls.Add(this.txtTuKhoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(771, 374);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.EditValue = "Tất cả";
            this.cboTimKiem.Location = new System.Drawing.Point(111, 12);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimKiem.Properties.Appearance.Options.UseFont = true;
            this.cboTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTimKiem.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Mã tài sản",
            "Tên tài sản",
            "Đơn giá",
            "Mã loại",
            "Mã xuất xứ",
            "Mã nguồn",
            "Mã bộ phận",
            "Tình trạng"});
            this.cboTimKiem.Size = new System.Drawing.Size(226, 22);
            this.cboTimKiem.StyleController = this.layoutControl1;
            this.cboTimKiem.TabIndex = 7;
            // 
            // gcDanhSachTS
            // 
            this.gcDanhSachTS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcDanhSachTS.Location = new System.Drawing.Point(12, 38);
            this.gcDanhSachTS.MainView = this.gvDanhSachTS;
            this.gcDanhSachTS.Name = "gcDanhSachTS";
            this.gcDanhSachTS.Size = new System.Drawing.Size(747, 314);
            this.gcDanhSachTS.TabIndex = 6;
            this.gcDanhSachTS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachTS});
            // 
            // gvDanhSachTS
            // 
            this.gvDanhSachTS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTS,
            this.TenTS,
            this.DVT,
            this.SoLuong,
            this.DonGia,
            this.NgayNhap,
            this.MaLoai,
            this.MaNguon,
            this.MaXuatXu,
            this.MaBP,
            this.TinhTrang});
            this.gvDanhSachTS.GridControl = this.gcDanhSachTS;
            this.gvDanhSachTS.Name = "gvDanhSachTS";
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
            this.MaTS.VisibleIndex = 0;
            // 
            // TenTS
            // 
            this.TenTS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTS.AppearanceCell.Options.UseFont = true;
            this.TenTS.Caption = "Tên tài sản";
            this.TenTS.FieldName = "TenTS";
            this.TenTS.Name = "TenTS";
            this.TenTS.OptionsColumn.AllowEdit = false;
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
            this.DVT.OptionsColumn.AllowEdit = false;
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 2;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.AppearanceCell.Options.UseFont = true;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowEdit = false;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.AppearanceCell.Options.UseFont = true;
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayNhap.AppearanceCell.Options.UseFont = true;
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.OptionsColumn.AllowEdit = false;
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
            this.MaLoai.OptionsColumn.AllowEdit = false;
            this.MaLoai.Visible = true;
            this.MaLoai.VisibleIndex = 6;
            // 
            // MaNguon
            // 
            this.MaNguon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNguon.AppearanceCell.Options.UseFont = true;
            this.MaNguon.Caption = "Mã nguồn";
            this.MaNguon.FieldName = "MaNguon";
            this.MaNguon.Name = "MaNguon";
            this.MaNguon.OptionsColumn.AllowEdit = false;
            this.MaNguon.Visible = true;
            this.MaNguon.VisibleIndex = 7;
            // 
            // MaXuatXu
            // 
            this.MaXuatXu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaXuatXu.AppearanceCell.Options.UseFont = true;
            this.MaXuatXu.Caption = "Mã xuất xứ";
            this.MaXuatXu.FieldName = "MaXuatXu";
            this.MaXuatXu.Name = "MaXuatXu";
            this.MaXuatXu.OptionsColumn.AllowEdit = false;
            this.MaXuatXu.Visible = true;
            this.MaXuatXu.VisibleIndex = 8;
            // 
            // MaBP
            // 
            this.MaBP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaBP.AppearanceCell.Options.UseFont = true;
            this.MaBP.Caption = "Mã bộ phận";
            this.MaBP.FieldName = "MaBP";
            this.MaBP.Name = "MaBP";
            this.MaBP.OptionsColumn.AllowEdit = false;
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
            this.TinhTrang.OptionsColumn.AllowEdit = false;
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 10;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(516, 12);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtTuKhoa.Size = new System.Drawing.Size(243, 22);
            this.txtTuKhoa.StyleController = this.layoutControl1;
            this.txtTuKhoa.TabIndex = 5;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(771, 374);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 344);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(751, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtTuKhoa;
            this.layoutControlItem2.Location = new System.Drawing.Point(405, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(346, 26);
            this.layoutControlItem2.Text = "Nhập từ khóa:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcDanhSachTS;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(751, 318);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(329, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(76, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.cboTimKiem;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(329, 26);
            this.layoutControlItem1.Text = "Tìm kiếm theo:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 16);
            // 
            // frmTimKiemTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 374);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmTimKiemTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm tài sản";
            this.Load += new System.EventHandler(this.frmTimKiemTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcDanhSachTS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachTS;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.ComboBoxEdit cboTimKiem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTS;
        private DevExpress.XtraGrid.Columns.GridColumn TenTS;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn MaNguon;
        private DevExpress.XtraGrid.Columns.GridColumn MaXuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn MaBP;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
    }
}