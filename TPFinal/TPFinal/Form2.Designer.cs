
namespace TPFinal
{
    partial class FInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.MaximumSize = new System.Drawing.Size(300, 300);
            this.label1.MinimumSize = new System.Drawing.Size(300, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 300);
            this.label1.TabIndex = 1;
            this.label1.Text = "Este es el trabajo practico de laboratorio de programacion 2. Consiste en colocar" +
    " las piezas de ajedrez en un tablero de 8x8\r\nde manera que todas las casillas qu" +
    "eden cubiertas\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 146);
            this.Controls.Add(this.label1);
            this.Name = "FInfo";
            this.Text = "Informacion";
            this.Load += new System.EventHandler(this.FInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}