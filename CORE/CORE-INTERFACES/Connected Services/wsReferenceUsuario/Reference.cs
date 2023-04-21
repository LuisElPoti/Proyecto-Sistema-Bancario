﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CoreServices;

namespace CORE_INTERFACES.wsReferenceUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReferenceUsuario.IWSUsuario")]
    public interface IWSUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/CrearUsuario", ReplyAction="http://tempuri.org/IWSUsuario/CrearUsuarioResponse")]
        bool CrearUsuario(int idPerfil, int idCliente, string nombre, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/CrearUsuario", ReplyAction="http://tempuri.org/IWSUsuario/CrearUsuarioResponse")]
        System.Threading.Tasks.Task<bool> CrearUsuarioAsync(int idPerfil, int idCliente, string nombre, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/EliminarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/EliminarUsuarioResponse")]
        bool EliminarUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/EliminarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> EliminarUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ActualizarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/ActualizarUsuarioResponse")]
        bool ActualizarUsuario(int idUsuario, int idPerfil, int idCliente, string nombre, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ActualizarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/ActualizarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> ActualizarUsuarioAsync(int idUsuario, int idPerfil, int idCliente, string nombre, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ValidarSeguridad", ReplyAction="http://tempuri.org/IWSUsuario/ValidarSeguridadResponse")]
        bool ValidarSeguridad(string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ValidarSeguridad", ReplyAction="http://tempuri.org/IWSUsuario/ValidarSeguridadResponse")]
        System.Threading.Tasks.Task<bool> ValidarSeguridadAsync(string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ValidarSesion", ReplyAction="http://tempuri.org/IWSUsuario/ValidarSesionResponse")]
        bool ValidarSesion(string nombre, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ValidarSesion", ReplyAction="http://tempuri.org/IWSUsuario/ValidarSesionResponse")]
        System.Threading.Tasks.Task<bool> ValidarSesionAsync(string nombre, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/MostrarUsuarios", ReplyAction="http://tempuri.org/IWSUsuario/MostrarUsuariosResponse")]
        System.Data.DataTable MostrarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/MostrarUsuarios", ReplyAction="http://tempuri.org/IWSUsuario/MostrarUsuariosResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> MostrarUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/BuscarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/BuscarUsuarioResponse")]
        System.Collections.Generic.List<Cliente> BuscarUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/BuscarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/BuscarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Cliente>> BuscarUsuarioAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSUsuarioChannel : CORE_INTERFACES.wsReferenceUsuario.IWSUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSUsuarioClient : System.ServiceModel.ClientBase<CORE_INTERFACES.wsReferenceUsuario.IWSUsuario>, CORE_INTERFACES.wsReferenceUsuario.IWSUsuario {
        
        public WSUsuarioClient() {
        }
        
        public WSUsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSUsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CrearUsuario(int idPerfil, int idCliente, string nombre, string clave) {
            return base.Channel.CrearUsuario(idPerfil, idCliente, nombre, clave);
        }
        
        public System.Threading.Tasks.Task<bool> CrearUsuarioAsync(int idPerfil, int idCliente, string nombre, string clave) {
            return base.Channel.CrearUsuarioAsync(idPerfil, idCliente, nombre, clave);
        }
        
        public bool EliminarUsuario(int id) {
            return base.Channel.EliminarUsuario(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarUsuarioAsync(int id) {
            return base.Channel.EliminarUsuarioAsync(id);
        }
        
        public bool ActualizarUsuario(int idUsuario, int idPerfil, int idCliente, string nombre, string clave) {
            return base.Channel.ActualizarUsuario(idUsuario, idPerfil, idCliente, nombre, clave);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarUsuarioAsync(int idUsuario, int idPerfil, int idCliente, string nombre, string clave) {
            return base.Channel.ActualizarUsuarioAsync(idUsuario, idPerfil, idCliente, nombre, clave);
        }
        
        public bool ValidarSeguridad(string clave) {
            return base.Channel.ValidarSeguridad(clave);
        }
        
        public System.Threading.Tasks.Task<bool> ValidarSeguridadAsync(string clave) {
            return base.Channel.ValidarSeguridadAsync(clave);
        }
        
        public bool ValidarSesion(string nombre, string clave) {
            return base.Channel.ValidarSesion(nombre, clave);
        }
        
        public System.Threading.Tasks.Task<bool> ValidarSesionAsync(string nombre, string clave) {
            return base.Channel.ValidarSesionAsync(nombre, clave);
        }
        
        public System.Data.DataTable MostrarUsuarios() {
            return base.Channel.MostrarUsuarios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> MostrarUsuariosAsync() {
            return base.Channel.MostrarUsuariosAsync();
        }
        
        public System.Collections.Generic.List<Cliente> BuscarUsuario(int id) {
            return base.Channel.BuscarUsuario(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Cliente>> BuscarUsuarioAsync(int id) {
            return base.Channel.BuscarUsuarioAsync(id);
        }
    }
}
