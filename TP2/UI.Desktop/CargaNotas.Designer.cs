
namespace UI.Desktop
{
    partial class CargaNotas
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.alumnoInscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.nNota = new System.Windows.Forms.NumericUpDown();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoInscripcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(650, 416);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(650, 416);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCondicion, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCondicion, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNota, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nNota, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvNotas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreAlumno, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.29214F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.707865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // alumnoInscripcionBindingSource
            // 
            this.alumnoInscripcionBindingSource.DataSource = typeof(Business.Entities.AlumnoInscripcion);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(504, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(56, 392);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota";
            // 
            // lblCondicion
            // 
            this.lblCondicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(333, 359);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 5;
            this.lblCondicion.Text = "Condicion";
            // 
            // cbCondicion
            // 
            this.cbCondicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Items.AddRange(new object[] {
            "Inscripto",
            "Libre",
            "Aprobado",
            "Cursando"});
            this.cbCondicion.Location = new System.Drawing.Point(488, 355);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(107, 21);
            this.cbCondicion.TabIndex = 6;
            this.cbCondicion.Text = "Inscripto";
            // 
            // nNota
            // 
            this.nNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nNota.Location = new System.Drawing.Point(190, 389);
            this.nNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nNota.Name = "nNota";
            this.nNota.Size = new System.Drawing.Size(49, 20);
            this.nNota.TabIndex = 7;
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvNotas, 4);
            this.dgvNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotas.Location = new System.Drawing.Point(3, 3);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(644, 343);
            this.dgvNotas.TabIndex = 8;
            this.dgvNotas.Click += new System.EventHandler(this.dgvNotas_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 359);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreAlumno.Location = new System.Drawing.Point(164, 355);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAlumno.TabIndex = 10;
            // 
            // CargaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 416);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "CargaNotas";
            this.Text = "CargaNotas";
            this.Load += new System.EventHandler(this.CargaNotas_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoInscripcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource alumnoInscripcionBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.NumericUpDown nNota;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreAlumno;
    }
}