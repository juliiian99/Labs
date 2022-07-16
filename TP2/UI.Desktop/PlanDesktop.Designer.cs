
namespace UI.Desktop
{
    partial class PlanDesktop
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
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.lblDescPlan = new System.Windows.Forms.Label();
            this.lblIDEspecialidad = new System.Windows.Forms.Label();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.txtDescPlan = new System.Windows.Forms.TextBox();
            this.txtIDEspecialidad = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblIDPlan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescPlan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDEspecialidad, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDPlan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescPlan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDEspecialidad, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Location = new System.Drawing.Point(48, 52);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(42, 13);
            this.lblIDPlan.TabIndex = 0;
            this.lblIDPlan.Text = "ID Plan";
            // 
            // lblDescPlan
            // 
            this.lblDescPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescPlan.AutoSize = true;
            this.lblDescPlan.Location = new System.Drawing.Point(26, 170);
            this.lblDescPlan.Name = "lblDescPlan";
            this.lblDescPlan.Size = new System.Drawing.Size(86, 13);
            this.lblDescPlan.TabIndex = 1;
            this.lblDescPlan.Text = "Descripcion plan";
            // 
            // lblIDEspecialidad
            // 
            this.lblIDEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIDEspecialidad.AutoSize = true;
            this.lblIDEspecialidad.Location = new System.Drawing.Point(307, 105);
            this.lblIDEspecialidad.Name = "lblIDEspecialidad";
            this.lblIDEspecialidad.Size = new System.Drawing.Size(81, 13);
            this.lblIDEspecialidad.TabIndex = 2;
            this.lblIDEspecialidad.Text = "ID Especialidad";
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDPlan.Location = new System.Drawing.Point(142, 49);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.ReadOnly = true;
            this.txtIDPlan.Size = new System.Drawing.Size(100, 20);
            this.txtIDPlan.TabIndex = 3;
            // 
            // txtDescPlan
            // 
            this.txtDescPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescPlan.Location = new System.Drawing.Point(142, 167);
            this.txtDescPlan.Name = "txtDescPlan";
            this.txtDescPlan.Size = new System.Drawing.Size(100, 20);
            this.txtDescPlan.TabIndex = 4;
            // 
            // txtIDEspecialidad
            // 
            this.txtIDEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDEspecialidad.Location = new System.Drawing.Point(420, 95);
            this.txtIDEspecialidad.Name = "txtIDEspecialidad";
            this.txtIDEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtIDEspecialidad.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(171, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(449, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlanDesktop";
            this.Text = "PlanDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.Label lblDescPlan;
        private System.Windows.Forms.Label lblIDEspecialidad;
        private System.Windows.Forms.TextBox txtIDPlan;
        private System.Windows.Forms.TextBox txtDescPlan;
        private System.Windows.Forms.TextBox txtIDEspecialidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}