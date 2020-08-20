using RestoDaDivisao.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class FrmRestoDaDivisao : Form
    {
        public FrmRestoDaDivisao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReaizarDivisao_Click(object sender, EventArgs e)
        {
            int dividendo, divisor;
            try
            {
                dividendo = Convert.ToInt32(txtDividendo.Text);
                divisor = Convert.ToInt32(txtDivisor.Text);
                txtResultado.Text = Calculadora.RestoDaDivisao(dividendo, divisor).ToString();
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(exception.Message);
            }
            catch(DivideByZeroException exception)
            {
                MessageBox.Show("O divisor nao pode ser zero!", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(exception.Message);
            }
            catch(FormatException exception)
            {
                MessageBox.Show("Os valores informados devem corresponder a números inteiros superiores a zero", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
