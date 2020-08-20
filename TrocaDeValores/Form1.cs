using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class Form1 : Form
    {
        //sobreposiçao ou polimorfismo de sobrecarga: Métodos de mesmo nome na mesma classe, porém com assinaturas diferentes
        //assinatura de um método: corresponde a quantidade e tipos de parâmetros que o método possui
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MeuMetodo()
        {

        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string aux = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = aux;

            MessageBox.Show("Troca de valores efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
