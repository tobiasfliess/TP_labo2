
namespace TPFinal
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tablero = new System.Windows.Forms.PictureBox();
            this.Torre2 = new System.Windows.Forms.PictureBox();
            this.Torre1 = new System.Windows.Forms.PictureBox();
            this.Rey = new System.Windows.Forms.PictureBox();
            this.Reina = new System.Windows.Forms.PictureBox();
            this.Caballo2 = new System.Windows.Forms.PictureBox();
            this.Caballo1 = new System.Windows.Forms.PictureBox();
            this.Alfil1 = new System.Windows.Forms.PictureBox();
            this.Alfil2 = new System.Windows.Forms.PictureBox();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Anterior = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Torre2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Torre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caballo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caballo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alfil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alfil2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablero
            // 
            this.Tablero.Image = global::TPFinal.Properties.Resources.Tablero;
            this.Tablero.Location = new System.Drawing.Point(-111, -23);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(1135, 613);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tablero.TabIndex = 0;
            this.Tablero.TabStop = false;
            this.Tablero.Click += new System.EventHandler(this.Tablero_Click);
            // 
            // Torre2
            // 
            this.Torre2.Image = global::TPFinal.Properties.Resources.Torre;
            this.Torre2.Location = new System.Drawing.Point(797, 523);
            this.Torre2.Name = "Torre2";
            this.Torre2.Size = new System.Drawing.Size(67, 65);
            this.Torre2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Torre2.TabIndex = 2;
            this.Torre2.TabStop = false;
            // 
            // Torre1
            // 
            this.Torre1.Image = global::TPFinal.Properties.Resources.Torre;
            this.Torre1.Location = new System.Drawing.Point(797, 452);
            this.Torre1.Name = "Torre1";
            this.Torre1.Size = new System.Drawing.Size(67, 65);
            this.Torre1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Torre1.TabIndex = 3;
            this.Torre1.TabStop = false;
            // 
            // Rey
            // 
            this.Rey.Image = global::TPFinal.Properties.Resources.Rey;
            this.Rey.Location = new System.Drawing.Point(797, 381);
            this.Rey.Name = "Rey";
            this.Rey.Size = new System.Drawing.Size(67, 65);
            this.Rey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rey.TabIndex = 4;
            this.Rey.TabStop = false;
            // 
            // Reina
            // 
            this.Reina.Image = global::TPFinal.Properties.Resources.Reina;
            this.Reina.Location = new System.Drawing.Point(797, 310);
            this.Reina.Name = "Reina";
            this.Reina.Size = new System.Drawing.Size(67, 65);
            this.Reina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reina.TabIndex = 5;
            this.Reina.TabStop = false;
            // 
            // Caballo2
            // 
            this.Caballo2.Image = global::TPFinal.Properties.Resources.Caballo;
            this.Caballo2.Location = new System.Drawing.Point(886, 94);
            this.Caballo2.Name = "Caballo2";
            this.Caballo2.Size = new System.Drawing.Size(67, 65);
            this.Caballo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Caballo2.TabIndex = 6;
            this.Caballo2.TabStop = false;
            // 
            // Caballo1
            // 
            this.Caballo1.Image = global::TPFinal.Properties.Resources.Caballo;
            this.Caballo1.Location = new System.Drawing.Point(797, 12);
            this.Caballo1.Name = "Caballo1";
            this.Caballo1.Size = new System.Drawing.Size(67, 65);
            this.Caballo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Caballo1.TabIndex = 7;
            this.Caballo1.TabStop = false;
            // 
            // Alfil1
            // 
            this.Alfil1.Image = global::TPFinal.Properties.Resources.Alfil;
            this.Alfil1.Location = new System.Drawing.Point(797, 94);
            this.Alfil1.Name = "Alfil1";
            this.Alfil1.Size = new System.Drawing.Size(76, 63);
            this.Alfil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Alfil1.TabIndex = 8;
            this.Alfil1.TabStop = false;
            // 
            // Alfil2
            // 
            this.Alfil2.Image = global::TPFinal.Properties.Resources.Alfil;
            this.Alfil2.Location = new System.Drawing.Point(886, 178);
            this.Alfil2.Name = "Alfil2";
            this.Alfil2.Size = new System.Drawing.Size(67, 65);
            this.Alfil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Alfil2.TabIndex = 9;
            this.Alfil2.TabStop = false;
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(776, 224);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 80);
            this.Siguiente.TabIndex = 10;
            this.Siguiente.Text = ">";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(46, 224);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(75, 80);
            this.Anterior.TabIndex = 11;
            this.Anterior.Text = "<";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(417, 596);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 12;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 640);
            this.ControlBox = false;
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Alfil2);
            this.Controls.Add(this.Alfil1);
            this.Controls.Add(this.Caballo1);
            this.Controls.Add(this.Caballo2);
            this.Controls.Add(this.Reina);
            this.Controls.Add(this.Rey);
            this.Controls.Add(this.Torre1);
            this.Controls.Add(this.Torre2);
            this.Controls.Add(this.Tablero);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Torre2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Torre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caballo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caballo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alfil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alfil2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tablero;
        public System.Windows.Forms.PictureBox Torre2;
        public System.Windows.Forms.PictureBox Torre1;
        public System.Windows.Forms.PictureBox Rey;
        public System.Windows.Forms.PictureBox Reina;
        public System.Windows.Forms.PictureBox Caballo2;
        public System.Windows.Forms.PictureBox Caballo1;
        public System.Windows.Forms.PictureBox Alfil1;
        public System.Windows.Forms.PictureBox Alfil2;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Salir;
    }
}