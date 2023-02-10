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
    public partial class TareaEjer2 : Form
    {
        public TareaEjer2()
        {
            InitializeComponent();
        }


        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            if (Nota1TextBox.Text == "" )
            {
                errorProvider.SetError(Nota1TextBox, "Ingrese un valor");
                return;
            }
            if ( Nota2TextBox.Text == "" )
            {
                errorProvider.SetError(Nota2TextBox, "Ingrese un valor");
                return;
            }
            if ( Nota3TextBox.Text == "" )
            {
                errorProvider.SetError(Nota3TextBox, "Ingrese un valor");
                return;
            }
            if ( Nota4TextBox.Text == "" )
            {
                errorProvider.SetError(Nota4TextBox, "Ingrese un valor");
                return;
            }

            errorProvider.Clear();


          decimal nota1 =Convert.ToDecimal(Nota1TextBox.Text);
          decimal nota2 = Convert.ToDecimal(Nota2TextBox.Text);
          decimal nota3 = Convert.ToDecimal(Nota3TextBox.Text);
          decimal nota4 = Convert.ToDecimal(Nota4TextBox.Text);

          decimal notaPromedio = await CalcularPromedioAsync(nota1, nota2, nota3, nota4);

            if (notaPromedio < 65)
            {
                label6.Text = "Repobado";
            }
            else
            {
                label6.Text = "Aprobado";
            }

          NotaFinalTextBox.Text = notaPromedio.ToString();

           
          
        }

        private async Task<decimal> CalcularPromedioAsync(decimal not1, decimal not2, decimal not3, decimal not4)
        {
            decimal promedio = await Task.Run(() =>
            {
                decimal suma = not1 + not2 + not3 + not4;
                promedio = suma / 4;
                return promedio;
            });

            return promedio;
        }
    }
}
