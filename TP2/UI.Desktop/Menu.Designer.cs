
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(81, 84);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 40);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "ABMC Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Location = new System.Drawing.Point(219, 83);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(75, 41);
            this.btnEspecialidad.TabIndex = 1;
            this.btnEspecialidad.Text = "ABMC  Especialidades";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.Location = new System.Drawing.Point(356, 81);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(75, 42);
            this.btnMaterias.TabIndex = 2;
            this.btnMaterias.Text = "ABMC Materias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnComisiones
            // 
            this.btnComisiones.Location = new System.Drawing.Point(148, 203);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Size = new System.Drawing.Size(75, 41);
            this.btnComisiones.TabIndex = 3;
            this.btnComisiones.Text = "ABMC Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = true;
            this.btnComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Location = new System.Drawing.Point(298, 203);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(78, 40);
            this.btnPlanes.TabIndex = 4;
            this.btnPlanes.Text = "ABMC\r\nPlanes\r\n";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 327);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.btnComisiones);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.btnEspecialidad);
            this.Controls.Add(this.btnUsuarios);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.Button btnPlanes;
    }
}