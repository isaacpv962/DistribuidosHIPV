﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.SeduinfoServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Estudiante", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Estudiante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarreraField;
        
        private int SemestreField;
        
        private double PromedioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TutorAsignadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoTutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoTutorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CI {
            get {
                return this.CIField;
            }
            set {
                if ((object.ReferenceEquals(this.CIField, value) != true)) {
                    this.CIField = value;
                    this.RaisePropertyChanged("CI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Carrera {
            get {
                return this.CarreraField;
            }
            set {
                if ((object.ReferenceEquals(this.CarreraField, value) != true)) {
                    this.CarreraField = value;
                    this.RaisePropertyChanged("Carrera");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Semestre {
            get {
                return this.SemestreField;
            }
            set {
                if ((this.SemestreField.Equals(value) != true)) {
                    this.SemestreField = value;
                    this.RaisePropertyChanged("Semestre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public double Promedio {
            get {
                return this.PromedioField;
            }
            set {
                if ((this.PromedioField.Equals(value) != true)) {
                    this.PromedioField = value;
                    this.RaisePropertyChanged("Promedio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string TutorAsignado {
            get {
                return this.TutorAsignadoField;
            }
            set {
                if ((object.ReferenceEquals(this.TutorAsignadoField, value) != true)) {
                    this.TutorAsignadoField = value;
                    this.RaisePropertyChanged("TutorAsignado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string CorreoTutor {
            get {
                return this.CorreoTutorField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoTutorField, value) != true)) {
                    this.CorreoTutorField = value;
                    this.RaisePropertyChanged("CorreoTutor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string TelefonoTutor {
            get {
                return this.TelefonoTutorField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoTutorField, value) != true)) {
                    this.TelefonoTutorField = value;
                    this.RaisePropertyChanged("TelefonoTutor");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SeduinfoServiceRef.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name CI from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerDatosAcademicos", ReplyAction="*")]
        WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponse ObtenerDatosAcademicos(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerDatosAcademicos", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponse> ObtenerDatosAcademicosAsync(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest request);
        
        // CODEGEN: Generating message contract since element name CI from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerDatosTutor", ReplyAction="*")]
        WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponse ObtenerDatosTutor(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerDatosTutor", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponse> ObtenerDatosTutorAsync(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerDatosAcademicosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerDatosAcademicos", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequestBody Body;
        
        public ObtenerDatosAcademicosRequest() {
        }
        
        public ObtenerDatosAcademicosRequest(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerDatosAcademicosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CI;
        
        public ObtenerDatosAcademicosRequestBody() {
        }
        
        public ObtenerDatosAcademicosRequestBody(string CI) {
            this.CI = CI;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerDatosAcademicosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerDatosAcademicosResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponseBody Body;
        
        public ObtenerDatosAcademicosResponse() {
        }
        
        public ObtenerDatosAcademicosResponse(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerDatosAcademicosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp1.SeduinfoServiceRef.Estudiante ObtenerDatosAcademicosResult;
        
        public ObtenerDatosAcademicosResponseBody() {
        }
        
        public ObtenerDatosAcademicosResponseBody(WindowsFormsApp1.SeduinfoServiceRef.Estudiante ObtenerDatosAcademicosResult) {
            this.ObtenerDatosAcademicosResult = ObtenerDatosAcademicosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerDatosTutorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerDatosTutor", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequestBody Body;
        
        public ObtenerDatosTutorRequest() {
        }
        
        public ObtenerDatosTutorRequest(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerDatosTutorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CI;
        
        public ObtenerDatosTutorRequestBody() {
        }
        
        public ObtenerDatosTutorRequestBody(string CI) {
            this.CI = CI;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerDatosTutorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerDatosTutorResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponseBody Body;
        
        public ObtenerDatosTutorResponse() {
        }
        
        public ObtenerDatosTutorResponse(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerDatosTutorResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp1.SeduinfoServiceRef.Estudiante ObtenerDatosTutorResult;
        
        public ObtenerDatosTutorResponseBody() {
        }
        
        public ObtenerDatosTutorResponseBody(WindowsFormsApp1.SeduinfoServiceRef.Estudiante ObtenerDatosTutorResult) {
            this.ObtenerDatosTutorResult = ObtenerDatosTutorResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap>, WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponse WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap.ObtenerDatosAcademicos(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest request) {
            return base.Channel.ObtenerDatosAcademicos(request);
        }
        
        public WindowsFormsApp1.SeduinfoServiceRef.Estudiante ObtenerDatosAcademicos(string CI) {
            WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest inValue = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest();
            inValue.Body = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequestBody();
            inValue.Body.CI = CI;
            WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponse retVal = ((WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap)(this)).ObtenerDatosAcademicos(inValue);
            return retVal.Body.ObtenerDatosAcademicosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponse> WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap.ObtenerDatosAcademicosAsync(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest request) {
            return base.Channel.ObtenerDatosAcademicosAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosResponse> ObtenerDatosAcademicosAsync(string CI) {
            WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest inValue = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequest();
            inValue.Body = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosAcademicosRequestBody();
            inValue.Body.CI = CI;
            return ((WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap)(this)).ObtenerDatosAcademicosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponse WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap.ObtenerDatosTutor(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest request) {
            return base.Channel.ObtenerDatosTutor(request);
        }
        
        public WindowsFormsApp1.SeduinfoServiceRef.Estudiante ObtenerDatosTutor(string CI) {
            WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest inValue = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest();
            inValue.Body = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequestBody();
            inValue.Body.CI = CI;
            WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponse retVal = ((WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap)(this)).ObtenerDatosTutor(inValue);
            return retVal.Body.ObtenerDatosTutorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponse> WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap.ObtenerDatosTutorAsync(WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest request) {
            return base.Channel.ObtenerDatosTutorAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorResponse> ObtenerDatosTutorAsync(string CI) {
            WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest inValue = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequest();
            inValue.Body = new WindowsFormsApp1.SeduinfoServiceRef.ObtenerDatosTutorRequestBody();
            inValue.Body.CI = CI;
            return ((WindowsFormsApp1.SeduinfoServiceRef.WebService1Soap)(this)).ObtenerDatosTutorAsync(inValue);
        }
    }
}
