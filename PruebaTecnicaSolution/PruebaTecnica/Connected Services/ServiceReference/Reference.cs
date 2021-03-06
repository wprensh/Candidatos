﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaTecnica.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IPtWcf")]
    public interface IPtWcf {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/NuevaEntrevista", ReplyAction="http://tempuri.org/IPtWcf/NuevaEntrevistaResponse")]
        bool NuevaEntrevista(PruebaTecnicaLibrary.Vo.Entrevista entrevista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/NuevaEntrevista", ReplyAction="http://tempuri.org/IPtWcf/NuevaEntrevistaResponse")]
        System.Threading.Tasks.Task<bool> NuevaEntrevistaAsync(PruebaTecnicaLibrary.Vo.Entrevista entrevista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/EditarEntrevista", ReplyAction="http://tempuri.org/IPtWcf/EditarEntrevistaResponse")]
        bool EditarEntrevista(PruebaTecnicaLibrary.Vo.Entrevista entrevista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/EditarEntrevista", ReplyAction="http://tempuri.org/IPtWcf/EditarEntrevistaResponse")]
        System.Threading.Tasks.Task<bool> EditarEntrevistaAsync(PruebaTecnicaLibrary.Vo.Entrevista entrevista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerReclutadores", ReplyAction="http://tempuri.org/IPtWcf/ObtenerReclutadoresResponse")]
        PruebaTecnicaLibrary.Vo.Reclutadore[] ObtenerReclutadores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerReclutadores", ReplyAction="http://tempuri.org/IPtWcf/ObtenerReclutadoresResponse")]
        System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.Reclutadore[]> ObtenerReclutadoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerCandidatos", ReplyAction="http://tempuri.org/IPtWcf/ObtenerCandidatosResponse")]
        PruebaTecnicaLibrary.Vo.MyJsonData[] ObtenerCandidatos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerCandidatos", ReplyAction="http://tempuri.org/IPtWcf/ObtenerCandidatosResponse")]
        System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.MyJsonData[]> ObtenerCandidatosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerEntrevistas", ReplyAction="http://tempuri.org/IPtWcf/ObtenerEntrevistasResponse")]
        PruebaTecnicaLibrary.Vo.Entrevista[] ObtenerEntrevistas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerEntrevistas", ReplyAction="http://tempuri.org/IPtWcf/ObtenerEntrevistasResponse")]
        System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.Entrevista[]> ObtenerEntrevistasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerTecnologias", ReplyAction="http://tempuri.org/IPtWcf/ObtenerTecnologiasResponse")]
        PruebaTecnicaLibrary.Vo.Tecnologia[] ObtenerTecnologias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerTecnologias", ReplyAction="http://tempuri.org/IPtWcf/ObtenerTecnologiasResponse")]
        System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.Tecnologia[]> ObtenerTecnologiasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerTipoTecnologias", ReplyAction="http://tempuri.org/IPtWcf/ObtenerTipoTecnologiasResponse")]
        PruebaTecnicaLibrary.Vo.TipoTecnologia[] ObtenerTipoTecnologias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPtWcf/ObtenerTipoTecnologias", ReplyAction="http://tempuri.org/IPtWcf/ObtenerTipoTecnologiasResponse")]
        System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.TipoTecnologia[]> ObtenerTipoTecnologiasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPtWcfChannel : PruebaTecnica.ServiceReference.IPtWcf, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PtWcfClient : System.ServiceModel.ClientBase<PruebaTecnica.ServiceReference.IPtWcf>, PruebaTecnica.ServiceReference.IPtWcf {
        
        public PtWcfClient() {
        }
        
        public PtWcfClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PtWcfClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PtWcfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PtWcfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool NuevaEntrevista(PruebaTecnicaLibrary.Vo.Entrevista entrevista) {
            return base.Channel.NuevaEntrevista(entrevista);
        }
        
        public System.Threading.Tasks.Task<bool> NuevaEntrevistaAsync(PruebaTecnicaLibrary.Vo.Entrevista entrevista) {
            return base.Channel.NuevaEntrevistaAsync(entrevista);
        }
        
        public bool EditarEntrevista(PruebaTecnicaLibrary.Vo.Entrevista entrevista) {
            return base.Channel.EditarEntrevista(entrevista);
        }
        
        public System.Threading.Tasks.Task<bool> EditarEntrevistaAsync(PruebaTecnicaLibrary.Vo.Entrevista entrevista) {
            return base.Channel.EditarEntrevistaAsync(entrevista);
        }
        
        public PruebaTecnicaLibrary.Vo.Reclutadore[] ObtenerReclutadores() {
            return base.Channel.ObtenerReclutadores();
        }
        
        public System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.Reclutadore[]> ObtenerReclutadoresAsync() {
            return base.Channel.ObtenerReclutadoresAsync();
        }
        
        public PruebaTecnicaLibrary.Vo.MyJsonData[] ObtenerCandidatos() {
            return base.Channel.ObtenerCandidatos();
        }
        
        public System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.MyJsonData[]> ObtenerCandidatosAsync() {
            return base.Channel.ObtenerCandidatosAsync();
        }
        
        public PruebaTecnicaLibrary.Vo.Entrevista[] ObtenerEntrevistas() {
            return base.Channel.ObtenerEntrevistas();
        }
        
        public System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.Entrevista[]> ObtenerEntrevistasAsync() {
            return base.Channel.ObtenerEntrevistasAsync();
        }
        
        public PruebaTecnicaLibrary.Vo.Tecnologia[] ObtenerTecnologias() {
            return base.Channel.ObtenerTecnologias();
        }
        
        public System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.Tecnologia[]> ObtenerTecnologiasAsync() {
            return base.Channel.ObtenerTecnologiasAsync();
        }
        
        public PruebaTecnicaLibrary.Vo.TipoTecnologia[] ObtenerTipoTecnologias() {
            return base.Channel.ObtenerTipoTecnologias();
        }
        
        public System.Threading.Tasks.Task<PruebaTecnicaLibrary.Vo.TipoTecnologia[]> ObtenerTipoTecnologiasAsync() {
            return base.Channel.ObtenerTipoTecnologiasAsync();
        }
    }
}
