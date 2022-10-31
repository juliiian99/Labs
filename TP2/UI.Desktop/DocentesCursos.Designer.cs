
namespace UI.Desktop
{
    partial class DocentesCursos
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
            this.tlpDocentesCursos = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDocentesCursos = new System.Windows.Forms.DataGridView();
            this.docenteCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tlpDocentesCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlpDocentesCursos);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(574, 275);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(574, 300);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tlpDocentesCursos
            // 
            this.tlpDocentesCursos.ColumnCount = 5;
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDocentesCursos.Controls.Add(this.btnAlta, 0, 1);
            this.tlpDocentesCursos.Controls.Add(this.btnModificar, 1, 1);
            this.tlpDocentesCursos.Controls.Add(this.btnBaja, 3, 1);
            this.tlpDocentesCursos.Controls.Add(this.btnConsultar, 2, 1);
            this.tlpDocentesCursos.Controls.Add(this.btnSalir, 4, 1);
            this.tlpDocentesCursos.Controls.Add(this.dgvDocentesCursos, 0, 0);
            this.tlpDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpDocentesCursos.Name = "tlpDocentesCursos";
            this.tlpDocentesCursos.RowCount = 2;
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.45454F));
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54545F));
            this.tlpDocentesCursos.Size = new System.Drawing.Size(574, 275);
            this.tlpDocentesCursos.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAlta.Location = new System.Drawing.Point(123, 250);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(85, 21);
            this.btnAlta.TabIndex = 11;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificar.Location = new System.Drawing.Point(214, 250);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 21);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBaja.Location = new System.Drawing.Point(396, 250);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(85, 21);
            this.btnBaja.TabIndex = 12;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConsultar.Location = new System.Drawing.Point(305, 250);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 21);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(487, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 21);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDocentesCursos
            // 
            this.dgvDocentesCursos.AllowUserToAddRows = false;
            this.dgvDocentesCursos.AllowUserToDeleteRows = false;
            this.dgvDocentesCursos.AutoGenerateColumns = false;
            this.dgvDocentesCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentesCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDCursoDataGridViewTextBoxColumn,
            this.Curso,
            this.iDDocenteDataGridViewTextBoxColumn,
            this.Docente,
            this.cargoDataGridViewTextBoxColumn});
            this.tlpDocentesCursos.SetColumnSpan(this.dgvDocentesCursos, 5);
            this.dgvDocentesCursos.DataSource = this.docenteCursoBindingSource;
            this.dgvDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentesCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvDocentesCursos.Name = "dgvDocentesCursos";
            this.dgvDocentesCursos.ReadOnly = true;
            this.dgvDocentesCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentesCursos.Size = new System.Drawing.Size(568, 240);
            this.dgvDocentesCursos.TabIndex = 16;
            // 
            // docenteCursoBindingSource
            // 
            this.docenteCursoBindingSource.DataSource = typeof(Business.Entities.DocenteCurso);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID Dictado";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCursoDataGridViewTextBoxColumn
            // 
            this.iDCursoDataGridViewTextBoxColumn.DataPropertyName = "IDCurso";
            this.iDCursoDataGridViewTextBoxColumn.HeaderText = "ID Curso";
            this.iDCursoDataGridViewTextBoxColumn.Name = "iDCursoDataGridViewTextBoxColumn";
            this.iDCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "Curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // iDDocenteDataGridViewTextBoxColumn
            // 
            this.iDDocenteDataGridViewTextBoxColumn.DataPropertyName = "IDDocente";
            this.iDDocenteDataGridViewTextBoxColumn.HeaderText = "ID Docente";
            this.iDDocenteDataGridViewTextBoxColumn.Name = "iDDocenteDataGridViewTextBoxColumn";
            this.iDDocenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Docente
            // 
            this.Docente.DataPropertyName = "Docente";
            this.Docente.HeaderText = "Docente";
            this.Docente.Name = "Docente";
            this.Docente.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 300);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "DocentesCursos";
            this.Text = "DocentesCursos";
            this.Load += new System.EventHandler(this.DocentesCursos_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlpDocentesCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteCursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpDocentesCursos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDocentesCursos;
        private System.Windows.Forms.BindingSource docenteCursoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
    }
}