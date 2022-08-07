namespace Visual
{
    partial class vtnAgregarElementos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.bntAgregarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProvedor = new System.Windows.Forms.Button();
            this.btnAgregarEjericios = new System.Windows.Forms.Button();
            this.bntAgregarMaquina = new System.Windows.Forms.Button();
            this.lbAgregar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Visual.Properties.Resources._62aadffb8508e1;
            this.panel1.Controls.Add(this.btnDevolver);
            this.panel1.Controls.Add(this.bntAgregarProducto);
            this.panel1.Controls.Add(this.btnAgregarProvedor);
            this.panel1.Controls.Add(this.btnAgregarEjericios);
            this.panel1.Controls.Add(this.bntAgregarMaquina);
            this.panel1.Controls.Add(this.lbAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Image = global::Visual.Properties.Resources.button_devolver;
            this.btnDevolver.Location = new System.Drawing.Point(46, 374);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(137, 41);
            this.btnDevolver.TabIndex = 5;
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // bntAgregarProducto
            // 
            this.bntAgregarProducto.Image = global::Visual.Properties.Resources.button_agregar_producto;
            this.bntAgregarProducto.Location = new System.Drawing.Point(322, 268);
            this.bntAgregarProducto.Name = "bntAgregarProducto";
            this.bntAgregarProducto.Size = new System.Drawing.Size(154, 28);
            this.bntAgregarProducto.TabIndex = 4;
            this.bntAgregarProducto.UseVisualStyleBackColor = true;
            this.bntAgregarProducto.Click += new System.EventHandler(this.bntAgregarProducto_Click);
            // 
            // btnAgregarProvedor
            // 
            this.btnAgregarProvedor.Image = global::Visual.Properties.Resources.button_agregar_proveedor;
            this.btnAgregarProvedor.Location = new System.Drawing.Point(322, 217);
            this.btnAgregarProvedor.Name = "btnAgregarProvedor";
            this.btnAgregarProvedor.Size = new System.Drawing.Size(154, 28);
            this.btnAgregarProvedor.TabIndex = 3;
            this.btnAgregarProvedor.UseVisualStyleBackColor = true;
            this.btnAgregarProvedor.Click += new System.EventHandler(this.btnAgregarProvedor_Click);
            // 
            // btnAgregarEjericios
            // 
            this.btnAgregarEjericios.Image = global::Visual.Properties.Resources.button_agregar_ejercicio;
            this.btnAgregarEjericios.Location = new System.Drawing.Point(322, 163);
            this.btnAgregarEjericios.Name = "btnAgregarEjericios";
            this.btnAgregarEjericios.Size = new System.Drawing.Size(154, 32);
            this.btnAgregarEjericios.TabIndex = 2;
            this.btnAgregarEjericios.UseVisualStyleBackColor = true;
            this.btnAgregarEjericios.Click += new System.EventHandler(this.btnAgregarEjericios_Click);
            // 
            // bntAgregarMaquina
            // 
            this.bntAgregarMaquina.Image = global::Visual.Properties.Resources.button_agregar_maquina;
            this.bntAgregarMaquina.Location = new System.Drawing.Point(322, 112);
            this.bntAgregarMaquina.Name = "bntAgregarMaquina";
            this.bntAgregarMaquina.Size = new System.Drawing.Size(154, 32);
            this.bntAgregarMaquina.TabIndex = 1;
            this.bntAgregarMaquina.UseVisualStyleBackColor = true;
            this.bntAgregarMaquina.Click += new System.EventHandler(this.bntAgregarMaquina_Click);
            // 
            // lbAgregar
            // 
            this.lbAgregar.AutoSize = true;
            this.lbAgregar.BackColor = System.Drawing.Color.Transparent;
            this.lbAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAgregar.Location = new System.Drawing.Point(248, 31);
            this.lbAgregar.Name = "lbAgregar";
            this.lbAgregar.Size = new System.Drawing.Size(308, 37);
            this.lbAgregar.TabIndex = 0;
            this.lbAgregar.Text = "Agregar Elementos";
            // 
            // vtnAgregarElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "vtnAgregarElementos";
            this.Text = "vtnAgregarElementos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntAgregarProducto;
        private System.Windows.Forms.Button btnAgregarProvedor;
        private System.Windows.Forms.Button btnAgregarEjericios;
        private System.Windows.Forms.Button bntAgregarMaquina;
        private System.Windows.Forms.Label lbAgregar;
        private System.Windows.Forms.Button btnDevolver;
    }
}