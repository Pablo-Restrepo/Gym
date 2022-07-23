
namespace Visual
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
            this.menulVertical = new System.Windows.Forms.Panel();
            this.AcercaDe = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Nutricion = new System.Windows.Forms.PictureBox();
            this.Entrenador = new System.Windows.Forms.PictureBox();
            this.Comprar = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.Adicional = new System.Windows.Forms.PictureBox();
            this.Buscar = new System.Windows.Forms.PictureBox();
            this.Inicio = new System.Windows.Forms.PictureBox();
            this.panelBarraTop = new System.Windows.Forms.Panel();
            this.btnTamanio2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnTamanio = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.menulVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcercaDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nutricion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entrenador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inicio)).BeginInit();
            this.panelBarraTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menulVertical
            // 
            this.menulVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.menulVertical.Controls.Add(this.AcercaDe);
            this.menulVertical.Controls.Add(this.pictureBox20);
            this.menulVertical.Controls.Add(this.Salir);
            this.menulVertical.Controls.Add(this.Nutricion);
            this.menulVertical.Controls.Add(this.Entrenador);
            this.menulVertical.Controls.Add(this.Comprar);
            this.menulVertical.Controls.Add(this.pictureBox15);
            this.menulVertical.Controls.Add(this.Adicional);
            this.menulVertical.Controls.Add(this.Buscar);
            this.menulVertical.Controls.Add(this.Inicio);
            this.menulVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menulVertical.Location = new System.Drawing.Point(0, 34);
            this.menulVertical.Name = "menulVertical";
            this.menulVertical.Size = new System.Drawing.Size(228, 686);
            this.menulVertical.TabIndex = 2;
            this.menulVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menulVertical_Paint);
            // 
            // AcercaDe
            // 
            this.AcercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.AcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcercaDe.Image = global::Visual.Properties.Resources.Acercade;
            this.AcercaDe.Location = new System.Drawing.Point(19, 540);
            this.AcercaDe.Name = "AcercaDe";
            this.AcercaDe.Size = new System.Drawing.Size(155, 35);
            this.AcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcercaDe.TabIndex = 9;
            this.AcercaDe.TabStop = false;
            this.AcercaDe.Click += new System.EventHandler(this.AcercaDe_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox20.Image = global::Visual.Properties.Resources.Linea;
            this.pictureBox20.Location = new System.Drawing.Point(12, 598);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(203, 10);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 8;
            this.pictureBox20.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Image = global::Visual.Properties.Resources.Salir;
            this.Salir.Location = new System.Drawing.Point(19, 627);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(108, 32);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 7;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Nutricion
            // 
            this.Nutricion.BackColor = System.Drawing.Color.Transparent;
            this.Nutricion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nutricion.Image = global::Visual.Properties.Resources.Nutricion;
            this.Nutricion.Location = new System.Drawing.Point(19, 359);
            this.Nutricion.Name = "Nutricion";
            this.Nutricion.Size = new System.Drawing.Size(142, 34);
            this.Nutricion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nutricion.TabIndex = 6;
            this.Nutricion.TabStop = false;
            this.Nutricion.Click += new System.EventHandler(this.Nutricion_Click);
            // 
            // Entrenador
            // 
            this.Entrenador.BackColor = System.Drawing.Color.Transparent;
            this.Entrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrenador.Image = global::Visual.Properties.Resources.Entrenador;
            this.Entrenador.Location = new System.Drawing.Point(19, 298);
            this.Entrenador.Name = "Entrenador";
            this.Entrenador.Size = new System.Drawing.Size(170, 38);
            this.Entrenador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Entrenador.TabIndex = 5;
            this.Entrenador.TabStop = false;
            this.Entrenador.Click += new System.EventHandler(this.Entrenador_Click);
            // 
            // Comprar
            // 
            this.Comprar.BackColor = System.Drawing.Color.Transparent;
            this.Comprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comprar.Image = global::Visual.Properties.Resources.Compras;
            this.Comprar.Location = new System.Drawing.Point(19, 239);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(142, 37);
            this.Comprar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Comprar.TabIndex = 4;
            this.Comprar.TabStop = false;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = global::Visual.Properties.Resources.Linea;
            this.pictureBox15.Location = new System.Drawing.Point(12, 203);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(203, 10);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 3;
            this.pictureBox15.TabStop = false;
            // 
            // Adicional
            // 
            this.Adicional.BackColor = System.Drawing.Color.Transparent;
            this.Adicional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicional.Image = global::Visual.Properties.Resources.Adicionales;
            this.Adicional.Location = new System.Drawing.Point(22, 145);
            this.Adicional.Name = "Adicional";
            this.Adicional.Size = new System.Drawing.Size(179, 35);
            this.Adicional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adicional.TabIndex = 2;
            this.Adicional.TabStop = false;
            this.Adicional.Click += new System.EventHandler(this.Adicional_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.Image = global::Visual.Properties.Resources.Buscar;
            this.Buscar.Location = new System.Drawing.Point(19, 89);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(130, 32);
            this.Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Buscar.TabIndex = 1;
            this.Buscar.TabStop = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.Transparent;
            this.Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inicio.Image = global::Visual.Properties.Resources.Inicio1;
            this.Inicio.Location = new System.Drawing.Point(15, 31);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(130, 32);
            this.Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inicio.TabIndex = 0;
            this.Inicio.TabStop = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // panelBarraTop
            // 
            this.panelBarraTop.BackColor = System.Drawing.Color.Black;
            this.panelBarraTop.Controls.Add(this.btnTamanio2);
            this.panelBarraTop.Controls.Add(this.btnCerrar);
            this.panelBarraTop.Controls.Add(this.btnMinimizar);
            this.panelBarraTop.Controls.Add(this.btnTamanio);
            this.panelBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTop.ForeColor = System.Drawing.Color.Transparent;
            this.panelBarraTop.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTop.Name = "panelBarraTop";
            this.panelBarraTop.Size = new System.Drawing.Size(1280, 34);
            this.panelBarraTop.TabIndex = 4;
            this.panelBarraTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTop_Paint);
            this.panelBarraTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnTamanio2
            // 
            this.btnTamanio2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamanio2.BackColor = System.Drawing.Color.Transparent;
            this.btnTamanio2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamanio2.FlatAppearance.BorderSize = 0;
            this.btnTamanio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamanio2.Image = global::Visual.Properties.Resources.Imagen15;
            this.btnTamanio2.Location = new System.Drawing.Point(1228, 6);
            this.btnTamanio2.Name = "btnTamanio2";
            this.btnTamanio2.Size = new System.Drawing.Size(16, 22);
            this.btnTamanio2.TabIndex = 3;
            this.btnTamanio2.UseVisualStyleBackColor = false;
            this.btnTamanio2.Visible = false;
            this.btnTamanio2.Click += new System.EventHandler(this.btnTamanio2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Visual.Properties.Resources.x;
            this.btnCerrar.Location = new System.Drawing.Point(1256, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 18);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizar.Image = global::Visual.Properties.Resources._;
            this.btnMinimizar.Location = new System.Drawing.Point(1199, 10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 17);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnTamanio
            // 
            this.btnTamanio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamanio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamanio.FlatAppearance.BorderSize = 0;
            this.btnTamanio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamanio.Image = global::Visual.Properties.Resources.cuadro;
            this.btnTamanio.Location = new System.Drawing.Point(1228, 8);
            this.btnTamanio.Name = "btnTamanio";
            this.btnTamanio.Size = new System.Drawing.Size(16, 18);
            this.btnTamanio.TabIndex = 1;
            this.btnTamanio.UseVisualStyleBackColor = true;
            this.btnTamanio.Click += new System.EventHandler(this.btnTamanio_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentral.BackColor = System.Drawing.Color.Transparent;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Location = new System.Drawing.Point(228, 34);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1050, 686);
            this.panelCentral.TabIndex = 3;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.menulVertical);
            this.Controls.Add(this.panelBarraTop);
            this.Controls.Add(this.panelCentral);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unicauca Fit";
            this.menulVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AcercaDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nutricion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entrenador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inicio)).EndInit();
            this.panelBarraTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnTamanio;
        private System.Windows.Forms.Button btnTamanio2;
        private System.Windows.Forms.Panel menulVertical;
        private System.Windows.Forms.PictureBox Inicio;
        private System.Windows.Forms.Panel panelBarraTop;
        private System.Windows.Forms.PictureBox Buscar;
        private System.Windows.Forms.PictureBox Adicional;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox AcercaDe;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Nutricion;
        private System.Windows.Forms.PictureBox Entrenador;
        private System.Windows.Forms.PictureBox Comprar;
        private System.Windows.Forms.Panel panelCentral;
    }
}

