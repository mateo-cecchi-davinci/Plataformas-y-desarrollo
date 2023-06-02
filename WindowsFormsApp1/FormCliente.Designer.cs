
namespace WindowsFormsApp1
{
    partial class FormCliente
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
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.btnConsumidorFinal = new System.Windows.Forms.RadioButton();
            this.btnResponsableInscripto = new System.Windows.Forms.RadioButton();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(90, 115);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(214, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(90, 290);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(214, 20);
            this.txtDniCliente.TabIndex = 1;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(90, 231);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(214, 20);
            this.txtEmailCliente.TabIndex = 2;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(90, 172);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(214, 20);
            this.txtDireccionCliente.TabIndex = 3;
            // 
            // btnConsumidorFinal
            // 
            this.btnConsumidorFinal.AutoSize = true;
            this.btnConsumidorFinal.Location = new System.Drawing.Point(90, 345);
            this.btnConsumidorFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsumidorFinal.Name = "btnConsumidorFinal";
            this.btnConsumidorFinal.Size = new System.Drawing.Size(105, 17);
            this.btnConsumidorFinal.TabIndex = 5;
            this.btnConsumidorFinal.TabStop = true;
            this.btnConsumidorFinal.Text = "Consumidor Final";
            this.btnConsumidorFinal.UseVisualStyleBackColor = true;
            // 
            // btnResponsableInscripto
            // 
            this.btnResponsableInscripto.AutoSize = true;
            this.btnResponsableInscripto.Location = new System.Drawing.Point(199, 345);
            this.btnResponsableInscripto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResponsableInscripto.Name = "btnResponsableInscripto";
            this.btnResponsableInscripto.Size = new System.Drawing.Size(130, 17);
            this.btnResponsableInscripto.TabIndex = 6;
            this.btnResponsableInscripto.TabStop = true;
            this.btnResponsableInscripto.Text = "Responsable Inscripto";
            this.btnResponsableInscripto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(90, 412);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(96, 46);
            this.btnAgregarCliente.TabIndex = 7;
            this.btnAgregarCliente.Text = "Agregar cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Location = new System.Drawing.Point(202, 412);
            this.btnVolverAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(102, 46);
            this.btnVolverAtras.TabIndex = 8;
            this.btnVolverAtras.Text = "Volver atrás";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Agregar un Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(87, 377);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(227, 17);
            this.txtError.TabIndex = 15;
            this.txtError.Text = "Todos los campos son obligatorios.";
            this.txtError.Visible = false;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 524);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnResponsableInscripto);
            this.Controls.Add(this.btnConsumidorFinal);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.RadioButton btnConsumidorFinal;
        private System.Windows.Forms.RadioButton btnResponsableInscripto;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtError;
    }
}