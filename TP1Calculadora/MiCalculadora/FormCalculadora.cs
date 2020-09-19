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
            if (isBin)
            {
                this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
                isBin = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// metodo statico que recibe dos numeros y un operador en forma de string y realizara la operacion correspondiente entre dos Numeros con el valor pasado
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>resultado (double)</returns>
        static private double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// borra los datos de los TextBox, ComboBox y del Label resultado
        /// </summary>
        private void Limpiar()
        {
            this.txbNumero1.Text = string.Empty;
            this.txbNumero2.Text = string.Empty;
            this.cmbOperadores.SelectedIndex = 0;
            this.lblResultado.Text = string.Empty;
        }

        /// <summary>
        /// verifica que haya un resultado cada vez que se cambia el texto de lblResultado para activar o descativar los botones de conversion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != string.Empty)
            {
                this.btnConvToBin.Enabled = true;
                this.btnConvToDecimal.Enabled = true;
            }
            else
            {
                this.btnConvToBin.Enabled = false;
                this.btnConvToDecimal.Enabled = false;
            }
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
