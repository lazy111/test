﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfRestfulClient.DataProvider {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="WCF.REST")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int SexField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Sex {
            get {
                return this.SexField;
            }
            set {
                if ((this.SexField.Equals(value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="WCF.REST", ConfigurationName="DataProvider.IDataProvider")]
    public interface IDataProvider {
        
        // CODEGEN: 命名空间 WCF.REST 的元素名称 data 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Update", ReplyAction="WCF.REST/IDataProvider/UpdateResponse")]
        WcfRestfulClient.DataProvider.UpdateResponse Update(WcfRestfulClient.DataProvider.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Update", ReplyAction="WCF.REST/IDataProvider/UpdateResponse")]
        System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.UpdateResponse> UpdateAsync(WcfRestfulClient.DataProvider.UpdateRequest request);
        
        // CODEGEN: 命名空间 WCF.REST 的元素名称 info 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Create", ReplyAction="WCF.REST/IDataProvider/CreateResponse")]
        WcfRestfulClient.DataProvider.CreateResponse Create(WcfRestfulClient.DataProvider.CreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Create", ReplyAction="WCF.REST/IDataProvider/CreateResponse")]
        System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.CreateResponse> CreateAsync(WcfRestfulClient.DataProvider.CreateRequest request);
        
        // CODEGEN: 命名空间 WCF.REST 的元素名称 GetResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Get", ReplyAction="WCF.REST/IDataProvider/GetResponse")]
        WcfRestfulClient.DataProvider.GetResponse Get(WcfRestfulClient.DataProvider.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Get", ReplyAction="WCF.REST/IDataProvider/GetResponse")]
        System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.GetResponse> GetAsync(WcfRestfulClient.DataProvider.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Delete", ReplyAction="WCF.REST/IDataProvider/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCF.REST/IDataProvider/Delete", ReplyAction="WCF.REST/IDataProvider/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="WCF.REST", Order=0)]
        public WcfRestfulClient.DataProvider.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(WcfRestfulClient.DataProvider.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="WCF.REST")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WcfRestfulClient.DataProvider.UserInfo data;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(WcfRestfulClient.DataProvider.UserInfo data) {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="WCF.REST", Order=0)]
        public WcfRestfulClient.DataProvider.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(WcfRestfulClient.DataProvider.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateResponseBody {
        
        public UpdateResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Create", Namespace="WCF.REST", Order=0)]
        public WcfRestfulClient.DataProvider.CreateRequestBody Body;
        
        public CreateRequest() {
        }
        
        public CreateRequest(WcfRestfulClient.DataProvider.CreateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="WCF.REST")]
    public partial class CreateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WcfRestfulClient.DataProvider.UserInfo info;
        
        public CreateRequestBody() {
        }
        
        public CreateRequestBody(WcfRestfulClient.DataProvider.UserInfo info) {
            this.info = info;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateResponse", Namespace="WCF.REST", Order=0)]
        public WcfRestfulClient.DataProvider.CreateResponseBody Body;
        
        public CreateResponse() {
        }
        
        public CreateResponse(WcfRestfulClient.DataProvider.CreateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CreateResponseBody {
        
        public CreateResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="WCF.REST", Order=0)]
        public WcfRestfulClient.DataProvider.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(WcfRestfulClient.DataProvider.GetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="WCF.REST")]
    public partial class GetRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetRequestBody() {
        }
        
        public GetRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetResponse", Namespace="WCF.REST", Order=0)]
        public WcfRestfulClient.DataProvider.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(WcfRestfulClient.DataProvider.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="WCF.REST")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WcfRestfulClient.DataProvider.UserInfo GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(WcfRestfulClient.DataProvider.UserInfo GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataProviderChannel : WcfRestfulClient.DataProvider.IDataProvider, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataProviderClient : System.ServiceModel.ClientBase<WcfRestfulClient.DataProvider.IDataProvider>, WcfRestfulClient.DataProvider.IDataProvider {
        
        public DataProviderClient() {
        }
        
        public DataProviderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataProviderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataProviderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataProviderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfRestfulClient.DataProvider.UpdateResponse WcfRestfulClient.DataProvider.IDataProvider.Update(WcfRestfulClient.DataProvider.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public void Update(WcfRestfulClient.DataProvider.UserInfo data) {
            WcfRestfulClient.DataProvider.UpdateRequest inValue = new WcfRestfulClient.DataProvider.UpdateRequest();
            inValue.Body = new WcfRestfulClient.DataProvider.UpdateRequestBody();
            inValue.Body.data = data;
            WcfRestfulClient.DataProvider.UpdateResponse retVal = ((WcfRestfulClient.DataProvider.IDataProvider)(this)).Update(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.UpdateResponse> WcfRestfulClient.DataProvider.IDataProvider.UpdateAsync(WcfRestfulClient.DataProvider.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.UpdateResponse> UpdateAsync(WcfRestfulClient.DataProvider.UserInfo data) {
            WcfRestfulClient.DataProvider.UpdateRequest inValue = new WcfRestfulClient.DataProvider.UpdateRequest();
            inValue.Body = new WcfRestfulClient.DataProvider.UpdateRequestBody();
            inValue.Body.data = data;
            return ((WcfRestfulClient.DataProvider.IDataProvider)(this)).UpdateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfRestfulClient.DataProvider.CreateResponse WcfRestfulClient.DataProvider.IDataProvider.Create(WcfRestfulClient.DataProvider.CreateRequest request) {
            return base.Channel.Create(request);
        }
        
        public void Create(WcfRestfulClient.DataProvider.UserInfo info) {
            WcfRestfulClient.DataProvider.CreateRequest inValue = new WcfRestfulClient.DataProvider.CreateRequest();
            inValue.Body = new WcfRestfulClient.DataProvider.CreateRequestBody();
            inValue.Body.info = info;
            WcfRestfulClient.DataProvider.CreateResponse retVal = ((WcfRestfulClient.DataProvider.IDataProvider)(this)).Create(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.CreateResponse> WcfRestfulClient.DataProvider.IDataProvider.CreateAsync(WcfRestfulClient.DataProvider.CreateRequest request) {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.CreateResponse> CreateAsync(WcfRestfulClient.DataProvider.UserInfo info) {
            WcfRestfulClient.DataProvider.CreateRequest inValue = new WcfRestfulClient.DataProvider.CreateRequest();
            inValue.Body = new WcfRestfulClient.DataProvider.CreateRequestBody();
            inValue.Body.info = info;
            return ((WcfRestfulClient.DataProvider.IDataProvider)(this)).CreateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfRestfulClient.DataProvider.GetResponse WcfRestfulClient.DataProvider.IDataProvider.Get(WcfRestfulClient.DataProvider.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public WcfRestfulClient.DataProvider.UserInfo Get(int id) {
            WcfRestfulClient.DataProvider.GetRequest inValue = new WcfRestfulClient.DataProvider.GetRequest();
            inValue.Body = new WcfRestfulClient.DataProvider.GetRequestBody();
            inValue.Body.id = id;
            WcfRestfulClient.DataProvider.GetResponse retVal = ((WcfRestfulClient.DataProvider.IDataProvider)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.GetResponse> WcfRestfulClient.DataProvider.IDataProvider.GetAsync(WcfRestfulClient.DataProvider.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfRestfulClient.DataProvider.GetResponse> GetAsync(int id) {
            WcfRestfulClient.DataProvider.GetRequest inValue = new WcfRestfulClient.DataProvider.GetRequest();
            inValue.Body = new WcfRestfulClient.DataProvider.GetRequestBody();
            inValue.Body.id = id;
            return ((WcfRestfulClient.DataProvider.IDataProvider)(this)).GetAsync(inValue);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}