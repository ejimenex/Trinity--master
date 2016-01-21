namespace spirit.Formularios
{
    partial class frmReporteTurnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkActualizar = new System.Windows.Forms.CheckBox();
            this.tmrReporteTurnos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(75, 20);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(63, 26);
            this.txtAnio.TabIndex = 2;
            // 
            // cboMes
            // 
            this.cboMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(213, 17);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 28);
            this.cboMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "mes:";
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(12, 52);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.Size = new System.Drawing.Size(699, 274);
            this.dgvTurnos.TabIndex = 5;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick);
            this.dgvTurnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(352, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkActualizar
            // 
            this.chkActualizar.AutoSize = true;
            this.chkActualizar.Checked = true;
            this.chkActualizar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActualizar.Location = new System.Drawing.Point(470, 12);
            this.chkActualizar.Name = "chkActualizar";
            this.chkActualizar.Size = new System.Drawing.Size(241, 24);
            this.chkActualizar.TabIndex = 11;
            this.chkActualizar.Text = "Actualizacion Automatica";
            this.chkActualizar.UseVisualStyleBackColor = true;
            this.chkActualizar.CheckedChanged += new System.EventHandler(this.chkActualizar_CheckedChanged);
            // 
            // tmrReporteTurnos
            // 
            this.tmrReporteTurnos.Enabled = true;
            this.tmrReporteTurnos.Interval = 5000;
            this.tmrReporteTurnos.Tick += new System.EventHandler(this.tmrReporteTurnos_Tick);
            // 
            // frmReporteTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 339);
            this.Controls.Add(this.chkActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMes);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmReporteTurnos";
            this.Text = "Reporte de Turnos";
            this.Load += new System.EventHandler(this.frmReporteTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkActualizar;
        private System.Windows.Forms.Timer tmrReporteTurnos;
    }
}