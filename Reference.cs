﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WithDraw", ReplyAction="http://tempuri.org/IService1/WithDrawResponse")]
        double WithDraw(double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WithDraw", ReplyAction="http://tempuri.org/IService1/WithDrawResponse")]
        System.Threading.Tasks.Task<double> WithDrawAsync(double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deposit", ReplyAction="http://tempuri.org/IService1/DepositResponse")]
        double Deposit(double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deposit", ReplyAction="http://tempuri.org/IService1/DepositResponse")]
        System.Threading.Tasks.Task<double> DepositAsync(double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowBanlance", ReplyAction="http://tempuri.org/IService1/ShowBanlanceResponse")]
        double ShowBanlance(string accno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowBanlance", ReplyAction="http://tempuri.org/IService1/ShowBanlanceResponse")]
        System.Threading.Tasks.Task<double> ShowBanlanceAsync(string accno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.IService1>, WindowsFormsApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double WithDraw(double amount) {
            return base.Channel.WithDraw(amount);
        }
        
        public System.Threading.Tasks.Task<double> WithDrawAsync(double amount) {
            return base.Channel.WithDrawAsync(amount);
        }
        
        public double Deposit(double amount) {
            return base.Channel.Deposit(amount);
        }
        
        public System.Threading.Tasks.Task<double> DepositAsync(double amount) {
            return base.Channel.DepositAsync(amount);
        }
        
        public double ShowBanlance(string accno) {
            return base.Channel.ShowBanlance(accno);
        }
        
        public System.Threading.Tasks.Task<double> ShowBanlanceAsync(string accno) {
            return base.Channel.ShowBanlanceAsync(accno);
        }
    }
}
