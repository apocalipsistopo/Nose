﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculadora_Somee.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Restar", ReplyAction="*")]
        double Restar(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Restar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RestarAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumaOperaciones", ReplyAction="*")]
        double SumaOperaciones(double nro1, double nro2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumaOperaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SumaOperacionesAsync(double nro1, double nro2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Raiz", ReplyAction="*")]
        double Raiz(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Raiz", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RaizAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PotenciaOperaciones", ReplyAction="*")]
        double PotenciaOperaciones(double base1, double exp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PotenciaOperaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<double> PotenciaOperacionesAsync(double base1, double exp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/logaritmo", ReplyAction="*")]
        double logaritmo(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/logaritmo", ReplyAction="*")]
        System.Threading.Tasks.Task<double> logaritmoAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/factorial", ReplyAction="*")]
        double factorial(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/factorial", ReplyAction="*")]
        System.Threading.Tasks.Task<double> factorialAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dividir", ReplyAction="*")]
        double dividir(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dividir", ReplyAction="*")]
        System.Threading.Tasks.Task<double> dividirAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/porcentaje", ReplyAction="*")]
        double porcentaje(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/porcentaje", ReplyAction="*")]
        System.Threading.Tasks.Task<double> porcentajeAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicacion", ReplyAction="*")]
        double multiplicacion(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicacion", ReplyAction="*")]
        System.Threading.Tasks.Task<double> multiplicacionAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vabsoluto", ReplyAction="*")]
        double vabsoluto(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vabsoluto", ReplyAction="*")]
        System.Threading.Tasks.Task<double> vabsolutoAsync(double n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Calculadora_Somee.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Calculadora_Somee.ServiceReference1.WebService1Soap>, Calculadora_Somee.ServiceReference1.WebService1Soap {
        
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
        
        public double Restar(double num1, double num2) {
            return base.Channel.Restar(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> RestarAsync(double num1, double num2) {
            return base.Channel.RestarAsync(num1, num2);
        }
        
        public double SumaOperaciones(double nro1, double nro2) {
            return base.Channel.SumaOperaciones(nro1, nro2);
        }
        
        public System.Threading.Tasks.Task<double> SumaOperacionesAsync(double nro1, double nro2) {
            return base.Channel.SumaOperacionesAsync(nro1, nro2);
        }
        
        public double Raiz(double n) {
            return base.Channel.Raiz(n);
        }
        
        public System.Threading.Tasks.Task<double> RaizAsync(double n) {
            return base.Channel.RaizAsync(n);
        }
        
        public double PotenciaOperaciones(double base1, double exp) {
            return base.Channel.PotenciaOperaciones(base1, exp);
        }
        
        public System.Threading.Tasks.Task<double> PotenciaOperacionesAsync(double base1, double exp) {
            return base.Channel.PotenciaOperacionesAsync(base1, exp);
        }
        
        public double logaritmo(double n) {
            return base.Channel.logaritmo(n);
        }
        
        public System.Threading.Tasks.Task<double> logaritmoAsync(double n) {
            return base.Channel.logaritmoAsync(n);
        }
        
        public double factorial(double n) {
            return base.Channel.factorial(n);
        }
        
        public System.Threading.Tasks.Task<double> factorialAsync(double n) {
            return base.Channel.factorialAsync(n);
        }
        
        public double dividir(double num1, double num2) {
            return base.Channel.dividir(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> dividirAsync(double num1, double num2) {
            return base.Channel.dividirAsync(num1, num2);
        }
        
        public double porcentaje(double num1, double num2) {
            return base.Channel.porcentaje(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> porcentajeAsync(double num1, double num2) {
            return base.Channel.porcentajeAsync(num1, num2);
        }
        
        public double multiplicacion(double num1, double num2) {
            return base.Channel.multiplicacion(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> multiplicacionAsync(double num1, double num2) {
            return base.Channel.multiplicacionAsync(num1, num2);
        }
        
        public double vabsoluto(double n) {
            return base.Channel.vabsoluto(n);
        }
        
        public System.Threading.Tasks.Task<double> vabsolutoAsync(double n) {
            return base.Channel.vabsolutoAsync(n);
        }
    }
}