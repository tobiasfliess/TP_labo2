
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
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciar.Location = new System.Drawing.Point(103, 87);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(113, 53);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCosto
            // 
            this.btnCosto.Location = new System.Drawing.Point(103, 146);
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
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(316, 314);
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
    }
}

