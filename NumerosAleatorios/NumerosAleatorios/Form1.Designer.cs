namespace NumerosAleatorios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNumeroAleatorio = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNumeroAleatorio
            // 
            this.btnNumeroAleatorio.Location = new System.Drawing.Point(198, 173);
            this.btnNumeroAleatorio.Name = "btnNumeroAleatorio";
            this.btnNumeroAleatorio.Size = new System.Drawing.Size(113, 23);
            this.btnNumeroAleatorio.TabIndex = 0;
            this.btnNumeroAleatorio.Text = "Adivina el numero";
            this.btnNumeroAleatorio.UseVisualStyleBackColor = true;
            this.btnNumeroAleatorio.Click += new System.EventHandler(this.btnNumeroAleatorio_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(198, 75);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(113, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnNumeroAleatorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNumeroAleatorio;
        private TextBox txtNumero;
        private Label label1;
    }
}