namespace WindowsFormsApp1
{
    partial class AgregarUsuarioForm
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
            this.labelAgregarUser = new System.Windows.Forms.Label();
            this.textAgregarNombreUsuario = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDniUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombreUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.imagenUsuario = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarImgUsuario = new System.Windows.Forms.Button();
            this.confirmarUsuarioButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAgregarUser
            // 
            this.labelAgregarUser.AutoSize = true;
            this.labelAgregarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarUser.Location = new System.Drawing.Point(260, 25);
            this.labelAgregarUser.Name = "labelAgregarUser";
            this.labelAgregarUser.Size = new System.Drawing.Size(188, 29);
            this.labelAgregarUser.TabIndex = 0;
            this.labelAgregarUser.Text = "Agregar Usuario";
            this.labelAgregarUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // textAgregarNombreUsuario
            // 
            this.textAgregarNombreUsuario.Location = new System.Drawing.Point(240, 121);
            this.textAgregarNombreUsuario.Name = "textAgregarNombreUsuario";
            this.textAgregarNombreUsuario.Size = new System.Drawing.Size(208, 26);
            this.textAgregarNombreUsuario.TabIndex = 1;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(240, 198);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(208, 26);
            this.textApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI:";
            // 
            // textDniUsuario
            // 
            this.textDniUsuario.Location = new System.Drawing.Point(240, 275);
            this.textDniUsuario.Name = "textDniUsuario";
            this.textDniUsuario.Size = new System.Drawing.Size(208, 26);
            this.textDniUsuario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre Usuario:";
            // 
            // textNombreUsuario
            // 
            this.textNombreUsuario.Location = new System.Drawing.Point(240, 358);
            this.textNombreUsuario.Name = "textNombreUsuario";
            this.textNombreUsuario.Size = new System.Drawing.Size(208, 26);
            this.textNombreUsuario.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña";
            // 
            // textContraseñaUsuario
            // 
            this.textContraseñaUsuario.Location = new System.Drawing.Point(240, 434);
            this.textContraseñaUsuario.Name = "textContraseñaUsuario";
            this.textContraseñaUsuario.Size = new System.Drawing.Size(208, 26);
            this.textContraseñaUsuario.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // textConfirmarContraseña
            // 
            this.textConfirmarContraseña.Location = new System.Drawing.Point(240, 520);
            this.textConfirmarContraseña.Name = "textConfirmarContraseña";
            this.textConfirmarContraseña.Size = new System.Drawing.Size(208, 26);
            this.textConfirmarContraseña.TabIndex = 14;
            // 
            // imagenUsuario
            // 
            this.imagenUsuario.Location = new System.Drawing.Point(240, 602);
            this.imagenUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenUsuario.Name = "imagenUsuario";
            this.imagenUsuario.Size = new System.Drawing.Size(418, 179);
            this.imagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenUsuario.TabIndex = 16;
            this.imagenUsuario.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Imagen:";
            // 
            // btnCargarImgUsuario
            // 
            this.btnCargarImgUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImgUsuario.Location = new System.Drawing.Point(240, 801);
            this.btnCargarImgUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarImgUsuario.Name = "btnCargarImgUsuario";
            this.btnCargarImgUsuario.Size = new System.Drawing.Size(224, 40);
            this.btnCargarImgUsuario.TabIndex = 18;
            this.btnCargarImgUsuario.Text = "Cargar Imagen";
            this.btnCargarImgUsuario.UseVisualStyleBackColor = true;
            this.btnCargarImgUsuario.Click += new System.EventHandler(this.btnCargarImgUsuario_Click);
            // 
            // confirmarUsuarioButton
            // 
            this.confirmarUsuarioButton.Location = new System.Drawing.Point(240, 890);
            this.confirmarUsuarioButton.Name = "confirmarUsuarioButton";
            this.confirmarUsuarioButton.Size = new System.Drawing.Size(212, 77);
            this.confirmarUsuarioButton.TabIndex = 19;
            this.confirmarUsuarioButton.Text = "Confirmar";
            this.confirmarUsuarioButton.UseVisualStyleBackColor = true;
            // 
            // AgregarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 1005);
            this.Controls.Add(this.confirmarUsuarioButton);
            this.Controls.Add(this.btnCargarImgUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imagenUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textConfirmarContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textContraseñaUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDniUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textAgregarNombreUsuario);
            this.Controls.Add(this.labelAgregarUser);
            this.Name = "AgregarUsuarioForm";
            this.Text = "AgregarUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgregarUser;
        private System.Windows.Forms.TextBox textAgregarNombreUsuario;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDniUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombreUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textContraseñaUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textConfirmarContraseña;
        private System.Windows.Forms.PictureBox imagenUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargarImgUsuario;
        private System.Windows.Forms.Button confirmarUsuarioButton;
    }
}