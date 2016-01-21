namespace spirit.Formularios
{
    partial class frmListadoVentas
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
            this.dgvListadoVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBomba = new System.Windows.Forms.NumericUpDown();
            this.nudLado = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudUltimasVentas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrListadoVentas = new System.Windows.Forms.Timer(this.components);
            this.chkActualizar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUltimasVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoVentas
            // 
            this.dgvListadoVentas.AllowUserToAddRows = false;
            this.dgvListadoVentas.AllowUserToDeleteRows = false;
            this.dgvListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoVentas.Location = new System.Drawing.Point(12, 43);
            this.dgvListadoVentas.Name = "dgvListadoVentas";
            this.dgvListadoVentas.ReadOnly = true;
            this.dgvListadoVentas.Size = new System.Drawing.Size(956, 563);
            this.dgvListadoVentas.TabIndex = 0;
            this.dgvListadoVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoVentas_CellContentClick);
            this.dgvListadoVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoVentas_CellContentDoubleClick);
            this.dgvListadoVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoVentas_CellDoubleClick);
            this.dgvListadoVentas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListadoVentas_RowHeaderMouseClick);
            this.dgvListadoVentas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListadoVentas_RowHeaderMouseDoubleClick);
            this.dgvListadoVentas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListadoVentas_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surtidor:";
            // 
            // nudBomba
            // 
            this.nudBomba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBomba.Location = new System.Drawing.Point(100, 7);
            this.nudBomba.Name = "nudBomba";
            this.nudBomba.Size = new System.Drawing.Size(51, 26);
            this.nudBomba.TabIndex = 3;
            // 
            // nudLado
            // 
            this.nudLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLado.Location = new System.Drawing.Point(262, 7);
            this.nudLado.Name = "nudLado";
            this.nudLado.Size = new System.Drawing.Size(51, 26);
            this.nudLado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manguera:";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(328, 4);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(149, 31);
            this.btnCargarDatos.TabIndex = 6;
            this.btnCargarDatos.Text = "Cargar Datos...";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ultimas";
            // 
            // nudUltimasVentas
            // 
            this.nudUltimasVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUltimasVentas.Location = new System.Drawing.Point(571, 7);
            this.nudUltimasVentas.Name = "nudUltimasVentas";
            this.nudUltimasVentas.Size = new System.Drawing.Size(51, 26);
            this.nudUltimasVentas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ventas";
            // 
            // tmrListadoVentas
            // 
            this.tmrListadoVentas.Interval = 5000;
            this.tmrListadoVentas.Tick += new System.EventHandler(this.tmrListadoVentas_Tick);
            // 
            // chkActualizar
            // 
            this.chkActualizar.AutoSize = true;
            this.chkActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActualizar.Location = new System.Drawing.Point(664, 612);
            this.chkActualizar.Name = "chkActualizar";
            this.chkActualizar.Size = new System.Drawing.Size(241, 24);
            this.chkActualizar.TabIndex = 10;
            this.chkActualizar.Text = "Actualizacion Automatica";
            this.chkActualizar.UseVisualStyleBackColor = true;
            this.chkActualizar.CheckedChanged += new System.EventHandler(this.chkActualizar_CheckedChanged);
            // 
            // frmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 648);
            this.Controls.Add(this.chkActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudUltimasVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.nudLado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBomba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListadoVentas);
            this.MaximizeBox = false;
            this.Name = "frmListadoVentas";
            this.Text = "Listado de Ultimas Ventas";
            this.Deactivate += new System.EventHandler(this.frmListadoVentas_Deactivate);
            this.Load += new System.EventHandler(this.frmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUltimasVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBomba;
        private System.Windows.Forms.NumericUpDown nudLado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudUltimasVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrListadoVentas;
        private System.Windows.Forms.CheckBox chkActualizar;
    }
}