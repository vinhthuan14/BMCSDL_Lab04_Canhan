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

namespace WindowsFormsApp1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSV_Lab04")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLOP(LOP instance);
    partial void UpdateLOP(LOP instance);
    partial void DeleteLOP(LOP instance);
    partial void InsertSINHVIEN(SINHVIEN instance);
    partial void UpdateSINHVIEN(SINHVIEN instance);
    partial void DeleteSINHVIEN(SINHVIEN instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApp1.Properties.Settings.Default.QLSV_Lab04ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LOP> LOPs
		{
			get
			{
				return this.GetTable<LOP>();
			}
		}
		
		public System.Data.Linq.Table<SINHVIEN> SINHVIENs
		{
			get
			{
				return this.GetTable<SINHVIEN>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INS_ENCRYPT_NHANVIEN")]
		public int SP_INS_ENCRYPT_NHANVIEN([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MANV", DbType="NVarChar(20)")] string mANV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HOTEN", DbType="NVarChar(100)")] string hOTEN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EMAIL", DbType="VarChar(20)")] string eMAIL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LUONG", DbType="VarChar(MAX)")] string lUONG, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TENDN", DbType="NVarChar(100)")] string tENDN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MATKHAU", DbType="VarChar(MAX)")] string mATKHAU)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), mANV, hOTEN, eMAIL, lUONG, tENDN, mATKHAU);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_SEL_NHANVIEN")]
		public ISingleResult<SP_SEL_NHANVIENResult> SP_SEL_NHANVIEN()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_SEL_NHANVIENResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INS_ENCRYPT_SINHVIEN")]
		public int SP_INS_ENCRYPT_SINHVIEN([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MASV", DbType="NVarChar(20)")] string mASV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HOTEN", DbType="NVarChar(100)")] string hOTEN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NGAYSINH", DbType="DateTime")] System.Nullable<System.DateTime> nGAYSINH, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DIACHI", DbType="NVarChar(200)")] string dIACHI, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MALOP", DbType="VarChar(20)")] string mALOP, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TENDN", DbType="NVarChar(100)")] string tENDN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MATKHAU", DbType="VarChar(32)")] string mATKHAU)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), mASV, hOTEN, nGAYSINH, dIACHI, mALOP, tENDN, mATKHAU);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOP")]
	public partial class LOP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MALOP;
		
		private string _TENLOP;
		
		private string _MANV;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMALOPChanging(string value);
    partial void OnMALOPChanged();
    partial void OnTENLOPChanging(string value);
    partial void OnTENLOPChanged();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    #endregion
		
		public LOP()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOP", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MALOP
		{
			get
			{
				return this._MALOP;
			}
			set
			{
				if ((this._MALOP != value))
				{
					this.OnMALOPChanging(value);
					this.SendPropertyChanging();
					this._MALOP = value;
					this.SendPropertyChanged("MALOP");
					this.OnMALOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TENLOP
		{
			get
			{
				return this._TENLOP;
			}
			set
			{
				if ((this._TENLOP != value))
				{
					this.OnTENLOPChanging(value);
					this.SendPropertyChanging();
					this._TENLOP = value;
					this.SendPropertyChanged("TENLOP");
					this.OnTENLOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="VarChar(20)")]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SINHVIEN")]
	public partial class SINHVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MASV;
		
		private string _HOTEN;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _DIACHI;
		
		private string _MALOP;
		
		private string _TENDN;
		
		private System.Data.Linq.Binary _MATKHAU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMASVChanging(string value);
    partial void OnMASVChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnMALOPChanging(string value);
    partial void OnMALOPChanged();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMATKHAUChanging(System.Data.Linq.Binary value);
    partial void OnMATKHAUChanged();
    #endregion
		
		public SINHVIEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASV", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MASV
		{
			get
			{
				return this._MASV;
			}
			set
			{
				if ((this._MASV != value))
				{
					this.OnMASVChanging(value);
					this.SendPropertyChanging();
					this._MASV = value;
					this.SendPropertyChanged("MASV");
					this.OnMASVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(200)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOP", DbType="VarChar(20)")]
		public string MALOP
		{
			get
			{
				return this._MALOP;
			}
			set
			{
				if ((this._MALOP != value))
				{
					this.OnMALOPChanging(value);
					this.SendPropertyChanging();
					this._MALOP = value;
					this.SendPropertyChanged("MALOP");
					this.OnMALOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private string _HOTEN;
		
		private string _EMAIL;
		
		private System.Data.Linq.Binary _LUONG;
		
		private string _TENDN;
		
		private System.Data.Linq.Binary _MATKHAU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnLUONGChanging(System.Data.Linq.Binary value);
    partial void OnLUONGChanged();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMATKHAUChanging(System.Data.Linq.Binary value);
    partial void OnMATKHAUChanged();
    #endregion
		
		public NHANVIEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(20)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LUONG", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary LUONG
		{
			get
			{
				return this._LUONG;
			}
			set
			{
				if ((this._LUONG != value))
				{
					this.OnLUONGChanging(value);
					this.SendPropertyChanging();
					this._LUONG = value;
					this.SendPropertyChanged("LUONG");
					this.OnLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
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
	
	public partial class SP_SEL_NHANVIENResult
	{
		
		private string _MANV;
		
		private string _HOTEN;
		
		private string _EMAIL;
		
		private string _LUONG;
		
		public SP_SEL_NHANVIENResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this._MANV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this._HOTEN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(20)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this._EMAIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LUONG", DbType="VarChar(MAX)")]
		public string LUONG
		{
			get
			{
				return this._LUONG;
			}
			set
			{
				if ((this._LUONG != value))
				{
					this._LUONG = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
