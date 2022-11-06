namespace GeneradorDeCasos
{
    partial class GeneradorDeCasos
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
            this.btnGenerarCorreo = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAplicacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIbm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.groupBoxDistribuidor = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxUsuario.SuspendLayout();
            this.groupBoxDistribuidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarCorreo
            // 
            this.btnGenerarCorreo.Location = new System.Drawing.Point(605, 532);
            this.btnGenerarCorreo.Name = "btnGenerarCorreo";
            this.btnGenerarCorreo.Size = new System.Drawing.Size(119, 23);
            this.btnGenerarCorreo.TabIndex = 0;
            this.btnGenerarCorreo.Text = "Generar Plantilla";
            this.btnGenerarCorreo.UseVisualStyleBackColor = true;
            this.btnGenerarCorreo.Click += new System.EventHandler(this.btnGenerarCorreo_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(230, 532);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(118, 23);
            this.btnLimpiarCampos.TabIndex = 1;
            this.btnLimpiarCampos.Text = "Limpiar Formulario";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.textBox1);
            this.groupBoxUsuario.Controls.Add(this.label5);
            this.groupBoxUsuario.Controls.Add(this.comboBoxAplicacion);
            this.groupBoxUsuario.Controls.Add(this.label4);
            this.groupBoxUsuario.Controls.Add(this.txtUsuario);
            this.groupBoxUsuario.Controls.Add(this.label3);
            this.groupBoxUsuario.Controls.Add(this.txtNombre);
            this.groupBoxUsuario.Controls.Add(this.label2);
            this.groupBoxUsuario.Controls.Add(this.txtIbm);
            this.groupBoxUsuario.Controls.Add(this.label1);
            this.groupBoxUsuario.Controls.Add(this.comboBoxMotivo);
            this.groupBoxUsuario.Controls.Add(this.lblMotivo);
            this.groupBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsuario.Location = new System.Drawing.Point(12, 22);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(473, 301);
            this.groupBoxUsuario.TabIndex = 6;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Datos del Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 24);
            this.textBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Correo electronico:";
            // 
            // comboBoxAplicacion
            // 
            this.comboBoxAplicacion.FormattingEnabled = true;
            this.comboBoxAplicacion.Location = new System.Drawing.Point(172, 212);
            this.comboBoxAplicacion.Name = "comboBoxAplicacion";
            this.comboBoxAplicacion.Size = new System.Drawing.Size(231, 26);
            this.comboBoxAplicacion.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Aplicación:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(172, 126);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(231, 24);
            this.txtUsuario.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Usuario:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 24);
            this.txtNombre.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // txtIbm
            // 
            this.txtIbm.Location = new System.Drawing.Point(172, 28);
            this.txtIbm.Name = "txtIbm";
            this.txtIbm.Size = new System.Drawing.Size(231, 24);
            this.txtIbm.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "IBM:";
            // 
            // comboBoxMotivo
            // 
            this.comboBoxMotivo.FormattingEnabled = true;
            this.comboBoxMotivo.Location = new System.Drawing.Point(172, 173);
            this.comboBoxMotivo.Name = "comboBoxMotivo";
            this.comboBoxMotivo.Size = new System.Drawing.Size(231, 26);
            this.comboBoxMotivo.TabIndex = 14;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(109, 172);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(57, 18);
            this.lblMotivo.TabIndex = 13;
            this.lblMotivo.Text = "Motivo:";
            // 
            // groupBoxDistribuidor
            // 
            this.groupBoxDistribuidor.Controls.Add(this.textBox4);
            this.groupBoxDistribuidor.Controls.Add(this.label8);
            this.groupBoxDistribuidor.Controls.Add(this.textBox3);
            this.groupBoxDistribuidor.Controls.Add(this.label7);
            this.groupBoxDistribuidor.Controls.Add(this.label6);
            this.groupBoxDistribuidor.Controls.Add(this.textBox2);
            this.groupBoxDistribuidor.Location = new System.Drawing.Point(532, 24);
            this.groupBoxDistribuidor.Name = "groupBoxDistribuidor";
            this.groupBoxDistribuidor.Size = new System.Drawing.Size(407, 299);
            this.groupBoxDistribuidor.TabIndex = 7;
            this.groupBoxDistribuidor.TabStop = false;
            this.groupBoxDistribuidor.Text = "Datos de Distribuidor";
            this.groupBoxDistribuidor.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Correo del jefe:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Correo electronico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Distribuidor:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 0;
            // 
            // GeneradorDeCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 567);
            this.Controls.Add(this.groupBoxDistribuidor);
            this.Controls.Add(this.groupBoxUsuario);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGenerarCorreo);
            this.Name = "GeneradorDeCasos";
            this.Text = "Generador de Casos";
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            this.groupBoxDistribuidor.ResumeLayout(false);
            this.groupBoxDistribuidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarCorreo;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.ComboBox comboBoxAplicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIbm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxDistribuidor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
    }
}

