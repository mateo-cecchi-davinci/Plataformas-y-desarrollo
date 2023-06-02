namespace WindowsFormsApp1
{
    partial class ConfirmarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaConfirmarVenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtFinalizarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.txtTotalConIva = new System.Windows.Forms.Label();
            this.totalConfirmarVenta = new System.Windows.Forms.Label();
            this.subTotalConfirmarVenta = new System.Windows.Forms.Label();
            this.btnVolverConfirmarVenta = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConfirmarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaConfirmarVenta
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablaConfirmarVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaConfirmarVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaConfirmarVenta.ColumnHeadersHeight = 15;
            this.tablaConfirmarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaConfirmarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Precio,
            this.Descripcion,
            this.Cantidad,
            this.Subtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaConfirmarVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaConfirmarVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaConfirmarVenta.Location = new System.Drawing.Point(165, 160);
            this.tablaConfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaConfirmarVenta.Name = "tablaConfirmarVenta";
            this.tablaConfirmarVenta.RowHeadersVisible = false;
            this.tablaConfirmarVenta.RowHeadersWidth = 62;
            this.tablaConfirmarVenta.Size = new System.Drawing.Size(952, 443);
            this.tablaConfirmarVenta.TabIndex = 0;
            this.tablaConfirmarVenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaConfirmarVenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaConfirmarVenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaConfirmarVenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaConfirmarVenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaConfirmarVenta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaConfirmarVenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaConfirmarVenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaConfirmarVenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaConfirmarVenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaConfirmarVenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaConfirmarVenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaConfirmarVenta.ThemeStyle.HeaderStyle.Height = 15;
            this.tablaConfirmarVenta.ThemeStyle.ReadOnly = false;
            this.tablaConfirmarVenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaConfirmarVenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaConfirmarVenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaConfirmarVenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaConfirmarVenta.ThemeStyle.RowsStyle.Height = 22;
            this.tablaConfirmarVenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaConfirmarVenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
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
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 8;
            this.Subtotal.Name = "Subtotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirmar Venta";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(879, 648);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(0, 29);
            this.txtTotal.TabIndex = 3;
            // 
            // txtFinalizarVenta
            // 
            this.txtFinalizarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFinalizarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtFinalizarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtFinalizarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtFinalizarVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFinalizarVenta.ForeColor = System.Drawing.Color.White;
            this.txtFinalizarVenta.Location = new System.Drawing.Point(661, 629);
            this.txtFinalizarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFinalizarVenta.Name = "txtFinalizarVenta";
            this.txtFinalizarVenta.Size = new System.Drawing.Size(218, 53);
            this.txtFinalizarVenta.TabIndex = 6;
            this.txtFinalizarVenta.Text = "Finalizar y Imprimir";
            this.txtFinalizarVenta.Click += new System.EventHandler(this.txtFinalizarVenta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1095, 694);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSize = true;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(1016, 651);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(0, 25);
            this.txtSubtotal.TabIndex = 10;
            // 
            // txtTotalConIva
            // 
            this.txtTotalConIva.AutoSize = true;
            this.txtTotalConIva.Location = new System.Drawing.Point(1095, 697);
            this.txtTotalConIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotalConIva.Name = "txtTotalConIva";
            this.txtTotalConIva.Size = new System.Drawing.Size(0, 20);
            this.txtTotalConIva.TabIndex = 11;
            // 
            // totalConfirmarVenta
            // 
            this.totalConfirmarVenta.AutoSize = true;
            this.totalConfirmarVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalConfirmarVenta.Location = new System.Drawing.Point(160, 697);
            this.totalConfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalConfirmarVenta.Name = "totalConfirmarVenta";
            this.totalConfirmarVenta.Size = new System.Drawing.Size(202, 29);
            this.totalConfirmarVenta.TabIndex = 2;
            this.totalConfirmarVenta.Text = "Total (con IVA):";
            // 
            // subTotalConfirmarVenta
            // 
            this.subTotalConfirmarVenta.AutoSize = true;
            this.subTotalConfirmarVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalConfirmarVenta.Location = new System.Drawing.Point(160, 629);
            this.subTotalConfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalConfirmarVenta.Name = "subTotalConfirmarVenta";
            this.subTotalConfirmarVenta.Size = new System.Drawing.Size(123, 29);
            this.subTotalConfirmarVenta.TabIndex = 9;
            this.subTotalConfirmarVenta.Text = "Subtotal:";
            // 
            // btnVolverConfirmarVenta
            // 
            this.btnVolverConfirmarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverConfirmarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverConfirmarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolverConfirmarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolverConfirmarVenta.FillColor = System.Drawing.Color.Red;
            this.btnVolverConfirmarVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolverConfirmarVenta.ForeColor = System.Drawing.Color.White;
            this.btnVolverConfirmarVenta.Location = new System.Drawing.Point(900, 629);
            this.btnVolverConfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverConfirmarVenta.Name = "btnVolverConfirmarVenta";
            this.btnVolverConfirmarVenta.Size = new System.Drawing.Size(218, 53);
            this.btnVolverConfirmarVenta.TabIndex = 12;
            this.btnVolverConfirmarVenta.Text = "Volver";
            this.btnVolverConfirmarVenta.Click += new System.EventHandler(this.btnVolverConfirmarVenta_Click);
            // 
            // ConfirmarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 955);
            this.Controls.Add(this.btnVolverConfirmarVenta);
            this.Controls.Add(this.txtTotalConIva);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.subTotalConfirmarVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFinalizarVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.totalConfirmarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaConfirmarVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfirmarVenta";
            this.Text = "ConfirmarVenta";
            this.Load += new System.EventHandler(this.ConfirmarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaConfirmarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tablaConfirmarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTotal;
        private Guna.UI2.WinForms.Guna2Button txtFinalizarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSubtotal;
        private System.Windows.Forms.Label txtTotalConIva;
        private System.Windows.Forms.Label totalConfirmarVenta;
        private System.Windows.Forms.Label subTotalConfirmarVenta;
        private Guna.UI2.WinForms.Guna2Button btnVolverConfirmarVenta;
    }
}