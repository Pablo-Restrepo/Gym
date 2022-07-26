
namespace Visual
{
    partial class vtnProducto
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
            this.Adicional = new System.Windows.Forms.PictureBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodBarras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // Adicional
            // 
            this.Adicional.BackColor = System.Drawing.Color.Transparent;
            this.Adicional.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Adicional.Image = global::Visual.Properties.Resources.prod;
            this.Adicional.Location = new System.Drawing.Point(2, 2);
            this.Adicional.Name = "Adicional";
            this.Adicional.Size = new System.Drawing.Size(510, 163);
            this.Adicional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adicional.TabIndex = 4;
            this.Adicional.TabStop = false;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProducto.Font = new System.Drawing.Font("Montserrat SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(421, 140);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(295, 66);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "hgfhrtyhty";
            // 
            // pbProducto
            // 
            this.pbProducto.BackColor = System.Drawing.Color.Transparent;
            this.pbProducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbProducto.Image = global::Visual.Properties.Resources.prod;
            this.pbProducto.Location = new System.Drawing.Point(76, 154);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(312, 262);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 6;
            this.pbProducto.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(424, 237);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 44);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "999";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(423, 289);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(182, 44);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "45645645";
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.BackColor = System.Drawing.Color.Transparent;
            this.lblCodBarras.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.Location = new System.Drawing.Point(423, 343);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(158, 44);
            this.lblCodBarras.TabIndex = 9;
            this.lblCodBarras.Text = "8678678";
            // 
            // vtnProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
            this.BackgroundImage = global::Visual.Properties.Resources.Background__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 720);
            this.Controls.Add(this.lblCodBarras);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.Adicional);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vtnProducto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "vtnProteinas";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.vtnProteinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Adicional;
        public System.Windows.Forms.Label lblNombreProducto;
        public System.Windows.Forms.Label lblCantidad;
        public System.Windows.Forms.Label lblPrecio;
        public System.Windows.Forms.Label lblCodBarras;
        public System.Windows.Forms.PictureBox pbProducto;
    }
}