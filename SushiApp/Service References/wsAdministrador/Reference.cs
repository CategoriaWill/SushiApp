﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsAdministrador {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsAdministrador.ServiceAdministrador")]
    public interface ServiceAdministrador {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/obtenerAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/obtenerAdministradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsAdministrador.obtenerAdministradorResponse obtenerAdministrador(SushiApp.wsAdministrador.obtenerAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/obtenerAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/obtenerAdministradorResponse")]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.obtenerAdministradorResponse> obtenerAdministradorAsync(SushiApp.wsAdministrador.obtenerAdministradorRequest request);
        
        // CODEGEN: El parámetro 'administrador' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/agregarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/agregarAdministradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsAdministrador.agregarAdministradorResponse agregarAdministrador(SushiApp.wsAdministrador.agregarAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/agregarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/agregarAdministradorResponse")]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.agregarAdministradorResponse> agregarAdministradorAsync(SushiApp.wsAdministrador.agregarAdministradorRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/eliminarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/eliminarAdministradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsAdministrador.eliminarAdministradorResponse eliminarAdministrador(SushiApp.wsAdministrador.eliminarAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/eliminarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/eliminarAdministradorResponse")]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.eliminarAdministradorResponse> eliminarAdministradorAsync(SushiApp.wsAdministrador.eliminarAdministradorRequest request);
        
        // CODEGEN: El parámetro 'administrador' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/modificarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/modificarAdministradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsAdministrador.modificarAdministradorResponse modificarAdministrador(SushiApp.wsAdministrador.modificarAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/modificarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/modificarAdministradorResponse")]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.modificarAdministradorResponse> modificarAdministradorAsync(SushiApp.wsAdministrador.modificarAdministradorRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/buscarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/buscarAdministradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsAdministrador.buscarAdministradorResponse buscarAdministrador(SushiApp.wsAdministrador.buscarAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceAdministrador/buscarAdministradorRequest", ReplyAction="http://WebService/ServiceAdministrador/buscarAdministradorResponse")]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.buscarAdministradorResponse> buscarAdministradorAsync(SushiApp.wsAdministrador.buscarAdministradorRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class administrador : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int administradorIdField;
        
        private string apellidoAdminField;
        
        private string corrreoAdminField;
        
        private string nombreAdminField;
        
        private string telefonoAdminField;
        
        private int usuarioIdField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int administradorId {
            get {
                return this.administradorIdField;
            }
            set {
                this.administradorIdField = value;
                this.RaisePropertyChanged("administradorId");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string apellidoAdmin {
            get {
                return this.apellidoAdminField;
            }
            set {
                this.apellidoAdminField = value;
                this.RaisePropertyChanged("apellidoAdmin");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string corrreoAdmin {
            get {
                return this.corrreoAdminField;
            }
            set {
                this.corrreoAdminField = value;
                this.RaisePropertyChanged("corrreoAdmin");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombreAdmin {
            get {
                return this.nombreAdminField;
            }
            set {
                this.nombreAdminField = value;
                this.RaisePropertyChanged("nombreAdmin");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string telefonoAdmin {
            get {
                return this.telefonoAdminField;
            }
            set {
                this.telefonoAdminField = value;
                this.RaisePropertyChanged("telefonoAdmin");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int usuarioId {
            get {
                return this.usuarioIdField;
            }
            set {
                this.usuarioIdField = value;
                this.RaisePropertyChanged("usuarioId");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerAdministrador", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerAdministradorRequest {
        
        public obtenerAdministradorRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerAdministradorResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerAdministradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsAdministrador.administrador[] @return;
        
        public obtenerAdministradorResponse() {
        }
        
        public obtenerAdministradorResponse(SushiApp.wsAdministrador.administrador[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarAdministrador", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarAdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsAdministrador.administrador administrador;
        
        public agregarAdministradorRequest() {
        }
        
        public agregarAdministradorRequest(SushiApp.wsAdministrador.administrador administrador) {
            this.administrador = administrador;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarAdministradorResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarAdministradorResponse {
        
        public agregarAdministradorResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarAdministrador", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarAdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarAdministradorRequest() {
        }
        
        public eliminarAdministradorRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarAdministradorResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarAdministradorResponse {
        
        public eliminarAdministradorResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarAdministrador", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarAdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsAdministrador.administrador administrador;
        
        public modificarAdministradorRequest() {
        }
        
        public modificarAdministradorRequest(SushiApp.wsAdministrador.administrador administrador) {
            this.administrador = administrador;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarAdministradorResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarAdministradorResponse {
        
        public modificarAdministradorResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarAdministrador", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarAdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarAdministradorRequest() {
        }
        
        public buscarAdministradorRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarAdministradorResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarAdministradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsAdministrador.administrador @return;
        
        public buscarAdministradorResponse() {
        }
        
        public buscarAdministradorResponse(SushiApp.wsAdministrador.administrador @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceAdministradorChannel : SushiApp.wsAdministrador.ServiceAdministrador, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAdministradorClient : System.ServiceModel.ClientBase<SushiApp.wsAdministrador.ServiceAdministrador>, SushiApp.wsAdministrador.ServiceAdministrador {
        
        public ServiceAdministradorClient() {
        }
        
        public ServiceAdministradorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAdministradorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdministradorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdministradorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsAdministrador.obtenerAdministradorResponse SushiApp.wsAdministrador.ServiceAdministrador.obtenerAdministrador(SushiApp.wsAdministrador.obtenerAdministradorRequest request) {
            return base.Channel.obtenerAdministrador(request);
        }
        
        public SushiApp.wsAdministrador.administrador[] obtenerAdministrador() {
            SushiApp.wsAdministrador.obtenerAdministradorRequest inValue = new SushiApp.wsAdministrador.obtenerAdministradorRequest();
            SushiApp.wsAdministrador.obtenerAdministradorResponse retVal = ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).obtenerAdministrador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.obtenerAdministradorResponse> SushiApp.wsAdministrador.ServiceAdministrador.obtenerAdministradorAsync(SushiApp.wsAdministrador.obtenerAdministradorRequest request) {
            return base.Channel.obtenerAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsAdministrador.obtenerAdministradorResponse> obtenerAdministradorAsync() {
            SushiApp.wsAdministrador.obtenerAdministradorRequest inValue = new SushiApp.wsAdministrador.obtenerAdministradorRequest();
            return ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).obtenerAdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsAdministrador.agregarAdministradorResponse SushiApp.wsAdministrador.ServiceAdministrador.agregarAdministrador(SushiApp.wsAdministrador.agregarAdministradorRequest request) {
            return base.Channel.agregarAdministrador(request);
        }
        
        public void agregarAdministrador(SushiApp.wsAdministrador.administrador administrador) {
            SushiApp.wsAdministrador.agregarAdministradorRequest inValue = new SushiApp.wsAdministrador.agregarAdministradorRequest();
            inValue.administrador = administrador;
            SushiApp.wsAdministrador.agregarAdministradorResponse retVal = ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).agregarAdministrador(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.agregarAdministradorResponse> SushiApp.wsAdministrador.ServiceAdministrador.agregarAdministradorAsync(SushiApp.wsAdministrador.agregarAdministradorRequest request) {
            return base.Channel.agregarAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsAdministrador.agregarAdministradorResponse> agregarAdministradorAsync(SushiApp.wsAdministrador.administrador administrador) {
            SushiApp.wsAdministrador.agregarAdministradorRequest inValue = new SushiApp.wsAdministrador.agregarAdministradorRequest();
            inValue.administrador = administrador;
            return ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).agregarAdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsAdministrador.eliminarAdministradorResponse SushiApp.wsAdministrador.ServiceAdministrador.eliminarAdministrador(SushiApp.wsAdministrador.eliminarAdministradorRequest request) {
            return base.Channel.eliminarAdministrador(request);
        }
        
        public void eliminarAdministrador(int id) {
            SushiApp.wsAdministrador.eliminarAdministradorRequest inValue = new SushiApp.wsAdministrador.eliminarAdministradorRequest();
            inValue.id = id;
            SushiApp.wsAdministrador.eliminarAdministradorResponse retVal = ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).eliminarAdministrador(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.eliminarAdministradorResponse> SushiApp.wsAdministrador.ServiceAdministrador.eliminarAdministradorAsync(SushiApp.wsAdministrador.eliminarAdministradorRequest request) {
            return base.Channel.eliminarAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsAdministrador.eliminarAdministradorResponse> eliminarAdministradorAsync(int id) {
            SushiApp.wsAdministrador.eliminarAdministradorRequest inValue = new SushiApp.wsAdministrador.eliminarAdministradorRequest();
            inValue.id = id;
            return ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).eliminarAdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsAdministrador.modificarAdministradorResponse SushiApp.wsAdministrador.ServiceAdministrador.modificarAdministrador(SushiApp.wsAdministrador.modificarAdministradorRequest request) {
            return base.Channel.modificarAdministrador(request);
        }
        
        public void modificarAdministrador(SushiApp.wsAdministrador.administrador administrador) {
            SushiApp.wsAdministrador.modificarAdministradorRequest inValue = new SushiApp.wsAdministrador.modificarAdministradorRequest();
            inValue.administrador = administrador;
            SushiApp.wsAdministrador.modificarAdministradorResponse retVal = ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).modificarAdministrador(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.modificarAdministradorResponse> SushiApp.wsAdministrador.ServiceAdministrador.modificarAdministradorAsync(SushiApp.wsAdministrador.modificarAdministradorRequest request) {
            return base.Channel.modificarAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsAdministrador.modificarAdministradorResponse> modificarAdministradorAsync(SushiApp.wsAdministrador.administrador administrador) {
            SushiApp.wsAdministrador.modificarAdministradorRequest inValue = new SushiApp.wsAdministrador.modificarAdministradorRequest();
            inValue.administrador = administrador;
            return ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).modificarAdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsAdministrador.buscarAdministradorResponse SushiApp.wsAdministrador.ServiceAdministrador.buscarAdministrador(SushiApp.wsAdministrador.buscarAdministradorRequest request) {
            return base.Channel.buscarAdministrador(request);
        }
        
        public SushiApp.wsAdministrador.administrador buscarAdministrador(int id) {
            SushiApp.wsAdministrador.buscarAdministradorRequest inValue = new SushiApp.wsAdministrador.buscarAdministradorRequest();
            inValue.id = id;
            SushiApp.wsAdministrador.buscarAdministradorResponse retVal = ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).buscarAdministrador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsAdministrador.buscarAdministradorResponse> SushiApp.wsAdministrador.ServiceAdministrador.buscarAdministradorAsync(SushiApp.wsAdministrador.buscarAdministradorRequest request) {
            return base.Channel.buscarAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsAdministrador.buscarAdministradorResponse> buscarAdministradorAsync(int id) {
            SushiApp.wsAdministrador.buscarAdministradorRequest inValue = new SushiApp.wsAdministrador.buscarAdministradorRequest();
            inValue.id = id;
            return ((SushiApp.wsAdministrador.ServiceAdministrador)(this)).buscarAdministradorAsync(inValue);
        }
    }
}
