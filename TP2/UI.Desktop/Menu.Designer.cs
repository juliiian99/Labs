
namespace UI.Desktop
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.docenteCursoLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docenteCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docenteCursoLogicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.personasToolStripMenuItem,
            this.especialidadToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.comisionesToolStripMenuItem,
            this.planesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.docenteCursoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            this.especialidadToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.comisionesToolStripMenuItem.Text = "Comisiones";
            this.comisionesToolStripMenuItem.Click += new System.EventHandler(this.comisionesToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.planesToolStripMenuItem.Text = "Planes";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem1,
            this.planesToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            this.cursosToolStripMenuItem1.Click += new System.EventHandler(this.cursosToolStripMenuItem1_Click);
            // 
            // planesToolStripMenuItem1
            // 
            this.planesToolStripMenuItem1.Name = "planesToolStripMenuItem1";
            this.planesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.planesToolStripMenuItem1.Text = "Planes";
            this.planesToolStripMenuItem1.Click += new System.EventHandler(this.planesToolStripMenuItem1_Click);
            // 
            // cbCursos
            // 
            this.cbCursos.DisplayMember = "DocenteCursoData";
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(185, 95);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(121, 21);
            this.cbCursos.TabIndex = 11;
            this.cbCursos.ValueMember = "DocenteCursoData";
            this.cbCursos.SelectionChangeCommitted += new System.EventHandler(this.cbCursos_SelectionChangeCommitted);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(208, 56);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(69, 13);
            this.lblCurso.TabIndex = 10;
            this.lblCurso.Text = "Elija su curso";
            // 
            // docenteCursoLogicBindingSource
            // 
            this.docenteCursoLogicBindingSource.DataSource = typeof(Business.Logic.DocenteCursoLogic);
            // 
            // docenteCursoToolStripMenuItem
            // 
            this.docenteCursoToolStripMenuItem.Name = "docenteCursoToolStripMenuItem";
            this.docenteCursoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.docenteCursoToolStripMenuItem.Text = "Docente Curso";
            this.docenteCursoToolStripMenuItem.Click += new System.EventHandler(this.docenteCursoToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 225);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docenteCursoLogicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.BindingSource docenteCursoLogicBindingSource;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem docenteCursoToolStripMenuItem;
    }
}