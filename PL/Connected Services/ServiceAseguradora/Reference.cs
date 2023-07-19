﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.ServiceAseguradora {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAseguradora.IServiceAseguradora")]
    public interface IServiceAseguradora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAseguradora/Add", ReplyAction="http://tempuri.org/IServiceAseguradora/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Aseguradora))]
        ML.Result Add(ML.Aseguradora aseguradora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAseguradora/Add", ReplyAction="http://tempuri.org/IServiceAseguradora/AddResponse")]
        System.Threading.Tasks.Task<ML.Result> AddAsync(ML.Aseguradora aseguradora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAseguradora/Update", ReplyAction="http://tempuri.org/IServiceAseguradora/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Aseguradora))]
        ML.Result Update(ML.Aseguradora aseguradora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAseguradora/Update", ReplyAction="http://tempuri.org/IServiceAseguradora/UpdateResponse")]
        System.Threading.Tasks.Task<ML.Result> UpdateAsync(ML.Aseguradora aseguradora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAseguradora/Delete", ReplyAction="http://tempuri.org/IServiceAseguradora/DeleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Aseguradora))]
        ML.Result Delete(ML.Aseguradora aseguradora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAseguradora/Delete", ReplyAction="http://tempuri.org/IServiceAseguradora/DeleteResponse")]
        System.Threading.Tasks.Task<ML.Result> DeleteAsync(ML.Aseguradora aseguradora);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAseguradoraChannel : PL.ServiceAseguradora.IServiceAseguradora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAseguradoraClient : System.ServiceModel.ClientBase<PL.ServiceAseguradora.IServiceAseguradora>, PL.ServiceAseguradora.IServiceAseguradora {
        
        public ServiceAseguradoraClient() {
        }
        
        public ServiceAseguradoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAseguradoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAseguradoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAseguradoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ML.Result Add(ML.Aseguradora aseguradora) {
            return base.Channel.Add(aseguradora);
        }
        
        public System.Threading.Tasks.Task<ML.Result> AddAsync(ML.Aseguradora aseguradora) {
            return base.Channel.AddAsync(aseguradora);
        }
        
        public ML.Result Update(ML.Aseguradora aseguradora) {
            return base.Channel.Update(aseguradora);
        }
        
        public System.Threading.Tasks.Task<ML.Result> UpdateAsync(ML.Aseguradora aseguradora) {
            return base.Channel.UpdateAsync(aseguradora);
        }
        
        public ML.Result Delete(ML.Aseguradora aseguradora) {
            return base.Channel.Delete(aseguradora);
        }
        
        public System.Threading.Tasks.Task<ML.Result> DeleteAsync(ML.Aseguradora aseguradora) {
            return base.Channel.DeleteAsync(aseguradora);
        }
    }
}