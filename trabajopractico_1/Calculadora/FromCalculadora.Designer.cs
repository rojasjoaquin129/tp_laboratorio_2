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
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnConvertirADecimal = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConvertiraBinario = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.CmbOperador = new System.Windows.Forms.ComboBox();
            this.TxtResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(12, 131);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(141, 34);
            this.BtnOperar.TabIndex = 4;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnConvertirADecimal
            // 
            this.BtnConvertirADecimal.Location = new System.Drawing.Point(222, 186);
            this.BtnConvertirADecimal.Name = "BtnConvertirADecimal";
            this.BtnConvertirADecimal.Size = new System.Drawing.Size(215, 47);
            this.BtnConvertirADecimal.TabIndex = 8;
            this.BtnConvertirADecimal.Text = "Comvertir a Decimal";
            this.BtnConvertirADecimal.UseVisualStyleBackColor = true;
            this.BtnConvertirADecimal.Click += new System.EventHandler(this.BtnConvertirADecimal_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(292, 131);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(145, 34);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConvertiraBinario
            // 
            this.BtnConvertiraBinario.Location = new System.Drawing.Point(12, 186);
            this.BtnConvertiraBinario.Name = "BtnConvertiraBinario";
            this.BtnConvertiraBinario.Size = new System.Drawing.Size(204, 47);
            this.BtnConvertiraBinario.TabIndex = 7;
            this.BtnConvertiraBinario.Text = "Convertir a Binario";
            this.BtnConvertiraBinario.UseVisualStyleBackColor = true;
            this.BtnConvertiraBinario.Click += new System.EventHandler(this.BtnConvertiraBinario_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(159, 131);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(127, 34);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero2.Location = new System.Drawing.Point(292, 64);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(145, 49);
            this.TxtNumero2.TabIndex = 3;
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero1.Location = new System.Drawing.Point(12, 64);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(141, 49);
            this.TxtNumero1.TabIndex = 1;
            // 
            // CmbOperador
            // 
            this.CmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbOperador.FormattingEnabled = true;
            this.CmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CmbOperador.Location = new System.Drawing.Point(181, 65);
            this.CmbOperador.Name = "CmbOperador";
            this.CmbOperador.Size = new System.Drawing.Size(81, 50);
            this.CmbOperador.TabIndex = 2;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.Location = new System.Drawing.Point(12, 9);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(425, 41);
            this.TxtResultado.TabIndex = 0;
            this.TxtResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // formCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 250);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.CmbOperador);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnConvertiraBinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnConvertirADecimal);
            this.Controls.Add(this.BtnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Joaquin Rojas 2C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnConvertirADecimal;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConvertiraBinario;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.ComboBox CmbOperador;
        private System.Windows.Forms.Label TxtResultado;
    }
}

