﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinopoiskMVC.FilmsServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Film", Namespace="http://schemas.datacontract.org/2004/07/DAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Film : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Actor> ActorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FilmIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Genre> GenresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalTitileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Actor> Actors {
            get {
                return this.ActorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ActorsField, value) != true)) {
                    this.ActorsField = value;
                    this.RaisePropertyChanged("Actors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FilmID {
            get {
                return this.FilmIDField;
            }
            set {
                if ((this.FilmIDField.Equals(value) != true)) {
                    this.FilmIDField = value;
                    this.RaisePropertyChanged("FilmID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Genre> Genres {
            get {
                return this.GenresField;
            }
            set {
                if ((object.ReferenceEquals(this.GenresField, value) != true)) {
                    this.GenresField = value;
                    this.RaisePropertyChanged("Genres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalTitile {
            get {
                return this.OriginalTitileField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalTitileField, value) != true)) {
                    this.OriginalTitileField = value;
                    this.RaisePropertyChanged("OriginalTitile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Actor", Namespace="http://schemas.datacontract.org/2004/07/DAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Actor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> FilmsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ActorID {
            get {
                return this.ActorIDField;
            }
            set {
                if ((this.ActorIDField.Equals(value) != true)) {
                    this.ActorIDField = value;
                    this.RaisePropertyChanged("ActorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> Films {
            get {
                return this.FilmsField;
            }
            set {
                if ((object.ReferenceEquals(this.FilmsField, value) != true)) {
                    this.FilmsField = value;
                    this.RaisePropertyChanged("Films");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Genre", Namespace="http://schemas.datacontract.org/2004/07/DAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Genre : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> FilmsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenreIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> Films {
            get {
                return this.FilmsField;
            }
            set {
                if ((object.ReferenceEquals(this.FilmsField, value) != true)) {
                    this.FilmsField = value;
                    this.RaisePropertyChanged("Films");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GenreID {
            get {
                return this.GenreIDField;
            }
            set {
                if ((this.GenreIDField.Equals(value) != true)) {
                    this.GenreIDField = value;
                    this.RaisePropertyChanged("GenreID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalTitle {
            get {
                return this.OriginalTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalTitleField, value) != true)) {
                    this.OriginalTitleField = value;
                    this.RaisePropertyChanged("OriginalTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FilmsServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectFilms", ReplyAction="http://tempuri.org/IService/SelectFilmsResponse")]
        System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> SelectFilms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddFilm", ReplyAction="http://tempuri.org/IService/AddFilmResponse")]
        bool AddFilm(KinopoiskMVC.FilmsServiceReference.Film film);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateFilm", ReplyAction="http://tempuri.org/IService/UpdateFilmResponse")]
        bool UpdateFilm(KinopoiskMVC.FilmsServiceReference.Film film);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteFilm", ReplyAction="http://tempuri.org/IService/DeleteFilmResponse")]
        bool DeleteFilm(int filmId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectGenres", ReplyAction="http://tempuri.org/IService/SelectGenresResponse")]
        System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Genre> SelectGenres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectFilmsByGenreId", ReplyAction="http://tempuri.org/IService/SelectFilmsByGenreIdResponse")]
        System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> SelectFilmsByGenreId(int genreId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : KinopoiskMVC.FilmsServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<KinopoiskMVC.FilmsServiceReference.IService>, KinopoiskMVC.FilmsServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> SelectFilms() {
            return base.Channel.SelectFilms();
        }
        
        public bool AddFilm(KinopoiskMVC.FilmsServiceReference.Film film) {
            return base.Channel.AddFilm(film);
        }
        
        public bool UpdateFilm(KinopoiskMVC.FilmsServiceReference.Film film) {
            return base.Channel.UpdateFilm(film);
        }
        
        public bool DeleteFilm(int filmId) {
            return base.Channel.DeleteFilm(filmId);
        }
        
        public System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Genre> SelectGenres() {
            return base.Channel.SelectGenres();
        }
        
        public System.Collections.Generic.List<KinopoiskMVC.FilmsServiceReference.Film> SelectFilmsByGenreId(int genreId) {
            return base.Channel.SelectFilmsByGenreId(genreId);
        }
    }
}
