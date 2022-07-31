
namespace Visual
{
    partial class vtnCompra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pcontener = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adicional
            // 
            this.Adicional.BackColor = System.Drawing.Color.Transparent;
            this.Adicional.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Adicional.Image = global::Visual.Properties.Resources.com;
            this.Adicional.Location = new System.Drawing.Point(0, 2);
            this.Adicional.Name = "Adicional";
            this.Adicional.Size = new System.Drawing.Size(510, 163);
            this.Adicional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adicional.TabIndex = 4;
            this.Adicional.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Pcontener);
            this.panel1.Controls.Add(this.Adicional);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 720);
            this.panel1.TabIndex = 5;
            // 
            // Pcontener
            // 
            this.Pcontener.AutoScroll = true;
            this.Pcontener.BackColor = System.Drawing.Color.Transparent;
            this.Pcontener.Location = new System.Drawing.Point(52, 136);
            this.Pcontener.Name = "Pcontener";
            this.Pcontener.Size = new System.Drawing.Size(948, 508);
            this.Pcontener.TabIndex = 12;
            // 
            // vtnCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
            this.BackgroundImage = global::Visual.Properties.Resources.Background__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 720);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vtnCompra";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "vtnCompra";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.vtnCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Adicional;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pcontener;
    }
}