
namespace UI.Desktop
{
    partial class AlumnosInscripciones
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAlumnoInscripcion = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.alumnoInscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoInscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(665, 279);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(665, 304);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnAlta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConsultar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnModificar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBaja, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvAlumnoInscripcion, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.24731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75269F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 279);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAlta.Location = new System.Drawing.Point(139, 253);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(106, 21);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConsultar.Location = new System.Drawing.Point(352, 253);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 21);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificar.Location = new System.Drawing.Point(251, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 21);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBaja.Location = new System.Drawing.Point(453, 253);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(95, 21);
            this.btnBaja.TabIndex = 7;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(554, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 21);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAlumnoInscripcion
            // 
            this.dgvAlumnoInscripcion.AllowUserToAddRows = false;
            this.dgvAlumnoInscripcion.AllowUserToDeleteRows = false;
            this.dgvAlumnoInscripcion.AutoGenerateColumns = false;
            this.dgvAlumnoInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.condicionDataGridViewTextBoxColumn,
            this.iDAlumnoDataGridViewTextBoxColumn,
            this.alumnoDataGridViewTextBoxColumn,
            this.iDCursoDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvAlumnoInscripcion, 5);
            this.dgvAlumnoInscripcion.DataSource = this.alumnoInscripcionBindingSource;
            this.dgvAlumnoInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnoInscripcion.Location = new System.Drawing.Point(3, 3);
            this.dgvAlumnoInscripcion.Name = "dgvAlumnoInscripcion";
            this.dgvAlumnoInscripcion.ReadOnly = true;
            this.dgvAlumnoInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnoInscripcion.Size = new System.Drawing.Size(659, 242);
            this.dgvAlumnoInscripcion.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // alumnoInscripcionBindingSource
            // 
            this.alumnoInscripcionBindingSource.DataSource = typeof(Business.Entities.AlumnoInscripcion);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID Inscripcion";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // condicionDataGridViewTextBoxColumn
            // 
            this.condicionDataGridViewTextBoxColumn.DataPropertyName = "Condicion";
            this.condicionDataGridViewTextBoxColumn.HeaderText = "Condicion";
            this.condicionDataGridViewTextBoxColumn.Name = "condicionDataGridViewTextBoxColumn";
            this.condicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDAlumnoDataGridViewTextBoxColumn
            // 
            this.iDAlumnoDataGridViewTextBoxColumn.DataPropertyName = "IDAlumno";
            this.iDAlumnoDataGridViewTextBoxColumn.HeaderText = "IDAlumno";
            this.iDAlumnoDataGridViewTextBoxColumn.Name = "iDAlumnoDataGridViewTextBoxColumn";
            this.iDAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alumnoDataGridViewTextBoxColumn
            // 
            this.alumnoDataGridViewTextBoxColumn.DataPropertyName = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.HeaderText = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.Name = "alumnoDataGridViewTextBoxColumn";
            this.alumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCursoDataGridViewTextBoxColumn
            // 
            this.iDCursoDataGridViewTextBoxColumn.DataPropertyName = "IDCurso";
            this.iDCursoDataGridViewTextBoxColumn.HeaderText = "IDCurso";
            this.iDCursoDataGridViewTextBoxColumn.Name = "iDCursoDataGridViewTextBoxColumn";
            this.iDCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AlumnosInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 304);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "AlumnosInscripciones";
            this.Text = "AlumnosInscripciones";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoInscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAlumnoInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alumnoInscripcionBindingSource;
    }
}