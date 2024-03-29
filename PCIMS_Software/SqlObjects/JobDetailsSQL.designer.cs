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

namespace PCIMS_Software.SqlObjects
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PCIMS")]
	public partial class JobDetailsSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public JobDetailsSQLDataContext() : 
				base(global::PCIMS_Software.Properties.Settings.Default.PCIMSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public JobDetailsSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobDetailsSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobDetailsSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobDetailsSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<job> jobs
		{
			get
			{
				return this.GetTable<job>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.jobs")]
	public partial class job
	{
		
		private int _JobNbr;
		
		private string _CustomerID;
		
		private string _OrderDateTime;
		
		private string _OrderBy;
		
		private string _TakenBy;
		
		private string _Vessel;
		
		private string _VesselType;
		
		private string _Cargo;
		
		private string _Terminal;
		
		private string _Location;
		
		private string _InspectionDate;
		
		private string _JobType;
		
		private string _Eta;
		
		private System.Nullable<int> _CargoQty;
		
		private string _Inspector;
		
		private System.Nullable<short> _Splits;
		
		private string _Reports;
		
		private string _Completed;
		
		private string _Dist1;
		
		private string _Dist2;
		
		private System.Nullable<byte> _Subs;
		
		private string _LD;
		
		public job()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobNbr", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int JobNbr
		{
			get
			{
				return this._JobNbr;
			}
			set
			{
				if ((this._JobNbr != value))
				{
					this._JobNbr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="NVarChar(8)")]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this._CustomerID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDateTime", DbType="NVarChar(25)")]
		public string OrderDateTime
		{
			get
			{
				return this._OrderDateTime;
			}
			set
			{
				if ((this._OrderDateTime != value))
				{
					this._OrderDateTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderBy", DbType="NVarChar(15)")]
		public string OrderBy
		{
			get
			{
				return this._OrderBy;
			}
			set
			{
				if ((this._OrderBy != value))
				{
					this._OrderBy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TakenBy", DbType="NVarChar(25)")]
		public string TakenBy
		{
			get
			{
				return this._TakenBy;
			}
			set
			{
				if ((this._TakenBy != value))
				{
					this._TakenBy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vessel", DbType="NVarChar(40)")]
		public string Vessel
		{
			get
			{
				return this._Vessel;
			}
			set
			{
				if ((this._Vessel != value))
				{
					this._Vessel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VesselType", DbType="NVarChar(10)")]
		public string VesselType
		{
			get
			{
				return this._VesselType;
			}
			set
			{
				if ((this._VesselType != value))
				{
					this._VesselType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cargo", DbType="NVarChar(40)")]
		public string Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				if ((this._Cargo != value))
				{
					this._Cargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Terminal", DbType="NVarChar(40)")]
		public string Terminal
		{
			get
			{
				return this._Terminal;
			}
			set
			{
				if ((this._Terminal != value))
				{
					this._Terminal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(40)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this._Location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InspectionDate", DbType="NVarChar(10)")]
		public string InspectionDate
		{
			get
			{
				return this._InspectionDate;
			}
			set
			{
				if ((this._InspectionDate != value))
				{
					this._InspectionDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobType", DbType="NVarChar(20)")]
		public string JobType
		{
			get
			{
				return this._JobType;
			}
			set
			{
				if ((this._JobType != value))
				{
					this._JobType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eta", DbType="NVarChar(15)")]
		public string Eta
		{
			get
			{
				return this._Eta;
			}
			set
			{
				if ((this._Eta != value))
				{
					this._Eta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoQty", DbType="Int")]
		public System.Nullable<int> CargoQty
		{
			get
			{
				return this._CargoQty;
			}
			set
			{
				if ((this._CargoQty != value))
				{
					this._CargoQty = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Inspector", DbType="NVarChar(50)")]
		public string Inspector
		{
			get
			{
				return this._Inspector;
			}
			set
			{
				if ((this._Inspector != value))
				{
					this._Inspector = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Splits", DbType="SmallInt")]
		public System.Nullable<short> Splits
		{
			get
			{
				return this._Splits;
			}
			set
			{
				if ((this._Splits != value))
				{
					this._Splits = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reports", DbType="NVarChar(15)")]
		public string Reports
		{
			get
			{
				return this._Reports;
			}
			set
			{
				if ((this._Reports != value))
				{
					this._Reports = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Completed", DbType="NVarChar(10)")]
		public string Completed
		{
			get
			{
				return this._Completed;
			}
			set
			{
				if ((this._Completed != value))
				{
					this._Completed = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dist1", DbType="NVarChar(250)")]
		public string Dist1
		{
			get
			{
				return this._Dist1;
			}
			set
			{
				if ((this._Dist1 != value))
				{
					this._Dist1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dist2", DbType="NVarChar(250)")]
		public string Dist2
		{
			get
			{
				return this._Dist2;
			}
			set
			{
				if ((this._Dist2 != value))
				{
					this._Dist2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subs", DbType="TinyInt")]
		public System.Nullable<byte> Subs
		{
			get
			{
				return this._Subs;
			}
			set
			{
				if ((this._Subs != value))
				{
					this._Subs = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LD", DbType="NVarChar(9)")]
		public string LD
		{
			get
			{
				return this._LD;
			}
			set
			{
				if ((this._LD != value))
				{
					this._LD = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
