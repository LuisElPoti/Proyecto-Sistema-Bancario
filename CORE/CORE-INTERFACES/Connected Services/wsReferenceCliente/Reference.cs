﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CORE_INTERFACES.wsReferenceCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReferenceCliente.IWSCliente")]
    public interface IWSCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/AgregarCliente", ReplyAction="http://tempuri.org/IWSCliente/AgregarClienteResponse")]
        void AgregarCliente(string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/AgregarCliente", ReplyAction="http://tempuri.org/IWSCliente/AgregarClienteResponse")]
        System.Threading.Tasks.Task AgregarClienteAsync(string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/EliminarCliente", ReplyAction="http://tempuri.org/IWSCliente/EliminarClienteResponse")]
        void EliminarCliente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/EliminarCliente", ReplyAction="http://tempuri.org/IWSCliente/EliminarClienteResponse")]
        System.Threading.Tasks.Task EliminarClienteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/ModificarCliente", ReplyAction="http://tempuri.org/IWSCliente/ModificarClienteResponse")]
        void ModificarCliente(int id, string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/ModificarCliente", ReplyAction="http://tempuri.org/IWSCliente/ModificarClienteResponse")]
        System.Threading.Tasks.Task ModificarClienteAsync(int id, string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/MostrarCliente", ReplyAction="http://tempuri.org/IWSCliente/MostrarClienteResponse")]
        void MostrarCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/MostrarCliente", ReplyAction="http://tempuri.org/IWSCliente/MostrarClienteResponse")]
        System.Threading.Tasks.Task MostrarClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/BuscarCliente", ReplyAction="http://tempuri.org/IWSCliente/BuscarClienteResponse")]
        void BuscarCliente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSCliente/BuscarCliente", ReplyAction="http://tempuri.org/IWSCliente/BuscarClienteResponse")]
        System.Threading.Tasks.Task BuscarClienteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSClienteChannel : CORE_INTERFACES.wsReferenceCliente.IWSCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSClienteClient : System.ServiceModel.ClientBase<CORE_INTERFACES.wsReferenceCliente.IWSCliente>, CORE_INTERFACES.wsReferenceCliente.IWSCliente {
        
        public WSClienteClient() {
        }
        
        public WSClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AgregarCliente(string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento) {
            base.Channel.AgregarCliente(Nombre, TipoDocumento, Documento, Correo, Telefono, Direccion, FechaNacimiento);
        }
        
        public System.Threading.Tasks.Task AgregarClienteAsync(string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento) {
            return base.Channel.AgregarClienteAsync(Nombre, TipoDocumento, Documento, Correo, Telefono, Direccion, FechaNacimiento);
        }
        
        public void EliminarCliente(int id) {
            base.Channel.EliminarCliente(id);
        }
        
        public System.Threading.Tasks.Task EliminarClienteAsync(int id) {
            return base.Channel.EliminarClienteAsync(id);
        }
        
        public void ModificarCliente(int id, string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento) {
            base.Channel.ModificarCliente(id, Nombre, TipoDocumento, Documento, Correo, Telefono, Direccion, FechaNacimiento);
        }
        
        public System.Threading.Tasks.Task ModificarClienteAsync(int id, string Nombre, int TipoDocumento, string Documento, string Correo, string Telefono, string Direccion, System.DateTime FechaNacimiento) {
            return base.Channel.ModificarClienteAsync(id, Nombre, TipoDocumento, Documento, Correo, Telefono, Direccion, FechaNacimiento);
        }
        
        public void MostrarCliente() {
            base.Channel.MostrarCliente();
        }
        
        public System.Threading.Tasks.Task MostrarClienteAsync() {
            return base.Channel.MostrarClienteAsync();
        }
        
        public void BuscarCliente(int id) {
            base.Channel.BuscarCliente(id);
        }
        
        public System.Threading.Tasks.Task BuscarClienteAsync(int id) {
            return base.Channel.BuscarClienteAsync(id);
        }
    }
}
