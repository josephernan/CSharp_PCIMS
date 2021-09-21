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
	public partial class CustomerDetailsSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public CustomerDetailsSQLDataContext() : 
				base(global::PCIMS_Software.Properties.Settings.Default.PCIMSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDetailsSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDetailsSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDetailsSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDetailsSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer
	{
		
		private int _CustomerID;
		
		private string _CompanyName;
		
		private string _ContactFirstName;
		
		private string _ContactLastName;
		
		private string _CompanyOrDepartment;
		
		private string _SortOrder;
		
		private string _BillingAddress;
		
		private string _BillingAddress2;
		
		private string _City;
		
		private string _StateOrProvince;
		
		private string _PostalCode;
		
		private string _Country;
		
		private string _ContactTitle;
		
		private string _PhoneNumber;
		
		private string _Extension;
		
		private string _FaxNumber;
		
		private string _EmailAddress;
		
		private string _Notes;
		
		public Customer()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int CustomerID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(50)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this._CompanyName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactFirstName", DbType="NVarChar(30)")]
		public string ContactFirstName
		{
			get
			{
				return this._ContactFirstName;
			}
			set
			{
				if ((this._ContactFirstName != value))
				{
					this._ContactFirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactLastName", DbType="NVarChar(50)")]
		public string ContactLastName
		{
			get
			{
				return this._ContactLastName;
			}
			set
			{
				if ((this._ContactLastName != value))
				{
					this._ContactLastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyOrDepartment", DbType="NVarChar(35)")]
		public string CompanyOrDepartment
		{
			get
			{
				return this._CompanyOrDepartment;
			}
			set
			{
				if ((this._CompanyOrDepartment != value))
				{
					this._CompanyOrDepartment = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SortOrder", DbType="NVarChar(35) NOT NULL", CanBeNull=false)]
		public string SortOrder
		{
			get
			{
				return this._SortOrder;
			}
			set
			{
				if ((this._SortOrder != value))
				{
					this._SortOrder = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillingAddress", DbType="NVarChar(255)")]
		public string BillingAddress
		{
			get
			{
				return this._BillingAddress;
			}
			set
			{
				if ((this._BillingAddress != value))
				{
					this._BillingAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillingAddress2", DbType="NVarChar(50)")]
		public string BillingAddress2
		{
			get
			{
				return this._BillingAddress2;
			}
			set
			{
				if ((this._BillingAddress2 != value))
				{
					this._BillingAddress2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateOrProvince", DbType="NVarChar(20)")]
		public string StateOrProvince
		{
			get
			{
				return this._StateOrProvince;
			}
			set
			{
				if ((this._StateOrProvince != value))
				{
					this._StateOrProvince = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="NVarChar(20)")]
		public string PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this._PostalCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(50)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactTitle", DbType="NVarChar(50)")]
		public string ContactTitle
		{
			get
			{
				return this._ContactTitle;
			}
			set
			{
				if ((this._ContactTitle != value))
				{
					this._ContactTitle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(30)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extension", DbType="NVarChar(50)")]
		public string Extension
		{
			get
			{
				return this._Extension;
			}
			set
			{
				if ((this._Extension != value))
				{
					this._Extension = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FaxNumber", DbType="NVarChar(30)")]
		public string FaxNumber
		{
			get
			{
				return this._FaxNumber;
			}
			set
			{
				if ((this._FaxNumber != value))
				{
					this._FaxNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(50)")]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this._EmailAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this._Notes = value;
				}
			}
		}
	}
}
#pragma warning restore 1591