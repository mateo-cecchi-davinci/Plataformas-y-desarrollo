namespace WindowsFormsApp1
{
    partial class FormAgregarUsuario
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
            this.txtAgregarNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDniUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.imagenUsuario = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarImgUsuario = new System.Windows.Forms.Button();
            this.confirmarAgregarUsuarioButton = new System.Windows.Forms.Button();
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
            // txtAgregarNombreUsuario
            // 
            this.txtAgregarNombreUsuario.Location = new System.Drawing.Point(240, 121);
            this.txtAgregarNombreUsuario.Name = "txtAgregarNombreUsuario";
            this.txtAgregarNombreUsuario.Size = new System.Drawing.Size(208, 26);
            this.txtAgregarNombreUsuario.TabIndex = 1;
            // 
            // txtUsuarioApellido
            // 
            this.txtApellidoUsuario.Location = new System.Drawing.Point(240, 198);
            this.txtApellidoUsuario.Name = "txtUsuarioApellido";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(208, 26);
            this.txtApellidoUsuario.TabIndex = 2;
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
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI:";
            // 
            // txtDniUsuario
            // 
            this.txtDniUsuario.Location = new System.Drawing.Point(240, 275);
            this.txtDniUsuario.Name = "txtDniUsuario";
            this.txtDniUsuario.Size = new System.Drawing.Size(208, 26);
            this.txtDniUsuario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre Usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtUserName.Location = new System.Drawing.Point(240, 358);
            this.txtUserName.Name = "txtNombreUsuario";
            this.txtUserName.Size = new System.Drawing.Size(208, 26);
            this.txtUserName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña";
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(240, 434);
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(208, 26);
            this.txtContraseñaUsuario.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(240, 520);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(208, 26);
            this.txtConfirmarContraseña.TabIndex = 14;
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
            // confirmarAgregarUsuarioButton
            // 
            this.confirmarAgregarUsuarioButton.Location = new System.Drawing.Point(240, 890);
            this.confirmarAgregarUsuarioButton.Name = "confirmarAgregarUsuarioButton";
            this.confirmarAgregarUsuarioButton.Size = new System.Drawing.Size(212, 77);
            this.confirmarAgregarUsuarioButton.TabIndex = 19;
            this.confirmarAgregarUsuarioButton.Text = "Confirmar";
            this.confirmarAgregarUsuarioButton.UseVisualStyleBackColor = true;
            this.confirmarAgregarUsuarioButton.Click += new System.EventHandler(this.confirmarAgregarUsuarioButton_Click);
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 1005);
            this.Controls.Add(this.confirmarAgregarUsuarioButton);
            this.Controls.Add(this.btnCargarImgUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imagenUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraseñaUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDniUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.txtAgregarNombreUsuario);
            this.Controls.Add(this.labelAgregarUser);
            this.Name = "FormAgregarUsuario";
            this.Text = "AgregarUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgregarUser;
        private System.Windows.Forms.TextBox txtAgregarNombreUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDniUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraseñaUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.PictureBox imagenUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargarImgUsuario;
        private System.Windows.Forms.Button confirmarAgregarUsuarioButton;
    }
}