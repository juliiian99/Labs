
namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescMateria = new System.Windows.Forms.Label();
            this.lblHsSemana = new System.Windows.Forms.Label();
            this.lblHsAnual = new System.Windows.Forms.Label();
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescMateria = new System.Windows.Forms.TextBox();
            this.txtHsSemana = new System.Windows.Forms.TextBox();
            this.txtHorasAnual = new System.Windows.Forms.TextBox();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.08425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.91575F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescMateria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHsSemana, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHsAnual, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDPlan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescMateria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHsSemana, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtHorasAnual, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDPlan, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 271);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(135, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 29);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(427, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 29);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(57, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblDescMateria
            // 
            this.lblDescMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescMateria.AutoSize = true;
            this.lblDescMateria.Location = new System.Drawing.Point(16, 112);
            this.lblDescMateria.Name = "lblDescMateria";
            this.lblDescMateria.Size = new System.Drawing.Size(100, 13);
            this.lblDescMateria.TabIndex = 3;
            this.lblDescMateria.Text = "Descripcion materia";
            // 
            // lblHsSemana
            // 
            this.lblHsSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHsSemana.AutoSize = true;
            this.lblHsSemana.Location = new System.Drawing.Point(302, 31);
            this.lblHsSemana.Name = "lblHsSemana";
            this.lblHsSemana.Size = new System.Drawing.Size(88, 13);
            this.lblHsSemana.TabIndex = 4;
            this.lblHsSemana.Text = "Horas semanales";
            // 
            // lblHsAnual
            // 
            this.lblHsAnual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHsAnual.AutoSize = true;
            this.lblHsAnual.Location = new System.Drawing.Point(311, 112);
            this.lblHsAnual.Name = "lblHsAnual";
            this.lblHsAnual.Size = new System.Drawing.Size(69, 13);
            this.lblHsAnual.TabIndex = 5;
            this.lblHsAnual.Text = "Horas totales";
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Location = new System.Drawing.Point(223, 192);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(42, 13);
            this.lblIDPlan.TabIndex = 6;
            this.lblIDPlan.Text = "ID Plan";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(150, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "Autogenerado";
            // 
            // txtDescMateria
            // 
            this.txtDescMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescMateria.Location = new System.Drawing.Point(150, 109);
            this.txtDescMateria.Name = "txtDescMateria";
            this.txtDescMateria.Size = new System.Drawing.Size(100, 20);
            this.txtDescMateria.TabIndex = 8;
            // 
            // txtHsSemana
            // 
            this.txtHsSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHsSemana.Location = new System.Drawing.Point(447, 28);
            this.txtHsSemana.Name = "txtHsSemana";
            this.txtHsSemana.Size = new System.Drawing.Size(100, 20);
            this.txtHsSemana.TabIndex = 9;
            // 
            // txtHorasAnual
            // 
            this.txtHorasAnual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHorasAnual.Location = new System.Drawing.Point(447, 109);
            this.txtHorasAnual.Name = "txtHorasAnual";
            this.txtHorasAnual.Size = new System.Drawing.Size(100, 20);
            this.txtHorasAnual.TabIndex = 10;
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDPlan.Location = new System.Drawing.Point(271, 189);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.Size = new System.Drawing.Size(100, 20);
            this.txtIDPlan.TabIndex = 11;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescMateria;
        private System.Windows.Forms.Label lblHsSemana;
        private System.Windows.Forms.Label lblHsAnual;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescMateria;
        private System.Windows.Forms.TextBox txtHsSemana;
        private System.Windows.Forms.TextBox txtHorasAnual;
        private System.Windows.Forms.TextBox txtIDPlan;
    }
}