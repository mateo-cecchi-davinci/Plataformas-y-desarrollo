namespace WindowsFormsApp1
{
    partial class FormInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonVentas = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.buttonProductos = new Guna.UI2.WinForms.Guna2Button();
            this.buttonInicioPantalla = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(130)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 100);
            this.panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(833, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(74, 55);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(829, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(212, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "HardHouse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LogoAppHardware;
            this.pictureBox1.Location = new System.Drawing.Point(27, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.buttonVentas);
            this.panel2.Controls.Add(this.buttonUsuarios);
            this.panel2.Controls.Add(this.buttonProductos);
            this.panel2.Controls.Add(this.buttonInicioPantalla);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 64);
            this.panel2.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.guna2Button1.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.guna2Button1.Location = new System.Drawing.Point(777, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(185, 61);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Categorias";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // buttonVentas
            // 
            this.buttonVentas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonVentas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonVentas.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonVentas.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonVentas.FillColor = System.Drawing.SystemColors.Control;
            this.buttonVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentas.ForeColor = System.Drawing.Color.Black;
            this.buttonVentas.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonVentas.HoverState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.buttonVentas.Location = new System.Drawing.Point(194, 0);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(197, 61);
            this.buttonVentas.TabIndex = 3;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonUsuarios.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonUsuarios.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUsuarios.FillColor = System.Drawing.SystemColors.Control;
            this.buttonUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.ForeColor = System.Drawing.Color.Black;
            this.buttonUsuarios.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonUsuarios.HoverState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUsuarios.Location = new System.Drawing.Point(584, -3);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(197, 64);
            this.buttonUsuarios.TabIndex = 2;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonProductos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonProductos.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonProductos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonProductos.FillColor = System.Drawing.SystemColors.Control;
            this.buttonProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.Color.Black;
            this.buttonProductos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonProductos.HoverState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProductos.Location = new System.Drawing.Point(397, 0);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(199, 61);
            this.buttonProductos.TabIndex = 1;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // buttonInicioPantalla
            // 
            this.buttonInicioPantalla.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonInicioPantalla.Checked = true;
            this.buttonInicioPantalla.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonInicioPantalla.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonInicioPantalla.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonInicioPantalla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonInicioPantalla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonInicioPantalla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonInicioPantalla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonInicioPantalla.FillColor = System.Drawing.SystemColors.Control;
            this.buttonInicioPantalla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicioPantalla.ForeColor = System.Drawing.Color.Black;
            this.buttonInicioPantalla.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.buttonInicioPantalla.HoverState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInicioPantalla.Location = new System.Drawing.Point(0, 0);
            this.buttonInicioPantalla.Name = "buttonInicioPantalla";
            this.buttonInicioPantalla.Size = new System.Drawing.Size(197, 61);
            this.buttonInicioPantalla.TabIndex = 0;
            this.buttonInicioPantalla.Text = "Inicio";
            this.buttonInicioPantalla.Click += new System.EventHandler(this.buttonInicioPantalla_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 164);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1325, 482);
            this.panelContainer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1325, 482);
            this.panel3.TabIndex = 3;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1325, 646);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button buttonInicioPantalla;
        private Guna.UI2.WinForms.Guna2Button buttonVentas;
        private Guna.UI2.WinForms.Guna2Button buttonUsuarios;
        private Guna.UI2.WinForms.Guna2Button buttonProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

