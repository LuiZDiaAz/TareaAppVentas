namespace AppVentas.Vista
{
    partial class frmRoles
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
            this.dgvVistaTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVistaTabla
            // 
            this.dgvVistaTabla.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvVistaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaTabla.Location = new System.Drawing.Point(47, 123);
            this.dgvVistaTabla.Name = "dgvVistaTabla";
            this.dgvVistaTabla.RowHeadersWidth = 51;
            this.dgvVistaTabla.RowTemplate.Height = 24;
            this.dgvVistaTabla.Size = new System.Drawing.Size(703, 291);
            this.dgvVistaTabla.TabIndex = 0;
            this.dgvVistaTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaTabla_CellContentClick);
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVistaTabla);
            this.Name = "frmRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVistaTabla;
    }
}