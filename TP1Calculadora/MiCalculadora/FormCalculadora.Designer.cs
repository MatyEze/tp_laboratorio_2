namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvToDecimal = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvToBin = new System.Windows.Forms.Button();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvToDecimal
            // 
            this.btnConvToDecimal.Enabled = false;
            this.btnConvToDecimal.Location = new System.Drawing.Point(373, 244);
            this.btnConvToDecimal.Name = "btnConvToDecimal";
            this.btnConvToDecimal.Size = new System.Drawing.Size(315, 56);
            this.btnConvToDecimal.TabIndex = 8;
            this.btnConvToDecimal.Text = "CONVERTIR A DECIMAL";
            this.btnConvToDecimal.UseVisualStyleBackColor = true;
            this.btnConvToDecimal.Click += new System.EventHandler(this.btnConvToDecimal_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 169);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(198, 56);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "OPERAR";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(250, 169);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(198, 56);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(490, 169);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(198, 56);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvToBin
            // 
            this.btnConvToBin.Enabled = false;
            this.btnConvToBin.Location = new System.Drawing.Point(12, 244);
            this.btnConvToBin.Name = "btnConvToBin";
            this.btnConvToBin.Size = new System.Drawing.Size(315, 56);
            this.btnConvToBin.TabIndex = 7;
            this.btnConvToBin.Text = "CONVERTIR A BINARIO";
            this.btnConvToBin.UseVisualStyleBackColor = true;
            this.btnConvToBin.Click += new System.EventHandler(this.btnConvToBin_Click);
            // 
            // txbNumero1
            // 
            this.txbNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumero1.Location = new System.Drawing.Point(12, 75);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(198, 53);
            this.txbNumero1.TabIndex = 1;
            this.txbNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNumero2
            // 
            this.txbNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumero2.Location = new System.Drawing.Point(490, 75);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(198, 53);
            this.txbNumero2.TabIndex = 3;
            this.txbNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperadores.Location = new System.Drawing.Point(289, 75);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOperadores.Size = new System.Drawing.Size(121, 54);
            this.cmbOperadores.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResultado.Location = new System.Drawing.Point(12, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultado.Size = new System.Drawing.Size(0, 46);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.TextChanged += new System.EventHandler(this.lblResultado_TextChanged);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperadores);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.btnConvToBin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnConvToDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Matias Sellanes de 2°D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvToDecimal;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvToBin;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.Label lblResultado;
    }
}

