namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.components = new System.ComponentModel.Container();
            this.tblUsuarioDskp = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblIDPersona = new System.Windows.Forms.Label();
            this.txtIDPersona = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsuarioDskp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblUsuarioDskp
            // 
            this.tblUsuarioDskp.ColumnCount = 4;
            this.tblUsuarioDskp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUsuarioDskp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tblUsuarioDskp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUsuarioDskp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tblUsuarioDskp.Controls.Add(this.lblID, 0, 0);
            this.tblUsuarioDskp.Controls.Add(this.lblNombre, 0, 1);
            this.tblUsuarioDskp.Controls.Add(this.lblEmail, 0, 2);
            this.tblUsuarioDskp.Controls.Add(this.lblClave, 0, 3);
            this.tblUsuarioDskp.Controls.Add(this.lblApellido, 2, 1);
            this.tblUsuarioDskp.Controls.Add(this.lblUsuario, 2, 2);
            this.tblUsuarioDskp.Controls.Add(this.lblConfirmarClave, 2, 3);
            this.tblUsuarioDskp.Controls.Add(this.txtID, 1, 0);
            this.tblUsuarioDskp.Controls.Add(this.txtNombre, 1, 1);
            this.tblUsuarioDskp.Controls.Add(this.txtEmail, 1, 2);
            this.tblUsuarioDskp.Controls.Add(this.txtClave, 1, 3);
            this.tblUsuarioDskp.Controls.Add(this.txtUsuario, 3, 2);
            this.tblUsuarioDskp.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tblUsuarioDskp.Controls.Add(this.chkHabilitado, 2, 0);
            this.tblUsuarioDskp.Controls.Add(this.btnCancelar, 3, 4);
            this.tblUsuarioDskp.Controls.Add(this.txtApellido, 3, 1);
            this.tblUsuarioDskp.Controls.Add(this.btnAceptar, 2, 4);
            this.tblUsuarioDskp.Controls.Add(this.lblIDPersona, 0, 4);
            this.tblUsuarioDskp.Controls.Add(this.txtIDPersona, 1, 4);
            this.tblUsuarioDskp.Location = new System.Drawing.Point(12, 12);
            this.tblUsuarioDskp.Name = "tblUsuarioDskp";
            this.tblUsuarioDskp.RowCount = 5;
            this.tblUsuarioDskp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692F));
            this.tblUsuarioDskp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308F));
            this.tblUsuarioDskp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblUsuarioDskp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblUsuarioDskp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblUsuarioDskp.Size = new System.Drawing.Size(605, 251);
            this.tblUsuarioDskp.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(50, 179);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(345, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(346, 127);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Location = new System.Drawing.Point(327, 179);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(81, 13);
            this.lblConfirmarClave.TabIndex = 7;
            this.lblConfirmarClave.Text = "Confirmar Clave";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(138, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(159, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(138, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(138, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.Location = new System.Drawing.Point(138, 175);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(159, 20);
            this.txtClave.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(438, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(164, 20);
            this.txtUsuario.TabIndex = 14;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmarClave.Location = new System.Drawing.Point(438, 175);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(164, 20);
            this.txtConfirmarClave.TabIndex = 15;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(331, 16);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 16;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(482, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Location = new System.Drawing.Point(438, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(164, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(330, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblIDPersona
            // 
            this.lblIDPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDPersona.AutoSize = true;
            this.lblIDPersona.Location = new System.Drawing.Point(37, 222);
            this.lblIDPersona.Name = "lblIDPersona";
            this.lblIDPersona.Size = new System.Drawing.Size(60, 13);
            this.lblIDPersona.TabIndex = 19;
            this.lblIDPersona.Text = "ID Persona";
            // 
            // txtIDPersona
            // 
            this.txtIDPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDPersona.Location = new System.Drawing.Point(138, 219);
            this.txtIDPersona.Name = "txtIDPersona";
            this.txtIDPersona.ReadOnly = true;
            this.txtIDPersona.Size = new System.Drawing.Size(159, 20);
            this.txtIDPersona.TabIndex = 20;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 290);
            this.Controls.Add(this.tblUsuarioDskp);
            this.Name = "UsuarioDesktop";
            this.Text = "Usuario Desktop";
            this.Load += new System.EventHandler(this.UsuarioDesktop_Load);
            this.tblUsuarioDskp.ResumeLayout(false);
            this.tblUsuarioDskp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblUsuarioDskp;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblIDPersona;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtIDPersona;
        public System.Windows.Forms.TextBox txtApellido;
    }
}