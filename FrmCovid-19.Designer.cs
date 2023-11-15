namespace Covid_19
{
    partial class FrmCovid19
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.btnCerrarA = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbtSintomas = new System.Windows.Forms.GroupBox();
            this.btnNuevoDiagnostico = new System.Windows.Forms.Button();
            this.btnResumir = new System.Windows.Forms.Button();
            this.chbIncapacidad = new System.Windows.Forms.CheckBox();
            this.chbDolorPecho = new System.Windows.Forms.CheckBox();
            this.chbDifResprirar = new System.Windows.Forms.CheckBox();
            this.chbcansancio = new System.Windows.Forms.CheckBox();
            this.chbTos = new System.Windows.Forms.CheckBox();
            this.chbFiebre = new System.Windows.Forms.CheckBox();
            this.lblSintomasGraves = new System.Windows.Forms.Label();
            this.lblSintomasBasico = new System.Windows.Forms.Label();
            this.gbinformacionPacientes = new System.Windows.Forms.GroupBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCorreoElec = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblFecgaNacimiento = new System.Windows.Forms.Label();
            this.lblCorreoElentronico = new System.Windows.Forms.Label();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cbProvincias = new System.Windows.Forms.ComboBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNivelAcadémico = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbtSintomas.SuspendLayout();
            this.gbinformacionPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIAGNÓSTICO DE PACIENTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(437, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(699, 13);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(136, 25);
            this.lblFechaActual.TabIndex = 2;
            this.lblFechaActual.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Enabled = false;
            this.txtFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaActual.Location = new System.Drawing.Point(853, 10);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.ReadOnly = true;
            this.txtFechaActual.Size = new System.Drawing.Size(124, 30);
            this.txtFechaActual.TabIndex = 3;
            this.txtFechaActual.Text = "29/06/2020";
            // 
            // btnCerrarA
            // 
            this.btnCerrarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarA.Location = new System.Drawing.Point(987, 71);
            this.btnCerrarA.Name = "btnCerrarA";
            this.btnCerrarA.Size = new System.Drawing.Size(140, 49);
            this.btnCerrarA.TabIndex = 4;
            this.btnCerrarA.Text = "Cerrar Aplicación";
            this.btnCerrarA.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(17, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1247, 575);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbtSintomas);
            this.tabPage1.Controls.Add(this.gbinformacionPacientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1239, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbtSintomas
            // 
            this.gbtSintomas.Controls.Add(this.btnNuevoDiagnostico);
            this.gbtSintomas.Controls.Add(this.btnResumir);
            this.gbtSintomas.Controls.Add(this.chbIncapacidad);
            this.gbtSintomas.Controls.Add(this.chbDolorPecho);
            this.gbtSintomas.Controls.Add(this.chbDifResprirar);
            this.gbtSintomas.Controls.Add(this.chbcansancio);
            this.gbtSintomas.Controls.Add(this.chbTos);
            this.gbtSintomas.Controls.Add(this.chbFiebre);
            this.gbtSintomas.Controls.Add(this.lblSintomasGraves);
            this.gbtSintomas.Controls.Add(this.lblSintomasBasico);
            this.gbtSintomas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbtSintomas.Location = new System.Drawing.Point(532, 7);
            this.gbtSintomas.Name = "gbtSintomas";
            this.gbtSintomas.Size = new System.Drawing.Size(711, 523);
            this.gbtSintomas.TabIndex = 1;
            this.gbtSintomas.TabStop = false;
            this.gbtSintomas.Text = "Síntomas";
            // 
            // btnNuevoDiagnostico
            // 
            this.btnNuevoDiagnostico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevoDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDiagnostico.Location = new System.Drawing.Point(491, 419);
            this.btnNuevoDiagnostico.Name = "btnNuevoDiagnostico";
            this.btnNuevoDiagnostico.Size = new System.Drawing.Size(142, 60);
            this.btnNuevoDiagnostico.TabIndex = 9;
            this.btnNuevoDiagnostico.Text = "Nuevo diagnóstico";
            this.btnNuevoDiagnostico.UseVisualStyleBackColor = false;
            // 
            // btnResumir
            // 
            this.btnResumir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResumir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumir.Location = new System.Drawing.Point(276, 312);
            this.btnResumir.Name = "btnResumir";
            this.btnResumir.Size = new System.Drawing.Size(134, 44);
            this.btnResumir.TabIndex = 8;
            this.btnResumir.Text = "Resumir";
            this.btnResumir.UseVisualStyleBackColor = false;
            this.btnResumir.Click += new System.EventHandler(this.btnResumir_Click);
            // 
            // chbIncapacidad
            // 
            this.chbIncapacidad.AutoSize = true;
            this.chbIncapacidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbIncapacidad.Location = new System.Drawing.Point(194, 251);
            this.chbIncapacidad.Name = "chbIncapacidad";
            this.chbIncapacidad.Size = new System.Drawing.Size(335, 29);
            this.chbIncapacidad.TabIndex = 7;
            this.chbIncapacidad.Text = "Incapacidad para hablar o moverse";
            this.chbIncapacidad.UseVisualStyleBackColor = true;
            this.chbIncapacidad.CheckedChanged += new System.EventHandler(this.chbIncapacidad_CheckedChanged);
            // 
            // chbDolorPecho
            // 
            this.chbDolorPecho.AutoSize = true;
            this.chbDolorPecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbDolorPecho.Location = new System.Drawing.Point(194, 216);
            this.chbDolorPecho.Name = "chbDolorPecho";
            this.chbDolorPecho.Size = new System.Drawing.Size(267, 29);
            this.chbDolorPecho.TabIndex = 6;
            this.chbDolorPecho.Text = "Dolor o presión en el pecho";
            this.chbDolorPecho.UseVisualStyleBackColor = true;
            this.chbDolorPecho.CheckedChanged += new System.EventHandler(this.chbDolorPecho_CheckedChanged);
            // 
            // chbDifResprirar
            // 
            this.chbDifResprirar.AutoSize = true;
            this.chbDifResprirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbDifResprirar.Location = new System.Drawing.Point(194, 181);
            this.chbDifResprirar.Name = "chbDifResprirar";
            this.chbDifResprirar.Size = new System.Drawing.Size(465, 29);
            this.chbDifResprirar.TabIndex = 5;
            this.chbDifResprirar.Text = "Dificultad para respirar o sensación de falta de aire";
            this.chbDifResprirar.UseVisualStyleBackColor = true;
            this.chbDifResprirar.CheckedChanged += new System.EventHandler(this.chbDifResprirar_CheckedChanged);
            // 
            // chbcansancio
            // 
            this.chbcansancio.AutoSize = true;
            this.chbcansancio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbcansancio.Location = new System.Drawing.Point(194, 113);
            this.chbcansancio.Name = "chbcansancio";
            this.chbcansancio.Size = new System.Drawing.Size(124, 29);
            this.chbcansancio.TabIndex = 4;
            this.chbcansancio.Text = "Cansancio";
            this.chbcansancio.UseVisualStyleBackColor = true;
            this.chbcansancio.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chbTos
            // 
            this.chbTos.AutoSize = true;
            this.chbTos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbTos.Location = new System.Drawing.Point(194, 75);
            this.chbTos.Name = "chbTos";
            this.chbTos.Size = new System.Drawing.Size(111, 29);
            this.chbTos.TabIndex = 3;
            this.chbTos.Text = "Tos seca";
            this.chbTos.UseVisualStyleBackColor = true;
            this.chbTos.CheckedChanged += new System.EventHandler(this.chbTos_CheckedChanged);
            // 
            // chbFiebre
            // 
            this.chbFiebre.AutoSize = true;
            this.chbFiebre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbFiebre.Location = new System.Drawing.Point(194, 37);
            this.chbFiebre.Name = "chbFiebre";
            this.chbFiebre.Size = new System.Drawing.Size(85, 29);
            this.chbFiebre.TabIndex = 2;
            this.chbFiebre.Text = "Fiebre";
            this.chbFiebre.UseVisualStyleBackColor = true;
            this.chbFiebre.CheckedChanged += new System.EventHandler(this.chbFiebre_CheckedChanged);
            // 
            // lblSintomasGraves
            // 
            this.lblSintomasGraves.AutoSize = true;
            this.lblSintomasGraves.ForeColor = System.Drawing.Color.Red;
            this.lblSintomasGraves.Location = new System.Drawing.Point(16, 181);
            this.lblSintomasGraves.Name = "lblSintomasGraves";
            this.lblSintomasGraves.Size = new System.Drawing.Size(164, 25);
            this.lblSintomasGraves.TabIndex = 1;
            this.lblSintomasGraves.Text = "Síntomas graves:";
            // 
            // lblSintomasBasico
            // 
            this.lblSintomasBasico.AutoSize = true;
            this.lblSintomasBasico.ForeColor = System.Drawing.Color.Red;
            this.lblSintomasBasico.Location = new System.Drawing.Point(16, 37);
            this.lblSintomasBasico.Name = "lblSintomasBasico";
            this.lblSintomasBasico.Size = new System.Drawing.Size(172, 25);
            this.lblSintomasBasico.TabIndex = 0;
            this.lblSintomasBasico.Text = "Síntomas básicos:";
            // 
            // gbinformacionPacientes
            // 
            this.gbinformacionPacientes.Controls.Add(this.DtpFechaNacimiento);
            this.gbinformacionPacientes.Controls.Add(this.textBox3);
            this.gbinformacionPacientes.Controls.Add(this.textBox2);
            this.gbinformacionPacientes.Controls.Add(this.txtCorreoElec);
            this.gbinformacionPacientes.Controls.Add(this.lblNacionalidad);
            this.gbinformacionPacientes.Controls.Add(this.lblEstadoCivil);
            this.gbinformacionPacientes.Controls.Add(this.lblFecgaNacimiento);
            this.gbinformacionPacientes.Controls.Add(this.lblCorreoElentronico);
            this.gbinformacionPacientes.Controls.Add(this.txtOtro);
            this.gbinformacionPacientes.Controls.Add(this.rbOtro);
            this.gbinformacionPacientes.Controls.Add(this.rbFemenino);
            this.gbinformacionPacientes.Controls.Add(this.rbMasculino);
            this.gbinformacionPacientes.Controls.Add(this.lblSexo);
            this.gbinformacionPacientes.Controls.Add(this.txtDireccion);
            this.gbinformacionPacientes.Controls.Add(this.cbProvincias);
            this.gbinformacionPacientes.Controls.Add(this.txtSegundoApellido);
            this.gbinformacionPacientes.Controls.Add(this.txtPrimerApellido);
            this.gbinformacionPacientes.Controls.Add(this.txtNombre);
            this.gbinformacionPacientes.Controls.Add(this.lblDireccion);
            this.gbinformacionPacientes.Controls.Add(this.lblNivelAcadémico);
            this.gbinformacionPacientes.Controls.Add(this.lblSegundoApellido);
            this.gbinformacionPacientes.Controls.Add(this.lblPrimerApellido);
            this.gbinformacionPacientes.Controls.Add(this.lblNombre);
            this.gbinformacionPacientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbinformacionPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbinformacionPacientes.Location = new System.Drawing.Point(-4, 6);
            this.gbinformacionPacientes.Name = "gbinformacionPacientes";
            this.gbinformacionPacientes.Size = new System.Drawing.Size(532, 525);
            this.gbinformacionPacientes.TabIndex = 0;
            this.gbinformacionPacientes.TabStop = false;
            this.gbinformacionPacientes.Text = "Información de pacientes";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(202, 410);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(272, 27);
            this.DtpFechaNacimiento.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(187, 492);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 27);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(187, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 27);
            this.textBox2.TabIndex = 20;
            // 
            // txtCorreoElec
            // 
            this.txtCorreoElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCorreoElec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoElec.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorreoElec.Location = new System.Drawing.Point(187, 364);
            this.txtCorreoElec.Name = "txtCorreoElec";
            this.txtCorreoElec.Size = new System.Drawing.Size(287, 27);
            this.txtCorreoElec.TabIndex = 19;
            this.txtCorreoElec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.ForeColor = System.Drawing.Color.Red;
            this.lblNacionalidad.Location = new System.Drawing.Point(10, 502);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(117, 20);
            this.lblNacionalidad.TabIndex = 18;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.Red;
            this.lblEstadoCivil.Location = new System.Drawing.Point(10, 460);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(107, 20);
            this.lblEstadoCivil.TabIndex = 17;
            this.lblEstadoCivil.Text = "Estado civil";
            // 
            // lblFecgaNacimiento
            // 
            this.lblFecgaNacimiento.AutoSize = true;
            this.lblFecgaNacimiento.ForeColor = System.Drawing.Color.Red;
            this.lblFecgaNacimiento.Location = new System.Drawing.Point(10, 417);
            this.lblFecgaNacimiento.Name = "lblFecgaNacimiento";
            this.lblFecgaNacimiento.Size = new System.Drawing.Size(186, 20);
            this.lblFecgaNacimiento.TabIndex = 16;
            this.lblFecgaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblCorreoElentronico
            // 
            this.lblCorreoElentronico.AutoSize = true;
            this.lblCorreoElentronico.ForeColor = System.Drawing.Color.Red;
            this.lblCorreoElentronico.Location = new System.Drawing.Point(10, 371);
            this.lblCorreoElentronico.Name = "lblCorreoElentronico";
            this.lblCorreoElentronico.Size = new System.Drawing.Size(165, 20);
            this.lblCorreoElentronico.TabIndex = 15;
            this.lblCorreoElentronico.Text = "Correo electrónico";
            // 
            // txtOtro
            // 
            this.txtOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtro.Enabled = false;
            this.txtOtro.Location = new System.Drawing.Point(260, 330);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(214, 27);
            this.txtOtro.TabIndex = 14;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(187, 333);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(67, 24);
            this.rbOtro.TabIndex = 13;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(363, 293);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(111, 24);
            this.rbFemenino.TabIndex = 12;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(187, 293);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(115, 24);
            this.rbMasculino.TabIndex = 11;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Red;
            this.lblSexo.Location = new System.Drawing.Point(10, 297);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 20);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(187, 180);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(287, 93);
            this.txtDireccion.TabIndex = 9;
            // 
            // cbProvincias
            // 
            this.cbProvincias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbProvincias.DisplayMember = "(ninguno)";
            this.cbProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbProvincias.FormattingEnabled = true;
            this.cbProvincias.Items.AddRange(new object[] {
            "San José",
            "Cartago",
            "Heredia",
            "Alajuela",
            "Guanacaste",
            "Puntarenas",
            "Limón"});
            this.cbProvincias.Location = new System.Drawing.Point(187, 143);
            this.cbProvincias.Name = "cbProvincias";
            this.cbProvincias.Size = new System.Drawing.Size(287, 28);
            this.cbProvincias.TabIndex = 8;
            this.cbProvincias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoApellido.Location = new System.Drawing.Point(187, 107);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(287, 27);
            this.txtSegundoApellido.TabIndex = 7;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerApellido.Location = new System.Drawing.Point(187, 69);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(287, 27);
            this.txtPrimerApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(187, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(287, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblDireccion.Location = new System.Drawing.Point(10, 187);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(81, 20);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNivelAcadémico
            // 
            this.lblNivelAcadémico.AutoSize = true;
            this.lblNivelAcadémico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcadémico.ForeColor = System.Drawing.Color.Red;
            this.lblNivelAcadémico.Location = new System.Drawing.Point(10, 151);
            this.lblNivelAcadémico.Name = "lblNivelAcadémico";
            this.lblNivelAcadémico.Size = new System.Drawing.Size(132, 20);
            this.lblNivelAcadémico.TabIndex = 3;
            this.lblNivelAcadémico.Text = "Nivel académico";
            this.lblNivelAcadémico.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.Red;
            this.lblSegundoApellido.Location = new System.Drawing.Point(10, 114);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(136, 20);
            this.lblSegundoApellido.TabIndex = 2;
            this.lblSegundoApellido.Text = "Segundo apellido";
            this.lblSegundoApellido.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.Red;
            this.lblPrimerApellido.Location = new System.Drawing.Point(10, 76);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(121, 20);
            this.lblPrimerApellido.TabIndex = 1;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Red;
            this.lblNombre.Location = new System.Drawing.Point(10, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // FrmCovid19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1276, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrarA);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCovid19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pacientes con Covid19";
            this.Load += new System.EventHandler(this.FrmCovid19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbtSintomas.ResumeLayout(false);
            this.gbtSintomas.PerformLayout();
            this.gbinformacionPacientes.ResumeLayout(false);
            this.gbinformacionPacientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.Button btnCerrarA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbinformacionPacientes;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNivelAcadémico;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cbProvincias;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCorreoElec;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblFecgaNacimiento;
        private System.Windows.Forms.Label lblCorreoElentronico;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.GroupBox gbtSintomas;
        private System.Windows.Forms.Label lblSintomasGraves;
        private System.Windows.Forms.Label lblSintomasBasico;
        private System.Windows.Forms.CheckBox chbIncapacidad;
        private System.Windows.Forms.CheckBox chbDolorPecho;
        private System.Windows.Forms.CheckBox chbDifResprirar;
        private System.Windows.Forms.CheckBox chbcansancio;
        private System.Windows.Forms.CheckBox chbTos;
        private System.Windows.Forms.CheckBox chbFiebre;
        private System.Windows.Forms.Button btnNuevoDiagnostico;
        private System.Windows.Forms.Button btnResumir;
    }
}

