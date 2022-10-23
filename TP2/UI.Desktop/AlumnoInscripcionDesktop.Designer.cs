
namespace UI.Desktop
{
    partial class AlumnoInscripcionDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIDInscripcion = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblIDAlumno = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbIDCurso = new System.Windows.Forms.ComboBox();
            this.nNota = new System.Windows.Forms.NumericUpDown();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.txtIDAlumno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNota)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIDInscripcion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIDCurso, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDAlumno, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbIDCurso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMateria, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblComision, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDAlumno, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCondicion, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCondicion, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNota, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nNota, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(135, 241);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(365, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIDInscripcion
            // 
            this.lblIDInscripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDInscripcion.AutoSize = true;
            this.lblIDInscripcion.Location = new System.Drawing.Point(21, 33);
            this.lblIDInscripcion.Name = "lblIDInscripcion";
            this.lblIDInscripcion.Size = new System.Drawing.Size(72, 13);
            this.lblIDInscripcion.TabIndex = 2;
            this.lblIDInscripcion.Text = "ID Inscripcion";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(33, 112);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 3;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblIDAlumno
            // 
            this.lblIDAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDAlumno.AutoSize = true;
            this.lblIDAlumno.Location = new System.Drawing.Point(29, 191);
            this.lblIDAlumno.Name = "lblIDAlumno";
            this.lblIDAlumno.Size = new System.Drawing.Size(56, 13);
            this.lblIDAlumno.TabIndex = 4;
            this.lblIDAlumno.Text = "ID Alumno";
            // 
            // lblCondicion
            // 
            this.lblCondicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(260, 191);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 5;
            this.lblCondicion.Text = "Condicion";
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(272, 33);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 6;
            this.lblNota.Text = "Nota";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(123, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(99, 20);
            this.txtID.TabIndex = 7;
            // 
            // cbIDCurso
            // 
            this.cbIDCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIDCurso.FormattingEnabled = true;
            this.cbIDCurso.Location = new System.Drawing.Point(123, 108);
            this.cbIDCurso.Name = "cbIDCurso";
            this.cbIDCurso.Size = new System.Drawing.Size(99, 21);
            this.cbIDCurso.TabIndex = 8;
            this.cbIDCurso.SelectionChangeCommitted += new System.EventHandler(this.cbIDCurso_SelectionChangeCommitted);
            // 
            // nNota
            // 
            this.nNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nNota.Location = new System.Drawing.Point(353, 29);
            this.nNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nNota.Name = "nNota";
            this.nNota.ReadOnly = true;
            this.nNota.Size = new System.Drawing.Size(99, 20);
            this.nNota.TabIndex = 11;
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(270, 112);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(35, 13);
            this.lblMateria.TabIndex = 12;
            this.lblMateria.Text = "label1";
            // 
            // lblComision
            // 
            this.lblComision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(385, 112);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(35, 13);
            this.lblComision.TabIndex = 13;
            this.lblComision.Text = "label2";
            // 
            // cbCondicion
            // 
            this.cbCondicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCondicion.Enabled = false;
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Items.AddRange(new object[] {
            "Inscripto",
            "Libre",
            "Regular",
            "Aprobado",
            "Cursando"});
            this.cbCondicion.Location = new System.Drawing.Point(353, 187);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(99, 21);
            this.cbCondicion.TabIndex = 16;
            this.cbCondicion.Text = "Inscripto";
            // 
            // txtIDAlumno
            // 
            this.txtIDAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDAlumno.Location = new System.Drawing.Point(123, 187);
            this.txtIDAlumno.Name = "txtIDAlumno";
            this.txtIDAlumno.ReadOnly = true;
            this.txtIDAlumno.Size = new System.Drawing.Size(99, 20);
            this.txtIDAlumno.TabIndex = 17;
            // 
            // AlumnoInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AlumnoInscripcionDesktop";
            this.Text = "AlumnoInscripcionDesktop";
            this.Load += new System.EventHandler(this.AlumnoInscripcionDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIDInscripcion;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblIDAlumno;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbIDCurso;
        private System.Windows.Forms.NumericUpDown nNota;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.TextBox txtIDAlumno;
    }
}