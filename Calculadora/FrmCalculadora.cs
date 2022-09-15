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
    public partial class FrmCalculadora : Form
    {
        public enum Operador
        {
            Soma = 1,
            Subtrai = 2,
            Multiplica = 3,
            Divide = 4
        }

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            rbtnSomar.Checked = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal num1;
            decimal num2;
            try
            {
                num1 = Convert.ToDecimal(tbNumero1.Text);
                num2 = Convert.ToDecimal(tbNumero2.Text);
            }
            catch (Exception)
            {
                Console.WriteLine("Campos devem ser preenchidos apenas com números. ");
                throw;
            }

            var calc = Calculo.Resultado(num1, num2, GetOperacao());
            tbResultado.Text = calc;
        }

        private Operador GetOperacao()
        {
            if (rbtnSomar.Checked == true)
            {
                return Operador.Soma;
            }
            else if (rbtnSubtrair.Checked == true)
            {
                return Operador.Subtrai;
            }
            else if (rbtnDividir.Checked == true)
            {
                return Operador.Divide;
            }
            else
            {
                return Operador.Multiplica;
            }
        }
    }
}
