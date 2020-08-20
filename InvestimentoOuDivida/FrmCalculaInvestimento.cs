using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvestimentoOuDivida
{
    public partial class FrmCalculaInvestimento : Form
    {
        public FrmCalculaInvestimento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LimparResultado();
            FormatarObjetos();
        }

        private void FormatarObjetos()
        {
            if (rdbInvestimento.Checked)
            {
                lblResultado.ForeColor = Color.Blue;
                txtResultado.ForeColor = Color.Blue;
                txtResultado.BackColor = Color.Yellow;
                lblResultado.Text = "Lucro obtido:";
            }
            else
            {
                lblResultado.ForeColor = txtResultado.ForeColor = Color.Red;
                txtResultado.BackColor = Color.Magenta;
                lblResultado.Text = "Perda:";
            }
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado;
                double percentualCalculado =  (Convert.ToDouble(txtValor.Text) * (Convert.ToDouble(txtPercentual.Text)/100));
                if (rdbDivida.Checked)
                {
                    resultado = Convert.ToDouble(txtValor.Text) - percentualCalculado;
                }
                else
                {
                    resultado = Convert.ToDouble(txtValor.Text) + percentualCalculado;
                }
                txtResultado.Text = resultado.ToString();
                FormatarObjetos();

            }
            catch(FormatException exception)
            {
                MessageBox.Show("Os valores informados devem ser núméricos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exception.Message);
            }
        }

        private void rdbDivida_CheckedChanged(object sender, EventArgs e)
        {
            LimparResultado();
            FormatarObjetos();
        }

        private void FrmCalculaInvestimento_Load(object sender, EventArgs e)
        {
            
        }

        private void LimparResultado()
        {
            if (!txtResultado.Text.Equals(""))
            {
                txtResultado.Text = "";
            }
        }
    }
}
