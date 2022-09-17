
namespace UI.Desktop
{
    partial class Materias
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
            this.tcMaterias = new System.Windows.Forms.ToolStripContainer();
            this.tlpMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSSemanalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAlta1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAlta = new System.Windows.Forms.Button();
            this.tcMaterias.ContentPanel.SuspendLayout();
            this.tcMaterias.TopToolStripPanel.SuspendLayout();
            this.tcMaterias.SuspendLayout();
            this.tlpMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMaterias
            // 
            // 
            // tcMaterias.ContentPanel
            // 
            this.tcMaterias.ContentPanel.Controls.Add(this.tlpMaterias);
            this.tcMaterias.ContentPanel.Size = new System.Drawing.Size(619, 302);
            this.tcMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMaterias.Location = new System.Drawing.Point(0, 0);
            this.tcMaterias.Name = "tcMaterias";
            this.tcMaterias.Size = new System.Drawing.Size(619, 327);
            this.tcMaterias.TabIndex = 0;
            this.tcMaterias.Text = "toolStripContainer1";
            // 
            // tcMaterias.TopToolStripPanel
            // 
            this.tcMaterias.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tlpMaterias
            // 
            this.tlpMaterias.ColumnCount = 5;
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMaterias.Controls.Add(this.dgvMaterias, 0, 0);
            this.tlpMaterias.Controls.Add(this.btnAlta1, 0, 1);
            this.tlpMaterias.Controls.Add(this.btnModificar, 1, 1);
            this.tlpMaterias.Controls.Add(this.btnConsulta, 2, 1);
            this.tlpMaterias.Controls.Add(this.btnBaja, 3, 1);
            this.tlpMaterias.Controls.Add(this.btnSalir, 4, 1);
            this.tlpMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpMaterias.Name = "tlpMaterias";
            this.tlpMaterias.RowCount = 2;
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMaterias.Size = new System.Drawing.Size(619, 302);
            this.tlpMaterias.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.hSSemanalesDataGridViewTextBoxColumn,
            this.iDPlanDataGridViewTextBoxColumn});
            this.tlpMaterias.SetColumnSpan(this.dgvMaterias, 5);
            this.dgvMaterias.DataSource = this.materiaBindingSource;
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(613, 271);
            this.dgvMaterias.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID Materia";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hSSemanalesDataGridViewTextBoxColumn
            // 
            this.hSSemanalesDataGridViewTextBoxColumn.DataPropertyName = "HSSemanales";
            this.hSSemanalesDataGridViewTextBoxColumn.HeaderText = "HSSemanales";
            this.hSSemanalesDataGridViewTextBoxColumn.Name = "hSSemanalesDataGridViewTextBoxColumn";
            this.hSSemanalesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPlanDataGridViewTextBoxColumn
            // 
            this.iDPlanDataGridViewTextBoxColumn.DataPropertyName = "IDPlan";
            this.iDPlanDataGridViewTextBoxColumn.HeaderText = "IDPlan";
            this.iDPlanDataGridViewTextBoxColumn.Name = "iDPlanDataGridViewTextBoxColumn";
            this.iDPlanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(Business.Entities.Materia);
            // 
            // btnAlta1
            // 
            this.btnAlta1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlta1.Location = new System.Drawing.Point(217, 280);
            this.btnAlta1.Name = "btnAlta1";
            this.btnAlta1.Size = new System.Drawing.Size(75, 19);
            this.btnAlta1.TabIndex = 1;
            this.btnAlta1.Text = "Alta";
            this.btnAlta1.UseVisualStyleBackColor = true;
            this.btnAlta1.Click += new System.EventHandler(this.btnAlta1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(298, 280);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 19);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsulta.Location = new System.Drawing.Point(379, 280);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 19);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaja.Location = new System.Drawing.Point(460, 280);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 19);
            this.btnBaja.TabIndex = 4;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(541, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 19);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlta.Location = new System.Drawing.Point(7, 302);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(65, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 327);
            this.Controls.Add(this.tcMaterias);
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            this.tcMaterias.ContentPanel.ResumeLayout(false);
            this.tcMaterias.TopToolStripPanel.ResumeLayout(false);
            this.tcMaterias.TopToolStripPanel.PerformLayout();
            this.tcMaterias.ResumeLayout(false);
            this.tcMaterias.PerformLayout();
            this.tlpMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcMaterias;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TableLayoutPanel tlpMaterias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnAlta1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSSemanalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materiaBindingSource;
    }
}