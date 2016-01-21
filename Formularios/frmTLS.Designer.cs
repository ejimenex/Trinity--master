namespace spirit.Formularios
{
    partial class frmTLS
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
            this.dgvTLS = new System.Windows.Forms.DataGridView();
            this.tmrTLS = new System.Windows.Forms.Timer(this.components);
            this.nudTLS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTLS = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorMaximo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductHeight = new System.Windows.Forms.TextBox();
            this.txtWaterHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductVolume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWaterVolume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductUllage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductTCVolume = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductDensity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProductMass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pgbTLS = new System.Windows.Forms.ProgressBar();
            this.lblPorciento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTLS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTLS
            // 
            this.dgvTLS.AllowUserToAddRows = false;
            this.dgvTLS.AllowUserToDeleteRows = false;
            this.dgvTLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTLS.Location = new System.Drawing.Point(12, 33);
            this.dgvTLS.Name = "dgvTLS";
            this.dgvTLS.ReadOnly = true;
            this.dgvTLS.Size = new System.Drawing.Size(1010, 274);
            this.dgvTLS.TabIndex = 1;
            this.dgvTLS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTLS_CellClick);
            this.dgvTLS.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTLS_CellContentDoubleClick);
            this.dgvTLS.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTLS_CellEnter);
            this.dgvTLS.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTLS_RowHeaderMouseClick);
            this.dgvTLS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvTLS_KeyPress);
            // 
            // tmrTLS
            // 
            this.tmrTLS.Enabled = true;
            this.tmrTLS.Interval = 1000;
            this.tmrTLS.Tick += new System.EventHandler(this.tmrTLS_Tick);
            // 
            // nudTLS
            // 
            this.nudTLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTLS.Location = new System.Drawing.Point(897, 4);
            this.nudTLS.Name = "nudTLS";
            this.nudTLS.Size = new System.Drawing.Size(50, 26);
            this.nudTLS.TabIndex = 2;
            this.nudTLS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTLS.ValueChanged += new System.EventHandler(this.nudTLS_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(755, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actualizar cada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(947, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "segundos";
            // 
            // dtpTLS
            // 
            this.dtpTLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTLS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTLS.Location = new System.Drawing.Point(645, 4);
            this.dtpTLS.Name = "dtpTLS";
            this.dtpTLS.Size = new System.Drawing.Size(104, 26);
            this.dtpTLS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Maximo";
            // 
            // txtValorMaximo
            // 
            this.txtValorMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMaximo.Location = new System.Drawing.Point(327, 313);
            this.txtValorMaximo.Name = "txtValorMaximo";
            this.txtValorMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtValorMaximo.TabIndex = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(433, 313);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 26);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ProductHeight";
            // 
            // txtProductHeight
            // 
            this.txtProductHeight.Enabled = false;
            this.txtProductHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductHeight.Location = new System.Drawing.Point(327, 352);
            this.txtProductHeight.Name = "txtProductHeight";
            this.txtProductHeight.Size = new System.Drawing.Size(100, 26);
            this.txtProductHeight.TabIndex = 11;
            // 
            // txtWaterHeight
            // 
            this.txtWaterHeight.Enabled = false;
            this.txtWaterHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterHeight.Location = new System.Drawing.Point(327, 390);
            this.txtWaterHeight.Name = "txtWaterHeight";
            this.txtWaterHeight.Size = new System.Drawing.Size(100, 26);
            this.txtWaterHeight.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "WaterHeight";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Enabled = false;
            this.txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(327, 431);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 26);
            this.txtTemperature.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Temperature";
            // 
            // txtProductVolume
            // 
            this.txtProductVolume.Enabled = false;
            this.txtProductVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductVolume.Location = new System.Drawing.Point(327, 472);
            this.txtProductVolume.Name = "txtProductVolume";
            this.txtProductVolume.Size = new System.Drawing.Size(100, 26);
            this.txtProductVolume.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "ProductVolume";
            // 
            // txtWaterVolume
            // 
            this.txtWaterVolume.Enabled = false;
            this.txtWaterVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterVolume.Location = new System.Drawing.Point(327, 514);
            this.txtWaterVolume.Name = "txtWaterVolume";
            this.txtWaterVolume.Size = new System.Drawing.Size(100, 26);
            this.txtWaterVolume.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "WaterVolume";
            // 
            // txtProductUllage
            // 
            this.txtProductUllage.Enabled = false;
            this.txtProductUllage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductUllage.Location = new System.Drawing.Point(594, 352);
            this.txtProductUllage.Name = "txtProductUllage";
            this.txtProductUllage.Size = new System.Drawing.Size(100, 26);
            this.txtProductUllage.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "ProductUllage";
            // 
            // txtProductTCVolume
            // 
            this.txtProductTCVolume.Enabled = false;
            this.txtProductTCVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTCVolume.Location = new System.Drawing.Point(594, 393);
            this.txtProductTCVolume.Name = "txtProductTCVolume";
            this.txtProductTCVolume.Size = new System.Drawing.Size(100, 26);
            this.txtProductTCVolume.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "ProductTCVolume";
            // 
            // txtProductDensity
            // 
            this.txtProductDensity.Enabled = false;
            this.txtProductDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDensity.Location = new System.Drawing.Point(594, 434);
            this.txtProductDensity.Name = "txtProductDensity";
            this.txtProductDensity.Size = new System.Drawing.Size(100, 26);
            this.txtProductDensity.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(433, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "ProductDensity";
            // 
            // txtProductMass
            // 
            this.txtProductMass.Enabled = false;
            this.txtProductMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductMass.Location = new System.Drawing.Point(594, 472);
            this.txtProductMass.Name = "txtProductMass";
            this.txtProductMass.Size = new System.Drawing.Size(100, 26);
            this.txtProductMass.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(433, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "ProductMass";
            // 
            // pgbTLS
            // 
            this.pgbTLS.Location = new System.Drawing.Point(13, 315);
            this.pgbTLS.MarqueeAnimationSpeed = 500;
            this.pgbTLS.Name = "pgbTLS";
            this.pgbTLS.Size = new System.Drawing.Size(172, 136);
            this.pgbTLS.TabIndex = 28;
            // 
            // lblPorciento
            // 
            this.lblPorciento.AutoSize = true;
            this.lblPorciento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPorciento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorciento.ForeColor = System.Drawing.Color.Red;
            this.lblPorciento.Location = new System.Drawing.Point(72, 376);
            this.lblPorciento.Name = "lblPorciento";
            this.lblPorciento.Size = new System.Drawing.Size(14, 13);
            this.lblPorciento.TabIndex = 29;
            this.lblPorciento.Text = "0";
            // 
            // frmTLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 544);
            this.Controls.Add(this.lblPorciento);
            this.Controls.Add(this.pgbTLS);
            this.Controls.Add(this.txtProductMass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtProductDensity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProductTCVolume);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProductUllage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWaterVolume);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProductVolume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWaterHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtValorMaximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTLS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTLS);
            this.Controls.Add(this.dgvTLS);
            this.MaximizeBox = false;
            this.Name = "frmTLS";
            this.Text = "Probetas";
            this.Load += new System.EventHandler(this.frmTLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTLS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTLS;
        private System.Windows.Forms.Timer tmrTLS;
        private System.Windows.Forms.NumericUpDown nudTLS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTLS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorMaximo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductHeight;
        private System.Windows.Forms.TextBox txtWaterHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWaterVolume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductUllage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductTCVolume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductDensity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProductMass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pgbTLS;
        private System.Windows.Forms.Label lblPorciento;
    }
}