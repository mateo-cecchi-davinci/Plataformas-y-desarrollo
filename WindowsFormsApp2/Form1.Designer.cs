namespace WindowsFormsApp2
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
            this.titulo_ABM = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_desripcion = new System.Windows.Forms.Label();
            this.lable_id = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.error_nombre = new System.Windows.Forms.Label();
            this.lbl_error_desc = new System.Windows.Forms.Label();
            this.lbl_eror_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo_ABM
            // 
            this.titulo_ABM.AutoSize = true;
            this.titulo_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_ABM.Location = new System.Drawing.Point(29, 21);
            this.titulo_ABM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo_ABM.Name = "titulo_ABM";
            this.titulo_ABM.Size = new System.Drawing.Size(446, 29);
            this.titulo_ABM.TabIndex = 0;
            this.titulo_ABM.Text = "Alta, Baja y Modificacion de Producto";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(50, 71);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(42, 13);
            this.label_nombre.TabIndex = 4;
            this.label_nombre.Text = "nombre";
            // 
            // label_desripcion
            // 
            this.label_desripcion.AutoSize = true;
            this.label_desripcion.Location = new System.Drawing.Point(50, 108);
            this.label_desripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_desripcion.Name = "label_desripcion";
            this.label_desripcion.Size = new System.Drawing.Size(61, 13);
            this.label_desripcion.TabIndex = 5;
            this.label_desripcion.Text = "descripcion";
            // 
            // lable_id
            // 
            this.lable_id.AutoSize = true;
            this.lable_id.Location = new System.Drawing.Point(50, 145);
            this.lable_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_id.Name = "lable_id";
            this.lable_id.Size = new System.Drawing.Size(15, 13);
            this.lable_id.TabIndex = 6;
            this.lable_id.Text = "id";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(170, 198);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(119, 39);
            this.btn_crear.TabIndex = 7;
            this.btn_crear.Text = "Crear Producto";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(170, 104);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(165, 20);
            this.txt_Descripcion.TabIndex = 2;
            this.txt_Descripcion.TextChanged += new System.EventHandler(this.txt_Descripcion_TextChanged_1);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(170, 67);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(170, 141);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(165, 20);
            this.txt_Id.TabIndex = 3;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.ForeColor = System.Drawing.Color.Brown;
            this.error_nombre.Location = new System.Drawing.Point(371, 71);
            this.error_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(69, 13);
            this.error_nombre.TabIndex = 9;
            this.error_nombre.Text = "Error Nombre";
            // 
            // lbl_error_desc
            // 
            this.lbl_error_desc.AutoSize = true;
            this.lbl_error_desc.ForeColor = System.Drawing.Color.Brown;
            this.lbl_error_desc.Location = new System.Drawing.Point(371, 104);
            this.lbl_error_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error_desc.Name = "lbl_error_desc";
            this.lbl_error_desc.Size = new System.Drawing.Size(57, 13);
            this.lbl_error_desc.TabIndex = 11;
            this.lbl_error_desc.Text = "Error Desc";
            // 
            // lbl_eror_id
            // 
            this.lbl_eror_id.AutoSize = true;
            this.lbl_eror_id.ForeColor = System.Drawing.Color.Brown;
            this.lbl_eror_id.Location = new System.Drawing.Point(371, 143);
            this.lbl_eror_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_eror_id.Name = "lbl_eror_id";
            this.lbl_eror_id.Size = new System.Drawing.Size(41, 13);
            this.lbl_eror_id.TabIndex = 12;
            this.lbl_eror_id.Text = "Error Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 292);
            this.Controls.Add(this.lbl_eror_id);
            this.Controls.Add(this.lbl_error_desc);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lable_id);
            this.Controls.Add(this.label_desripcion);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.titulo_ABM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_ABM;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_desripcion;
        private System.Windows.Forms.Label lable_id;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label error_nombre;
        private System.Windows.Forms.Label lbl_error_desc;
        private System.Windows.Forms.Label lbl_eror_id;
    }
}

