
namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlpCursoD = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.lblIDComision = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.cbIDMateria = new System.Windows.Forms.ComboBox();
            this.cbIDComision = new System.Windows.Forms.ComboBox();
            this.txtAnioCalendario = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpCursoD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCursoD
            // 
            this.tlpCursoD.ColumnCount = 4;
            this.tlpCursoD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCursoD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCursoD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCursoD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCursoD.Controls.Add(this.lblIDCurso, 0, 0);
            this.tlpCursoD.Controls.Add(this.lblIDMateria, 0, 1);
            this.tlpCursoD.Controls.Add(this.lblIDComision, 0, 2);
            this.tlpCursoD.Controls.Add(this.lblAnioCalendario, 2, 0);
            this.tlpCursoD.Controls.Add(this.lblCupo, 2, 1);
            this.tlpCursoD.Controls.Add(this.txtIDCurso, 1, 0);
            this.tlpCursoD.Controls.Add(this.cbIDMateria, 1, 1);
            this.tlpCursoD.Controls.Add(this.cbIDComision, 1, 2);
            this.tlpCursoD.Controls.Add(this.txtAnioCalendario, 3, 0);
            this.tlpCursoD.Controls.Add(this.txtCupo, 3, 1);
            this.tlpCursoD.Controls.Add(this.btnAceptar, 1, 3);
            this.tlpCursoD.Controls.Add(this.btnCancelar, 3, 3);
            this.tlpCursoD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCursoD.Location = new System.Drawing.Point(0, 0);
            this.tlpCursoD.Name = "tlpCursoD";
            this.tlpCursoD.RowCount = 4;
            this.tlpCursoD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.91566F));
            this.tlpCursoD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.12048F));
            this.tlpCursoD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.91566F));
            this.tlpCursoD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74699F));
            this.tlpCursoD.Size = new System.Drawing.Size(593, 332);
            this.tlpCursoD.TabIndex = 0;
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(97, 41);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 0;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(103, 139);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(42, 13);
            this.lblIDMateria.TabIndex = 1;
            this.lblIDMateria.Text = "Materia";
            // 
            // lblIDComision
            // 
            this.lblIDComision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDComision.AutoSize = true;
            this.lblIDComision.Location = new System.Drawing.Point(96, 237);
            this.lblIDComision.Name = "lblIDComision";
            this.lblIDComision.Size = new System.Drawing.Size(49, 13);
            this.lblIDComision.TabIndex = 2;
            this.lblIDComision.Text = "Comision";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(363, 83);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(78, 13);
            this.lblAnioCalendario.TabIndex = 3;
            this.lblAnioCalendario.Text = "Año calendario";
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(409, 183);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 4;
            this.lblCupo.Text = "Cupo";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDCurso.Location = new System.Drawing.Point(172, 38);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.ReadOnly = true;
            this.txtIDCurso.Size = new System.Drawing.Size(100, 20);
            this.txtIDCurso.TabIndex = 5;
            // 
            // cbIDMateria
            // 
            this.cbIDMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIDMateria.FormattingEnabled = true;
            this.cbIDMateria.Location = new System.Drawing.Point(161, 135);
            this.cbIDMateria.Name = "cbIDMateria";
            this.cbIDMateria.Size = new System.Drawing.Size(121, 21);
            this.cbIDMateria.TabIndex = 6;
            // 
            // cbIDComision
            // 
            this.cbIDComision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIDComision.FormattingEnabled = true;
            this.cbIDComision.Location = new System.Drawing.Point(161, 233);
            this.cbIDComision.Name = "cbIDComision";
            this.cbIDComision.Size = new System.Drawing.Size(121, 21);
            this.cbIDComision.TabIndex = 7;
            // 
            // txtAnioCalendario
            // 
            this.txtAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAnioCalendario.Location = new System.Drawing.Point(468, 73);
            this.txtAnioCalendario.Name = "txtAnioCalendario";
            this.txtAnioCalendario.Size = new System.Drawing.Size(100, 20);
            this.txtAnioCalendario.TabIndex = 8;
            // 
            // txtCupo
            // 
            this.txtCupo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCupo.Location = new System.Drawing.Point(468, 173);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(100, 20);
            this.txtCupo.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(184, 300);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(481, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 332);
            this.Controls.Add(this.tlpCursoD);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.Load += new System.EventHandler(this.CursoDesktop_Load);
            this.tlpCursoD.ResumeLayout(false);
            this.tlpCursoD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCursoD;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.Label lblIDComision;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.ComboBox cbIDMateria;
        private System.Windows.Forms.ComboBox cbIDComision;
        private System.Windows.Forms.TextBox txtAnioCalendario;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}