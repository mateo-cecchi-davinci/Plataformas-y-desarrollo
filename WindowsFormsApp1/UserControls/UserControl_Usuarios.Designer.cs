namespace WindowsFormsApp1.UserControls
{
    partial class UserControl_Usuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.buttonAgregarUsuario = new System.Windows.Forms.PictureBox();
            this.buttonBuscarUsuario = new System.Windows.Forms.PictureBox();
            this.btnCambiarEstadoUsuario = new System.Windows.Forms.PictureBox();
            this.tablaUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditarUsuario = new System.Windows.Forms.PictureBox();
            this.textBoxBuscadorUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBuscarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiarEstadoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.Image = global::WindowsFormsApp1.Properties.Resources.agregar;
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(254, 103);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(104, 77);
            this.buttonAgregarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAgregarUsuario.TabIndex = 3;
            this.buttonAgregarUsuario.TabStop = false;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Image = global::WindowsFormsApp1.Properties.Resources.buscar;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(1143, 104);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(104, 77);
            this.buttonBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonBuscarUsuario.TabIndex = 4;
            this.buttonBuscarUsuario.TabStop = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // btnCambiarEstadoUsuario
            // 
            this.btnCambiarEstadoUsuario.Image = global::WindowsFormsApp1.Properties.Resources.true_false;
            this.btnCambiarEstadoUsuario.Location = new System.Drawing.Point(384, 103);
            this.btnCambiarEstadoUsuario.Name = "btnCambiarEstadoUsuario";
            this.btnCambiarEstadoUsuario.Size = new System.Drawing.Size(124, 77);
            this.btnCambiarEstadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCambiarEstadoUsuario.TabIndex = 6;
            this.btnCambiarEstadoUsuario.TabStop = false;
            this.btnCambiarEstadoUsuario.Click += new System.EventHandler(this.btnCambiarEstadoUsuario_Click);
            // 
            // tablaUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaUsuarios.ColumnHeadersHeight = 28;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.dni,
            this.NombreDeUsuario,
            this.Activo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaUsuarios.Location = new System.Drawing.Point(254, 237);
            this.tablaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.RowHeadersVisible = false;
            this.tablaUsuarios.RowHeadersWidth = 62;
            this.tablaUsuarios.Size = new System.Drawing.Size(993, 431);
            this.tablaUsuarios.TabIndex = 7;
            this.tablaUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaUsuarios.ThemeStyle.HeaderStyle.Height = 28;
            this.tablaUsuarios.ThemeStyle.ReadOnly = false;
            this.tablaUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.tablaUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "Codigo Usuario";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 8;
            this.dni.Name = "dni";
            // 
            // NombreDeUsuario
            // 
            this.NombreDeUsuario.HeaderText = "Nombre de usuario";
            this.NombreDeUsuario.MinimumWidth = 8;
            this.NombreDeUsuario.Name = "NombreDeUsuario";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 8;
            this.Activo.Name = "Activo";
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.Image = global::WindowsFormsApp1.Properties.Resources.editar;
            this.buttonEditarUsuario.Location = new System.Drawing.Point(534, 102);
            this.buttonEditarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(104, 78);
            this.buttonEditarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonEditarUsuario.TabIndex = 8;
            this.buttonEditarUsuario.TabStop = false;
            this.buttonEditarUsuario.Click += new System.EventHandler(this.buttonEditarUsuario_Click);
            // 
            // textBoxBuscadorUsuario
            // 
            this.textBoxBuscadorUsuario.Location = new System.Drawing.Point(882, 154);
            this.textBoxBuscadorUsuario.Name = "textBoxBuscadorUsuario";
            this.textBoxBuscadorUsuario.Size = new System.Drawing.Size(229, 26);
            this.textBoxBuscadorUsuario.TabIndex = 9;
            // 
            // UserControl_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxBuscadorUsuario);
            this.Controls.Add(this.buttonEditarUsuario);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.btnCambiarEstadoUsuario);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.Controls.Add(this.buttonAgregarUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_Usuarios";
            this.Size = new System.Drawing.Size(1443, 742);
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBuscarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiarEstadoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private System.Windows.Forms.PictureBox buttonAgregarUsuario;
        private System.Windows.Forms.PictureBox buttonBuscarUsuario;
        private System.Windows.Forms.PictureBox btnCambiarEstadoUsuario;
        private Guna.UI2.WinForms.Guna2DataGridView tablaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.PictureBox buttonEditarUsuario;
        private System.Windows.Forms.TextBox textBoxBuscadorUsuario;
    }
}
