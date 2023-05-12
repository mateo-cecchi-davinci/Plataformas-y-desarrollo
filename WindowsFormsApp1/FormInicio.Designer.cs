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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonVentas = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.buttonProductos = new Guna.UI2.WinForms.Guna2Button();
            this.buttonInicioPantalla = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(130)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 154);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1194, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1311, 41);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(82, 74);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(318, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "HardHouse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LogoAppHardware;
            this.pictureBox1.Location = new System.Drawing.Point(40, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonVentas);
            this.panel2.Controls.Add(this.buttonUsuarios);
            this.panel2.Controls.Add(this.buttonProductos);
            this.panel2.Controls.Add(this.buttonInicioPantalla);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 99);
            this.panel2.TabIndex = 1;
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
            this.buttonVentas.Location = new System.Drawing.Point(865, 0);
            this.buttonVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(296, 99);
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
            this.buttonUsuarios.Location = new System.Drawing.Point(575, 0);
            this.buttonUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(296, 99);
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
            this.buttonProductos.Location = new System.Drawing.Point(289, 0);
            this.buttonProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(296, 99);
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
            this.buttonInicioPantalla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInicioPantalla.Name = "buttonInicioPantalla";
            this.buttonInicioPantalla.Size = new System.Drawing.Size(296, 99);
            this.buttonInicioPantalla.TabIndex = 0;
            this.buttonInicioPantalla.Text = "Inicio";
            this.buttonInicioPantalla.Click += new System.EventHandler(this.buttonInicioPantalla_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 253);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1443, 741);
            this.panelContainer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1443, 741);
            this.panel3.TabIndex = 3;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1443, 994);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

