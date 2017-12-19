﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsOferta {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsOferta.ServiceOferta")]
    public interface ServiceOferta {
        
        // CODEGEN: El parámetro 'oferta' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/agregarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/agregarOfertaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsOferta.agregarOfertaResponse agregarOferta(SushiApp.wsOferta.agregarOfertaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/agregarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/agregarOfertaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOferta.agregarOfertaResponse> agregarOfertaAsync(SushiApp.wsOferta.agregarOfertaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/obtenerOfertaRequest", ReplyAction="http://WebService/ServiceOferta/obtenerOfertaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsOferta.obtenerOfertaResponse obtenerOferta(SushiApp.wsOferta.obtenerOfertaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/obtenerOfertaRequest", ReplyAction="http://WebService/ServiceOferta/obtenerOfertaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOferta.obtenerOfertaResponse> obtenerOfertaAsync(SushiApp.wsOferta.obtenerOfertaRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/eliminarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/eliminarOfertaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsOferta.eliminarOfertaResponse eliminarOferta(SushiApp.wsOferta.eliminarOfertaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/eliminarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/eliminarOfertaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOferta.eliminarOfertaResponse> eliminarOfertaAsync(SushiApp.wsOferta.eliminarOfertaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/buscarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/buscarOfertaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsOferta.buscarOfertaResponse buscarOferta(SushiApp.wsOferta.buscarOfertaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/buscarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/buscarOfertaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOferta.buscarOfertaResponse> buscarOfertaAsync(SushiApp.wsOferta.buscarOfertaRequest request);
        
        // CODEGEN: El parámetro 'oferta' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/modificarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/modificarOfertaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsOferta.modificarOfertaResponse modificarOferta(SushiApp.wsOferta.modificarOfertaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOferta/modificarOfertaRequest", ReplyAction="http://WebService/ServiceOferta/modificarOfertaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOferta.modificarOfertaResponse> modificarOfertaAsync(SushiApp.wsOferta.modificarOfertaRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class oferta : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fechaInicioField;
        
        private string fechaTerminoField;
        
        private int ofertaIdField;
        
        private double porcentajeOfertaField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string fechaInicio {
            get {
                return this.fechaInicioField;
            }
            set {
                this.fechaInicioField = value;
                this.RaisePropertyChanged("fechaInicio");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string fechaTermino {
            get {
                return this.fechaTerminoField;
            }
            set {
                this.fechaTerminoField = value;
                this.RaisePropertyChanged("fechaTermino");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int ofertaId {
            get {
                return this.ofertaIdField;
            }
            set {
                this.ofertaIdField = value;
                this.RaisePropertyChanged("ofertaId");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double porcentajeOferta {
            get {
                return this.porcentajeOfertaField;
            }
            set {
                this.porcentajeOfertaField = value;
                this.RaisePropertyChanged("porcentajeOferta");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarOferta", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarOfertaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOferta.oferta oferta;
        
        public agregarOfertaRequest() {
        }
        
        public agregarOfertaRequest(SushiApp.wsOferta.oferta oferta) {
            this.oferta = oferta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarOfertaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarOfertaResponse {
        
        public agregarOfertaResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerOferta", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerOfertaRequest {
        
        public obtenerOfertaRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerOfertaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerOfertaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOferta.oferta[] @return;
        
        public obtenerOfertaResponse() {
        }
        
        public obtenerOfertaResponse(SushiApp.wsOferta.oferta[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarOferta", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarOfertaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarOfertaRequest() {
        }
        
        public eliminarOfertaRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarOfertaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarOfertaResponse {
        
        public eliminarOfertaResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarOferta", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarOfertaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarOfertaRequest() {
        }
        
        public buscarOfertaRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarOfertaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarOfertaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOferta.oferta @return;
        
        public buscarOfertaResponse() {
        }
        
        public buscarOfertaResponse(SushiApp.wsOferta.oferta @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarOferta", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarOfertaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOferta.oferta oferta;
        
        public modificarOfertaRequest() {
        }
        
        public modificarOfertaRequest(SushiApp.wsOferta.oferta oferta) {
            this.oferta = oferta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarOfertaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarOfertaResponse {
        
        public modificarOfertaResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceOfertaChannel : SushiApp.wsOferta.ServiceOferta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceOfertaClient : System.ServiceModel.ClientBase<SushiApp.wsOferta.ServiceOferta>, SushiApp.wsOferta.ServiceOferta {
        
        public ServiceOfertaClient() {
        }
        
        public ServiceOfertaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceOfertaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOfertaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOfertaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOferta.agregarOfertaResponse SushiApp.wsOferta.ServiceOferta.agregarOferta(SushiApp.wsOferta.agregarOfertaRequest request) {
            return base.Channel.agregarOferta(request);
        }
        
        public void agregarOferta(SushiApp.wsOferta.oferta oferta) {
            SushiApp.wsOferta.agregarOfertaRequest inValue = new SushiApp.wsOferta.agregarOfertaRequest();
            inValue.oferta = oferta;
            SushiApp.wsOferta.agregarOfertaResponse retVal = ((SushiApp.wsOferta.ServiceOferta)(this)).agregarOferta(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOferta.agregarOfertaResponse> SushiApp.wsOferta.ServiceOferta.agregarOfertaAsync(SushiApp.wsOferta.agregarOfertaRequest request) {
            return base.Channel.agregarOfertaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOferta.agregarOfertaResponse> agregarOfertaAsync(SushiApp.wsOferta.oferta oferta) {
            SushiApp.wsOferta.agregarOfertaRequest inValue = new SushiApp.wsOferta.agregarOfertaRequest();
            inValue.oferta = oferta;
            return ((SushiApp.wsOferta.ServiceOferta)(this)).agregarOfertaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOferta.obtenerOfertaResponse SushiApp.wsOferta.ServiceOferta.obtenerOferta(SushiApp.wsOferta.obtenerOfertaRequest request) {
            return base.Channel.obtenerOferta(request);
        }
        
        public SushiApp.wsOferta.oferta[] obtenerOferta() {
            SushiApp.wsOferta.obtenerOfertaRequest inValue = new SushiApp.wsOferta.obtenerOfertaRequest();
            SushiApp.wsOferta.obtenerOfertaResponse retVal = ((SushiApp.wsOferta.ServiceOferta)(this)).obtenerOferta(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOferta.obtenerOfertaResponse> SushiApp.wsOferta.ServiceOferta.obtenerOfertaAsync(SushiApp.wsOferta.obtenerOfertaRequest request) {
            return base.Channel.obtenerOfertaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOferta.obtenerOfertaResponse> obtenerOfertaAsync() {
            SushiApp.wsOferta.obtenerOfertaRequest inValue = new SushiApp.wsOferta.obtenerOfertaRequest();
            return ((SushiApp.wsOferta.ServiceOferta)(this)).obtenerOfertaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOferta.eliminarOfertaResponse SushiApp.wsOferta.ServiceOferta.eliminarOferta(SushiApp.wsOferta.eliminarOfertaRequest request) {
            return base.Channel.eliminarOferta(request);
        }
        
        public void eliminarOferta(int id) {
            SushiApp.wsOferta.eliminarOfertaRequest inValue = new SushiApp.wsOferta.eliminarOfertaRequest();
            inValue.id = id;
            SushiApp.wsOferta.eliminarOfertaResponse retVal = ((SushiApp.wsOferta.ServiceOferta)(this)).eliminarOferta(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOferta.eliminarOfertaResponse> SushiApp.wsOferta.ServiceOferta.eliminarOfertaAsync(SushiApp.wsOferta.eliminarOfertaRequest request) {
            return base.Channel.eliminarOfertaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOferta.eliminarOfertaResponse> eliminarOfertaAsync(int id) {
            SushiApp.wsOferta.eliminarOfertaRequest inValue = new SushiApp.wsOferta.eliminarOfertaRequest();
            inValue.id = id;
            return ((SushiApp.wsOferta.ServiceOferta)(this)).eliminarOfertaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOferta.buscarOfertaResponse SushiApp.wsOferta.ServiceOferta.buscarOferta(SushiApp.wsOferta.buscarOfertaRequest request) {
            return base.Channel.buscarOferta(request);
        }
        
        public SushiApp.wsOferta.oferta buscarOferta(int id) {
            SushiApp.wsOferta.buscarOfertaRequest inValue = new SushiApp.wsOferta.buscarOfertaRequest();
            inValue.id = id;
            SushiApp.wsOferta.buscarOfertaResponse retVal = ((SushiApp.wsOferta.ServiceOferta)(this)).buscarOferta(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOferta.buscarOfertaResponse> SushiApp.wsOferta.ServiceOferta.buscarOfertaAsync(SushiApp.wsOferta.buscarOfertaRequest request) {
            return base.Channel.buscarOfertaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOferta.buscarOfertaResponse> buscarOfertaAsync(int id) {
            SushiApp.wsOferta.buscarOfertaRequest inValue = new SushiApp.wsOferta.buscarOfertaRequest();
            inValue.id = id;
            return ((SushiApp.wsOferta.ServiceOferta)(this)).buscarOfertaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOferta.modificarOfertaResponse SushiApp.wsOferta.ServiceOferta.modificarOferta(SushiApp.wsOferta.modificarOfertaRequest request) {
            return base.Channel.modificarOferta(request);
        }
        
        public void modificarOferta(SushiApp.wsOferta.oferta oferta) {
            SushiApp.wsOferta.modificarOfertaRequest inValue = new SushiApp.wsOferta.modificarOfertaRequest();
            inValue.oferta = oferta;
            SushiApp.wsOferta.modificarOfertaResponse retVal = ((SushiApp.wsOferta.ServiceOferta)(this)).modificarOferta(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOferta.modificarOfertaResponse> SushiApp.wsOferta.ServiceOferta.modificarOfertaAsync(SushiApp.wsOferta.modificarOfertaRequest request) {
            return base.Channel.modificarOfertaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOferta.modificarOfertaResponse> modificarOfertaAsync(SushiApp.wsOferta.oferta oferta) {
            SushiApp.wsOferta.modificarOfertaRequest inValue = new SushiApp.wsOferta.modificarOfertaRequest();
            inValue.oferta = oferta;
            return ((SushiApp.wsOferta.ServiceOferta)(this)).modificarOfertaAsync(inValue);
        }
    }
}
