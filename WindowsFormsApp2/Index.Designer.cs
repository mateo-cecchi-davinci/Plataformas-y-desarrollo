namespace WindowsFormsApp2
{
    partial class Index
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
            this.btn_prods = new System.Windows.Forms.Button();
            this.btn_cats = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_prods
            // 
            this.btn_prods.Location = new System.Drawing.Point(52, 25);
            this.btn_prods.Name = "btn_prods";
            this.btn_prods.Size = new System.Drawing.Size(122, 37);
            this.btn_prods.TabIndex = 0;
            this.btn_prods.Text = "Productos";
            this.btn_prods.UseVisualStyleBackColor = true;
            this.btn_prods.Click += new System.EventHandler(this.btn_prods_Click);
            // 
            // btn_cats
            // 
            this.btn_cats.Location = new System.Drawing.Point(220, 26);
            this.btn_cats.Name = "btn_cats";
            this.btn_cats.Size = new System.Drawing.Size(122, 36);
            this.btn_cats.TabIndex = 1;
            this.btn_cats.Text = "Categorias";
            this.btn_cats.UseVisualStyleBackColor = true;
            this.btn_cats.Click += new System.EventHandler(this.btn_cats_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(53, 96);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1130, 429);
            this.panelContainer.TabIndex = 2;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 549);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btn_cats);
            this.Controls.Add(this.btn_prods);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_prods;
        private System.Windows.Forms.Button btn_cats;
        private System.Windows.Forms.Panel panelContainer;
    }
}