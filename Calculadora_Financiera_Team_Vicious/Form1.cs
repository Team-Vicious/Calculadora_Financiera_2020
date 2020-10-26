using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_Team_Vicious
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //CLASES GENERADAS POR EL IDE 
        //NO BORRARLAS SINO SE ROMPE EL PROGRAMA
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void text_RESULT_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_RESULTADO_TextChanged(object sender, EventArgs e)
        {

        }


        //BOTON PARA SALIR
        private void butt_OUT_Click(object sender, EventArgs e)
        {
            //Application.Exit(); esta funcion te permite salir automaticamente

            if (MessageBox.Show("Desea SALIR???", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)

            {
                this.Close();
            }

        }

        //BOTON QUE BORRA TODO EL CONTENIDO ASIGNADO
        private void butt_DEL_Click(object sender, EventArgs e)
        {
            text_val1opf.Clear();
            text_val2opf.Clear();
            text_val3opf.Clear();
            textBox_FORMULA.Clear();
            textBox_RESULTADO.Clear();
        }

        //METODOS QUE PERMITEN SOLO EL INGRESO DE VALORES NUMERICOS EN CADA CELDA VALOR
        private void text_val1opf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 40 && e.KeyChar <= 57)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void text_val2opf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 40 && e.KeyChar <= 57)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
        private void text_val3opf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 40 && e.KeyChar <= 57)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        //BOTONES PARA BORRAR CADA DATO INGRESADO EN CASO DE ERROR

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_val1opf.TextLength >= 1)
            {
                text_val1opf.Text = text_val1opf.Text.Remove(text_val1opf.Text.Length - 1, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_val2opf.TextLength >= 1)
            {
                text_val2opf.Text = text_val2opf.Text.Remove(text_val2opf.Text.Length - 1, 1);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (text_val3opf.TextLength >= 1)
            {
                text_val3opf.Text = text_val3opf.Text.Remove(text_val3opf.Text.Length - 1, 1);
            }

        }

        //MENU DE OPERACIONES QUE MUESTRAN SUS FORMULAS PARA VERIFICAR SI SON LAS INDICADAS
        private void comboBox_opf_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox_opf.Text;
            /*
            *********** DEFINICIONES IMPORTANTES ******************
            I = Interés expresado en valores monetarios
            VA = Valor actual, expresado en unidades monetarias
            VF = Valor futuro, expresado en unidades monetarias
            n = Periodo de capitalización, unidad de tiempo, años, meses, diario,...
            i = Tasa de interés, porcentaje anual, mensual, diario, llamado también tasa de interés real.

            */
            switch (seleccion)
            {
                case "INTERES SIMPLE GENERAL":

                    textBox_FORMULA.Text = "VF = VA(1+ n* i )";

                    break;

                case "INTERES DE UNA INVERSION":

                    textBox_FORMULA.Text = " I = VA * n * i";
                    break;


                case "TASA DE INTERES 1":
                    textBox_FORMULA.Text = "i = (I / VA) * n";
                    break;

                case "TASA DE INTERES 2":
                    textBox_FORMULA.Text = "i = ((VF/VA) - 1 )/ n";
                    break;

                case "PERIODO DE CAPITALIZACION 1":
                    textBox_FORMULA.Text = "n = (I / VA) * n";
                    break;

                case "PERIODO DE CAPITALIZACION 2":
                    textBox_FORMULA.Text = "n = ((VF/VA) - 1 )/ i";
                    break;
                case "DESCUENTO SIMPLE 1":

                    textBox_FORMULA.Text = "DR = VF – VA";
                    break;

                case "DESCUENTO SIMPLE 2":

                    textBox_FORMULA.Text = "DR = VF * n * i";
                    break;

                case "INTERES COMPUESTO GENERAL":

                    textBox_FORMULA.Text = "VF = VA * ((1 + i)^n) ";
                    break;

                case "CAPITALIZACION COMPUESTA":

                    textBox_FORMULA.Text = "I = VA * ((1+i)^n−1)";
                    break;

                case "VALOR ACTUAL A INTERES COMPUESTO":
                    textBox_FORMULA.Text = "VA = VF / (1+i)^n";
                    break;

                case "TASA DEL PERIODO DE CAPITALIZACION ":
                    textBox_FORMULA.Text = "i = n^√(VF/VA) - 1";
                    break;
                case "CALCULO DE LA DURACION DE LA OPERACION FINANCIERA":
                    textBox_FORMULA.Text = "n = (log(VF/VA))/ log(1+i) ";
                    
                    break;

            }

        }

        //BOTON QUE PERMITE REALIZAR LAS DIFERENTES OPERACIONES
        private void butt_OP_Click(object sender, EventArgs e)
        {
            string op = comboBox_opf.Text;

            double val1 = Convert.ToDouble(text_val1opf.Text);
            double val2 = Convert.ToDouble(text_val2opf.Text);
            double val3 = Convert.ToDouble(text_val3opf.Text);
            double result = 0;

            switch (op)
            {
                case "INTERES SIMPLE GENERAL":
                    
                    result = val1 * (1 + val2 * val3);

                    textBox_RESULTADO.Text = result.ToString();

                    break;

                case "INTERES DE UNA INVERSION":

                    result = val1 * val2 * val3;
                    textBox_RESULTADO.Text = result.ToString();
                    break;

                case "TASA DE INTERES 1":

                    if (val2 != 0 && val3 != 0)
                    {
                        result = (val1 / val2) * val3;
                        textBox_RESULTADO.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por CERO", "CUIDADO¡¡¡",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        text_val1opf.Clear();
                        text_val2opf.Clear();
                        text_val3opf.Clear();
                        textBox_RESULTADO.Clear();
                        textBox_FORMULA.Clear();
                    }
                    break;

                case "TASA DE INTERES 2":

                    if (val2 != 0 && val3 != 0)
                    {
                        result = ((val1 / val2) - 1)/val3 ;
                        textBox_RESULTADO.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por CERO", "CUIDADO¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_val1opf.Clear();
                        text_val2opf.Clear();
                        text_val3opf.Clear();
                        textBox_RESULTADO.Clear();
                        textBox_FORMULA.Clear();
                    }
                    break;

                case "PERIODO DE CAPITALIZACION 1":

                    if (val2 != 0 && val3 != 0)
                    {
                        result = val1 / val2 * val3;
                        textBox_RESULTADO.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por CERO", "CUIDADO¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_val1opf.Clear();
                        text_val2opf.Clear();
                        text_val3opf.Clear();
                        textBox_RESULTADO.Clear();
                        textBox_FORMULA.Clear();
                    }
                    break;
               
                case "PERIODO DE CAPITALIZACION 2":

                    if (val2 != 0 && val3 != 0)
                    {
                        result = ((val1 / val2) - 1 ) / val3;
                        textBox_RESULTADO.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por CERO", "CUIDADO¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_val1opf.Clear();
                        text_val2opf.Clear();
                        text_val3opf.Clear();
                        textBox_RESULTADO.Clear();
                        textBox_FORMULA.Clear();
                    }
                    break;
               
                case "DESCUENTO SIMPLE 1":

                    result = val1 - val2;

                    textBox_RESULTADO.Text = result.ToString();

                    break;

                case "DESCUENTO SIMPLE 2":

                    result = val1 * val2 * val3;

                    textBox_RESULTADO.Text = result.ToString();

                    break;

                case "INTERES COMPUESTO GENERAL":
                    result = val1 * Math.Pow(1 + val2, val3);

                    textBox_RESULTADO.Text = result.ToString();

                    break;

                case "CAPITALIZACION COMPUESTA":

                    result = val1 * Math.Pow(1 + val2, val3 - 1);
                   
                    textBox_RESULTADO.Text = result.ToString();
                    
                    break;

                case "VALOR ACTUAL A INTERES COMPUESTO":
                    result = val1 / Math.Pow(1 + val2, val3);
                    
                    textBox_RESULTADO.Text = result.ToString();
                    
                    break;
                
                case "TASA DEL PERIODO DE CAPITALIZACION ":

                    if(val2 != 0 && val3 != 0)
                    {
                        result = Math.Pow((val1 / val2) - 1, 1 / val3);
                        
                        textBox_RESULTADO.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por CERO", "CUIDADO¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_val1opf.Clear();
                        text_val2opf.Clear();
                        text_val3opf.Clear();
                        textBox_RESULTADO.Clear();
                        textBox_FORMULA.Clear();
                    }
                    
                    
                    break;
                case "CALCULO DE LA DURACION DE LA OPERACION FINANCIERA":

                    if (val1 < 0 || val3 < 0)
                    {
                        MessageBox.Show("No se puede calcular logaritmo de numeros negativos", "CUIDADO¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_val1opf.Clear();
                        text_val2opf.Clear();
                        text_val3opf.Clear();
                        textBox_RESULTADO.Clear();
                        textBox_FORMULA.Clear();
                        textBox_RESULTADO.Text = result.ToString();
                    }

                    else if (val2 == 0)
                    {
                        MessageBox.Show("No se puede dividir por CERO", "CUIDADO¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        text_val1opf.Clear();
                        text_val2opf.Clear();
                        text_val3opf.Clear();
                        textBox_RESULTADO.Clear();
                        textBox_FORMULA.Clear();
                    }
                    else
                    {

                        result = Math.Log(val1 / val2) / Math.Log(1 + val3);
                        textBox_RESULTADO.Text = result.ToString();
                    }
                    break;
                default:
                    break;
            }

        }
    }
    }

