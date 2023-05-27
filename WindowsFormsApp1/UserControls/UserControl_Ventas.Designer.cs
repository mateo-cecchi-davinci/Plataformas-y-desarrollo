namespace WindowsFormsApp1.UserControls
{
    partial class UserControl_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaVenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioBtnEfectivo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.radioBtnTarjeta = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxNombreClienteVentas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmailVentas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtCantidadProd = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAgregarProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteSalesProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxAddressVentas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.foundProductsTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboboxCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DateLabelVentas = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalConIVA1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubTotal1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSalesProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVenta
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.tablaVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tablaVenta.ColumnHeadersHeight = 15;
            this.tablaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreProducto,
            this.Precio,
            this.Descripcion,
            this.Cantidad});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaVenta.DefaultCellStyle = dataGridViewCellStyle15;
            this.tablaVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaVenta.Location = new System.Drawing.Point(32, 215);
            this.tablaVenta.Name = "tablaVenta";
            this.tablaVenta.RowHeadersVisible = false;
            this.tablaVenta.RowHeadersWidth = 62;
            this.tablaVenta.RowTemplate.Height = 24;
            this.tablaVenta.Size = new System.Drawing.Size(1020, 411);
            this.tablaVenta.TabIndex = 0;
            this.tablaVenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaVenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaVenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaVenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaVenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaVenta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaVenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaVenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaVenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaVenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaVenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaVenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaVenta.ThemeStyle.HeaderStyle.Height = 15;
            this.tablaVenta.ThemeStyle.ReadOnly = false;
            this.tablaVenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaVenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaVenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaVenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaVenta.ThemeStyle.RowsStyle.Height = 24;
            this.tablaVenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaVenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.MinimumWidth = 8;
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            // 
            // radioBtnEfectivo
            // 
            this.radioBtnEfectivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnEfectivo.CheckedState.BorderThickness = 0;
            this.radioBtnEfectivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnEfectivo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnEfectivo.Location = new System.Drawing.Point(99, 677);
            this.radioBtnEfectivo.Name = "radioBtnEfectivo";
            this.radioBtnEfectivo.Size = new System.Drawing.Size(22, 25);
            this.radioBtnEfectivo.TabIndex = 1;
            this.radioBtnEfectivo.Text = "guna2CustomRadioButton1";
            this.radioBtnEfectivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnEfectivo.UncheckedState.BorderThickness = 2;
            this.radioBtnEfectivo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnEfectivo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioBtnTarjeta
            // 
            this.radioBtnTarjeta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnTarjeta.CheckedState.BorderThickness = 0;
            this.radioBtnTarjeta.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnTarjeta.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnTarjeta.Location = new System.Drawing.Point(208, 677);
            this.radioBtnTarjeta.Name = "radioBtnTarjeta";
            this.radioBtnTarjeta.Size = new System.Drawing.Size(22, 25);
            this.radioBtnTarjeta.TabIndex = 2;
            this.radioBtnTarjeta.Text = "guna2CustomRadioButton2";
            this.radioBtnTarjeta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnTarjeta.UncheckedState.BorderThickness = 2;
            this.radioBtnTarjeta.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnTarjeta.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Efectivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarjeta";
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.White;
            this.btnGenerarVenta.Location = new System.Drawing.Point(99, 735);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(290, 57);
            this.btnGenerarVenta.TabIndex = 5;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // txtBoxNombreClienteVentas
            // 
            this.txtBoxNombreClienteVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNombreClienteVentas.DefaultText = "";
            this.txtBoxNombreClienteVentas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxNombreClienteVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxNombreClienteVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNombreClienteVentas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNombreClienteVentas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNombreClienteVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxNombreClienteVentas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNombreClienteVentas.Location = new System.Drawing.Point(32, 165);
            this.txtBoxNombreClienteVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNombreClienteVentas.Name = "txtBoxNombreClienteVentas";
            this.txtBoxNombreClienteVentas.PasswordChar = '\0';
            this.txtBoxNombreClienteVentas.PlaceholderText = "";
            this.txtBoxNombreClienteVentas.SelectedText = "";
            this.txtBoxNombreClienteVentas.Size = new System.Drawing.Size(225, 45);
            this.txtBoxNombreClienteVentas.TabIndex = 6;
            this.txtBoxNombreClienteVentas.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // txtBoxEmailVentas
            // 
            this.txtBoxEmailVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmailVentas.DefaultText = "";
            this.txtBoxEmailVentas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmailVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmailVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmailVentas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmailVentas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmailVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxEmailVentas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmailVentas.Location = new System.Drawing.Point(303, 165);
            this.txtBoxEmailVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxEmailVentas.Name = "txtBoxEmailVentas";
            this.txtBoxEmailVentas.PasswordChar = '\0';
            this.txtBoxEmailVentas.PlaceholderText = "";
            this.txtBoxEmailVentas.SelectedText = "";
            this.txtBoxEmailVentas.Size = new System.Drawing.Size(225, 45);
            this.txtBoxEmailVentas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1128, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1130, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad:";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(1248, 18);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(0, 33);
            this.txtFecha.TabIndex = 19;
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidadProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidadProd.Location = new System.Drawing.Point(1132, 643);
            this.txtCantidadProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadProd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(292, 58);
            this.txtCantidadProd.TabIndex = 20;
            this.txtCantidadProd.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProd.Location = new System.Drawing.Point(1132, 709);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(292, 57);
            this.btnAgregarProd.TabIndex = 21;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // btnDeleteSalesProduct
            // 
            this.btnDeleteSalesProduct.Image = global::WindowsFormsApp1.Properties.Resources.eliminar_logo;
            this.btnDeleteSalesProduct.ImageRotate = 0F;
            this.btnDeleteSalesProduct.Location = new System.Drawing.Point(916, 140);
            this.btnDeleteSalesProduct.Name = "btnDeleteSalesProduct";
            this.btnDeleteSalesProduct.Size = new System.Drawing.Size(66, 69);
            this.btnDeleteSalesProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteSalesProduct.TabIndex = 22;
            this.btnDeleteSalesProduct.TabStop = false;
            this.btnDeleteSalesProduct.Click += new System.EventHandler(this.btnDeleteSalesProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Vendedor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1263, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 33);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(555, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Dirección:";
            // 
            // txtBoxAddressVentas
            // 
            this.txtBoxAddressVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAddressVentas.DefaultText = "";
            this.txtBoxAddressVentas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAddressVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAddressVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddressVentas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddressVentas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddressVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAddressVentas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddressVentas.Location = new System.Drawing.Point(555, 165);
            this.txtBoxAddressVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAddressVentas.Name = "txtBoxAddressVentas";
            this.txtBoxAddressVentas.PasswordChar = '\0';
            this.txtBoxAddressVentas.PlaceholderText = "";
            this.txtBoxAddressVentas.SelectedText = "";
            this.txtBoxAddressVentas.Size = new System.Drawing.Size(225, 45);
            this.txtBoxAddressVentas.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 643);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "Medio de Pago:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 70);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ventas";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProd.DefaultText = "";
            this.txtNombreProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProd.Location = new System.Drawing.Point(1132, 165);
            this.txtNombreProd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.PasswordChar = '\0';
            this.txtNombreProd.PlaceholderText = "";
            this.txtNombreProd.SelectedText = "";
            this.txtNombreProd.Size = new System.Drawing.Size(292, 45);
            this.txtNombreProd.TabIndex = 29;
            this.txtNombreProd.TextChanged += new System.EventHandler(this.txtNombreProd_TextChanged);
            // 
            // foundProductsTable
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.foundProductsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foundProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.foundProductsTable.ColumnHeadersHeight = 15;
            this.foundProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.foundProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Stock,
            this.Id});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foundProductsTable.DefaultCellStyle = dataGridViewCellStyle18;
            this.foundProductsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.foundProductsTable.Location = new System.Drawing.Point(1132, 262);
            this.foundProductsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foundProductsTable.Name = "foundProductsTable";
            this.foundProductsTable.RowHeadersVisible = false;
            this.foundProductsTable.RowHeadersWidth = 62;
            this.foundProductsTable.Size = new System.Drawing.Size(292, 329);
            this.foundProductsTable.TabIndex = 30;
            this.foundProductsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.foundProductsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.foundProductsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.foundProductsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.foundProductsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.foundProductsTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.foundProductsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.foundProductsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.foundProductsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.foundProductsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundProductsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.foundProductsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.foundProductsTable.ThemeStyle.HeaderStyle.Height = 15;
            this.foundProductsTable.ThemeStyle.ReadOnly = false;
            this.foundProductsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.foundProductsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.foundProductsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundProductsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.foundProductsTable.ThemeStyle.RowsStyle.Height = 22;
            this.foundProductsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.foundProductsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 8;
            this.Stock.Name = "Stock";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // comboboxCategoria
            // 
            this.comboboxCategoria.BackColor = System.Drawing.Color.Transparent;
            this.comboboxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxCategoria.ItemHeight = 30;
            this.comboboxCategoria.Location = new System.Drawing.Point(1127, 70);
            this.comboboxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboboxCategoria.Name = "comboboxCategoria";
            this.comboboxCategoria.Size = new System.Drawing.Size(290, 36);
            this.comboboxCategoria.TabIndex = 31;
            this.comboboxCategoria.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1123, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Categoria:";
            // 
            // DateLabelVentas
            // 
            this.DateLabelVentas.AutoSize = true;
            this.DateLabelVentas.Location = new System.Drawing.Point(982, 31);
            this.DateLabelVentas.Name = "DateLabelVentas";
            this.DateLabelVentas.Size = new System.Drawing.Size(0, 20);
            this.DateLabelVentas.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(143, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(891, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "label14";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(684, 654);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 29);
            this.label18.TabIndex = 38;
            this.label18.Text = "SubTotal :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(636, 709);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 29);
            this.label16.TabIndex = 39;
            this.label16.Text = "Total Con IVA :  ";
            // 
            // txtTotalConIVA1
            // 
            this.txtTotalConIVA1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalConIVA1.DefaultText = "";
            this.txtTotalConIVA1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalConIVA1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalConIVA1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalConIVA1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalConIVA1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalConIVA1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalConIVA1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalConIVA1.Location = new System.Drawing.Point(827, 709);
            this.txtTotalConIVA1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalConIVA1.Name = "txtTotalConIVA1";
            this.txtTotalConIVA1.PasswordChar = '\0';
            this.txtTotalConIVA1.PlaceholderText = "";
            this.txtTotalConIVA1.SelectedText = "";
            this.txtTotalConIVA1.Size = new System.Drawing.Size(225, 45);
            this.txtTotalConIVA1.TabIndex = 42;
            // 
            // txtSubTotal1
            // 
            this.txtSubTotal1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal1.DefaultText = "";
            this.txtSubTotal1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubTotal1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubTotal1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubTotal1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubTotal1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubTotal1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubTotal1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubTotal1.Location = new System.Drawing.Point(827, 643);
            this.txtSubTotal1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubTotal1.Name = "txtSubTotal1";
            this.txtSubTotal1.PasswordChar = '\0';
            this.txtSubTotal1.PlaceholderText = "";
            this.txtSubTotal1.SelectedText = "";
            this.txtSubTotal1.Size = new System.Drawing.Size(225, 45);
            this.txtSubTotal1.TabIndex = 43;
            // 
            // UserControl_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSubTotal1);
            this.Controls.Add(this.txtTotalConIVA1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DateLabelVentas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboboxCategoria);
            this.Controls.Add(this.foundProductsTable);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxAddressVentas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteSalesProduct);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEmailVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNombreClienteVentas);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnTarjeta);
            this.Controls.Add(this.radioBtnEfectivo);
            this.Controls.Add(this.tablaVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_Ventas";
            this.Size = new System.Drawing.Size(1485, 1040);
            this.Load += new System.EventHandler(this.UserControl_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSalesProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundProductsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tablaVenta;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioBtnEfectivo;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioBtnTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnGenerarVenta;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxNombreClienteVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmailVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtFecha;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtCantidadProd;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProd;
        private Guna.UI2.WinForms.Guna2PictureBox btnDeleteSalesProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAddressVentas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProd;
        private Guna.UI2.WinForms.Guna2DataGridView foundProductsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxCategoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label DateLabelVentas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalConIVA1;
        private Guna.UI2.WinForms.Guna2TextBox txtSubTotal1;
    }
}
