namespace proyectoBase
{
    partial class AltaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPersona));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbSurname = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtbFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdioMasculino = new System.Windows.Forms.RadioButton();
            this.rdioFemenino = new System.Windows.Forms.RadioButton();
            this.panelSexo = new System.Windows.Forms.Panel();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cbTipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.lblNdoc = new System.Windows.Forms.Label();
            this.txtbNdoc = new System.Windows.Forms.MaskedTextBox();
            this.txtbNroCasa = new System.Windows.Forms.TextBox();
            this.lblNcasa = new System.Windows.Forms.Label();
            this.txtbCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.chkSoltero = new System.Windows.Forms.CheckBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.chkHijos = new System.Windows.Forms.CheckBox();
            this.txtbCantidadHijos = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.btnRegistrarPersona = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gdrPersona = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(155, 40);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(161, 20);
            this.txtbName.TabIndex = 1;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(155, 66);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(161, 20);
            this.txtbApellido.TabIndex = 3;
            // 
            // txtbSurname
            // 
            this.txtbSurname.AutoSize = true;
            this.txtbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSurname.Location = new System.Drawing.Point(12, 69);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(60, 13);
            this.txtbSurname.TabIndex = 2;
            this.txtbSurname.Text = "Apellido: ";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(12, 121);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 13);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sexo: ";
            // 
            // txtbFechaNacimiento
            // 
            this.txtbFechaNacimiento.Location = new System.Drawing.Point(155, 93);
            this.txtbFechaNacimiento.Mask = "00/00/0000";
            this.txtbFechaNacimiento.Name = "txtbFechaNacimiento";
            this.txtbFechaNacimiento.Size = new System.Drawing.Size(161, 20);
            this.txtbFechaNacimiento.TabIndex = 8;
            this.txtbFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de nacimiento; ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdioMasculino
            // 
            this.rdioMasculino.AutoSize = true;
            this.rdioMasculino.Location = new System.Drawing.Point(3, 3);
            this.rdioMasculino.Name = "rdioMasculino";
            this.rdioMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdioMasculino.TabIndex = 11;
            this.rdioMasculino.TabStop = true;
            this.rdioMasculino.Text = "Masculino";
            this.rdioMasculino.UseVisualStyleBackColor = true;
            // 
            // rdioFemenino
            // 
            this.rdioFemenino.AutoSize = true;
            this.rdioFemenino.Location = new System.Drawing.Point(3, 26);
            this.rdioFemenino.Name = "rdioFemenino";
            this.rdioFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdioFemenino.TabIndex = 12;
            this.rdioFemenino.TabStop = true;
            this.rdioFemenino.Text = "Femenino";
            this.rdioFemenino.UseVisualStyleBackColor = true;
            // 
            // panelSexo
            // 
            this.panelSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSexo.Controls.Add(this.rdOtro);
            this.panelSexo.Controls.Add(this.rdioMasculino);
            this.panelSexo.Controls.Add(this.rdioFemenino);
            this.panelSexo.Location = new System.Drawing.Point(155, 121);
            this.panelSexo.Name = "panelSexo";
            this.panelSexo.Size = new System.Drawing.Size(161, 70);
            this.panelSexo.TabIndex = 13;
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Location = new System.Drawing.Point(3, 48);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(45, 17);
            this.rdOtro.TabIndex = 13;
            this.rdOtro.TabStop = true;
            this.rdOtro.Text = "Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(12, 207);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(124, 13);
            this.lblTipoDocumento.TabIndex = 14;
            this.lblTipoDocumento.Text = "Tipo de documento: ";
            // 
            // cbTipoDeDocumento
            // 
            this.cbTipoDeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDeDocumento.FormattingEnabled = true;
            this.cbTipoDeDocumento.Location = new System.Drawing.Point(155, 207);
            this.cbTipoDeDocumento.Name = "cbTipoDeDocumento";
            this.cbTipoDeDocumento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDeDocumento.TabIndex = 15;
            this.cbTipoDeDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeDocumento_SelectedIndexChanged);
            // 
            // lblNdoc
            // 
            this.lblNdoc.AutoSize = true;
            this.lblNdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdoc.Location = new System.Drawing.Point(12, 241);
            this.lblNdoc.Name = "lblNdoc";
            this.lblNdoc.Size = new System.Drawing.Size(113, 13);
            this.lblNdoc.TabIndex = 16;
            this.lblNdoc.Text = "N° de documento: ";
            // 
            // txtbNdoc
            // 
            this.txtbNdoc.Location = new System.Drawing.Point(155, 241);
            this.txtbNdoc.Mask = "99999999";
            this.txtbNdoc.Name = "txtbNdoc";
            this.txtbNdoc.Size = new System.Drawing.Size(100, 20);
            this.txtbNdoc.TabIndex = 17;
            this.txtbNdoc.ValidatingType = typeof(int);
            // 
            // txtbNroCasa
            // 
            this.txtbNroCasa.Location = new System.Drawing.Point(155, 293);
            this.txtbNroCasa.Name = "txtbNroCasa";
            this.txtbNroCasa.Size = new System.Drawing.Size(161, 20);
            this.txtbNroCasa.TabIndex = 21;
            // 
            // lblNcasa
            // 
            this.lblNcasa.AutoSize = true;
            this.lblNcasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNcasa.Location = new System.Drawing.Point(12, 296);
            this.lblNcasa.Name = "lblNcasa";
            this.lblNcasa.Size = new System.Drawing.Size(78, 13);
            this.lblNcasa.TabIndex = 20;
            this.lblNcasa.Text = "N° de casa: ";
            // 
            // txtbCalle
            // 
            this.txtbCalle.Location = new System.Drawing.Point(155, 267);
            this.txtbCalle.Name = "txtbCalle";
            this.txtbCalle.Size = new System.Drawing.Size(161, 20);
            this.txtbCalle.TabIndex = 19;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(12, 270);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(39, 13);
            this.lblCalle.TabIndex = 18;
            this.lblCalle.Text = "Calle:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(12, 328);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(77, 13);
            this.lblEstadoCivil.TabIndex = 22;
            this.lblEstadoCivil.Text = "Estado civil:";
            // 
            // chkSoltero
            // 
            this.chkSoltero.AutoSize = true;
            this.chkSoltero.Location = new System.Drawing.Point(155, 327);
            this.chkSoltero.Name = "chkSoltero";
            this.chkSoltero.Size = new System.Drawing.Size(59, 17);
            this.chkSoltero.TabIndex = 23;
            this.chkSoltero.Text = "Soltero";
            this.chkSoltero.UseVisualStyleBackColor = true;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(155, 350);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(62, 17);
            this.chkCasado.TabIndex = 24;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // chkHijos
            // 
            this.chkHijos.AutoSize = true;
            this.chkHijos.Location = new System.Drawing.Point(155, 373);
            this.chkHijos.Name = "chkHijos";
            this.chkHijos.Size = new System.Drawing.Size(69, 17);
            this.chkHijos.TabIndex = 25;
            this.chkHijos.Text = "Con hijos";
            this.chkHijos.UseVisualStyleBackColor = true;
            this.chkHijos.CheckedChanged += new System.EventHandler(this.chkHijos_CheckedChanged);
            // 
            // txtbCantidadHijos
            // 
            this.txtbCantidadHijos.Location = new System.Drawing.Point(288, 370);
            this.txtbCantidadHijos.Mask = "99";
            this.txtbCantidadHijos.Name = "txtbCantidadHijos";
            this.txtbCantidadHijos.Size = new System.Drawing.Size(28, 20);
            this.txtbCantidadHijos.TabIndex = 26;
            this.txtbCantidadHijos.ValidatingType = typeof(int);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(230, 374);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(12, 401);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 13);
            this.lblCarrera.TabIndex = 28;
            this.lblCarrera.Text = "Carrera:";
            // 
            // cbCarrera
            // 
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(155, 398);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbCarrera.TabIndex = 29;
            // 
            // btnRegistrarPersona
            // 
            this.btnRegistrarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPersona.Location = new System.Drawing.Point(155, 452);
            this.btnRegistrarPersona.Name = "btnRegistrarPersona";
            this.btnRegistrarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarPersona.TabIndex = 30;
            this.btnRegistrarPersona.Text = "Registrar";
            this.btnRegistrarPersona.UseVisualStyleBackColor = true;
            this.btnRegistrarPersona.Click += new System.EventHandler(this.btnRegistrarPersona_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(241, 452);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCampos.TabIndex = 31;
            this.btnLimpiarCampos.Text = "Limpiar ";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ingrese los datos";
            // 
            // gdrPersona
            // 
            this.gdrPersona.AllowUserToAddRows = false;
            this.gdrPersona.AllowUserToDeleteRows = false;
            this.gdrPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Apellido,
            this.Nombre});
            this.gdrPersona.Location = new System.Drawing.Point(374, 40);
            this.gdrPersona.Name = "gdrPersona";
            this.gdrPersona.ReadOnly = true;
            this.gdrPersona.Size = new System.Drawing.Size(443, 379);
            this.gdrPersona.TabIndex = 33;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 487);
            this.Controls.Add(this.gdrPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnRegistrarPersona);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtbCantidadHijos);
            this.Controls.Add(this.chkHijos);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.chkSoltero);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.txtbNroCasa);
            this.Controls.Add(this.lblNcasa);
            this.Controls.Add(this.txtbCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtbNdoc);
            this.Controls.Add(this.lblNdoc);
            this.Controls.Add(this.cbTipoDeDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.panelSexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbFechaNacimiento);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbSurname);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta nueva persona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            this.panelSexo.ResumeLayout(false);
            this.panelSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.Label txtbSurname;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.MaskedTextBox txtbFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdioMasculino;
        private System.Windows.Forms.RadioButton rdioFemenino;
        private System.Windows.Forms.Panel panelSexo;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cbTipoDeDocumento;
        private System.Windows.Forms.Label lblNdoc;
        private System.Windows.Forms.MaskedTextBox txtbNdoc;
        private System.Windows.Forms.TextBox txtbNroCasa;
        private System.Windows.Forms.Label lblNcasa;
        private System.Windows.Forms.TextBox txtbCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.CheckBox chkSoltero;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.CheckBox chkHijos;
        private System.Windows.Forms.MaskedTextBox txtbCantidadHijos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Button btnRegistrarPersona;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdrPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}