
namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbIDCurso = new System.Windows.Forms.ComboBox();
            this.cbDocente = new System.Windows.Forms.ComboBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblComi = new System.Windows.Forms.Label();
            this.lblMate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.64922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.35078F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIDCurso, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDocente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbIDCurso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbDocente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCargo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblComision, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMateria, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblComi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMate, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Dictado";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(13, 89);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(51, 13);
            this.lblIDCurso.TabIndex = 1;
            this.lblIDCurso.Text = "ID Curso:";
            // 
            // lblDocente
            // 
            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(13, 152);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(51, 13);
            this.lblDocente.TabIndex = 2;
            this.lblDocente.Text = "Docente:";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(26, 218);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(70, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // cbIDCurso
            // 
            this.cbIDCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbIDCurso.FormattingEnabled = true;
            this.cbIDCurso.Location = new System.Drawing.Point(70, 85);
            this.cbIDCurso.Name = "cbIDCurso";
            this.cbIDCurso.Size = new System.Drawing.Size(109, 21);
            this.cbIDCurso.TabIndex = 5;
            this.cbIDCurso.SelectionChangeCommitted += new System.EventHandler(this.cbIDCurso_SelectionChangeCommitted);
            // 
            // cbDocente
            // 
            this.cbDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.Location = new System.Drawing.Point(70, 148);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(109, 21);
            this.cbDocente.TabIndex = 6;
            // 
            // cbCargo
            // 
            this.cbCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(70, 214);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(109, 21);
            this.cbCargo.TabIndex = 7;
            // 
            // lblComision
            // 
            this.lblComision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(215, 89);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(49, 13);
            this.lblComision.TabIndex = 8;
            this.lblComision.Text = "Comision";
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(337, 89);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 9;
            this.lblMateria.Text = "Materia";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(87, 271);
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
            this.btnCancelar.Location = new System.Drawing.Point(320, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblComi
            // 
            this.lblComi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblComi.AutoSize = true;
            this.lblComi.Location = new System.Drawing.Point(215, 51);
            this.lblComi.Name = "lblComi";
            this.lblComi.Size = new System.Drawing.Size(49, 13);
            this.lblComi.TabIndex = 12;
            this.lblComi.Text = "Comision";
            // 
            // lblMate
            // 
            this.lblMate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMate.AutoSize = true;
            this.lblMate.Location = new System.Drawing.Point(337, 51);
            this.lblMate.Name = "lblMate";
            this.lblMate.Size = new System.Drawing.Size(42, 13);
            this.lblMate.TabIndex = 13;
            this.lblMate.Text = "Materia";
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DocenteCursoDesktop";
            this.Text = "DocenteCursoDesktop";
            this.Load += new System.EventHandler(this.DocenteCursoDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbIDCurso;
        private System.Windows.Forms.ComboBox cbDocente;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblComi;
        private System.Windows.Forms.Label lblMate;
    }
}