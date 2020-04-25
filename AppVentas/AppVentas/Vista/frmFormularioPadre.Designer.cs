namespace AppVentas.Vista
{
    partial class frmFormularioPadre
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
            this.bttnBuscarr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnBuscarr
            // 
            this.bttnBuscarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscarr.Location = new System.Drawing.Point(13, 13);
            this.bttnBuscarr.Margin = new System.Windows.Forms.Padding(4);
            this.bttnBuscarr.Name = "bttnBuscarr";
            this.bttnBuscarr.Size = new System.Drawing.Size(103, 29);
            this.bttnBuscarr.TabIndex = 11;
            this.bttnBuscarr.Text = "Buscar";
            this.bttnBuscarr.UseVisualStyleBackColor = true;
            this.bttnBuscarr.Click += new System.EventHandler(this.bttnBuscarr_Click);
            // 
            // frmFormularioPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnBuscarr);
            this.IsMdiContainer = true;
            this.Name = "frmFormularioPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFormularioPadre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnBuscarr;
    }
}