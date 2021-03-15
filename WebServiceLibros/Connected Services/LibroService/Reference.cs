﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceLibros.LibroService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibroService.LibrosSoap")]
    public interface LibrosSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lista", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Lista();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lista", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Eliminar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> EliminarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet addBook(string Titulo, string Autor, double Precio, string Fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addBook", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> addBookAsync(string Titulo, string Autor, double Precio, string Fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getOneBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getOneBook(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getOneBook", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getOneBookAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet updateBook(int Id, string Titulo, string Autor, double Precio, string Fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateBook", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> updateBookAsync(int Id, string Titulo, string Autor, double Precio, string Fecha);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LibrosSoapChannel : WebServiceLibros.LibroService.LibrosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibrosSoapClient : System.ServiceModel.ClientBase<WebServiceLibros.LibroService.LibrosSoap>, WebServiceLibros.LibroService.LibrosSoap {
        
        public LibrosSoapClient() {
        }
        
        public LibrosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibrosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibrosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibrosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Lista() {
            return base.Channel.Lista();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListaAsync() {
            return base.Channel.ListaAsync();
        }
        
        public System.Data.DataSet Eliminar(int id) {
            return base.Channel.Eliminar(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> EliminarAsync(int id) {
            return base.Channel.EliminarAsync(id);
        }
        
        public System.Data.DataSet addBook(string Titulo, string Autor, double Precio, string Fecha) {
            return base.Channel.addBook(Titulo, Autor, Precio, Fecha);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> addBookAsync(string Titulo, string Autor, double Precio, string Fecha) {
            return base.Channel.addBookAsync(Titulo, Autor, Precio, Fecha);
        }
        
        public System.Data.DataSet getOneBook(int Id) {
            return base.Channel.getOneBook(Id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getOneBookAsync(int Id) {
            return base.Channel.getOneBookAsync(Id);
        }
        
        public System.Data.DataSet updateBook(int Id, string Titulo, string Autor, double Precio, string Fecha) {
            return base.Channel.updateBook(Id, Titulo, Autor, Precio, Fecha);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> updateBookAsync(int Id, string Titulo, string Autor, double Precio, string Fecha) {
            return base.Channel.updateBookAsync(Id, Titulo, Autor, Precio, Fecha);
        }
    }
}