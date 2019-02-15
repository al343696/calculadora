using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacion="";
        double operando1;
        string operando2="";
        double resultado;
        double numero;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "0";
            }
            if (pantalla.Text != "0")
            {
                pantalla.Text = pantalla.Text + "0";
            }
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "1";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "1";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "1";
                }
            }
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "2";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "2";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "2";
                }
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "3";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "3";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "3";
                }
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "4";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "4";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "4";
                }
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "5";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "5";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "5";
                }
            }
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "6";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "6";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "6";
                }
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "7";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "7";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "7";
                }
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "8";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "8";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "8";
                }
            }
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text == operacion)
            {
                pantalla.Text = "9";
            }
            else
            {
                if (pantalla.Text.Length == 1 && pantalla.Text[0] == '0')
                {
                    pantalla.Text = "9";
                }
                else
                {
                    pantalla.Text = pantalla.Text + "9";
                }
            }
        }

        private void buttonCE_MouseClick(object sender, MouseEventArgs e)
        {
            pantalla.Text = "0";
        }

        private void buttonC_MouseClick(object sender, MouseEventArgs e)
        {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonCE.Enabled = true;
            buttonDIVISION.Enabled = true;
            buttonIGUAL.Enabled = true;
            buttonMULTIPLICACION.Enabled = true;
            buttonPUNTO.Enabled = true;
            buttonRESTA.Enabled = true;
            buttonSUMA.Enabled = true;
            buttoncambiosigno.Enabled = true;
            pantalla.Text = "0";


        }

        private void buttonRESTA_MouseClick(object sender, MouseEventArgs e)
        {
            if (operacion.Length == 1 && pantalla.Text != operacion)
            {
                operando2 = pantalla.Text;
                switch (operacion)
                {
                    case "-":
                        operando1 = operando1 - Convert.ToDouble(operando2);
                        break;
                    case "+":
                        operando1 = operando1 + Convert.ToDouble(operando2);
                        break;
                    case "*":
                        operando1 = operando1 * Convert.ToDouble(operando2);
                        break;
                    case "/":
                        operando1 = operando1 / Convert.ToDouble(operando2);
                        break;
                    default:
                        break;
                }
                operando2 = "";
                operacion = "-";
                pantalla.Text = operacion;
            }
            else
            {
                if (pantalla.Text != operacion)
                {
                    operando1 = Convert.ToDouble(pantalla.Text);
                    operacion = "-";
                    pantalla.Text = operacion;
                }
            }
        }

        private void buttonSUMA_MouseClick(object sender, MouseEventArgs e)
        {
            if (operacion.Length == 1 && pantalla.Text != operacion)
            {
                operando2 = pantalla.Text;
                switch (operacion)
                {
                    case "-":
                        operando1 = operando1 - Convert.ToDouble(operando2);
                        break;
                    case "+":
                        operando1 = operando1 + Convert.ToDouble(operando2);
                        break;
                    case "*":
                        operando1 = operando1 * Convert.ToDouble(operando2);
                        break;
                    case "/":
                        operando1 = operando1 / Convert.ToDouble(operando2);
                        break;
                    default:
                        break;
                }
                operando2 = "";
                operacion = "+";
                pantalla.Text = operacion;
            }
            else
            {
                if (pantalla.Text != operacion)
                {
                    operando1 = Convert.ToDouble(pantalla.Text);
                    operacion = "+";
                    pantalla.Text = operacion;
                }
            }
        }

        private void buttonMULTIPLICACION_MouseClick(object sender, MouseEventArgs e)
        {
            if (operacion.Length == 1 && pantalla.Text != operacion)
            {
                operando2 = pantalla.Text;
                switch (operacion)
                {
                    case "-":
                        operando1 = operando1 - Convert.ToDouble(operando2);
                        break;
                    case "+":
                        operando1 = operando1 + Convert.ToDouble(operando2);
                        break;
                    case "*":
                        operando1 = operando1 * Convert.ToDouble(operando2);
                        break;
                    case "/":
                        operando1 = operando1 / Convert.ToDouble(operando2);
                        break;
                    default:
                        break;
                }
                operando2 = "";
                operacion = "*";
                pantalla.Text = operacion;
            }
            else
            {
                if (pantalla.Text != operacion)
                {
                    operando1 = Convert.ToDouble(pantalla.Text);
                    operacion = "*";
                    pantalla.Text = operacion;
                }
            }
        }

        private void buttonDIVISION_MouseClick(object sender, MouseEventArgs e)
        {
            if (operacion.Length == 1 && pantalla.Text != operacion)
            {
                operando2 = pantalla.Text;
                switch (operacion)
                {
                    case "-":
                        operando1 = operando1 - Convert.ToDouble(operando2);
                        break;
                    case "+":
                        operando1 = operando1 + Convert.ToDouble(operando2);
                        break;
                    case "*":
                        operando1 = operando1 * Convert.ToDouble(operando2);
                        break;
                    case "/":
                        operando1 = operando1 / Convert.ToDouble(operando2);
                        break;
                    default:
                        break;
                }
                operando2 = "";
                operacion = "/";
                pantalla.Text = operacion;
            }
            else
            {
                if (pantalla.Text != operacion)
                {
                    operando1 = Convert.ToDouble(pantalla.Text);
                    operacion = "/";
                    pantalla.Text = operacion;
                }
            }
        }

        private void buttonPUNTO_MouseClick(object sender, MouseEventArgs e)
        {
            if (!pantalla.Text.Contains(","))
            {
                pantalla.Text = pantalla.Text + ",";
            }
        }

        private void buttonIGUAL_MouseClick(object sender, MouseEventArgs e)
        {
            if (operando2!=operacion)
            {
                operando2 = pantalla.Text;
            }
            if (operacion.Length==1)
            {
                switch (operacion)
                {
                    case "-":
                        resultado = operando1 - Convert.ToDouble(operando2);
                        pantalla.Text = Convert.ToString(resultado);
                        break;
                    case "+":
                        resultado = operando1 + Convert.ToDouble(operando2);
                        pantalla.Text = Convert.ToString(resultado);
                        break;
                    case "*":
                        resultado = operando1 * Convert.ToDouble(operando2);
                        pantalla.Text = Convert.ToString(resultado);
                        break;
                    case "/":
                        if (operando1==0 && operando2 == "0")
                        {
                            pantalla.Text = "ERROR";
                            button0.Enabled = false;
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            button5.Enabled = false;
                            button6.Enabled = false;
                            button7.Enabled = false;
                            button8.Enabled = false;
                            button9.Enabled = false;
                            buttonCE.Enabled = false;
                            buttonDIVISION.Enabled = false;
                            buttonIGUAL.Enabled = false;
                            buttonMULTIPLICACION.Enabled = false;
                            buttonPUNTO.Enabled = false;
                            buttonRESTA.Enabled = false;
                            buttonSUMA.Enabled = false;
                            buttoncambiosigno.Enabled = false;
                            break;
                        }
                        else
                        {
                            resultado = operando1 / Convert.ToDouble(operando2);
                            pantalla.Text = Convert.ToString(resultado);
                            break;
                        } 

                       
                    default:
                        break;
                }
                operacion = "";
                operando2 = "";
            }
        }

        private void buttoncambiosigno_MouseClick(object sender, MouseEventArgs e)
        {
            if (pantalla.Text != operacion)
            {           
                numero = Convert.ToDouble(pantalla.Text);
                pantalla.Text = Convert.ToString(-numero);
                
            }
        }
    }
}
