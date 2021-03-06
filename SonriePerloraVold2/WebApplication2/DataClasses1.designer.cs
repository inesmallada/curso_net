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

namespace WebApplication2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SonriePerlora")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertDepartamento(Departamento instance);
    partial void UpdateDepartamento(Departamento instance);
    partial void DeleteDepartamento(Departamento instance);
    partial void InsertPersonal(Personal instance);
    partial void UpdatePersonal(Personal instance);
    partial void DeletePersonal(Personal instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SonriePerloraConnectionString1"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Cliente> Cliente
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Departamento> Departamento
		{
			get
			{
				return this.GetTable<Departamento>();
			}
		}
		
		public System.Data.Linq.Table<Nominas> Nominas
		{
			get
			{
				return this.GetTable<Nominas>();
			}
		}
		
		public System.Data.Linq.Table<Personal> Personal
		{
			get
			{
				return this.GetTable<Personal>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admin
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_Cliente;
		
		private string _Nombre;
		
		private string _Apellidos;
		
		private string _Genero;
		
		private string _DNI;
		
		private int _Edad;
		
		private string _Localidad;
		
		private int _NumPersonas;
		
		private string _Animales;
		
		private string _Habitacion;
		
		private decimal _Precio;
		
		private System.DateTime _FechaInicio;
		
		private System.DateTime _FechaFin;
		
		private string _PackCamp;
		
		private string _Dieta;
		
		private string _Alergias;
		
		private string _DiversidadFuncional;
		
		private string _ID_Departamento;
		
		private EntityRef<Departamento> _Departamento;
		
		private EntityRef<Departamento> _Departamento1;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_ClienteChanging(string value);
    partial void OnID_ClienteChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidosChanging(string value);
    partial void OnApellidosChanged();
    partial void OnGeneroChanging(string value);
    partial void OnGeneroChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnEdadChanging(int value);
    partial void OnEdadChanged();
    partial void OnLocalidadChanging(string value);
    partial void OnLocalidadChanged();
    partial void OnNumPersonasChanging(int value);
    partial void OnNumPersonasChanged();
    partial void OnAnimalesChanging(string value);
    partial void OnAnimalesChanged();
    partial void OnHabitacionChanging(string value);
    partial void OnHabitacionChanged();
    partial void OnPrecioChanging(decimal value);
    partial void OnPrecioChanged();
    partial void OnFechaInicioChanging(System.DateTime value);
    partial void OnFechaInicioChanged();
    partial void OnFechaFinChanging(System.DateTime value);
    partial void OnFechaFinChanged();
    partial void OnPackCampChanging(string value);
    partial void OnPackCampChanged();
    partial void OnDietaChanging(string value);
    partial void OnDietaChanged();
    partial void OnAlergiasChanging(string value);
    partial void OnAlergiasChanged();
    partial void OnDiversidadFuncionalChanging(string value);
    partial void OnDiversidadFuncionalChanged();
    partial void OnID_DepartamentoChanging(string value);
    partial void OnID_DepartamentoChanged();
    #endregion
		
		public Cliente()
		{
			this._Departamento = default(EntityRef<Departamento>);
			this._Departamento1 = default(EntityRef<Departamento>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Cliente", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_Cliente
		{
			get
			{
				return this._ID_Cliente;
			}
			set
			{
				if ((this._ID_Cliente != value))
				{
					this.OnID_ClienteChanging(value);
					this.SendPropertyChanging();
					this._ID_Cliente = value;
					this.SendPropertyChanged("ID_Cliente");
					this.OnID_ClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this.OnApellidosChanging(value);
					this.SendPropertyChanging();
					this._Apellidos = value;
					this.SendPropertyChanged("Apellidos");
					this.OnApellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this.OnGeneroChanging(value);
					this.SendPropertyChanging();
					this._Genero = value;
					this.SendPropertyChanged("Genero");
					this.OnGeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edad", DbType="Int NOT NULL")]
		public int Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				if ((this._Edad != value))
				{
					this.OnEdadChanging(value);
					this.SendPropertyChanging();
					this._Edad = value;
					this.SendPropertyChanged("Edad");
					this.OnEdadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Localidad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Localidad
		{
			get
			{
				return this._Localidad;
			}
			set
			{
				if ((this._Localidad != value))
				{
					this.OnLocalidadChanging(value);
					this.SendPropertyChanging();
					this._Localidad = value;
					this.SendPropertyChanged("Localidad");
					this.OnLocalidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumPersonas", DbType="Int NOT NULL")]
		public int NumPersonas
		{
			get
			{
				return this._NumPersonas;
			}
			set
			{
				if ((this._NumPersonas != value))
				{
					this.OnNumPersonasChanging(value);
					this.SendPropertyChanging();
					this._NumPersonas = value;
					this.SendPropertyChanged("NumPersonas");
					this.OnNumPersonasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animales", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Animales
		{
			get
			{
				return this._Animales;
			}
			set
			{
				if ((this._Animales != value))
				{
					this.OnAnimalesChanging(value);
					this.SendPropertyChanging();
					this._Animales = value;
					this.SendPropertyChanged("Animales");
					this.OnAnimalesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Habitacion", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Habitacion
		{
			get
			{
				return this._Habitacion;
			}
			set
			{
				if ((this._Habitacion != value))
				{
					this.OnHabitacionChanging(value);
					this.SendPropertyChanging();
					this._Habitacion = value;
					this.SendPropertyChanged("Habitacion");
					this.OnHabitacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(18,2) NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this.OnPrecioChanging(value);
					this.SendPropertyChanging();
					this._Precio = value;
					this.SendPropertyChanged("Precio");
					this.OnPrecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaInicio", DbType="DateTime NOT NULL")]
		public System.DateTime FechaInicio
		{
			get
			{
				return this._FechaInicio;
			}
			set
			{
				if ((this._FechaInicio != value))
				{
					this.OnFechaInicioChanging(value);
					this.SendPropertyChanging();
					this._FechaInicio = value;
					this.SendPropertyChanged("FechaInicio");
					this.OnFechaInicioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaFin", DbType="DateTime NOT NULL")]
		public System.DateTime FechaFin
		{
			get
			{
				return this._FechaFin;
			}
			set
			{
				if ((this._FechaFin != value))
				{
					this.OnFechaFinChanging(value);
					this.SendPropertyChanging();
					this._FechaFin = value;
					this.SendPropertyChanged("FechaFin");
					this.OnFechaFinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PackCamp", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PackCamp
		{
			get
			{
				return this._PackCamp;
			}
			set
			{
				if ((this._PackCamp != value))
				{
					this.OnPackCampChanging(value);
					this.SendPropertyChanging();
					this._PackCamp = value;
					this.SendPropertyChanged("PackCamp");
					this.OnPackCampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dieta", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Dieta
		{
			get
			{
				return this._Dieta;
			}
			set
			{
				if ((this._Dieta != value))
				{
					this.OnDietaChanging(value);
					this.SendPropertyChanging();
					this._Dieta = value;
					this.SendPropertyChanged("Dieta");
					this.OnDietaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Alergias", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Alergias
		{
			get
			{
				return this._Alergias;
			}
			set
			{
				if ((this._Alergias != value))
				{
					this.OnAlergiasChanging(value);
					this.SendPropertyChanging();
					this._Alergias = value;
					this.SendPropertyChanged("Alergias");
					this.OnAlergiasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiversidadFuncional", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiversidadFuncional
		{
			get
			{
				return this._DiversidadFuncional;
			}
			set
			{
				if ((this._DiversidadFuncional != value))
				{
					this.OnDiversidadFuncionalChanging(value);
					this.SendPropertyChanging();
					this._DiversidadFuncional = value;
					this.SendPropertyChanged("DiversidadFuncional");
					this.OnDiversidadFuncionalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Departamento", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ID_Departamento
		{
			get
			{
				return this._ID_Departamento;
			}
			set
			{
				if ((this._ID_Departamento != value))
				{
					if ((this._Departamento.HasLoadedOrAssignedValue || this._Departamento1.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_DepartamentoChanging(value);
					this.SendPropertyChanging();
					this._ID_Departamento = value;
					this.SendPropertyChanged("ID_Departamento");
					this.OnID_DepartamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Cliente", Storage="_Departamento", ThisKey="ID_Departamento", OtherKey="ID_Departamento", IsForeignKey=true)]
		public Departamento Departamento
		{
			get
			{
				return this._Departamento.Entity;
			}
			set
			{
				Departamento previousValue = this._Departamento.Entity;
				if (((previousValue != value) 
							|| (this._Departamento.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departamento.Entity = null;
						previousValue.Cliente.Remove(this);
					}
					this._Departamento.Entity = value;
					if ((value != null))
					{
						value.Cliente.Add(this);
						this._ID_Departamento = value.ID_Departamento;
					}
					else
					{
						this._ID_Departamento = default(string);
					}
					this.SendPropertyChanged("Departamento");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Cliente1", Storage="_Departamento1", ThisKey="ID_Departamento", OtherKey="ID_Departamento", IsForeignKey=true)]
		public Departamento Departamento1
		{
			get
			{
				return this._Departamento1.Entity;
			}
			set
			{
				Departamento previousValue = this._Departamento1.Entity;
				if (((previousValue != value) 
							|| (this._Departamento1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departamento1.Entity = null;
						previousValue.Cliente1.Remove(this);
					}
					this._Departamento1.Entity = value;
					if ((value != null))
					{
						value.Cliente1.Add(this);
						this._ID_Departamento = value.ID_Departamento;
					}
					else
					{
						this._ID_Departamento = default(string);
					}
					this.SendPropertyChanged("Departamento1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departamento")]
	public partial class Departamento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_Departamento;
		
		private string _Actividad;
		
		private EntitySet<Cliente> _Cliente;
		
		private EntitySet<Cliente> _Cliente1;
		
		private EntitySet<Personal> _Personal;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_DepartamentoChanging(string value);
    partial void OnID_DepartamentoChanged();
    partial void OnActividadChanging(string value);
    partial void OnActividadChanged();
    #endregion
		
		public Departamento()
		{
			this._Cliente = new EntitySet<Cliente>(new Action<Cliente>(this.attach_Cliente), new Action<Cliente>(this.detach_Cliente));
			this._Cliente1 = new EntitySet<Cliente>(new Action<Cliente>(this.attach_Cliente1), new Action<Cliente>(this.detach_Cliente1));
			this._Personal = new EntitySet<Personal>(new Action<Personal>(this.attach_Personal), new Action<Personal>(this.detach_Personal));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Departamento", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_Departamento
		{
			get
			{
				return this._ID_Departamento;
			}
			set
			{
				if ((this._ID_Departamento != value))
				{
					this.OnID_DepartamentoChanging(value);
					this.SendPropertyChanging();
					this._ID_Departamento = value;
					this.SendPropertyChanged("ID_Departamento");
					this.OnID_DepartamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Actividad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Actividad
		{
			get
			{
				return this._Actividad;
			}
			set
			{
				if ((this._Actividad != value))
				{
					this.OnActividadChanging(value);
					this.SendPropertyChanging();
					this._Actividad = value;
					this.SendPropertyChanged("Actividad");
					this.OnActividadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Cliente", Storage="_Cliente", ThisKey="ID_Departamento", OtherKey="ID_Departamento")]
		public EntitySet<Cliente> Cliente
		{
			get
			{
				return this._Cliente;
			}
			set
			{
				this._Cliente.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Cliente1", Storage="_Cliente1", ThisKey="ID_Departamento", OtherKey="ID_Departamento")]
		public EntitySet<Cliente> Cliente1
		{
			get
			{
				return this._Cliente1;
			}
			set
			{
				this._Cliente1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Personal", Storage="_Personal", ThisKey="ID_Departamento", OtherKey="ID_Departamento")]
		public EntitySet<Personal> Personal
		{
			get
			{
				return this._Personal;
			}
			set
			{
				this._Personal.Assign(value);
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
		
		private void attach_Cliente(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Departamento = this;
		}
		
		private void detach_Cliente(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Departamento = null;
		}
		
		private void attach_Cliente1(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Departamento1 = this;
		}
		
		private void detach_Cliente1(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Departamento1 = null;
		}
		
		private void attach_Personal(Personal entity)
		{
			this.SendPropertyChanging();
			entity.Departamento = this;
		}
		
		private void detach_Personal(Personal entity)
		{
			this.SendPropertyChanging();
			entity.Departamento = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nominas")]
	public partial class Nominas
	{
		
		private string _ID_Nominas;
		
		private int _Vacaciones;
		
		private int _Bajas;
		
		private decimal _PrecioHora;
		
		private decimal _PrecioHoraExtra;
		
		private int _HorasTrabajadas;
		
		private int _HorasExtra;
		
		private decimal _IRPF;
		
		private int _Liquidacion;
		
		private string _DireccionEmpresa;
		
		private string _Cod_Cuenta;
		
		public Nominas()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Nominas", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ID_Nominas
		{
			get
			{
				return this._ID_Nominas;
			}
			set
			{
				if ((this._ID_Nominas != value))
				{
					this._ID_Nominas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vacaciones", DbType="Int NOT NULL")]
		public int Vacaciones
		{
			get
			{
				return this._Vacaciones;
			}
			set
			{
				if ((this._Vacaciones != value))
				{
					this._Vacaciones = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bajas", DbType="Int NOT NULL")]
		public int Bajas
		{
			get
			{
				return this._Bajas;
			}
			set
			{
				if ((this._Bajas != value))
				{
					this._Bajas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioHora", DbType="Decimal(18,2) NOT NULL")]
		public decimal PrecioHora
		{
			get
			{
				return this._PrecioHora;
			}
			set
			{
				if ((this._PrecioHora != value))
				{
					this._PrecioHora = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioHoraExtra", DbType="Decimal(18,2) NOT NULL")]
		public decimal PrecioHoraExtra
		{
			get
			{
				return this._PrecioHoraExtra;
			}
			set
			{
				if ((this._PrecioHoraExtra != value))
				{
					this._PrecioHoraExtra = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HorasTrabajadas", DbType="Int NOT NULL")]
		public int HorasTrabajadas
		{
			get
			{
				return this._HorasTrabajadas;
			}
			set
			{
				if ((this._HorasTrabajadas != value))
				{
					this._HorasTrabajadas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HorasExtra", DbType="Int NOT NULL")]
		public int HorasExtra
		{
			get
			{
				return this._HorasExtra;
			}
			set
			{
				if ((this._HorasExtra != value))
				{
					this._HorasExtra = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IRPF", DbType="Decimal(18,2) NOT NULL")]
		public decimal IRPF
		{
			get
			{
				return this._IRPF;
			}
			set
			{
				if ((this._IRPF != value))
				{
					this._IRPF = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Liquidacion", DbType="Int NOT NULL")]
		public int Liquidacion
		{
			get
			{
				return this._Liquidacion;
			}
			set
			{
				if ((this._Liquidacion != value))
				{
					this._Liquidacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DireccionEmpresa", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DireccionEmpresa
		{
			get
			{
				return this._DireccionEmpresa;
			}
			set
			{
				if ((this._DireccionEmpresa != value))
				{
					this._DireccionEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cod_Cuenta", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Cod_Cuenta
		{
			get
			{
				return this._Cod_Cuenta;
			}
			set
			{
				if ((this._Cod_Cuenta != value))
				{
					this._Cod_Cuenta = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Personal")]
	public partial class Personal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_Personal;
		
		private string _Nombre;
		
		private string _Apellidos;
		
		private string _Genero;
		
		private string _DNI;
		
		private string _NSS;
		
		private string _Localidad;
		
		private int _Cpostal;
		
		private string _ID_Departamento;
		
		private string _TipoContrato;
		
		private string _Puesto;
		
		private string _TipoJornada;
		
		private System.Nullable<decimal> _SalarioBruto;
		
		private System.Nullable<decimal> _SalarioNeto;
		
		private EntityRef<Departamento> _Departamento;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_PersonalChanging(string value);
    partial void OnID_PersonalChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidosChanging(string value);
    partial void OnApellidosChanged();
    partial void OnGeneroChanging(string value);
    partial void OnGeneroChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnNSSChanging(string value);
    partial void OnNSSChanged();
    partial void OnLocalidadChanging(string value);
    partial void OnLocalidadChanged();
    partial void OnCpostalChanging(int value);
    partial void OnCpostalChanged();
    partial void OnID_DepartamentoChanging(string value);
    partial void OnID_DepartamentoChanged();
    partial void OnTipoContratoChanging(string value);
    partial void OnTipoContratoChanged();
    partial void OnPuestoChanging(string value);
    partial void OnPuestoChanged();
    partial void OnTipoJornadaChanging(string value);
    partial void OnTipoJornadaChanged();
    partial void OnSalarioBrutoChanging(System.Nullable<decimal> value);
    partial void OnSalarioBrutoChanged();
    partial void OnSalarioNetoChanging(System.Nullable<decimal> value);
    partial void OnSalarioNetoChanged();
    #endregion
		
		public Personal()
		{
			this._Departamento = default(EntityRef<Departamento>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Personal", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_Personal
		{
			get
			{
				return this._ID_Personal;
			}
			set
			{
				if ((this._ID_Personal != value))
				{
					this.OnID_PersonalChanging(value);
					this.SendPropertyChanging();
					this._ID_Personal = value;
					this.SendPropertyChanged("ID_Personal");
					this.OnID_PersonalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this.OnApellidosChanging(value);
					this.SendPropertyChanging();
					this._Apellidos = value;
					this.SendPropertyChanged("Apellidos");
					this.OnApellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this.OnGeneroChanging(value);
					this.SendPropertyChanging();
					this._Genero = value;
					this.SendPropertyChanged("Genero");
					this.OnGeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSS", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NSS
		{
			get
			{
				return this._NSS;
			}
			set
			{
				if ((this._NSS != value))
				{
					this.OnNSSChanging(value);
					this.SendPropertyChanging();
					this._NSS = value;
					this.SendPropertyChanged("NSS");
					this.OnNSSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Localidad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Localidad
		{
			get
			{
				return this._Localidad;
			}
			set
			{
				if ((this._Localidad != value))
				{
					this.OnLocalidadChanging(value);
					this.SendPropertyChanging();
					this._Localidad = value;
					this.SendPropertyChanged("Localidad");
					this.OnLocalidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cpostal", DbType="Int NOT NULL")]
		public int Cpostal
		{
			get
			{
				return this._Cpostal;
			}
			set
			{
				if ((this._Cpostal != value))
				{
					this.OnCpostalChanging(value);
					this.SendPropertyChanging();
					this._Cpostal = value;
					this.SendPropertyChanged("Cpostal");
					this.OnCpostalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Departamento", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ID_Departamento
		{
			get
			{
				return this._ID_Departamento;
			}
			set
			{
				if ((this._ID_Departamento != value))
				{
					if (this._Departamento.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_DepartamentoChanging(value);
					this.SendPropertyChanging();
					this._ID_Departamento = value;
					this.SendPropertyChanged("ID_Departamento");
					this.OnID_DepartamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoContrato", DbType="NVarChar(50)")]
		public string TipoContrato
		{
			get
			{
				return this._TipoContrato;
			}
			set
			{
				if ((this._TipoContrato != value))
				{
					this.OnTipoContratoChanging(value);
					this.SendPropertyChanging();
					this._TipoContrato = value;
					this.SendPropertyChanged("TipoContrato");
					this.OnTipoContratoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Puesto", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Puesto
		{
			get
			{
				return this._Puesto;
			}
			set
			{
				if ((this._Puesto != value))
				{
					this.OnPuestoChanging(value);
					this.SendPropertyChanging();
					this._Puesto = value;
					this.SendPropertyChanged("Puesto");
					this.OnPuestoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoJornada", DbType="NVarChar(50)")]
		public string TipoJornada
		{
			get
			{
				return this._TipoJornada;
			}
			set
			{
				if ((this._TipoJornada != value))
				{
					this.OnTipoJornadaChanging(value);
					this.SendPropertyChanging();
					this._TipoJornada = value;
					this.SendPropertyChanged("TipoJornada");
					this.OnTipoJornadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalarioBruto", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> SalarioBruto
		{
			get
			{
				return this._SalarioBruto;
			}
			set
			{
				if ((this._SalarioBruto != value))
				{
					this.OnSalarioBrutoChanging(value);
					this.SendPropertyChanging();
					this._SalarioBruto = value;
					this.SendPropertyChanged("SalarioBruto");
					this.OnSalarioBrutoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalarioNeto", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> SalarioNeto
		{
			get
			{
				return this._SalarioNeto;
			}
			set
			{
				if ((this._SalarioNeto != value))
				{
					this.OnSalarioNetoChanging(value);
					this.SendPropertyChanging();
					this._SalarioNeto = value;
					this.SendPropertyChanged("SalarioNeto");
					this.OnSalarioNetoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Personal", Storage="_Departamento", ThisKey="ID_Departamento", OtherKey="ID_Departamento", IsForeignKey=true)]
		public Departamento Departamento
		{
			get
			{
				return this._Departamento.Entity;
			}
			set
			{
				Departamento previousValue = this._Departamento.Entity;
				if (((previousValue != value) 
							|| (this._Departamento.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departamento.Entity = null;
						previousValue.Personal.Remove(this);
					}
					this._Departamento.Entity = value;
					if ((value != null))
					{
						value.Personal.Add(this);
						this._ID_Departamento = value.ID_Departamento;
					}
					else
					{
						this._ID_Departamento = default(string);
					}
					this.SendPropertyChanged("Departamento");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin
	{
		
		private string _usuario;
		
		private string _pass;
		
		private string _tipo;
		
		public Admin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this._usuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this._pass = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					this._tipo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
