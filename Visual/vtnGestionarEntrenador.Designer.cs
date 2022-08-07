namespace Visual
{
    partial class vtnGestionarEntrenador
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCapacitarEntrenador = new System.Windows.Forms.Button();
            this.btnCrearRutina = new System.Windows.Forms.Button();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnCrearEntrenador = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Visual.Properties.Resources._62aadffb8508e1;
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnCapacitarEntrenador);
            this.panel1.Controls.Add(this.btnCrearRutina);
            this.panel1.Controls.Add(this.btnCrearCurso);
            this.panel1.Controls.Add(this.btnCrearEntrenador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 468);
            this.panel1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::Visual.Properties.Resources.button_atras;
            this.btnAtras.Location = new System.Drawing.Point(84, 369);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(86, 41);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCapacitarEntrenador
            // 
            this.btnCapacitarEntrenador.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCapacitarEntrenador.Image = global::Visual.Properties.Resources.button_capacitar_entrenador;
            this.btnCapacitarEntrenador.Location = new System.Drawing.Point(260, 260);
            this.btnCapacitarEntrenador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapacitarEntrenador.Name = "btnCapacitarEntrenador";
            this.btnCapacitarEntrenador.Size = new System.Drawing.Size(154, 31);
            this.btnCapacitarEntrenador.TabIndex = 3;
            this.btnCapacitarEntrenador.UseVisualStyleBackColor = false;
            this.btnCapacitarEntrenador.Click += new System.EventHandler(this.btnCapacitarEntrenador_Click);
            // 
            // btnCrearRutina
            // 
            this.btnCrearRutina.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCrearRutina.Image = global::Visual.Properties.Resources.button_crear_rutina;
            this.btnCrearRutina.Location = new System.Drawing.Point(260, 206);
            this.btnCrearRutina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearRutina.Name = "btnCrearRutina";
            this.btnCrearRutina.Size = new System.Drawing.Size(154, 31);
            this.btnCrearRutina.TabIndex = 2;
            this.btnCrearRutina.UseVisualStyleBackColor = false;
            this.btnCrearRutina.Click += new System.EventHandler(this.btnCrearRutina_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCrearCurso.Image = global::Visual.Properties.Resources.button_crear_curso;
            this.btnCrearCurso.Location = new System.Drawing.Point(260, 163);
            this.btnCrearCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(154, 27);
            this.btnCrearCurso.TabIndex = 1;
            this.btnCrearCurso.UseVisualStyleBackColor = false;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // btnCrearEntrenador
            // 
            this.btnCrearEntrenador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCrearEntrenador.Image = global::Visual.Properties.Resources.button_crear_entrenador;
            this.btnCrearEntrenador.Location = new System.Drawing.Point(260, 119);
            this.btnCrearEntrenador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearEntrenador.Name = "btnCrearEntrenador";
            this.btnCrearEntrenador.Size = new System.Drawing.Size(154, 32);
            this.btnCrearEntrenador.TabIndex = 0;
            this.btnCrearEntrenador.UseVisualStyleBackColor = false;
            this.btnCrearEntrenador.Click += new System.EventHandler(this.btnCrearEntrenador_Click);
            // 
            // vtnGestionarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 468);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "vtnGestionarEntrenador";
            this.Text = "vtnGestionarEntrenador";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearRutina;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Button btnCrearEntrenador;
        private System.Windows.Forms.Button btnCapacitarEntrenador;
        private System.Windows.Forms.Button btnAtras;
    }
}