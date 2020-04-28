namespace AppVentas.Vista
{
    partial class frmVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIdNumeracion = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCodigoPro = new System.Windows.Forms.TextBox();
            this.txtPrecioPro = new System.Windows.Forms.TextBox();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTipodocu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.bttnGuardarVenta = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buscar Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 425);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 513);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 596);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total";
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(412, 157);
            this.bttnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(103, 29);
            this.bttnBuscar.TabIndex = 10;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 591);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIdNumeracion
            // 
            this.txtIdNumeracion.Enabled = false;
            this.txtIdNumeracion.Location = new System.Drawing.Point(174, 22);
            this.txtIdNumeracion.Name = "txtIdNumeracion";
            this.txtIdNumeracion.Size = new System.Drawing.Size(216, 27);
            this.txtIdNumeracion.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 27);
            this.textBox3.TabIndex = 15;
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Enabled = false;
            this.txtCodigoPro.Location = new System.Drawing.Point(174, 244);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.Size = new System.Drawing.Size(216, 27);
            this.txtCodigoPro.TabIndex = 16;
            // 
            // txtPrecioPro
            // 
            this.txtPrecioPro.Enabled = false;
            this.txtPrecioPro.Location = new System.Drawing.Point(167, 418);
            this.txtPrecioPro.Name = "txtPrecioPro";
            this.txtPrecioPro.Size = new System.Drawing.Size(216, 27);
            this.txtPrecioPro.TabIndex = 17;
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Enabled = false;
            this.txtNombrePro.Location = new System.Drawing.Point(174, 332);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(216, 27);
            this.txtNombrePro.TabIndex = 18;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(106, 506);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(216, 27);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(74, 593);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(216, 27);
            this.txtTotal.TabIndex = 20;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.PRECIO,
            this.CANTIDAD,
            this.TOTAL});
            this.dgvVentas.Location = new System.Drawing.Point(556, 189);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(802, 427);
            this.dgvVentas.TabIndex = 21;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO PRO";
            this.CODIGO.MinimumWidth = 6;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE PRO";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO PRO";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(721, 21);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(216, 28);
            this.cmbCliente.TabIndex = 22;
            // 
            // cmbTipodocu
            // 
            this.cmbTipodocu.FormattingEnabled = true;
            this.cmbTipodocu.Location = new System.Drawing.Point(799, 114);
            this.cmbTipodocu.Name = "cmbTipodocu";
            this.cmbTipodocu.Size = new System.Drawing.Size(216, 28);
            this.cmbTipodocu.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 673);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 38);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total $:";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Enabled = false;
            this.txtTotalFinal.Location = new System.Drawing.Point(160, 663);
            this.txtTotalFinal.Multiline = true;
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(134, 49);
            this.txtTotalFinal.TabIndex = 25;
            // 
            // bttnGuardarVenta
            // 
            this.bttnGuardarVenta.Location = new System.Drawing.Point(425, 591);
            this.bttnGuardarVenta.Name = "bttnGuardarVenta";
            this.bttnGuardarVenta.Size = new System.Drawing.Size(103, 29);
            this.bttnGuardarVenta.TabIndex = 27;
            this.bttnGuardarVenta.Text = "Guardar";
            this.bttnGuardarVenta.UseVisualStyleBackColor = true;
            this.bttnGuardarVenta.Click += new System.EventHandler(this.bttnGuardarVenta_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Location = new System.Drawing.Point(1021, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(337, 27);
            this.dtpFecha.TabIndex = 28;
            // 
            // frmVentas
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1395, 729);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.bttnGuardarVenta);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbTipodocu);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.txtPrecioPro);
            this.Controls.Add(this.txtCodigoPro);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtIdNumeracion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIdNumeracion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipodocu;
        public System.Windows.Forms.TextBox txtCodigoPro;
        public System.Windows.Forms.TextBox txtPrecioPro;
        public System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalFinal;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button bttnGuardarVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}