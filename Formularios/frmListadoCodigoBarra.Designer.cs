namespace spirit.Formularios
{
    partial class frmListadoCodigoBarra
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
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.chkMonto = new System.Windows.Forms.CheckBox();
            this.dgvPrepago = new System.Windows.Forms.DataGridView();
            this.imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cboMontoDesde = new System.Windows.Forms.ComboBox();
            this.cboMontoHasta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepago)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(94, 48);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(102, 26);
            this.dtpFechaDesde.TabIndex = 7;
            this.dtpFechaDesde.Value = new System.DateTime(2015, 3, 18, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(94, 10);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(373, 28);
            this.cboCliente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(202, 48);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(103, 26);
            this.dtpFechaHasta.TabIndex = 8;
            this.dtpFechaHasta.Value = new System.DateTime(2015, 3, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto:";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFecha.Location = new System.Drawing.Point(12, 52);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(15, 14);
            this.chkFecha.TabIndex = 13;
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // chkMonto
            // 
            this.chkMonto.AutoSize = true;
            this.chkMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonto.Location = new System.Drawing.Point(12, 83);
            this.chkMonto.Name = "chkMonto";
            this.chkMonto.Size = new System.Drawing.Size(15, 14);
            this.chkMonto.TabIndex = 14;
            this.chkMonto.UseVisualStyleBackColor = true;
            this.chkMonto.CheckedChanged += new System.EventHandler(this.chkMonto_CheckedChanged);
            // 
            // dgvPrepago
            // 
            this.dgvPrepago.AllowUserToAddRows = false;
            this.dgvPrepago.AllowUserToDeleteRows = false;
            this.dgvPrepago.AllowUserToOrderColumns = true;
            this.dgvPrepago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrepago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imprimir,
            this.CodigoBarra,
            this.Monto,
            this.Consumido,
            this.Fecha,
            this.hora,
            this.cliente});
            this.dgvPrepago.Location = new System.Drawing.Point(12, 128);
            this.dgvPrepago.Name = "dgvPrepago";
            this.dgvPrepago.Size = new System.Drawing.Size(779, 229);
            this.dgvPrepago.TabIndex = 15;
            // 
            // imprimir
            // 
            this.imprimir.HeaderText = "Imprimir";
            this.imprimir.Name = "imprimir";
            this.imprimir.Width = 50;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.HeaderText = "Codigo de Barra";
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Width = 120;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 80;
            // 
            // Consumido
            // 
            this.Consumido.HeaderText = "Consumido";
            this.Consumido.Name = "Consumido";
            this.Consumido.ReadOnly = true;
            this.Consumido.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 70;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.Width = 60;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(311, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 27);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(388, 83);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(79, 27);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir...";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cboMontoDesde
            // 
            this.cboMontoDesde.Enabled = false;
            this.cboMontoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMontoDesde.FormattingEnabled = true;
            this.cboMontoDesde.Location = new System.Drawing.Point(94, 84);
            this.cboMontoDesde.Name = "cboMontoDesde";
            this.cboMontoDesde.Size = new System.Drawing.Size(102, 28);
            this.cboMontoDesde.TabIndex = 18;
            // 
            // cboMontoHasta
            // 
            this.cboMontoHasta.Enabled = false;
            this.cboMontoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMontoHasta.FormattingEnabled = true;
            this.cboMontoHasta.Location = new System.Drawing.Point(202, 83);
            this.cboMontoHasta.Name = "cboMontoHasta";
            this.cboMontoHasta.Size = new System.Drawing.Size(103, 28);
            this.cboMontoHasta.TabIndex = 19;
            // 
            // frmListadoCodigoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(803, 367);
            this.Controls.Add(this.cboMontoHasta);
            this.Controls.Add(this.cboMontoDesde);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvPrepago);
            this.Controls.Add(this.chkMonto);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmListadoCodigoBarra";
            this.Text = "Listado de Tickets Prepago";
            this.Deactivate += new System.EventHandler(this.frmListadoCodigoBarra_Deactivate);
            this.Load += new System.EventHandler(this.frmListadoCodigoBarra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.CheckBox chkMonto;
        private System.Windows.Forms.DataGridView dgvPrepago;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.ComboBox cboMontoDesde;
        private System.Windows.Forms.ComboBox cboMontoHasta;
    }
}