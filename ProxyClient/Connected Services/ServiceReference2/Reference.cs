﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProxyClientx.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://acleite/myservices/2018/12/02", ConfigurationName="ServiceReference2.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Add", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Add", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Subtract", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/SubtractResponse")]
        double Subtract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Subtract", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Multiply", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Multiply", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Divide", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Divide", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Calc", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/CalcResponse")]
        bool Calc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/Calc", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/CalcResponse")]
        System.Threading.Tasks.Task<bool> CalcAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/CloseCalc", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/CloseCalcResponse")]
        void CloseCalc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://acleite/myservices/2018/12/02/ICalculator/CloseCalc", ReplyAction="http://acleite/myservices/2018/12/02/ICalculator/CloseCalcResponse")]
        System.Threading.Tasks.Task CloseCalcAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : ProxyClientx.ServiceReference2.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<ProxyClientx.ServiceReference2.ICalculator>, ProxyClientx.ServiceReference2.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Subtract(double n1, double n2) {
            return base.Channel.Subtract(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2) {
            return base.Channel.SubtractAsync(n1, n2);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2) {
            return base.Channel.MultiplyAsync(n1, n2);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2) {
            return base.Channel.DivideAsync(n1, n2);
        }
        
        public bool Calc() {
            return base.Channel.Calc();
        }
        
        public System.Threading.Tasks.Task<bool> CalcAsync() {
            return base.Channel.CalcAsync();
        }
        
        public void CloseCalc() {
            base.Channel.CloseCalc();
        }
        
        public System.Threading.Tasks.Task CloseCalcAsync() {
            return base.Channel.CloseCalcAsync();
        }
    }
}
