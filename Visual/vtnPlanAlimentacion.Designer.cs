
namespace Visual
{
    partial class vtnPlanAlimentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adicional = new System.Windows.Forms.PictureBox();
            this.lblNombrePlan = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.idrutina = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Adicional
            // 
            this.Adicional.BackColor = System.Drawing.Color.Transparent;
            this.Adicional.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Adicional.Image = global::Visual.Properties.Resources.ali;
            this.Adicional.Location = new System.Drawing.Point(5, 3);
            this.Adicional.Name = "Adicional";
            this.Adicional.Size = new System.Drawing.Size(510, 163);
            this.Adicional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adicional.TabIndex = 4;
            this.Adicional.TabStop = false;
            // 
            // lblNombrePlan
            // 
            this.lblNombrePlan.AutoSize = true;
            this.lblNombrePlan.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePlan.Font = new System.Drawing.Font("Montserrat SemiBold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlan.Location = new System.Drawing.Point(33, 131);
            this.lblNombrePlan.Name = "lblNombrePlan";
            this.lblNombrePlan.Size = new System.Drawing.Size(330, 75);
            this.lblNombrePlan.TabIndex = 5;
            this.lblNombrePlan.Text = "hgfhrtyhty";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::Visual.Properties.Resources.volver;
            this.btnVolver.Location = new System.Drawing.Point(13, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(50, 50);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 21;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.Transparent;
            this.panelCentro.Controls.Add(this.label2);
            this.panelCentro.Controls.Add(this.dataGridView1);
            this.panelCentro.Controls.Add(this.idrutina);
            this.panelCentro.Controls.Add(this.btnAgregar);
            this.panelCentro.Controls.Add(this.label1);
            this.panelCentro.Controls.Add(this.btnVolver);
            this.panelCentro.Controls.Add(this.lblNombrePlan);
            this.panelCentro.Controls.Add(this.Adicional);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(1052, 720);
            this.panelCentro.TabIndex = 22;
            // 
            // idrutina
            // 
            this.idrutina.AutoSize = true;
            this.idrutina.Location = new System.Drawing.Point(1347, 566);
            this.idrutina.Name = "idrutina";
            this.idrutina.Size = new System.Drawing.Size(0, 13);
            this.idrutina.TabIndex = 31;
            this.idrutina.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::Visual.Properties.Resources.agregar;
            this.btnAgregar.Location = new System.Drawing.Point(838, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 61);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "Plan:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(49, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(960, 175);
            this.dataGridView1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 658);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 33;
            this.label2.Visible = false;
            // 
            // vtnPlanAlimentacion
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
            this.Name = "vtnPlanAlimentacion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "vtnProteinas";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.vtnProteinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Adicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Adicional;
        public System.Windows.Forms.Label lblNombrePlan;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.Panel panelCentro;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox btnAgregar;
        public System.Windows.Forms.Label idrutina;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label2;
    }
}