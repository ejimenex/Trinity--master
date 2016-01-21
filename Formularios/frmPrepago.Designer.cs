namespace spirit.Formularios
{
    partial class frmPrepago
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
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboMonto = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvPrepago = new System.Windows.Forms.DataGridView();
            this.clmimprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmcodigobarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepago)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(84, 8);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(282, 28);
            this.cboCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(84, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 26);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2015, 3, 18, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora:";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "hh:mm:ss";
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(280, 47);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(86, 26);
            this.dtpHora.TabIndex = 5;
            this.dtpHora.Value = new System.DateTime(2015, 3, 18, 12, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(266, 130);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Generar...";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboMonto
            // 
            this.cboMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonto.FormattingEnabled = true;
            this.cboMonto.Location = new System.Drawing.Point(84, 88);
            this.cboMonto.Name = "cboMonto";
            this.cboMonto.Size = new System.Drawing.Size(103, 28);
            this.cboMonto.TabIndex = 12;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(280, 88);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(50, 26);
            this.nudCantidad.TabIndex = 13;
            // 
            // dgvPrepago
            // 
            this.dgvPrepago.AllowUserToAddRows = false;
            this.dgvPrepago.AllowUserToDeleteRows = false;
            this.dgvPrepago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrepago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmimprimir,
            this.clmcodigobarra,
            this.clmmonto,
            this.clmCantidad});
            this.dgvPrepago.Location = new System.Drawing.Point(22, 174);
            this.dgvPrepago.Name = "dgvPrepago";
            this.dgvPrepago.ReadOnly = true;
            this.dgvPrepago.Size = new System.Drawing.Size(400, 224);
            this.dgvPrepago.TabIndex = 14;
            // 
            // clmimprimir
            // 
            this.clmimprimir.HeaderText = "Imprimir";
            this.clmimprimir.Name = "clmimprimir";
            this.clmimprimir.ReadOnly = true;
            // 
            // clmcodigobarra
            // 
            this.clmcodigobarra.HeaderText = "Codigo Barra";
            this.clmcodigobarra.Name = "clmcodigobarra";
            this.clmcodigobarra.ReadOnly = true;
            // 
            // clmmonto
            // 
            this.clmmonto.HeaderText = "Monto";
            this.clmmonto.Name = "clmmonto";
            this.clmmonto.ReadOnly = true;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Visible = false;
            // 
            // frmPrepago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(442, 415);
            this.Controls.Add(this.dgvPrepago);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cboMonto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPrepago";
            this.Text = "Generacion de Tickets Prepago";
            this.Load += new System.EventHandler(this.frmPrepago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboMonto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridView dgvPrepago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmimprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodigobarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
    }
}