namespace AplicacionListaDeObjetos
{
    partial class Form1
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
            this.btnObjetos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObjetos
            // 
            this.btnObjetos.Location = new System.Drawing.Point(167, 126);
            this.btnObjetos.Name = "btnObjetos";
            this.btnObjetos.Size = new System.Drawing.Size(75, 23);
            this.btnObjetos.TabIndex = 0;
            this.btnObjetos.Text = "Ver lista";
            this.btnObjetos.UseVisualStyleBackColor = true;
            this.btnObjetos.Click += new System.EventHandler(this.btnObjetos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObjetos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObjetos;
        private System.Windows.Forms.Button button1;
    }
}

