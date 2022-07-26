
namespace Visual
{
    partial class vtnProteinas
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
            this.Pcontener = new System.Windows.Forms.Panel();
            this.panelCentro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).BeginInit();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.Transparent;
            this.panelCentro.Controls.Add(this.Pcontener);
            this.panelCentro.Controls.Add(this.Adicional);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(1052, 720);
            this.panelCentro.TabIndex = 13;
            // 
            // Adicional
            // 
            this.Adicional.BackColor = System.Drawing.Color.Transparent;
            this.Adicional.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Adicional.Image = global::Visual.Properties.Resources.prote;
            this.Adicional.Location = new System.Drawing.Point(0, 0);
            this.Adicional.Name = "Adicional";
            this.Adicional.Size = new System.Drawing.Size(510, 163);
            this.Adicional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adicional.TabIndex = 4;
            this.Adicional.TabStop = false;
            // 
            // Pcontener
            // 
            this.Pcontener.AutoScroll = true;
            this.Pcontener.BackColor = System.Drawing.Color.Transparent;
            this.Pcontener.Location = new System.Drawing.Point(65, 150);
            this.Pcontener.Name = "Pcontener";
            this.Pcontener.Size = new System.Drawing.Size(902, 508);
            this.Pcontener.TabIndex = 11;
            // 
            // vtnProteinas
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
            this.Name = "vtnProteinas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "vtnProteinas";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.vtnProteinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).EndInit();
            this.panelCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Adicional;
        private System.Windows.Forms.Panel Pcontener;
        private System.Windows.Forms.Panel panelCentro;
    }
}