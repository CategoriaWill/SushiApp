﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsProvincia {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsProvincia.ServiceProvincia")]
    public interface ServiceProvincia {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/buscarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/buscarProvinciaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsProvincia.buscarProvinciaResponse buscarProvincia(SushiApp.wsProvincia.buscarProvinciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/buscarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/buscarProvinciaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.buscarProvinciaResponse> buscarProvinciaAsync(SushiApp.wsProvincia.buscarProvinciaRequest request);
        
        // CODEGEN: El parámetro 'provincia' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/agregarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/agregarProvinciaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsProvincia.agregarProvinciaResponse agregarProvincia(SushiApp.wsProvincia.agregarProvinciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/agregarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/agregarProvinciaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.agregarProvinciaResponse> agregarProvinciaAsync(SushiApp.wsProvincia.agregarProvinciaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/obtenerProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/obtenerProvinciaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsProvincia.obtenerProvinciaResponse obtenerProvincia(SushiApp.wsProvincia.obtenerProvinciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/obtenerProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/obtenerProvinciaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.obtenerProvinciaResponse> obtenerProvinciaAsync(SushiApp.wsProvincia.obtenerProvinciaRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/eliminarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/eliminarProvinciaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsProvincia.eliminarProvinciaResponse eliminarProvincia(SushiApp.wsProvincia.eliminarProvinciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/eliminarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/eliminarProvinciaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.eliminarProvinciaResponse> eliminarProvinciaAsync(SushiApp.wsProvincia.eliminarProvinciaRequest request);
        
        // CODEGEN: El parámetro 'provincia' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/modificarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/modificarProvinciaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsProvincia.modificarProvinciaResponse modificarProvincia(SushiApp.wsProvincia.modificarProvinciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProvincia/modificarProvinciaRequest", ReplyAction="http://WebService/ServiceProvincia/modificarProvinciaResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.modificarProvinciaResponse> modificarProvinciaAsync(SushiApp.wsProvincia.modificarProvinciaRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class provincia : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int provinciaIdField;
        
        private string provinciaNombreField;
        
        private int regionIdField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int provinciaId {
            get {
                return this.provinciaIdField;
            }
            set {
                this.provinciaIdField = value;
                this.RaisePropertyChanged("provinciaId");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string provinciaNombre {
            get {
                return this.provinciaNombreField;
            }
            set {
                this.provinciaNombreField = value;
                this.RaisePropertyChanged("provinciaNombre");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int regionId {
            get {
                return this.regionIdField;
            }
            set {
                this.regionIdField = value;
                this.RaisePropertyChanged("regionId");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarProvincia", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarProvinciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarProvinciaRequest() {
        }
        
        public buscarProvinciaRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarProvinciaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarProvinciaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProvincia.provincia @return;
        
        public buscarProvinciaResponse() {
        }
        
        public buscarProvinciaResponse(SushiApp.wsProvincia.provincia @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarProvincia", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarProvinciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProvincia.provincia provincia;
        
        public agregarProvinciaRequest() {
        }
        
        public agregarProvinciaRequest(SushiApp.wsProvincia.provincia provincia) {
            this.provincia = provincia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarProvinciaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarProvinciaResponse {
        
        public agregarProvinciaResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerProvincia", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerProvinciaRequest {
        
        public obtenerProvinciaRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerProvinciaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerProvinciaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProvincia.provincia[] @return;
        
        public obtenerProvinciaResponse() {
        }
        
        public obtenerProvinciaResponse(SushiApp.wsProvincia.provincia[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarProvincia", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarProvinciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarProvinciaRequest() {
        }
        
        public eliminarProvinciaRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarProvinciaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarProvinciaResponse {
        
        public eliminarProvinciaResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarProvincia", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarProvinciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProvincia.provincia provincia;
        
        public modificarProvinciaRequest() {
        }
        
        public modificarProvinciaRequest(SushiApp.wsProvincia.provincia provincia) {
            this.provincia = provincia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarProvinciaResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarProvinciaResponse {
        
        public modificarProvinciaResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceProvinciaChannel : SushiApp.wsProvincia.ServiceProvincia, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceProvinciaClient : System.ServiceModel.ClientBase<SushiApp.wsProvincia.ServiceProvincia>, SushiApp.wsProvincia.ServiceProvincia {
        
        public ServiceProvinciaClient() {
        }
        
        public ServiceProvinciaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceProvinciaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProvinciaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProvinciaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProvincia.buscarProvinciaResponse SushiApp.wsProvincia.ServiceProvincia.buscarProvincia(SushiApp.wsProvincia.buscarProvinciaRequest request) {
            return base.Channel.buscarProvincia(request);
        }
        
        public SushiApp.wsProvincia.provincia buscarProvincia(int id) {
            SushiApp.wsProvincia.buscarProvinciaRequest inValue = new SushiApp.wsProvincia.buscarProvinciaRequest();
            inValue.id = id;
            SushiApp.wsProvincia.buscarProvinciaResponse retVal = ((SushiApp.wsProvincia.ServiceProvincia)(this)).buscarProvincia(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.buscarProvinciaResponse> SushiApp.wsProvincia.ServiceProvincia.buscarProvinciaAsync(SushiApp.wsProvincia.buscarProvinciaRequest request) {
            return base.Channel.buscarProvinciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProvincia.buscarProvinciaResponse> buscarProvinciaAsync(int id) {
            SushiApp.wsProvincia.buscarProvinciaRequest inValue = new SushiApp.wsProvincia.buscarProvinciaRequest();
            inValue.id = id;
            return ((SushiApp.wsProvincia.ServiceProvincia)(this)).buscarProvinciaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProvincia.agregarProvinciaResponse SushiApp.wsProvincia.ServiceProvincia.agregarProvincia(SushiApp.wsProvincia.agregarProvinciaRequest request) {
            return base.Channel.agregarProvincia(request);
        }
        
        public void agregarProvincia(SushiApp.wsProvincia.provincia provincia) {
            SushiApp.wsProvincia.agregarProvinciaRequest inValue = new SushiApp.wsProvincia.agregarProvinciaRequest();
            inValue.provincia = provincia;
            SushiApp.wsProvincia.agregarProvinciaResponse retVal = ((SushiApp.wsProvincia.ServiceProvincia)(this)).agregarProvincia(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.agregarProvinciaResponse> SushiApp.wsProvincia.ServiceProvincia.agregarProvinciaAsync(SushiApp.wsProvincia.agregarProvinciaRequest request) {
            return base.Channel.agregarProvinciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProvincia.agregarProvinciaResponse> agregarProvinciaAsync(SushiApp.wsProvincia.provincia provincia) {
            SushiApp.wsProvincia.agregarProvinciaRequest inValue = new SushiApp.wsProvincia.agregarProvinciaRequest();
            inValue.provincia = provincia;
            return ((SushiApp.wsProvincia.ServiceProvincia)(this)).agregarProvinciaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProvincia.obtenerProvinciaResponse SushiApp.wsProvincia.ServiceProvincia.obtenerProvincia(SushiApp.wsProvincia.obtenerProvinciaRequest request) {
            return base.Channel.obtenerProvincia(request);
        }
        
        public SushiApp.wsProvincia.provincia[] obtenerProvincia() {
            SushiApp.wsProvincia.obtenerProvinciaRequest inValue = new SushiApp.wsProvincia.obtenerProvinciaRequest();
            SushiApp.wsProvincia.obtenerProvinciaResponse retVal = ((SushiApp.wsProvincia.ServiceProvincia)(this)).obtenerProvincia(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.obtenerProvinciaResponse> SushiApp.wsProvincia.ServiceProvincia.obtenerProvinciaAsync(SushiApp.wsProvincia.obtenerProvinciaRequest request) {
            return base.Channel.obtenerProvinciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProvincia.obtenerProvinciaResponse> obtenerProvinciaAsync() {
            SushiApp.wsProvincia.obtenerProvinciaRequest inValue = new SushiApp.wsProvincia.obtenerProvinciaRequest();
            return ((SushiApp.wsProvincia.ServiceProvincia)(this)).obtenerProvinciaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProvincia.eliminarProvinciaResponse SushiApp.wsProvincia.ServiceProvincia.eliminarProvincia(SushiApp.wsProvincia.eliminarProvinciaRequest request) {
            return base.Channel.eliminarProvincia(request);
        }
        
        public void eliminarProvincia(int id) {
            SushiApp.wsProvincia.eliminarProvinciaRequest inValue = new SushiApp.wsProvincia.eliminarProvinciaRequest();
            inValue.id = id;
            SushiApp.wsProvincia.eliminarProvinciaResponse retVal = ((SushiApp.wsProvincia.ServiceProvincia)(this)).eliminarProvincia(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.eliminarProvinciaResponse> SushiApp.wsProvincia.ServiceProvincia.eliminarProvinciaAsync(SushiApp.wsProvincia.eliminarProvinciaRequest request) {
            return base.Channel.eliminarProvinciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProvincia.eliminarProvinciaResponse> eliminarProvinciaAsync(int id) {
            SushiApp.wsProvincia.eliminarProvinciaRequest inValue = new SushiApp.wsProvincia.eliminarProvinciaRequest();
            inValue.id = id;
            return ((SushiApp.wsProvincia.ServiceProvincia)(this)).eliminarProvinciaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProvincia.modificarProvinciaResponse SushiApp.wsProvincia.ServiceProvincia.modificarProvincia(SushiApp.wsProvincia.modificarProvinciaRequest request) {
            return base.Channel.modificarProvincia(request);
        }
        
        public void modificarProvincia(SushiApp.wsProvincia.provincia provincia) {
            SushiApp.wsProvincia.modificarProvinciaRequest inValue = new SushiApp.wsProvincia.modificarProvinciaRequest();
            inValue.provincia = provincia;
            SushiApp.wsProvincia.modificarProvinciaResponse retVal = ((SushiApp.wsProvincia.ServiceProvincia)(this)).modificarProvincia(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProvincia.modificarProvinciaResponse> SushiApp.wsProvincia.ServiceProvincia.modificarProvinciaAsync(SushiApp.wsProvincia.modificarProvinciaRequest request) {
            return base.Channel.modificarProvinciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProvincia.modificarProvinciaResponse> modificarProvinciaAsync(SushiApp.wsProvincia.provincia provincia) {
            SushiApp.wsProvincia.modificarProvinciaRequest inValue = new SushiApp.wsProvincia.modificarProvinciaRequest();
            inValue.provincia = provincia;
            return ((SushiApp.wsProvincia.ServiceProvincia)(this)).modificarProvinciaAsync(inValue);
        }
    }
}
