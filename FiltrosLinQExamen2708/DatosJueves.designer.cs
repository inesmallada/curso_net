#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejercicio_Filtros
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FiltrosLINQ")]
	public partial class DatosJuevesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertDatosFiltrosLINQ(DatosFiltrosLINQ instance);
    partial void UpdateDatosFiltrosLINQ(DatosFiltrosLINQ instance);
    partial void DeleteDatosFiltrosLINQ(DatosFiltrosLINQ instance);
    #endregion
		
		public DatosJuevesDataContext() : 
				base(global::Ejercicio_Filtros.Properties.Settings.Default.FiltrosLINQConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatosJuevesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosJuevesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosJuevesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosJuevesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DatosFiltrosLINQ> DatosFiltrosLINQ
		{
			get
			{
				return this.GetTable<DatosFiltrosLINQ>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DatosFiltrosLINQ")]
	public partial class DatosFiltrosLINQ : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private System.Nullable<System.DateTime> _Fecha_Ins;
		
		private System.Nullable<System.DateTime> _Fecha_Cont;
		
		private string _Curso;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnFecha_InsChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_InsChanged();
    partial void OnFecha_ContChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_ContChanged();
    partial void OnCursoChanging(string value);
    partial void OnCursoChanged();
    #endregion
		
		public DatosFiltrosLINQ()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="NVarChar(50)")]
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
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Ins", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_Ins
		{
			get
			{
				return this._Fecha_Ins;
			}
			set
			{
				if ((this._Fecha_Ins != value))
				{
					this.OnFecha_InsChanging(value);
					this.SendPropertyChanging();
					this._Fecha_Ins = value;
					this.SendPropertyChanged("Fecha_Ins");
					this.OnFecha_InsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Cont", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_Cont
		{
			get
			{
				return this._Fecha_Cont;
			}
			set
			{
				if ((this._Fecha_Cont != value))
				{
					this.OnFecha_ContChanging(value);
					this.SendPropertyChanging();
					this._Fecha_Cont = value;
					this.SendPropertyChanged("Fecha_Cont");
					this.OnFecha_ContChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Curso", DbType="NVarChar(50)")]
		public string Curso
		{
			get
			{
				return this._Curso;
			}
			set
			{
				if ((this._Curso != value))
				{
					this.OnCursoChanging(value);
					this.SendPropertyChanging();
					this._Curso = value;
					this.SendPropertyChanged("Curso");
					this.OnCursoChanged();
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
}
#pragma warning restore 1591
