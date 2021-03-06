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

namespace wizzAppServer.DBmanager
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dmaa0914_Spec14Games_1")]
	public partial class DBlinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDescription(Description instance);
    partial void UpdateDescription(Description instance);
    partial void DeleteDescription(Description instance);
    partial void InsertSession(Session instance);
    partial void UpdateSession(Session instance);
    partial void DeleteSession(Session instance);
    partial void InsertEmailSubscriber(EmailSubscriber instance);
    partial void UpdateEmailSubscriber(EmailSubscriber instance);
    partial void DeleteEmailSubscriber(EmailSubscriber instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DBlinqDataContext() : 
				base(global::wizzAppServer.Properties.Settings.Default.dmaa0914_Spec14Games_1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBlinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBlinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBlinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBlinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Description> Descriptions
		{
			get
			{
				return this.GetTable<Description>();
			}
		}
		
		public System.Data.Linq.Table<Session> Sessions
		{
			get
			{
				return this.GetTable<Session>();
			}
		}
		
		public System.Data.Linq.Table<EmailSubscriber> EmailSubscribers
		{
			get
			{
				return this.GetTable<EmailSubscriber>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Descriptions")]
	public partial class Description : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _Description1;
		
		private System.DateTime _LastUpdated;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescription1Changing(string value);
    partial void OnDescription1Changed();
    partial void OnLastUpdatedChanging(System.DateTime value);
    partial void OnLastUpdatedChanged();
    #endregion
		
		public Description()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Description", Storage="_Description1", DbType="NVarChar(1024) NOT NULL", CanBeNull=false)]
		public string Description1
		{
			get
			{
				return this._Description1;
			}
			set
			{
				if ((this._Description1 != value))
				{
					this.OnDescription1Changing(value);
					this.SendPropertyChanging();
					this._Description1 = value;
					this.SendPropertyChanged("Description1");
					this.OnDescription1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdated", DbType="SmallDateTime NOT NULL")]
		public System.DateTime LastUpdated
		{
			get
			{
				return this._LastUpdated;
			}
			set
			{
				if ((this._LastUpdated != value))
				{
					this.OnLastUpdatedChanging(value);
					this.SendPropertyChanging();
					this._LastUpdated = value;
					this.SendPropertyChanged("LastUpdated");
					this.OnLastUpdatedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sessions")]
	public partial class Session : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _userId;
		
		private string _identifyer;
		
		private System.DateTime _startTime;
		
		private System.DateTime _stopTime;
		
		private int _shotsFired;
		
		private int _shotsHit;
		
		private int _kills;
		
		private int _deaths;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnidentifyerChanging(string value);
    partial void OnidentifyerChanged();
    partial void OnstartTimeChanging(System.DateTime value);
    partial void OnstartTimeChanged();
    partial void OnstopTimeChanging(System.DateTime value);
    partial void OnstopTimeChanged();
    partial void OnshotsFiredChanging(int value);
    partial void OnshotsFiredChanged();
    partial void OnshotsHitChanging(int value);
    partial void OnshotsHitChanged();
    partial void OnkillsChanging(int value);
    partial void OnkillsChanged();
    partial void OndeathsChanging(int value);
    partial void OndeathsChanged();
    #endregion
		
		public Session()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="Int NOT NULL")]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identifyer", DbType="NVarChar(32)")]
		public string identifyer
		{
			get
			{
				return this._identifyer;
			}
			set
			{
				if ((this._identifyer != value))
				{
					this.OnidentifyerChanging(value);
					this.SendPropertyChanging();
					this._identifyer = value;
					this.SendPropertyChanged("identifyer");
					this.OnidentifyerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_startTime", DbType="DateTime NOT NULL")]
		public System.DateTime startTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				if ((this._startTime != value))
				{
					this.OnstartTimeChanging(value);
					this.SendPropertyChanging();
					this._startTime = value;
					this.SendPropertyChanged("startTime");
					this.OnstartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stopTime", DbType="DateTime NOT NULL")]
		public System.DateTime stopTime
		{
			get
			{
				return this._stopTime;
			}
			set
			{
				if ((this._stopTime != value))
				{
					this.OnstopTimeChanging(value);
					this.SendPropertyChanging();
					this._stopTime = value;
					this.SendPropertyChanged("stopTime");
					this.OnstopTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shotsFired", DbType="Int NOT NULL")]
		public int shotsFired
		{
			get
			{
				return this._shotsFired;
			}
			set
			{
				if ((this._shotsFired != value))
				{
					this.OnshotsFiredChanging(value);
					this.SendPropertyChanging();
					this._shotsFired = value;
					this.SendPropertyChanged("shotsFired");
					this.OnshotsFiredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shotsHit", DbType="Int NOT NULL")]
		public int shotsHit
		{
			get
			{
				return this._shotsHit;
			}
			set
			{
				if ((this._shotsHit != value))
				{
					this.OnshotsHitChanging(value);
					this.SendPropertyChanging();
					this._shotsHit = value;
					this.SendPropertyChanged("shotsHit");
					this.OnshotsHitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kills", DbType="Int NOT NULL")]
		public int kills
		{
			get
			{
				return this._kills;
			}
			set
			{
				if ((this._kills != value))
				{
					this.OnkillsChanging(value);
					this.SendPropertyChanging();
					this._kills = value;
					this.SendPropertyChanged("kills");
					this.OnkillsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deaths", DbType="Int NOT NULL")]
		public int deaths
		{
			get
			{
				return this._deaths;
			}
			set
			{
				if ((this._deaths != value))
				{
					this.OndeathsChanging(value);
					this.SendPropertyChanging();
					this._deaths = value;
					this.SendPropertyChanged("deaths");
					this.OndeathsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Session", Storage="_User", ThisKey="userId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Sessions.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Sessions.Add(this);
						this._userId = value.Id;
					}
					else
					{
						this._userId = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmailSubscribers")]
	public partial class EmailSubscriber : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _userId;
		
		private string _emailAddress;
		
		private string _validationCode;
		
		private bool _addressValidated;
		
		private System.Nullable<System.DateTime> _dateSubscribed;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnuserIdChanging(System.Nullable<int> value);
    partial void OnuserIdChanged();
    partial void OnemailAddressChanging(string value);
    partial void OnemailAddressChanged();
    partial void OnvalidationCodeChanging(string value);
    partial void OnvalidationCodeChanged();
    partial void OnaddressValidatedChanging(bool value);
    partial void OnaddressValidatedChanged();
    partial void OndateSubscribedChanging(System.Nullable<System.DateTime> value);
    partial void OndateSubscribedChanged();
    #endregion
		
		public EmailSubscriber()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="Int")]
		public System.Nullable<int> userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailAddress", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string emailAddress
		{
			get
			{
				return this._emailAddress;
			}
			set
			{
				if ((this._emailAddress != value))
				{
					this.OnemailAddressChanging(value);
					this.SendPropertyChanging();
					this._emailAddress = value;
					this.SendPropertyChanged("emailAddress");
					this.OnemailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_validationCode", DbType="NVarChar(128)")]
		public string validationCode
		{
			get
			{
				return this._validationCode;
			}
			set
			{
				if ((this._validationCode != value))
				{
					this.OnvalidationCodeChanging(value);
					this.SendPropertyChanging();
					this._validationCode = value;
					this.SendPropertyChanged("validationCode");
					this.OnvalidationCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_addressValidated", DbType="Bit NOT NULL")]
		public bool addressValidated
		{
			get
			{
				return this._addressValidated;
			}
			set
			{
				if ((this._addressValidated != value))
				{
					this.OnaddressValidatedChanging(value);
					this.SendPropertyChanging();
					this._addressValidated = value;
					this.SendPropertyChanged("addressValidated");
					this.OnaddressValidatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateSubscribed", DbType="DateTime")]
		public System.Nullable<System.DateTime> dateSubscribed
		{
			get
			{
				return this._dateSubscribed;
			}
			set
			{
				if ((this._dateSubscribed != value))
				{
					this.OndateSubscribedChanging(value);
					this.SendPropertyChanging();
					this._dateSubscribed = value;
					this.SendPropertyChanged("dateSubscribed");
					this.OndateSubscribedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_EmailSubscriber", Storage="_User", ThisKey="userId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.EmailSubscribers.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.EmailSubscribers.Add(this);
						this._userId = value.Id;
					}
					else
					{
						this._userId = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private System.DateTime _DateCreated;
		
		private System.Nullable<bool> _validated;
		
		private string _ValidationCode;
		
		private System.Nullable<System.DateTime> _VCUpdated;
		
		private EntitySet<Session> _Sessions;
		
		private EntitySet<EmailSubscriber> _EmailSubscribers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnvalidatedChanging(System.Nullable<bool> value);
    partial void OnvalidatedChanged();
    partial void OnValidationCodeChanging(string value);
    partial void OnValidationCodeChanged();
    partial void OnVCUpdatedChanging(System.Nullable<System.DateTime> value);
    partial void OnVCUpdatedChanged();
    #endregion
		
		public User()
		{
			this._Sessions = new EntitySet<Session>(new Action<Session>(this.attach_Sessions), new Action<Session>(this.detach_Sessions));
			this._EmailSubscribers = new EntitySet<EmailSubscriber>(new Action<EmailSubscriber>(this.attach_EmailSubscribers), new Action<EmailSubscriber>(this.detach_EmailSubscribers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="SmallDateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_validated", DbType="Bit")]
		public System.Nullable<bool> validated
		{
			get
			{
				return this._validated;
			}
			set
			{
				if ((this._validated != value))
				{
					this.OnvalidatedChanging(value);
					this.SendPropertyChanging();
					this._validated = value;
					this.SendPropertyChanged("validated");
					this.OnvalidatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidationCode", DbType="NVarChar(255)")]
		public string ValidationCode
		{
			get
			{
				return this._ValidationCode;
			}
			set
			{
				if ((this._ValidationCode != value))
				{
					this.OnValidationCodeChanging(value);
					this.SendPropertyChanging();
					this._ValidationCode = value;
					this.SendPropertyChanged("ValidationCode");
					this.OnValidationCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VCUpdated", DbType="DateTime")]
		public System.Nullable<System.DateTime> VCUpdated
		{
			get
			{
				return this._VCUpdated;
			}
			set
			{
				if ((this._VCUpdated != value))
				{
					this.OnVCUpdatedChanging(value);
					this.SendPropertyChanging();
					this._VCUpdated = value;
					this.SendPropertyChanged("VCUpdated");
					this.OnVCUpdatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Session", Storage="_Sessions", ThisKey="Id", OtherKey="userId")]
		public EntitySet<Session> Sessions
		{
			get
			{
				return this._Sessions;
			}
			set
			{
				this._Sessions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_EmailSubscriber", Storage="_EmailSubscribers", ThisKey="Id", OtherKey="userId")]
		public EntitySet<EmailSubscriber> EmailSubscribers
		{
			get
			{
				return this._EmailSubscribers;
			}
			set
			{
				this._EmailSubscribers.Assign(value);
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
		
		private void attach_Sessions(Session entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Sessions(Session entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_EmailSubscribers(EmailSubscriber entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_EmailSubscribers(EmailSubscriber entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
