
namespace TPFinal
{
    partial class FPrincipal
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCosto = new System.Windows.Forms.Button();
            this.CBRotar = new System.Windows.Forms.CheckBox();
            this.Cant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.advertencia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciar.Location = new System.Drawing.Point(103, 105);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(113, 53);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCosto
            // 
            this.btnCosto.Location = new System.Drawing.Point(103, 208);
            this.btnCosto.Name = "btnCosto";
            this.btnCosto.Size = new System.Drawing.Size(113, 53);
            this.btnCosto.TabIndex = 2;
            this.btnCosto.Text = "Calculo de costo";
            this.btnCosto.UseVisualStyleBackColor = true;
            this.btnCosto.Click += new System.EventHandler(this.btnCosto_Click);
            // 
            // CBRotar
            // 
            this.CBRotar.AutoSize = true;
            this.CBRotar.Location = new System.Drawing.Point(23, 35);
            this.CBRotar.Name = "CBRotar";
            this.CBRotar.Size = new System.Drawing.Size(175, 21);
            this.CBRotar.TabIndex = 3;
            this.CBRotar.Text = "Resolver con espejado";
            this.CBRotar.UseVisualStyleBackColor = true;
            // 
            // Cant
            // 
            this.Cant.Location = new System.Drawing.Point(188, 60);
            this.Cant.Name = "Cant";
            this.Cant.Size = new System.Drawing.Size(46, 22);
            this.Cant.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de soluciones:";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(103, 267);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(113, 35);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // advertencia
            // 
            this.advertencia.AutoSize = true;
            this.advertencia.Location = new System.Drawing.Point(240, 51);
            this.advertencia.MaximumSize = new System.Drawing.Size(50, 50);
            this.advertencia.MinimumSize = new System.Drawing.Size(150, 50);
            this.advertencia.Name = "advertencia";
            this.advertencia.Size = new System.Drawing.Size(150, 50);
            this.advertencia.TabIndex = 8;
            this.advertencia.Text = "Debe ingresar un numero mayor a 0\r\n";
            this.advertencia.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Informacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(367, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advertencia);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cant);
            this.Controls.Add(this.CBRotar);
            this.Controls.Add(this.btnCosto);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FPrincipal";
            this.Text = "Ajedrez Virtual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCosto;
        private System.Windows.Forms.CheckBox CBRotar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Cant;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label advertencia;
        private System.Windows.Forms.Button button1;
    }
}

