
namespace UI.Desktop
{
    partial class Cursos
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
            this.tcCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlCursos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.academiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.cursosTableAdapter();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioCalendarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDComisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCursos.ContentPanel.SuspendLayout();
            this.tcCursos.TopToolStripPanel.SuspendLayout();
            this.tcCursos.SuspendLayout();
            this.tlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCursos
            // 
            // 
            // tcCursos.ContentPanel
            // 
            this.tcCursos.ContentPanel.Controls.Add(this.tlCursos);
            this.tcCursos.ContentPanel.Size = new System.Drawing.Size(652, 315);
            this.tcCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCursos.Location = new System.Drawing.Point(0, 0);
            this.tcCursos.Name = "tcCursos";
            this.tcCursos.Size = new System.Drawing.Size(652, 340);
            this.tcCursos.TabIndex = 0;
            this.tcCursos.Text = "toolStripContainer1";
            // 
            // tcCursos.TopToolStripPanel
            // 
            this.tcCursos.TopToolStripPanel.Controls.Add(this.tsCursos);
            // 
            // tlCursos
            // 
            this.tlCursos.ColumnCount = 5;
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCursos.Controls.Add(this.dgvCursos, 0, 0);
            this.tlCursos.Controls.Add(this.btnAlta, 0, 1);
            this.tlCursos.Controls.Add(this.btnModificar, 1, 1);
            this.tlCursos.Controls.Add(this.btnSalir, 4, 1);
            this.tlCursos.Controls.Add(this.btnBaja, 3, 1);
            this.tlCursos.Controls.Add(this.btnConsulta, 2, 1);
            this.tlCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCursos.Location = new System.Drawing.Point(0, 0);
            this.tlCursos.Name = "tlCursos";
            this.tlCursos.RowCount = 2;
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.79365F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.206349F));
            this.tlCursos.Size = new System.Drawing.Size(652, 315);
            this.tlCursos.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.anioCalendarioDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn,
            this.iDComisionDataGridViewTextBoxColumn,
            this.iDMateriaDataGridViewTextBoxColumn});
            this.tlCursos.SetColumnSpan(this.dgvCursos, 5);
            this.dgvCursos.DataSource = this.cursoBindingSource;
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(646, 279);
            this.dgvCursos.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlta.Location = new System.Drawing.Point(234, 289);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(79, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(319, 289);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaja.Location = new System.Drawing.Point(485, 289);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(79, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(570, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsCursos
            // 
            this.tsCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCursos.Location = new System.Drawing.Point(3, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(111, 25);
            this.tsCursos.TabIndex = 0;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.academiaDataSet;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsulta.Location = new System.Drawing.Point(404, 289);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Business.Entities.Curso);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID Curso";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anioCalendarioDataGridViewTextBoxColumn
            // 
            this.anioCalendarioDataGridViewTextBoxColumn.DataPropertyName = "AnioCalendario";
            this.anioCalendarioDataGridViewTextBoxColumn.HeaderText = "Año Calendario";
            this.anioCalendarioDataGridViewTextBoxColumn.Name = "anioCalendarioDataGridViewTextBoxColumn";
            this.anioCalendarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "Cupo";
            this.cupoDataGridViewTextBoxColumn.HeaderText = "Cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            this.cupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDComisionDataGridViewTextBoxColumn
            // 
            this.iDComisionDataGridViewTextBoxColumn.DataPropertyName = "IDComision";
            this.iDComisionDataGridViewTextBoxColumn.HeaderText = "IDComision";
            this.iDComisionDataGridViewTextBoxColumn.Name = "iDComisionDataGridViewTextBoxColumn";
            this.iDComisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMateriaDataGridViewTextBoxColumn
            // 
            this.iDMateriaDataGridViewTextBoxColumn.DataPropertyName = "IDMateria";
            this.iDMateriaDataGridViewTextBoxColumn.HeaderText = "IDMateria";
            this.iDMateriaDataGridViewTextBoxColumn.Name = "iDMateriaDataGridViewTextBoxColumn";
            this.iDMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 340);
            this.Controls.Add(this.tcCursos);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.tcCursos.ContentPanel.ResumeLayout(false);
            this.tcCursos.TopToolStripPanel.ResumeLayout(false);
            this.tcCursos.TopToolStripPanel.PerformLayout();
            this.tcCursos.ResumeLayout(false);
            this.tcCursos.PerformLayout();
            this.tlCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCursos;
        private System.Windows.Forms.TableLayoutPanel tlCursos;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSalir;
        private AcademiaDataSet academiaDataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private AcademiaDataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioCalendarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDComisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cursoBindingSource;
    }
}