
namespace UI.Desktop
{
    partial class ComisionDesktop
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
            this.tlComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lbl_descomision = new System.Windows.Forms.Label();
            this.lbl_anioespecial = new System.Windows.Forms.Label();
            this.lbl_idPlan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescomision = new System.Windows.Forms.TextBox();
            this.txtAnioespecial = new System.Windows.Forms.TextBox();
            this.cbxIDPlan = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlComisiones
            // 
            this.tlComisiones.ColumnCount = 4;
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlComisiones.Controls.Add(this.lblID, 0, 0);
            this.tlComisiones.Controls.Add(this.lbl_descomision, 0, 1);
            this.tlComisiones.Controls.Add(this.lbl_anioespecial, 2, 0);
            this.tlComisiones.Controls.Add(this.lbl_idPlan, 2, 1);
            this.tlComisiones.Controls.Add(this.txtID, 1, 0);
            this.tlComisiones.Controls.Add(this.txtDescomision, 1, 1);
            this.tlComisiones.Controls.Add(this.txtAnioespecial, 3, 0);
            this.tlComisiones.Controls.Add(this.cbxIDPlan, 3, 1);
            this.tlComisiones.Controls.Add(this.btnAceptar, 1, 2);
            this.tlComisiones.Controls.Add(this.btnCancelar, 3, 2);
            this.tlComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComisiones.Location = new System.Drawing.Point(0, 0);
            this.tlComisiones.Name = "tlComisiones";
            this.tlComisiones.RowCount = 3;
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlComisiones.Size = new System.Drawing.Size(566, 269);
            this.tlComisiones.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(61, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lbl_descomision
            // 
            this.lbl_descomision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descomision.AutoSize = true;
            this.lbl_descomision.Location = new System.Drawing.Point(17, 162);
            this.lbl_descomision.Name = "lbl_descomision";
            this.lbl_descomision.Size = new System.Drawing.Size(107, 26);
            this.lbl_descomision.TabIndex = 1;
            this.lbl_descomision.Text = "Descripcion comision\r\n\r\n";
            // 
            // lbl_anioespecial
            // 
            this.lbl_anioespecial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_anioespecial.AutoSize = true;
            this.lbl_anioespecial.Location = new System.Drawing.Point(308, 52);
            this.lbl_anioespecial.Name = "lbl_anioespecial";
            this.lbl_anioespecial.Size = new System.Drawing.Size(88, 13);
            this.lbl_anioespecial.TabIndex = 2;
            this.lbl_anioespecial.Text = "Año especialidad";
            // 
            // lbl_idPlan
            // 
            this.lbl_idPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_idPlan.AutoSize = true;
            this.lbl_idPlan.Location = new System.Drawing.Point(331, 169);
            this.lbl_idPlan.Name = "lbl_idPlan";
            this.lbl_idPlan.Size = new System.Drawing.Size(42, 13);
            this.lbl_idPlan.TabIndex = 3;
            this.lbl_idPlan.Text = "ID Plan";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(161, 48);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtDescomision
            // 
            this.txtDescomision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescomision.Location = new System.Drawing.Point(161, 165);
            this.txtDescomision.Name = "txtDescomision";
            this.txtDescomision.Size = new System.Drawing.Size(100, 20);
            this.txtDescomision.TabIndex = 5;
            // 
            // txtAnioespecial
            // 
            this.txtAnioespecial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnioespecial.Location = new System.Drawing.Point(444, 48);
            this.txtAnioespecial.Name = "txtAnioespecial";
            this.txtAnioespecial.Size = new System.Drawing.Size(100, 20);
            this.txtAnioespecial.TabIndex = 6;
            // 
            // cbxIDPlan
            // 
            this.cbxIDPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxIDPlan.FormattingEnabled = true;
            this.cbxIDPlan.Location = new System.Drawing.Point(434, 165);
            this.cbxIDPlan.Name = "cbxIDPlan";
            this.cbxIDPlan.Size = new System.Drawing.Size(121, 21);
            this.cbxIDPlan.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(174, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(457, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 269);
            this.Controls.Add(this.tlComisiones);
            this.Name = "ComisionDesktop";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.ComisionDesktop_Load);
            this.tlComisiones.ResumeLayout(false);
            this.tlComisiones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlComisiones;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbl_descomision;
        private System.Windows.Forms.Label lbl_anioespecial;
        private System.Windows.Forms.Label lbl_idPlan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescomision;
        private System.Windows.Forms.TextBox txtAnioespecial;
        private System.Windows.Forms.ComboBox cbxIDPlan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}