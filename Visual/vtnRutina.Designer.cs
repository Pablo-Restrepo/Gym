
namespace Visual
{
    partial class vtnRutina
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelRutinasUsuario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRutinasDisponibles = new System.Windows.Forms.Panel();
            this.panelCentro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).BeginInit();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adicional
            // 
            this.Adicional.BackColor = System.Drawing.Color.Transparent;
            this.Adicional.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Adicional.Image = global::Visual.Properties.Resources.ruti;
            this.Adicional.Location = new System.Drawing.Point(0, 0);
            this.Adicional.Name = "Adicional";
            this.Adicional.Size = new System.Drawing.Size(510, 163);
            this.Adicional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adicional.TabIndex = 4;
            this.Adicional.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tus Rutinas:";
            // 
            // panelRutinasUsuario
            // 
            this.panelRutinasUsuario.BackColor = System.Drawing.Color.Transparent;
            this.panelRutinasUsuario.Location = new System.Drawing.Point(72, 201);
            this.panelRutinasUsuario.Name = "panelRutinasUsuario";
            this.panelRutinasUsuario.Size = new System.Drawing.Size(1687, 122);
            this.panelRutinasUsuario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rutinas Disponibles:";
            // 
            // panelRutinasDisponibles
            // 
            this.panelRutinasDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.panelRutinasDisponibles.Location = new System.Drawing.Point(72, 405);
            this.panelRutinasDisponibles.Name = "panelRutinasDisponibles";
            this.panelRutinasDisponibles.Size = new System.Drawing.Size(919, 237);
            this.panelRutinasDisponibles.TabIndex = 7;
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.Transparent;
            this.panelCentro.Controls.Add(this.panelRutinasDisponibles);
            this.panelCentro.Controls.Add(this.label1);
            this.panelCentro.Controls.Add(this.label2);
            this.panelCentro.Controls.Add(this.Adicional);
            this.panelCentro.Controls.Add(this.panelRutinasUsuario);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(1052, 720);
            this.panelCentro.TabIndex = 8;
            // 
            // vtnRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
            this.BackgroundImage = global::Visual.Properties.Resources.Background__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 720);
            this.Controls.Add(this.panelCentro);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vtnRutina";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "vtnRutina";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.vtnRutina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).EndInit();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Adicional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRutinasUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRutinasDisponibles;
        private System.Windows.Forms.Panel panelCentro;
    }
}