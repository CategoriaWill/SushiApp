﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsEstablecimiento {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsEstablecimiento.ServiceEstablecimiento")]
    public interface ServiceEstablecimiento {
        
        // CODEGEN: El parámetro 'establecimiento' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/agregarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/agregarEstablecimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsEstablecimiento.agregarEstablecimientoResponse agregarEstablecimiento(SushiApp.wsEstablecimiento.agregarEstablecimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/agregarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/agregarEstablecimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.agregarEstablecimientoResponse> agregarEstablecimientoAsync(SushiApp.wsEstablecimiento.agregarEstablecimientoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/obtenerEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/obtenerEstablecimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsEstablecimiento.obtenerEstablecimientoResponse obtenerEstablecimiento(SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/obtenerEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/obtenerEstablecimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.obtenerEstablecimientoResponse> obtenerEstablecimientoAsync(SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/eliminarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/eliminarEstablecimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsEstablecimiento.eliminarEstablecimientoResponse eliminarEstablecimiento(SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/eliminarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/eliminarEstablecimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.eliminarEstablecimientoResponse> eliminarEstablecimientoAsync(SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/buscarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/buscarEstablecimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsEstablecimiento.buscarEstablecimientoResponse buscarEstablecimiento(SushiApp.wsEstablecimiento.buscarEstablecimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/buscarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/buscarEstablecimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.buscarEstablecimientoResponse> buscarEstablecimientoAsync(SushiApp.wsEstablecimiento.buscarEstablecimientoRequest request);
        
        // CODEGEN: El parámetro 'establecimiento' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/modificarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/modificarEstablecimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsEstablecimiento.modificarEstablecimientoResponse modificarEstablecimiento(SushiApp.wsEstablecimiento.modificarEstablecimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceEstablecimiento/modificarEstablecimientoRequest", ReplyAction="http://WebService/ServiceEstablecimiento/modificarEstablecimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.modificarEstablecimientoResponse> modificarEstablecimientoAsync(SushiApp.wsEstablecimiento.modificarEstablecimientoRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class establecimiento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string comunaField;
        
        private string direccionField;
        
        private int establecimientoIdField;
        
        private string nombreLocalField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string comuna {
            get {
                return this.comunaField;
            }
            set {
                this.comunaField = value;
                this.RaisePropertyChanged("comuna");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int establecimientoId {
            get {
                return this.establecimientoIdField;
            }
            set {
                this.establecimientoIdField = value;
                this.RaisePropertyChanged("establecimientoId");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombreLocal {
            get {
                return this.nombreLocalField;
            }
            set {
                this.nombreLocalField = value;
                this.RaisePropertyChanged("nombreLocal");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarEstablecimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarEstablecimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsEstablecimiento.establecimiento establecimiento;
        
        public agregarEstablecimientoRequest() {
        }
        
        public agregarEstablecimientoRequest(SushiApp.wsEstablecimiento.establecimiento establecimiento) {
            this.establecimiento = establecimiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarEstablecimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarEstablecimientoResponse {
        
        public agregarEstablecimientoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerEstablecimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerEstablecimientoRequest {
        
        public obtenerEstablecimientoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerEstablecimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerEstablecimientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsEstablecimiento.establecimiento[] @return;
        
        public obtenerEstablecimientoResponse() {
        }
        
        public obtenerEstablecimientoResponse(SushiApp.wsEstablecimiento.establecimiento[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEstablecimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarEstablecimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarEstablecimientoRequest() {
        }
        
        public eliminarEstablecimientoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEstablecimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarEstablecimientoResponse {
        
        public eliminarEstablecimientoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarEstablecimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarEstablecimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarEstablecimientoRequest() {
        }
        
        public buscarEstablecimientoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarEstablecimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarEstablecimientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsEstablecimiento.establecimiento @return;
        
        public buscarEstablecimientoResponse() {
        }
        
        public buscarEstablecimientoResponse(SushiApp.wsEstablecimiento.establecimiento @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEstablecimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarEstablecimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsEstablecimiento.establecimiento establecimiento;
        
        public modificarEstablecimientoRequest() {
        }
        
        public modificarEstablecimientoRequest(SushiApp.wsEstablecimiento.establecimiento establecimiento) {
            this.establecimiento = establecimiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEstablecimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarEstablecimientoResponse {
        
        public modificarEstablecimientoResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceEstablecimientoChannel : SushiApp.wsEstablecimiento.ServiceEstablecimiento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceEstablecimientoClient : System.ServiceModel.ClientBase<SushiApp.wsEstablecimiento.ServiceEstablecimiento>, SushiApp.wsEstablecimiento.ServiceEstablecimiento {
        
        public ServiceEstablecimientoClient() {
        }
        
        public ServiceEstablecimientoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceEstablecimientoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEstablecimientoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEstablecimientoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsEstablecimiento.agregarEstablecimientoResponse SushiApp.wsEstablecimiento.ServiceEstablecimiento.agregarEstablecimiento(SushiApp.wsEstablecimiento.agregarEstablecimientoRequest request) {
            return base.Channel.agregarEstablecimiento(request);
        }
        
        public void agregarEstablecimiento(SushiApp.wsEstablecimiento.establecimiento establecimiento) {
            SushiApp.wsEstablecimiento.agregarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.agregarEstablecimientoRequest();
            inValue.establecimiento = establecimiento;
            SushiApp.wsEstablecimiento.agregarEstablecimientoResponse retVal = ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).agregarEstablecimiento(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.agregarEstablecimientoResponse> SushiApp.wsEstablecimiento.ServiceEstablecimiento.agregarEstablecimientoAsync(SushiApp.wsEstablecimiento.agregarEstablecimientoRequest request) {
            return base.Channel.agregarEstablecimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.agregarEstablecimientoResponse> agregarEstablecimientoAsync(SushiApp.wsEstablecimiento.establecimiento establecimiento) {
            SushiApp.wsEstablecimiento.agregarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.agregarEstablecimientoRequest();
            inValue.establecimiento = establecimiento;
            return ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).agregarEstablecimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsEstablecimiento.obtenerEstablecimientoResponse SushiApp.wsEstablecimiento.ServiceEstablecimiento.obtenerEstablecimiento(SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest request) {
            return base.Channel.obtenerEstablecimiento(request);
        }
        
        public SushiApp.wsEstablecimiento.establecimiento[] obtenerEstablecimiento() {
            SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest();
            SushiApp.wsEstablecimiento.obtenerEstablecimientoResponse retVal = ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).obtenerEstablecimiento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.obtenerEstablecimientoResponse> SushiApp.wsEstablecimiento.ServiceEstablecimiento.obtenerEstablecimientoAsync(SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest request) {
            return base.Channel.obtenerEstablecimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.obtenerEstablecimientoResponse> obtenerEstablecimientoAsync() {
            SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.obtenerEstablecimientoRequest();
            return ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).obtenerEstablecimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsEstablecimiento.eliminarEstablecimientoResponse SushiApp.wsEstablecimiento.ServiceEstablecimiento.eliminarEstablecimiento(SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest request) {
            return base.Channel.eliminarEstablecimiento(request);
        }
        
        public void eliminarEstablecimiento(int id) {
            SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest();
            inValue.id = id;
            SushiApp.wsEstablecimiento.eliminarEstablecimientoResponse retVal = ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).eliminarEstablecimiento(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.eliminarEstablecimientoResponse> SushiApp.wsEstablecimiento.ServiceEstablecimiento.eliminarEstablecimientoAsync(SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest request) {
            return base.Channel.eliminarEstablecimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.eliminarEstablecimientoResponse> eliminarEstablecimientoAsync(int id) {
            SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.eliminarEstablecimientoRequest();
            inValue.id = id;
            return ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).eliminarEstablecimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsEstablecimiento.buscarEstablecimientoResponse SushiApp.wsEstablecimiento.ServiceEstablecimiento.buscarEstablecimiento(SushiApp.wsEstablecimiento.buscarEstablecimientoRequest request) {
            return base.Channel.buscarEstablecimiento(request);
        }
        
        public SushiApp.wsEstablecimiento.establecimiento buscarEstablecimiento(int id) {
            SushiApp.wsEstablecimiento.buscarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.buscarEstablecimientoRequest();
            inValue.id = id;
            SushiApp.wsEstablecimiento.buscarEstablecimientoResponse retVal = ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).buscarEstablecimiento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.buscarEstablecimientoResponse> SushiApp.wsEstablecimiento.ServiceEstablecimiento.buscarEstablecimientoAsync(SushiApp.wsEstablecimiento.buscarEstablecimientoRequest request) {
            return base.Channel.buscarEstablecimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.buscarEstablecimientoResponse> buscarEstablecimientoAsync(int id) {
            SushiApp.wsEstablecimiento.buscarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.buscarEstablecimientoRequest();
            inValue.id = id;
            return ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).buscarEstablecimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsEstablecimiento.modificarEstablecimientoResponse SushiApp.wsEstablecimiento.ServiceEstablecimiento.modificarEstablecimiento(SushiApp.wsEstablecimiento.modificarEstablecimientoRequest request) {
            return base.Channel.modificarEstablecimiento(request);
        }
        
        public void modificarEstablecimiento(SushiApp.wsEstablecimiento.establecimiento establecimiento) {
            SushiApp.wsEstablecimiento.modificarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.modificarEstablecimientoRequest();
            inValue.establecimiento = establecimiento;
            SushiApp.wsEstablecimiento.modificarEstablecimientoResponse retVal = ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).modificarEstablecimiento(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.modificarEstablecimientoResponse> SushiApp.wsEstablecimiento.ServiceEstablecimiento.modificarEstablecimientoAsync(SushiApp.wsEstablecimiento.modificarEstablecimientoRequest request) {
            return base.Channel.modificarEstablecimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsEstablecimiento.modificarEstablecimientoResponse> modificarEstablecimientoAsync(SushiApp.wsEstablecimiento.establecimiento establecimiento) {
            SushiApp.wsEstablecimiento.modificarEstablecimientoRequest inValue = new SushiApp.wsEstablecimiento.modificarEstablecimientoRequest();
            inValue.establecimiento = establecimiento;
            return ((SushiApp.wsEstablecimiento.ServiceEstablecimiento)(this)).modificarEstablecimientoAsync(inValue);
        }
    }
}
