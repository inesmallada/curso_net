﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HUCANET_Formu
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HOSPITAL")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::HUCANET_Formu.Properties.Settings.Default.HOSPITALConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Enfermo> Enfermo
		{
			get
			{
				return this.GetTable<Enfermo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Enfermo")]
	public partial class Enfermo
	{
		
		private System.Nullable<int> _inscripcion;
		
		private string _Apellido;
		
		private string _Direccion;
		
		private System.Nullable<int> _Dir;
		
		private System.Nullable<System.DateTime> _Fecha_Nac;
		
		private string _S;
		
		private System.Nullable<int> _NSS;
		
		private System.Nullable<int> _Cod_Hospital;
		
		public Enfermo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inscripcion", DbType="Int")]
		public System.Nullable<int> inscripcion
		{
			get
			{
				return this._inscripcion;
			}
			set
			{
				if ((this._inscripcion != value))
				{
					this._inscripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(50)")]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this._Apellido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dir", DbType="Int")]
		public System.Nullable<int> Dir
		{
			get
			{
				return this._Dir;
			}
			set
			{
				if ((this._Dir != value))
				{
					this._Dir = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Nac", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Fecha_Nac
		{
			get
			{
				return this._Fecha_Nac;
			}
			set
			{
				if ((this._Fecha_Nac != value))
				{
					this._Fecha_Nac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S", DbType="VarChar(2)")]
		public string S
		{
			get
			{
				return this._S;
			}
			set
			{
				if ((this._S != value))
				{
					this._S = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSS", DbType="Int")]
		public System.Nullable<int> NSS
		{
			get
			{
				return this._NSS;
			}
			set
			{
				if ((this._NSS != value))
				{
					this._NSS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cod_Hospital", DbType="Int")]
		public System.Nullable<int> Cod_Hospital
		{
			get
			{
				return this._Cod_Hospital;
			}
			set
			{
				if ((this._Cod_Hospital != value))
				{
					this._Cod_Hospital = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
