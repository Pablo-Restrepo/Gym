
namespace Visual
{
    partial class vtnIniciarSesion
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
            this.panelBarraTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.PictureBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnRegistrarse = new System.Windows.Forms.PictureBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTarjCredito = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtRecContrasenia = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pbRegistr = new System.Windows.Forms.PictureBox();
            this.txtContraseniaIniSes = new System.Windows.Forms.TextBox();
            this.txtUsuarioIniSes = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.PictureBox();
            this.pbLogoIniciarSes = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelBarraTop.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoIniciarSes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTop
            // 
            this.panelBarraTop.BackColor = System.Drawing.Color.Transparent;
            this.panelBarraTop.Controls.Add(this.btnCerrar);
            this.panelBarraTop.Controls.Add(this.btnMinimizar);
            this.panelBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTop.ForeColor = System.Drawing.Color.Transparent;
            this.panelBarraTop.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTop.Name = "panelBarraTop";
            this.panelBarraTop.Size = new System.Drawing.Size(906, 34);
            this.panelBarraTop.TabIndex = 4;
            this.panelBarraTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Visual.Properties.Resources.x;
            this.btnCerrar.Location = new System.Drawing.Point(876, 8);
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
            this.btnMinimizar.Location = new System.Drawing.Point(847, 10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 17);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Transparent;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Controls.Add(this.btnAdmin);
            this.panelCentral.Controls.Add(this.txtCiudad);
            this.panelCentral.Controls.Add(this.dtpFechaNacimiento);
            this.panelCentral.Controls.Add(this.cbxSexo);
            this.panelCentral.Controls.Add(this.btnVolver);
            this.panelCentral.Controls.Add(this.btnRegistrarse);
            this.panelCentral.Controls.Add(this.txtAltura);
            this.panelCentral.Controls.Add(this.txtPeso);
            this.panelCentral.Controls.Add(this.txtCedula);
            this.panelCentral.Controls.Add(this.txtApellido);
            this.panelCentral.Controls.Add(this.txtNombre);
            this.panelCentral.Controls.Add(this.txtTarjCredito);
            this.panelCentral.Controls.Add(this.txtCorreo);
            this.panelCentral.Controls.Add(this.txtRecContrasenia);
            this.panelCentral.Controls.Add(this.txtContrasenia);
            this.panelCentral.Controls.Add(this.txtUsuario);
            this.panelCentral.Controls.Add(this.pbRegistr);
            this.panelCentral.Controls.Add(this.txtContraseniaIniSes);
            this.panelCentral.Controls.Add(this.txtUsuarioIniSes);
            this.panelCentral.Controls.Add(this.btnRegistrar);
            this.panelCentral.Controls.Add(this.btnIniciar);
            this.panelCentral.Controls.Add(this.pbLogoIniciarSes);
            this.panelCentral.Controls.Add(this.pbLogo);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(906, 720);
            this.panelCentral.TabIndex = 3;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Image = global::Visual.Properties.Resources.admin;
            this.btnAdmin.Location = new System.Drawing.Point(12, 655);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(152, 53);
            this.btnAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdmin.TabIndex = 24;
            this.btnAdmin.TabStop = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCiudad.Location = new System.Drawing.Point(217, 471);
            this.txtCiudad.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtCiudad.MaxLength = 30;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(187, 22);
            this.txtCiudad.TabIndex = 23;
            this.txtCiudad.Visible = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.dtpFechaNacimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.dtpFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.dtpFechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(663, 343);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(119, 23);
            this.dtpFechaNacimiento.TabIndex = 22;
            this.dtpFechaNacimiento.Visible = false;
            // 
            // cbxSexo
            // 
            this.cbxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.cbxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.ForeColor = System.Drawing.Color.White;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbxSexo.Location = new System.Drawing.Point(556, 406);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(227, 24);
            this.cbxSexo.TabIndex = 21;
            this.cbxSexo.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::Visual.Properties.Resources.volver;
            this.btnVolver.Location = new System.Drawing.Point(40, 40);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(50, 50);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 20;
            this.btnVolver.TabStop = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.Image = global::Visual.Properties.Resources.registrars;
            this.btnRegistrarse.Location = new System.Drawing.Point(389, 589);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(152, 53);
            this.btnRegistrarse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.TabStop = false;
            this.btnRegistrarse.Visible = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAltura.Location = new System.Drawing.Point(381, 534);
            this.txtAltura.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtAltura.MaxLength = 30;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(229, 22);
            this.txtAltura.TabIndex = 18;
            this.txtAltura.Visible = false;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPeso.Location = new System.Drawing.Point(550, 471);
            this.txtPeso.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtPeso.MaxLength = 30;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(238, 22);
            this.txtPeso.TabIndex = 17;
            this.txtPeso.Visible = false;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCedula.Location = new System.Drawing.Point(564, 283);
            this.txtCedula.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtCedula.MaxLength = 30;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(224, 22);
            this.txtCedula.TabIndex = 15;
            this.txtCedula.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.txtApellido.Location = new System.Drawing.Point(572, 219);
            this.txtApellido.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(216, 22);
            this.txtApellido.TabIndex = 14;
            this.txtApellido.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(578, 155);
            this.txtNombre.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 22);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Visible = false;
            // 
            // txtTarjCredito
            // 
            this.txtTarjCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtTarjCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarjCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjCredito.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTarjCredito.Location = new System.Drawing.Point(244, 406);
            this.txtTarjCredito.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtTarjCredito.MaxLength = 30;
            this.txtTarjCredito.Name = "txtTarjCredito";
            this.txtTarjCredito.Size = new System.Drawing.Size(187, 22);
            this.txtTarjCredito.TabIndex = 12;
            this.txtTarjCredito.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Location = new System.Drawing.Point(207, 344);
            this.txtCorreo.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(224, 22);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.Visible = false;
            // 
            // txtRecContrasenia
            // 
            this.txtRecContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtRecContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecContrasenia.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRecContrasenia.Location = new System.Drawing.Point(281, 281);
            this.txtRecContrasenia.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtRecContrasenia.MaxLength = 30;
            this.txtRecContrasenia.Name = "txtRecContrasenia";
            this.txtRecContrasenia.PasswordChar = '*';
            this.txtRecContrasenia.Size = new System.Drawing.Size(153, 22);
            this.txtRecContrasenia.TabIndex = 10;
            this.txtRecContrasenia.Visible = false;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContrasenia.Location = new System.Drawing.Point(246, 218);
            this.txtContrasenia.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtContrasenia.MaxLength = 30;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(185, 22);
            this.txtContrasenia.TabIndex = 9;
            this.txtContrasenia.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Location = new System.Drawing.Point(213, 155);
            this.txtUsuario.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 22);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Visible = false;
            // 
            // pbRegistr
            // 
            this.pbRegistr.Image = global::Visual.Properties.Resources.regitrarsefinal;
            this.pbRegistr.Location = new System.Drawing.Point(79, 60);
            this.pbRegistr.Name = "pbRegistr";
            this.pbRegistr.Size = new System.Drawing.Size(762, 609);
            this.pbRegistr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegistr.TabIndex = 6;
            this.pbRegistr.TabStop = false;
            this.pbRegistr.Visible = false;
            // 
            // txtContraseniaIniSes
            // 
            this.txtContraseniaIniSes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtContraseniaIniSes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseniaIniSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseniaIniSes.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContraseniaIniSes.Location = new System.Drawing.Point(572, 368);
            this.txtContraseniaIniSes.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtContraseniaIniSes.MaxLength = 30;
            this.txtContraseniaIniSes.Name = "txtContraseniaIniSes";
            this.txtContraseniaIniSes.PasswordChar = '*';
            this.txtContraseniaIniSes.Size = new System.Drawing.Size(205, 22);
            this.txtContraseniaIniSes.TabIndex = 5;
            // 
            // txtUsuarioIniSes
            // 
            this.txtUsuarioIniSes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtUsuarioIniSes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioIniSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioIniSes.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuarioIniSes.Location = new System.Drawing.Point(572, 298);
            this.txtUsuarioIniSes.MaximumSize = new System.Drawing.Size(260, 22);
            this.txtUsuarioIniSes.MaxLength = 30;
            this.txtUsuarioIniSes.Name = "txtUsuarioIniSes";
            this.txtUsuarioIniSes.Size = new System.Drawing.Size(205, 22);
            this.txtUsuarioIniSes.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Image = global::Visual.Properties.Resources.regis2;
            this.btnRegistrar.Location = new System.Drawing.Point(612, 512);
            this.btnRegistrar.MaximumSize = new System.Drawing.Size(107, 32);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 32);
            this.btnRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Image = global::Visual.Properties.Resources.botonis;
            this.btnIniciar.Location = new System.Drawing.Point(582, 437);
            this.btnIniciar.MaximumSize = new System.Drawing.Size(162, 56);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(160, 56);
            this.btnIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.TabStop = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pbLogoIniciarSes
            // 
            this.pbLogoIniciarSes.Image = global::Visual.Properties.Resources.IS;
            this.pbLogoIniciarSes.Location = new System.Drawing.Point(437, 173);
            this.pbLogoIniciarSes.Name = "pbLogoIniciarSes";
            this.pbLogoIniciarSes.Size = new System.Drawing.Size(427, 397);
            this.pbLogoIniciarSes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoIniciarSes.TabIndex = 1;
            this.pbLogoIniciarSes.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Visual.Properties.Resources.sesion;
            this.pbLogo.Location = new System.Drawing.Point(3, 188);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(415, 348);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // vtnIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
            this.BackgroundImage = global::Visual.Properties.Resources._62aadffb8508e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 720);
            this.Controls.Add(this.panelBarraTop);
            this.Controls.Add(this.panelCentral);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vtnIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unicauca Fit";
            this.panelBarraTop.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoIniciarSes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelBarraTop;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbLogoIniciarSes;
        private System.Windows.Forms.PictureBox btnIniciar;
        private System.Windows.Forms.PictureBox btnRegistrar;
        private System.Windows.Forms.TextBox txtUsuarioIniSes;
        private System.Windows.Forms.TextBox txtContraseniaIniSes;
        private System.Windows.Forms.PictureBox btnRegistrarse;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTarjCredito;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtRecContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbRegistr;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.PictureBox btnAdmin;
    }
}

