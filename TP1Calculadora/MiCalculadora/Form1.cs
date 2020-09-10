using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        bool isBin = false;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperadores.SelectedIndex != -1 && this.txbNumero1.Text != null && this.txbNumero2.Text != null)
            {
                this.lblResultado.Text = FormCalculadora.Operar(this.txbNumero1.Text, this.txbNumero2.Text, this.cmbOperadores.SelectedItem.ToString()).ToString();
                isBin = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            isBin = false;
        }

        private void btnConvToBin_Click(object sender, EventArgs e)
        {
            if (!isBin)
            {
                this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
                isBin = true;
            }
        }

        private void btnConvToDecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
            isBin = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static private double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }

        private void Limpiar()
        {
            this.txbNumero1.Text = string.Empty;
            this.txbNumero2.Text = string.Empty;
            this.cmbOperadores.SelectedIndex = -1;
            this.lblResultado.Text = string.Empty;
        }
    }
}
