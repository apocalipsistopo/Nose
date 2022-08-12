using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Calculadora_Somee
{
   
    public partial class WebForm1 : System.Web.UI.Page
    {

        ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        static double nro1;
        static string operacion="";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            digitar("1");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            digitar("2");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            digitar("3");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            digitar("4");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            digitar("5");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            digitar("6");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            digitar("7");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            digitar("8");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            digitar("9");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            digitar("0");
        }
       

        protected void Button13_Click(object sender, EventArgs e)
        {
            operacionmetodo("+");
        }


       

        protected void Button14_Click(object sender, EventArgs e)
        {
            operacionmetodo("-");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            operacionmetodo("x");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            operacionmetodo("/");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            operacionmetodo("%");
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            nro1 = Convert.ToDouble(txtLabel.Text);
            txtLabel.Text = service.factorial(nro1).ToString();
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            nro1 = Convert.ToDouble(txtLabel.Text);
            txtLabel.Text = service.logaritmo(nro1).ToString();
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            nro1 = Convert.ToDouble(txtLabel.Text);
            txtLabel.Text = service.vabsoluto(nro1).ToString();
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            nro1 = Convert.ToDouble(txtLabel.Text);
            txtLabel.Text = service.Raiz(nro1).ToString();
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            operacionmetodo("^");
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            digitar(".");
        }
        protected void Button23_Click(object sender, EventArgs e)
        {
            igual(Convert.ToDouble(txtLabel.Text),"");
        }
        private void digitar(String nro)
        {
            string numero=txtLabel.Text+nro ;
            txtLabel.Text = numero;
        }
        private void operacionmetodo(String operando)
        {
            
            if (operacion=="")
            {
                Console.WriteLine(txtLabel.Text);
                nro1 = Convert.ToDouble(txtLabel.Text);
                operacion = operando;
               
            }
            else
            {
                igual(Convert.ToDouble(txtLabel.Text),operando);
            }
            txtLabel.Text = "";


        }
         private void igual(Double nro2,String signo) {
            switch (operacion) 
            {
                case "+":
                    {
                        txtLabel.Text= service.SumaOperaciones(nro1, nro2).ToString();
                        break;
                    }
                case "-":
                    {
                        txtLabel.Text = service.Restar(nro1, nro2).ToString();
                        break;
                    }
                case "x":
                    {
                        txtLabel.Text = service.multiplicacion(nro1, nro2).ToString();
                        break;
                    }
                case "/":
                    {
                        txtLabel.Text = service.dividir(nro1, nro2).ToString();
                        break;
                    }
                case "%":
                    {
                        txtLabel.Text = service.porcentaje(nro1, nro2).ToString();
                        break;
                    }
           
                case "^":
                    {
                        txtLabel.Text = service.PotenciaOperaciones(nro1, nro2).ToString();
                        break;
                    }

            }
            nro1 = Convert.ToDouble(txtLabel.Text);
            operacion = signo;
                
           

           }

        
    }
    
}