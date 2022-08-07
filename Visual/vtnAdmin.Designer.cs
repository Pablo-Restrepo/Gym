namespace Visual
{
    partial class vtnAdmin
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
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAgregarElementos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarSe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportes.Image = global::Visual.Properties.Resources.button_reportes;
            this.btnReportes.Location = new System.Drawing.Point(230, 177);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(204, 68);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnAgregarElementos
            // 
            this.btnAgregarElementos.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarElementos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarElementos.Image = global::Visual.Properties.Resources.button_agregar_elementos__1_;
            this.btnAgregarElementos.Location = new System.Drawing.Point(221, 380);
            this.btnAgregarElementos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarElementos.Name = "btnAgregarElementos";
            this.btnAgregarElementos.Size = new System.Drawing.Size(221, 59);
            this.btnAgregarElementos.TabIndex = 1;
            this.btnAgregarElementos.UseVisualStyleBackColor = false;
            this.btnAgregarElementos.Click += new System.EventHandler(this.btnAgregarElementos_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.Transparent;
            this.btnGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Image = global::Visual.Properties.Resources.button_entrenador_gestion__1_;
            this.btnGestion.Location = new System.Drawing.Point(223, 287);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(221, 56);
            this.btnGestion.TabIndex = 2;
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(164, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN GESTION";
            // 
            // btnIniciarSe
            // 
            this.btnIniciarSe.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSe.Image = global::Visual.Properties.Resources.botonis1;
            this.btnIniciarSe.Location = new System.Drawing.Point(27, 489);
            this.btnIniciarSe.Name = "btnIniciarSe";
            this.btnIniciarSe.Size = new System.Drawing.Size(154, 54);
            this.btnIniciarSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIniciarSe.TabIndex = 4;
            this.btnIniciarSe.TabStop = false;
            this.btnIniciarSe.Click += new System.EventHandler(this.btnIniciarSe_Click);
            // 
            // vtnAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual.Properties.Resources._62aadffb8508e1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 566);
            this.Controls.Add(this.btnIniciarSe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.btnAgregarElementos);
            this.Controls.Add(this.btnReportes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "vtnAdmin";
            this.Text = "vtnAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAgregarElementos;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnIniciarSe;
    }
}