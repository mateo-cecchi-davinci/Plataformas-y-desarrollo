namespace WindowsFormsApp1.UserControls
{
    partial class UserControl_Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonEditarUsuario = new System.Windows.Forms.PictureBox();
            this.buttonEstadoProducto = new System.Windows.Forms.PictureBox();
            this.buscadorProductos = new System.Windows.Forms.PictureBox();
            this.buttonAgregarProducto = new System.Windows.Forms.PictureBox();
            this.textBoxBuscarProductos = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEstadoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscadorProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProductos.ColumnHeadersHeight = 15;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.descProducto,
            this.stockProducto,
            this.precioProducto,
            this.estadoProducto,
            this.categoriaProducto,
            this.Imagen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaProductos.Location = new System.Drawing.Point(45, 119);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.Size = new System.Drawing.Size(1193, 430);
            this.tablaProductos.TabIndex = 4;
            this.tablaProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaProductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaProductos.ThemeStyle.HeaderStyle.Height = 15;
            this.tablaProductos.ThemeStyle.ReadOnly = false;
            this.tablaProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaProductos.ThemeStyle.RowsStyle.Height = 22;
            this.tablaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Codigo";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            // 
            // descProducto
            // 
            this.descProducto.HeaderText = "Descripcion";
            this.descProducto.MinimumWidth = 6;
            this.descProducto.Name = "descProducto";
            // 
            // stockProducto
            // 
            this.stockProducto.HeaderText = "Stock";
            this.stockProducto.MinimumWidth = 6;
            this.stockProducto.Name = "stockProducto";
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.MinimumWidth = 6;
            this.precioProducto.Name = "precioProducto";
            // 
            // estadoProducto
            // 
            this.estadoProducto.HeaderText = "Activo";
            this.estadoProducto.MinimumWidth = 6;
            this.estadoProducto.Name = "estadoProducto";
            // 
            // categoriaProducto
            // 
            this.categoriaProducto.HeaderText = "Categoría";
            this.categoriaProducto.MinimumWidth = 6;
            this.categoriaProducto.Name = "categoriaProducto";
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.Name = "Imagen";
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.Image = global::WindowsFormsApp1.Properties.Resources.editar;
            this.buttonEditarUsuario.Location = new System.Drawing.Point(141, 34);
            this.buttonEditarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(62, 43);
            this.buttonEditarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonEditarUsuario.TabIndex = 6;
            this.buttonEditarUsuario.TabStop = false;
            this.buttonEditarUsuario.Click += new System.EventHandler(this.buttonEditarUsuario_Click);
            // 
            // buttonEstadoProducto
            // 
            this.buttonEstadoProducto.Image = global::WindowsFormsApp1.Properties.Resources.true_false;
            this.buttonEstadoProducto.Location = new System.Drawing.Point(223, 34);
            this.buttonEstadoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEstadoProducto.Name = "buttonEstadoProducto";
            this.buttonEstadoProducto.Size = new System.Drawing.Size(87, 43);
            this.buttonEstadoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonEstadoProducto.TabIndex = 5;
            this.buttonEstadoProducto.TabStop = false;
            this.buttonEstadoProducto.Click += new System.EventHandler(this.buttonCambiarEstadoProducto_Click);
            // 
            // buscadorProductos
            // 
            this.buscadorProductos.Image = global::WindowsFormsApp1.Properties.Resources.buscar;
            this.buscadorProductos.Location = new System.Drawing.Point(1092, 15);
            this.buscadorProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscadorProductos.Name = "buscadorProductos";
            this.buscadorProductos.Size = new System.Drawing.Size(92, 62);
            this.buscadorProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buscadorProductos.TabIndex = 3;
            this.buscadorProductos.TabStop = false;
            this.buscadorProductos.Click += new System.EventHandler(this.buttonBuscadorProductos_Click);
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Image = global::WindowsFormsApp1.Properties.Resources.agregar;
            this.buttonAgregarProducto.Location = new System.Drawing.Point(45, 34);
            this.buttonAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(67, 43);
            this.buttonAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAgregarProducto.TabIndex = 2;
            this.buttonAgregarProducto.TabStop = false;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // textBoxBuscarProductos
            // 
            this.textBoxBuscarProductos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBuscarProductos.DefaultText = "";
            this.textBoxBuscarProductos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxBuscarProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxBuscarProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBuscarProductos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBuscarProductos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBuscarProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxBuscarProductos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBuscarProductos.Location = new System.Drawing.Point(639, 15);
            this.textBoxBuscarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuscarProductos.Name = "textBoxBuscarProductos";
            this.textBoxBuscarProductos.PasswordChar = '\0';
            this.textBoxBuscarProductos.PlaceholderText = "";
            this.textBoxBuscarProductos.SelectedText = "";
            this.textBoxBuscarProductos.Size = new System.Drawing.Size(447, 62);
            this.textBoxBuscarProductos.TabIndex = 7;
            // 
            // UserControl_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxBuscarProductos);
            this.Controls.Add(this.buttonEditarUsuario);
            this.Controls.Add(this.buttonEstadoProducto);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.buscadorProductos);
            this.Controls.Add(this.buttonAgregarProducto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Productos";
            this.Size = new System.Drawing.Size(1283, 593);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEstadoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscadorProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox buttonAgregarProducto;
        private System.Windows.Forms.PictureBox buscadorProductos;
        private Guna.UI2.WinForms.Guna2DataGridView tablaProductos;
        private System.Windows.Forms.PictureBox buttonEstadoProducto;
        private System.Windows.Forms.PictureBox buttonEditarUsuario;
        private Guna.UI2.WinForms.Guna2TextBox textBoxBuscarProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProducto;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}
