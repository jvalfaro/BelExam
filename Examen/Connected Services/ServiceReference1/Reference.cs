﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IExamenService")]
    public interface IExamenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExamenService/ListarProductos", ReplyAction="http://tempuri.org/IExamenService/ListarProductosResponse")]
        Examen.BE.Producto[] ListarProductos(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExamenService/ListarProductos", ReplyAction="http://tempuri.org/IExamenService/ListarProductosResponse")]
        System.Threading.Tasks.Task<Examen.BE.Producto[]> ListarProductosAsync(string nombre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExamenServiceChannel : Examen.ServiceReference1.IExamenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExamenServiceClient : System.ServiceModel.ClientBase<Examen.ServiceReference1.IExamenService>, Examen.ServiceReference1.IExamenService {
        
        public ExamenServiceClient() {
        }
        
        public ExamenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExamenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExamenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExamenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Examen.BE.Producto[] ListarProductos(string nombre) {
            return base.Channel.ListarProductos(nombre);
        }
        
        public System.Threading.Tasks.Task<Examen.BE.Producto[]> ListarProductosAsync(string nombre) {
            return base.Channel.ListarProductosAsync(nombre);
        }
    }
}
