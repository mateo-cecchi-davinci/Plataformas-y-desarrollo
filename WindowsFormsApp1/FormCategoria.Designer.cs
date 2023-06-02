namespace WindowsFormsApp1
{
    partial class FormCategoria
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
            this.txtAgregarCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombreCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActiva = new System.Windows.Forms.RadioButton();
            this.btnInactiva = new System.Windows.Forms.RadioButton();
            this.txtCategoriaPadre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCategoriaError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Categoria";
            // 
            // txtAgregarCategoria
            // 
            this.txtAgregarCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAgregarCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtAgregarCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtAgregarCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.txtAgregarCategoria.Location = new System.Drawing.Point(295, 382);
            this.txtAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.Size = new System.Drawing.Size(263, 55);
            this.txtAgregarCategoria.TabIndex = 1;
            this.txtAgregarCategoria.Text = "Agregar Categoria";
            this.txtAgregarCategoria.Click += new System.EventHandler(this.txtAgregarCategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.DefaultText = "";
            this.txtNombreCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCategoria.Location = new System.Drawing.Point(295, 134);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.PlaceholderText = "";
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.Size = new System.Drawing.Size(267, 44);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria Padre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado:";
            // 
            // btnActiva
            // 
            this.btnActiva.AutoSize = true;
            this.btnActiva.Location = new System.Drawing.Point(299, 313);
            this.btnActiva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.Size = new System.Drawing.Size(62, 20);
            this.btnActiva.TabIndex = 8;
            this.btnActiva.TabStop = true;
            this.btnActiva.Text = "Activa";
            this.btnActiva.UseVisualStyleBackColor = true;
            // 
            // btnInactiva
            // 
            this.btnInactiva.AutoSize = true;
            this.btnInactiva.Location = new System.Drawing.Point(399, 313);
            this.btnInactiva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInactiva.Name = "btnInactiva";
            this.btnInactiva.Size = new System.Drawing.Size(71, 20);
            this.btnInactiva.TabIndex = 9;
            this.btnInactiva.TabStop = true;
            this.btnInactiva.Text = "Inactiva";
            this.btnInactiva.UseVisualStyleBackColor = true;
            // 
            // txtCategoriaPadre
            // 
            this.txtCategoriaPadre.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoriaPadre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCategoriaPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoriaPadre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoriaPadre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoriaPadre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategoriaPadre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtCategoriaPadre.ItemHeight = 30;
            this.txtCategoriaPadre.Location = new System.Drawing.Point(295, 226);
            this.txtCategoriaPadre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoriaPadre.Name = "txtCategoriaPadre";
            this.txtCategoriaPadre.Size = new System.Drawing.Size(265, 36);
            this.txtCategoriaPadre.TabIndex = 10;
            // 
            // txtCategoriaError
            // 
            this.txtCategoriaError.AutoSize = true;
            this.txtCategoriaError.ForeColor = System.Drawing.Color.Red;
            this.txtCategoriaError.Location = new System.Drawing.Point(293, 350);
            this.txtCategoriaError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCategoriaError.Name = "txtCategoriaError";
            this.txtCategoriaError.Size = new System.Drawing.Size(222, 16);
            this.txtCategoriaError.TabIndex = 11;
            this.txtCategoriaError.Text = "Todos los campos son obligatorios.";
            this.txtCategoriaError.Visible = false;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 528);
            this.Controls.Add(this.txtCategoriaError);
            this.Controls.Add(this.txtCategoriaPadre);
            this.Controls.Add(this.btnInactiva);
            this.Controls.Add(this.btnActiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.txtAgregarCategoria);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button txtAgregarCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton btnActiva;
        private System.Windows.Forms.RadioButton btnInactiva;
        private Guna.UI2.WinForms.Guna2ComboBox txtCategoriaPadre;
        private System.Windows.Forms.Label txtCategoriaError;
    }
}