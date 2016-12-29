﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace EvfaEOC.evfawr {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="evfawsaSoap", Namespace="http://tempuri.org/")]
    public partial class evfawsa : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchEventsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getEventJobsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getEventCodeNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTeamRotaOperationCompleted;
        
        private System.Threading.SendOrPostCallback getEventStartDateTimeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getJobDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback savePrfOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPrfDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback getnextJobIDOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public evfawsa() {
            this.Url = global::EvfaEOC.Properties.Settings.Default.EvfaEOC_evfawr_evfawsa;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event SearchEventsCompletedEventHandler SearchEventsCompleted;
        
        /// <remarks/>
        public event getEventJobsCompletedEventHandler getEventJobsCompleted;
        
        /// <remarks/>
        public event getEventCodeNameCompletedEventHandler getEventCodeNameCompleted;
        
        /// <remarks/>
        public event getTeamRotaCompletedEventHandler getTeamRotaCompleted;
        
        /// <remarks/>
        public event getEventStartDateTimeCompletedEventHandler getEventStartDateTimeCompleted;
        
        /// <remarks/>
        public event getJobDataCompletedEventHandler getJobDataCompleted;
        
        /// <remarks/>
        public event savePrfCompletedEventHandler savePrfCompleted;
        
        /// <remarks/>
        public event getPrfDataCompletedEventHandler getPrfDataCompleted;
        
        /// <remarks/>
        public event getnextJobIDCompletedEventHandler getnextJobIDCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SearchEvents", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SearchEvents(string partial, System.DateTime sd, System.DateTime ed, bool incdel) {
            object[] results = this.Invoke("SearchEvents", new object[] {
                        partial,
                        sd,
                        ed,
                        incdel});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SearchEventsAsync(string partial, System.DateTime sd, System.DateTime ed, bool incdel) {
            this.SearchEventsAsync(partial, sd, ed, incdel, null);
        }
        
        /// <remarks/>
        public void SearchEventsAsync(string partial, System.DateTime sd, System.DateTime ed, bool incdel, object userState) {
            if ((this.SearchEventsOperationCompleted == null)) {
                this.SearchEventsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchEventsOperationCompleted);
            }
            this.InvokeAsync("SearchEvents", new object[] {
                        partial,
                        sd,
                        ed,
                        incdel}, this.SearchEventsOperationCompleted, userState);
        }
        
        private void OnSearchEventsOperationCompleted(object arg) {
            if ((this.SearchEventsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchEventsCompleted(this, new SearchEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getEventJobs", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getEventJobs(int EventID, int JobStatus) {
            object[] results = this.Invoke("getEventJobs", new object[] {
                        EventID,
                        JobStatus});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getEventJobsAsync(int EventID, int JobStatus) {
            this.getEventJobsAsync(EventID, JobStatus, null);
        }
        
        /// <remarks/>
        public void getEventJobsAsync(int EventID, int JobStatus, object userState) {
            if ((this.getEventJobsOperationCompleted == null)) {
                this.getEventJobsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEventJobsOperationCompleted);
            }
            this.InvokeAsync("getEventJobs", new object[] {
                        EventID,
                        JobStatus}, this.getEventJobsOperationCompleted, userState);
        }
        
        private void OngetEventJobsOperationCompleted(object arg) {
            if ((this.getEventJobsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEventJobsCompleted(this, new getEventJobsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getEventCodeName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getEventCodeName(int EventID) {
            object[] results = this.Invoke("getEventCodeName", new object[] {
                        EventID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getEventCodeNameAsync(int EventID) {
            this.getEventCodeNameAsync(EventID, null);
        }
        
        /// <remarks/>
        public void getEventCodeNameAsync(int EventID, object userState) {
            if ((this.getEventCodeNameOperationCompleted == null)) {
                this.getEventCodeNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEventCodeNameOperationCompleted);
            }
            this.InvokeAsync("getEventCodeName", new object[] {
                        EventID}, this.getEventCodeNameOperationCompleted, userState);
        }
        
        private void OngetEventCodeNameOperationCompleted(object arg) {
            if ((this.getEventCodeNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEventCodeNameCompleted(this, new getEventCodeNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getTeamRota", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getTeamRota(int EventID) {
            object[] results = this.Invoke("getTeamRota", new object[] {
                        EventID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getTeamRotaAsync(int EventID) {
            this.getTeamRotaAsync(EventID, null);
        }
        
        /// <remarks/>
        public void getTeamRotaAsync(int EventID, object userState) {
            if ((this.getTeamRotaOperationCompleted == null)) {
                this.getTeamRotaOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTeamRotaOperationCompleted);
            }
            this.InvokeAsync("getTeamRota", new object[] {
                        EventID}, this.getTeamRotaOperationCompleted, userState);
        }
        
        private void OngetTeamRotaOperationCompleted(object arg) {
            if ((this.getTeamRotaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTeamRotaCompleted(this, new getTeamRotaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getEventStartDateTime", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getEventStartDateTime(int EventID, string SE) {
            object[] results = this.Invoke("getEventStartDateTime", new object[] {
                        EventID,
                        SE});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getEventStartDateTimeAsync(int EventID, string SE) {
            this.getEventStartDateTimeAsync(EventID, SE, null);
        }
        
        /// <remarks/>
        public void getEventStartDateTimeAsync(int EventID, string SE, object userState) {
            if ((this.getEventStartDateTimeOperationCompleted == null)) {
                this.getEventStartDateTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEventStartDateTimeOperationCompleted);
            }
            this.InvokeAsync("getEventStartDateTime", new object[] {
                        EventID,
                        SE}, this.getEventStartDateTimeOperationCompleted, userState);
        }
        
        private void OngetEventStartDateTimeOperationCompleted(object arg) {
            if ((this.getEventStartDateTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEventStartDateTimeCompleted(this, new getEventStartDateTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getJobData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getJobData(int EventID, int JobID) {
            object[] results = this.Invoke("getJobData", new object[] {
                        EventID,
                        JobID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getJobDataAsync(int EventID, int JobID) {
            this.getJobDataAsync(EventID, JobID, null);
        }
        
        /// <remarks/>
        public void getJobDataAsync(int EventID, int JobID, object userState) {
            if ((this.getJobDataOperationCompleted == null)) {
                this.getJobDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetJobDataOperationCompleted);
            }
            this.InvokeAsync("getJobData", new object[] {
                        EventID,
                        JobID}, this.getJobDataOperationCompleted, userState);
        }
        
        private void OngetJobDataOperationCompleted(object arg) {
            if ((this.getJobDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getJobDataCompleted(this, new getJobDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/savePrf", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int savePrf(System.Data.DataSet ds) {
            object[] results = this.Invoke("savePrf", new object[] {
                        ds});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void savePrfAsync(System.Data.DataSet ds) {
            this.savePrfAsync(ds, null);
        }
        
        /// <remarks/>
        public void savePrfAsync(System.Data.DataSet ds, object userState) {
            if ((this.savePrfOperationCompleted == null)) {
                this.savePrfOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsavePrfOperationCompleted);
            }
            this.InvokeAsync("savePrf", new object[] {
                        ds}, this.savePrfOperationCompleted, userState);
        }
        
        private void OnsavePrfOperationCompleted(object arg) {
            if ((this.savePrfCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.savePrfCompleted(this, new savePrfCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getPrfData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getPrfData(int EventID, int JobID, int PrfID) {
            object[] results = this.Invoke("getPrfData", new object[] {
                        EventID,
                        JobID,
                        PrfID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getPrfDataAsync(int EventID, int JobID, int PrfID) {
            this.getPrfDataAsync(EventID, JobID, PrfID, null);
        }
        
        /// <remarks/>
        public void getPrfDataAsync(int EventID, int JobID, int PrfID, object userState) {
            if ((this.getPrfDataOperationCompleted == null)) {
                this.getPrfDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPrfDataOperationCompleted);
            }
            this.InvokeAsync("getPrfData", new object[] {
                        EventID,
                        JobID,
                        PrfID}, this.getPrfDataOperationCompleted, userState);
        }
        
        private void OngetPrfDataOperationCompleted(object arg) {
            if ((this.getPrfDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPrfDataCompleted(this, new getPrfDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getnextJobID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getnextJobID(int EventID, int TeamID, int AuditID) {
            object[] results = this.Invoke("getnextJobID", new object[] {
                        EventID,
                        TeamID,
                        AuditID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getnextJobIDAsync(int EventID, int TeamID, int AuditID) {
            this.getnextJobIDAsync(EventID, TeamID, AuditID, null);
        }
        
        /// <remarks/>
        public void getnextJobIDAsync(int EventID, int TeamID, int AuditID, object userState) {
            if ((this.getnextJobIDOperationCompleted == null)) {
                this.getnextJobIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetnextJobIDOperationCompleted);
            }
            this.InvokeAsync("getnextJobID", new object[] {
                        EventID,
                        TeamID,
                        AuditID}, this.getnextJobIDOperationCompleted, userState);
        }
        
        private void OngetnextJobIDOperationCompleted(object arg) {
            if ((this.getnextJobIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getnextJobIDCompleted(this, new getnextJobIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SearchEventsCompletedEventHandler(object sender, SearchEventsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getEventJobsCompletedEventHandler(object sender, getEventJobsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEventJobsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEventJobsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getEventCodeNameCompletedEventHandler(object sender, getEventCodeNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEventCodeNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEventCodeNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getTeamRotaCompletedEventHandler(object sender, getTeamRotaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTeamRotaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTeamRotaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getEventStartDateTimeCompletedEventHandler(object sender, getEventStartDateTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEventStartDateTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEventStartDateTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getJobDataCompletedEventHandler(object sender, getJobDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getJobDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getJobDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void savePrfCompletedEventHandler(object sender, savePrfCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class savePrfCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal savePrfCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getPrfDataCompletedEventHandler(object sender, getPrfDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPrfDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPrfDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getnextJobIDCompletedEventHandler(object sender, getnextJobIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getnextJobIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getnextJobIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591