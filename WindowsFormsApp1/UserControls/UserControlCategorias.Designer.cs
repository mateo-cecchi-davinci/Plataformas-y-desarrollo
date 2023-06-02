namespace WindowsFormsApp1.UserControls
{
    partial class UserControlCategorias
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
            this.tablaCategorias = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAgregarProducto = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonEstadoProducto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEstadoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCategorias
            // 
            this.tablaCategorias.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCategorias.ColumnHeadersHeight = 18;
            this.tablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.Nombre,
            this.CategoriaPadre,
            this.estadoCategoria});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaCategorias.Location = new System.Drawing.Point(44, 178);
            this.tablaCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaCategorias.Name = "tablaCategorias";
            this.tablaCategorias.RowHeadersVisible = false;
            this.tablaCategorias.RowHeadersWidth = 62;
            this.tablaCategorias.Size = new System.Drawing.Size(982, 521);
            this.tablaCategorias.TabIndex = 0;
            this.tablaCategorias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaCategorias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaCategorias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaCategorias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaCategorias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaCategorias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaCategorias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaCategorias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaCategorias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaCategorias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCategorias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaCategorias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaCategorias.ThemeStyle.HeaderStyle.Height = 18;
            this.tablaCategorias.ThemeStyle.ReadOnly = false;
            this.tablaCategorias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaCategorias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCategorias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCategorias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaCategorias.ThemeStyle.RowsStyle.Height = 22;
            this.tablaCategorias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaCategorias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "Codigo";
            this.idCategoria.MinimumWidth = 8;
            this.idCategoria.Name = "idCategoria";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // CategoriaPadre
            // 
            this.CategoriaPadre.HeaderText = "Categoria Padre";
            this.CategoriaPadre.MinimumWidth = 8;
            this.CategoriaPadre.Name = "CategoriaPadre";
            // 
            // estadoCategoria
            // 
            this.estadoCategoria.HeaderText = "Estado";
            this.estadoCategoria.MinimumWidth = 8;
            this.estadoCategoria.Name = "estadoCategoria";
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Image = global::WindowsFormsApp1.Properties.Resources.agregar;
            this.buttonAgregarProducto.Location = new System.Drawing.Point(44, 105);
            this.buttonAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(75, 54);
            this.buttonAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAgregarProducto.TabIndex = 3;
            this.buttonAgregarProducto.TabStop = false;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 70);
            this.label12.TabIndex = 29;
            this.label12.Text = "Categorias";
            // 
            // buttonEstadoProducto
            // 
            this.buttonEstadoProducto.Image = global::WindowsFormsApp1.Properties.Resources.true_false;
            this.buttonEstadoProducto.Location = new System.Drawing.Point(142, 105);
            this.buttonEstadoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEstadoProducto.Name = "buttonEstadoProducto";
            this.buttonEstadoProducto.Size = new System.Drawing.Size(98, 54);
            this.buttonEstadoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonEstadoProducto.TabIndex = 31;
            this.buttonEstadoProducto.TabStop = false;
            this.buttonEstadoProducto.Click += new System.EventHandler(this.buttonEstadoProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.editar;
            this.pictureBox1.Location = new System.Drawing.Point(262, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserControlCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEstadoProducto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonAgregarProducto);
            this.Controls.Add(this.tablaCategorias);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlCategorias";
            this.Size = new System.Drawing.Size(1485, 1040);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEstadoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tablaCategorias;
        private System.Windows.Forms.PictureBox buttonAgregarProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox buttonEstadoProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCategoria;
    }
}
