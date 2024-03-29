﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTaiSan
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyTaiSan")]
	public partial class LinqToQLTSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBOPHAN(BOPHAN instance);
    partial void UpdateBOPHAN(BOPHAN instance);
    partial void DeleteBOPHAN(BOPHAN instance);
    partial void InsertXUATXU(XUATXU instance);
    partial void UpdateXUATXU(XUATXU instance);
    partial void DeleteXUATXU(XUATXU instance);
    partial void InsertLOAITAISAN(LOAITAISAN instance);
    partial void UpdateLOAITAISAN(LOAITAISAN instance);
    partial void DeleteLOAITAISAN(LOAITAISAN instance);
    partial void InsertNGUOIDUNG(NGUOIDUNG instance);
    partial void UpdateNGUOIDUNG(NGUOIDUNG instance);
    partial void DeleteNGUOIDUNG(NGUOIDUNG instance);
    partial void InsertNGUONQUY(NGUONQUY instance);
    partial void UpdateNGUONQUY(NGUONQUY instance);
    partial void DeleteNGUONQUY(NGUONQUY instance);
    partial void InsertTAISAN(TAISAN instance);
    partial void UpdateTAISAN(TAISAN instance);
    partial void DeleteTAISAN(TAISAN instance);
    partial void InsertTHANHLYT(THANHLYT instance);
    partial void UpdateTHANHLYT(THANHLYT instance);
    partial void DeleteTHANHLYT(THANHLYT instance);
    #endregion
		
		public LinqToQLTSDataContext() : 
				base(global::QuanLyTaiSan.Properties.Settings.Default.QuanLyTaiSanConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToQLTSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToQLTSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToQLTSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToQLTSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BOPHAN> BOPHANs
		{
			get
			{
				return this.GetTable<BOPHAN>();
			}
		}
		
		public System.Data.Linq.Table<XUATXU> XUATXUs
		{
			get
			{
				return this.GetTable<XUATXU>();
			}
		}
		
		public System.Data.Linq.Table<LOAITAISAN> LOAITAISANs
		{
			get
			{
				return this.GetTable<LOAITAISAN>();
			}
		}
		
		public System.Data.Linq.Table<NGUOIDUNG> NGUOIDUNGs
		{
			get
			{
				return this.GetTable<NGUOIDUNG>();
			}
		}
		
		public System.Data.Linq.Table<NGUONQUY> NGUONQUYs
		{
			get
			{
				return this.GetTable<NGUONQUY>();
			}
		}
		
		public System.Data.Linq.Table<TAISAN> TAISANs
		{
			get
			{
				return this.GetTable<TAISAN>();
			}
		}
		
		public System.Data.Linq.Table<THANHLYT> THANHLYTs
		{
			get
			{
				return this.GetTable<THANHLYT>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HoaDonThanhLyTS")]
		public ISingleResult<HoaDonThanhLyTSResult> HoaDonThanhLyTS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaTS", DbType="NVarChar(10)")] string maTS)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maTS);
			return ((ISingleResult<HoaDonThanhLyTSResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BOPHAN")]
	public partial class BOPHAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaBP;
		
		private string _TenBP;
		
		private string _ChucNang;
		
		private EntitySet<TAISAN> _TAISANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBPChanging(string value);
    partial void OnMaBPChanged();
    partial void OnTenBPChanging(string value);
    partial void OnTenBPChanged();
    partial void OnChucNangChanging(string value);
    partial void OnChucNangChanged();
    #endregion
		
		public BOPHAN()
		{
			this._TAISANs = new EntitySet<TAISAN>(new Action<TAISAN>(this.attach_TAISANs), new Action<TAISAN>(this.detach_TAISANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBP", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaBP
		{
			get
			{
				return this._MaBP;
			}
			set
			{
				if ((this._MaBP != value))
				{
					this.OnMaBPChanging(value);
					this.SendPropertyChanging();
					this._MaBP = value;
					this.SendPropertyChanged("MaBP");
					this.OnMaBPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenBP
		{
			get
			{
				return this._TenBP;
			}
			set
			{
				if ((this._TenBP != value))
				{
					this.OnTenBPChanging(value);
					this.SendPropertyChanging();
					this._TenBP = value;
					this.SendPropertyChanged("TenBP");
					this.OnTenBPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucNang", DbType="NVarChar(100)")]
		public string ChucNang
		{
			get
			{
				return this._ChucNang;
			}
			set
			{
				if ((this._ChucNang != value))
				{
					this.OnChucNangChanging(value);
					this.SendPropertyChanging();
					this._ChucNang = value;
					this.SendPropertyChanged("ChucNang");
					this.OnChucNangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOPHAN_TAISAN", Storage="_TAISANs", ThisKey="MaBP", OtherKey="MaBP")]
		public EntitySet<TAISAN> TAISANs
		{
			get
			{
				return this._TAISANs;
			}
			set
			{
				this._TAISANs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.BOPHAN = this;
		}
		
		private void detach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.BOPHAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.XUATXU")]
	public partial class XUATXU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaXuatXu;
		
		private string _NoiXuatXu;
		
		private EntitySet<TAISAN> _TAISANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaXuatXuChanging(string value);
    partial void OnMaXuatXuChanged();
    partial void OnNoiXuatXuChanging(string value);
    partial void OnNoiXuatXuChanged();
    #endregion
		
		public XUATXU()
		{
			this._TAISANs = new EntitySet<TAISAN>(new Action<TAISAN>(this.attach_TAISANs), new Action<TAISAN>(this.detach_TAISANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaXuatXu", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaXuatXu
		{
			get
			{
				return this._MaXuatXu;
			}
			set
			{
				if ((this._MaXuatXu != value))
				{
					this.OnMaXuatXuChanging(value);
					this.SendPropertyChanging();
					this._MaXuatXu = value;
					this.SendPropertyChanged("MaXuatXu");
					this.OnMaXuatXuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiXuatXu", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NoiXuatXu
		{
			get
			{
				return this._NoiXuatXu;
			}
			set
			{
				if ((this._NoiXuatXu != value))
				{
					this.OnNoiXuatXuChanging(value);
					this.SendPropertyChanging();
					this._NoiXuatXu = value;
					this.SendPropertyChanged("NoiXuatXu");
					this.OnNoiXuatXuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="XUATXU_TAISAN", Storage="_TAISANs", ThisKey="MaXuatXu", OtherKey="MaXuatXu")]
		public EntitySet<TAISAN> TAISANs
		{
			get
			{
				return this._TAISANs;
			}
			set
			{
				this._TAISANs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.XUATXU = this;
		}
		
		private void detach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.XUATXU = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAITAISAN")]
	public partial class LOAITAISAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLoai;
		
		private string _TenLoai;
		
		private int _KhauHao;
		
		private EntitySet<TAISAN> _TAISANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    partial void OnKhauHaoChanging(int value);
    partial void OnKhauHaoChanged();
    #endregion
		
		public LOAITAISAN()
		{
			this._TAISANs = new EntitySet<TAISAN>(new Action<TAISAN>(this.attach_TAISANs), new Action<TAISAN>(this.detach_TAISANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KhauHao", DbType="Int NOT NULL")]
		public int KhauHao
		{
			get
			{
				return this._KhauHao;
			}
			set
			{
				if ((this._KhauHao != value))
				{
					this.OnKhauHaoChanging(value);
					this.SendPropertyChanging();
					this._KhauHao = value;
					this.SendPropertyChanged("KhauHao");
					this.OnKhauHaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAITAISAN_TAISAN", Storage="_TAISANs", ThisKey="MaLoai", OtherKey="MaLoai")]
		public EntitySet<TAISAN> TAISANs
		{
			get
			{
				return this._TAISANs;
			}
			set
			{
				this._TAISANs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.LOAITAISAN = this;
		}
		
		private void detach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.LOAITAISAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NGUOIDUNG")]
	public partial class NGUOIDUNG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
		private string _PhanQuyen;
		
		private string _HoTen;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _DienThoai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnPhanQuyenChanging(string value);
    partial void OnPhanQuyenChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    #endregion
		
		public NGUOIDUNG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhanQuyen", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string PhanQuyen
		{
			get
			{
				return this._PhanQuyen;
			}
			set
			{
				if ((this._PhanQuyen != value))
				{
					this.OnPhanQuyenChanging(value);
					this.SendPropertyChanging();
					this._PhanQuyen = value;
					this.SendPropertyChanged("PhanQuyen");
					this.OnPhanQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="NVarChar(10)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NGUONQUY")]
	public partial class NGUONQUY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNguon;
		
		private string _TenNguon;
		
		private EntitySet<TAISAN> _TAISANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNguonChanging(string value);
    partial void OnMaNguonChanged();
    partial void OnTenNguonChanging(string value);
    partial void OnTenNguonChanged();
    #endregion
		
		public NGUONQUY()
		{
			this._TAISANs = new EntitySet<TAISAN>(new Action<TAISAN>(this.attach_TAISANs), new Action<TAISAN>(this.detach_TAISANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNguon", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNguon
		{
			get
			{
				return this._MaNguon;
			}
			set
			{
				if ((this._MaNguon != value))
				{
					this.OnMaNguonChanging(value);
					this.SendPropertyChanging();
					this._MaNguon = value;
					this.SendPropertyChanged("MaNguon");
					this.OnMaNguonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNguon", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNguon
		{
			get
			{
				return this._TenNguon;
			}
			set
			{
				if ((this._TenNguon != value))
				{
					this.OnTenNguonChanging(value);
					this.SendPropertyChanging();
					this._TenNguon = value;
					this.SendPropertyChanged("TenNguon");
					this.OnTenNguonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NGUONQUY_TAISAN", Storage="_TAISANs", ThisKey="MaNguon", OtherKey="MaNguon")]
		public EntitySet<TAISAN> TAISANs
		{
			get
			{
				return this._TAISANs;
			}
			set
			{
				this._TAISANs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.NGUONQUY = this;
		}
		
		private void detach_TAISANs(TAISAN entity)
		{
			this.SendPropertyChanging();
			entity.NGUONQUY = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAISAN")]
	public partial class TAISAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaTS;
		
		private string _TenTS;
		
		private string _DVT;
		
		private int _SoLuong;
		
		private int _DonGia;
		
		private System.DateTime _NgayNhap;
		
		private string _MaLoai;
		
		private string _MaXuatXu;
		
		private string _MaNguon;
		
		private string _MaBP;
		
		private string _TinhTrang;
		
		private EntitySet<THANHLYT> _THANHLYTs;
		
		private EntityRef<BOPHAN> _BOPHAN;
		
		private EntityRef<LOAITAISAN> _LOAITAISAN;
		
		private EntityRef<NGUONQUY> _NGUONQUY;
		
		private EntityRef<XUATXU> _XUATXU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTSChanging(string value);
    partial void OnMaTSChanged();
    partial void OnTenTSChanging(string value);
    partial void OnTenTSChanged();
    partial void OnDVTChanging(string value);
    partial void OnDVTChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(int value);
    partial void OnDonGiaChanged();
    partial void OnNgayNhapChanging(System.DateTime value);
    partial void OnNgayNhapChanged();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnMaXuatXuChanging(string value);
    partial void OnMaXuatXuChanged();
    partial void OnMaNguonChanging(string value);
    partial void OnMaNguonChanged();
    partial void OnMaBPChanging(string value);
    partial void OnMaBPChanged();
    partial void OnTinhTrangChanging(string value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public TAISAN()
		{
			this._THANHLYTs = new EntitySet<THANHLYT>(new Action<THANHLYT>(this.attach_THANHLYTs), new Action<THANHLYT>(this.detach_THANHLYTs));
			this._BOPHAN = default(EntityRef<BOPHAN>);
			this._LOAITAISAN = default(EntityRef<LOAITAISAN>);
			this._NGUONQUY = default(EntityRef<NGUONQUY>);
			this._XUATXU = default(EntityRef<XUATXU>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTS", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTS
		{
			get
			{
				return this._MaTS;
			}
			set
			{
				if ((this._MaTS != value))
				{
					this.OnMaTSChanging(value);
					this.SendPropertyChanging();
					this._MaTS = value;
					this.SendPropertyChanged("MaTS");
					this.OnMaTSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTS", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenTS
		{
			get
			{
				return this._TenTS;
			}
			set
			{
				if ((this._TenTS != value))
				{
					this.OnTenTSChanging(value);
					this.SendPropertyChanging();
					this._TenTS = value;
					this.SendPropertyChanged("TenTS");
					this.OnTenTSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DVT", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string DVT
		{
			get
			{
				return this._DVT;
			}
			set
			{
				if ((this._DVT != value))
				{
					this.OnDVTChanging(value);
					this.SendPropertyChanging();
					this._DVT = value;
					this.SendPropertyChanged("DVT");
					this.OnDVTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Int NOT NULL")]
		public int DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayNhap", DbType="DateTime NOT NULL")]
		public System.DateTime NgayNhap
		{
			get
			{
				return this._NgayNhap;
			}
			set
			{
				if ((this._NgayNhap != value))
				{
					this.OnNgayNhapChanging(value);
					this.SendPropertyChanging();
					this._NgayNhap = value;
					this.SendPropertyChanged("NgayNhap");
					this.OnNgayNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					if (this._LOAITAISAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaXuatXu", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaXuatXu
		{
			get
			{
				return this._MaXuatXu;
			}
			set
			{
				if ((this._MaXuatXu != value))
				{
					if (this._XUATXU.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaXuatXuChanging(value);
					this.SendPropertyChanging();
					this._MaXuatXu = value;
					this.SendPropertyChanged("MaXuatXu");
					this.OnMaXuatXuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNguon", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaNguon
		{
			get
			{
				return this._MaNguon;
			}
			set
			{
				if ((this._MaNguon != value))
				{
					if (this._NGUONQUY.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNguonChanging(value);
					this.SendPropertyChanging();
					this._MaNguon = value;
					this.SendPropertyChanged("MaNguon");
					this.OnMaNguonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBP", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaBP
		{
			get
			{
				return this._MaBP;
			}
			set
			{
				if ((this._MaBP != value))
				{
					if (this._BOPHAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaBPChanging(value);
					this.SendPropertyChanging();
					this._MaBP = value;
					this.SendPropertyChanged("MaBP");
					this.OnMaBPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAISAN_THANHLYT", Storage="_THANHLYTs", ThisKey="MaTS", OtherKey="MaTS")]
		public EntitySet<THANHLYT> THANHLYTs
		{
			get
			{
				return this._THANHLYTs;
			}
			set
			{
				this._THANHLYTs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOPHAN_TAISAN", Storage="_BOPHAN", ThisKey="MaBP", OtherKey="MaBP", IsForeignKey=true)]
		public BOPHAN BOPHAN
		{
			get
			{
				return this._BOPHAN.Entity;
			}
			set
			{
				BOPHAN previousValue = this._BOPHAN.Entity;
				if (((previousValue != value) 
							|| (this._BOPHAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BOPHAN.Entity = null;
						previousValue.TAISANs.Remove(this);
					}
					this._BOPHAN.Entity = value;
					if ((value != null))
					{
						value.TAISANs.Add(this);
						this._MaBP = value.MaBP;
					}
					else
					{
						this._MaBP = default(string);
					}
					this.SendPropertyChanged("BOPHAN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAITAISAN_TAISAN", Storage="_LOAITAISAN", ThisKey="MaLoai", OtherKey="MaLoai", IsForeignKey=true)]
		public LOAITAISAN LOAITAISAN
		{
			get
			{
				return this._LOAITAISAN.Entity;
			}
			set
			{
				LOAITAISAN previousValue = this._LOAITAISAN.Entity;
				if (((previousValue != value) 
							|| (this._LOAITAISAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAITAISAN.Entity = null;
						previousValue.TAISANs.Remove(this);
					}
					this._LOAITAISAN.Entity = value;
					if ((value != null))
					{
						value.TAISANs.Add(this);
						this._MaLoai = value.MaLoai;
					}
					else
					{
						this._MaLoai = default(string);
					}
					this.SendPropertyChanged("LOAITAISAN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NGUONQUY_TAISAN", Storage="_NGUONQUY", ThisKey="MaNguon", OtherKey="MaNguon", IsForeignKey=true)]
		public NGUONQUY NGUONQUY
		{
			get
			{
				return this._NGUONQUY.Entity;
			}
			set
			{
				NGUONQUY previousValue = this._NGUONQUY.Entity;
				if (((previousValue != value) 
							|| (this._NGUONQUY.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NGUONQUY.Entity = null;
						previousValue.TAISANs.Remove(this);
					}
					this._NGUONQUY.Entity = value;
					if ((value != null))
					{
						value.TAISANs.Add(this);
						this._MaNguon = value.MaNguon;
					}
					else
					{
						this._MaNguon = default(string);
					}
					this.SendPropertyChanged("NGUONQUY");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="XUATXU_TAISAN", Storage="_XUATXU", ThisKey="MaXuatXu", OtherKey="MaXuatXu", IsForeignKey=true)]
		public XUATXU XUATXU
		{
			get
			{
				return this._XUATXU.Entity;
			}
			set
			{
				XUATXU previousValue = this._XUATXU.Entity;
				if (((previousValue != value) 
							|| (this._XUATXU.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._XUATXU.Entity = null;
						previousValue.TAISANs.Remove(this);
					}
					this._XUATXU.Entity = value;
					if ((value != null))
					{
						value.TAISANs.Add(this);
						this._MaXuatXu = value.MaXuatXu;
					}
					else
					{
						this._MaXuatXu = default(string);
					}
					this.SendPropertyChanged("XUATXU");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_THANHLYTs(THANHLYT entity)
		{
			this.SendPropertyChanging();
			entity.TAISAN = this;
		}
		
		private void detach_THANHLYTs(THANHLYT entity)
		{
			this.SendPropertyChanging();
			entity.TAISAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THANHLYTS")]
	public partial class THANHLYT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTL;
		
		private string _MaTS;
		
		private int _SoLuong;
		
		private int _DonGia;
		
		private string _TinhTrang;
		
		private EntityRef<TAISAN> _TAISAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTLChanging(int value);
    partial void OnMaTLChanged();
    partial void OnMaTSChanging(string value);
    partial void OnMaTSChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(int value);
    partial void OnDonGiaChanged();
    partial void OnTinhTrangChanging(string value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public THANHLYT()
		{
			this._TAISAN = default(EntityRef<TAISAN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTL", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTL
		{
			get
			{
				return this._MaTL;
			}
			set
			{
				if ((this._MaTL != value))
				{
					this.OnMaTLChanging(value);
					this.SendPropertyChanging();
					this._MaTL = value;
					this.SendPropertyChanged("MaTL");
					this.OnMaTLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTS", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaTS
		{
			get
			{
				return this._MaTS;
			}
			set
			{
				if ((this._MaTS != value))
				{
					if (this._TAISAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTSChanging(value);
					this.SendPropertyChanging();
					this._MaTS = value;
					this.SendPropertyChanged("MaTS");
					this.OnMaTSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Int NOT NULL")]
		public int DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAISAN_THANHLYT", Storage="_TAISAN", ThisKey="MaTS", OtherKey="MaTS", IsForeignKey=true)]
		public TAISAN TAISAN
		{
			get
			{
				return this._TAISAN.Entity;
			}
			set
			{
				TAISAN previousValue = this._TAISAN.Entity;
				if (((previousValue != value) 
							|| (this._TAISAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TAISAN.Entity = null;
						previousValue.THANHLYTs.Remove(this);
					}
					this._TAISAN.Entity = value;
					if ((value != null))
					{
						value.THANHLYTs.Add(this);
						this._MaTS = value.MaTS;
					}
					else
					{
						this._MaTS = default(string);
					}
					this.SendPropertyChanged("TAISAN");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class HoaDonThanhLyTSResult
	{
		
		private string _TenTS;
		
		private int _MaTL;
		
		private string _MaTS;
		
		private int _SoLuong;
		
		private int _DonGia;
		
		private string _TinhTrang;
		
		public HoaDonThanhLyTSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTS", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenTS
		{
			get
			{
				return this._TenTS;
			}
			set
			{
				if ((this._TenTS != value))
				{
					this._TenTS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTL", DbType="Int NOT NULL")]
		public int MaTL
		{
			get
			{
				return this._MaTL;
			}
			set
			{
				if ((this._MaTL != value))
				{
					this._MaTL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTS", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaTS
		{
			get
			{
				return this._MaTS;
			}
			set
			{
				if ((this._MaTS != value))
				{
					this._MaTS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this._SoLuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Int NOT NULL")]
		public int DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this._DonGia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this._TinhTrang = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
