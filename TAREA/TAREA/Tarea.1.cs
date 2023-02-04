using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            String numero, nume;

            if (NumeroTextBox.Text == "")
            {
                errorProvider.SetError(NumeroTextBox, "Ingrese un valor");
                return;
            }
            errorProvider.Clear();

            int num = Convert.ToInt32(NumeroTextBox.Text);
            numero = ParImpar(num);
            nume = PositivoNegativo(num);
            MessageBox.Show("El valor ingresado es " + numero + " y " + nume, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //label2.Text = Convert.ToString("El valor ingresado es " + numero + " y " + nume);
        }

        private String ParImpar(int num)
        {
            int n = num % 2;
            String resultado;

            if (n == 0)
                resultado = "Par";
            else
                resultado = "Impar";

            return resultado;
        }

        private String PositivoNegativo(int numero)
        {
            String resultad2;

            if (numero > 0)
                resultad2 = "Positivo";
            else
                resultad2 = "Negativo";

            return resultad2;
        }
    }
}
    
