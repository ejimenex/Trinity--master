namespace spirit.Formularios
{
    partial class frmRol
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
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.dgvAsignados = new System.Windows.Forms.DataGridView();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRol
            // 
            this.dgvRol.AllowUserToAddRows = false;
            this.dgvRol.AllowUserToDeleteRows = false;
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Location = new System.Drawing.Point(16, 49);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.ReadOnly = true;
            this.dgvRol.Size = new System.Drawing.Size(323, 184);
            this.dgvRol.TabIndex = 2;
            this.dgvRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRol_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rol:";
            // 
            // txtRol
            // 
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(65, 12);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(237, 26);
            this.txtRol.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 326);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRol);
            this.tabPage1.Controls.Add(this.txtRol);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Roles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAsignar);
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvDisponibles);
            this.tabPage2.Controls.Add(this.dgvAsignados);
            this.tabPage2.Controls.Add(this.cboRol);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Permisos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol:";
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(68, 17);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(255, 28);
            this.cboRol.TabIndex = 5;
            this.cboRol.SelectedIndexChanged += new System.EventHandler(this.cboRol_SelectedIndexChanged);
            // 
            // dgvAsignados
            // 
            this.dgvAsignados.AllowUserToAddRows = false;
            this.dgvAsignados.AllowUserToDeleteRows = false;
            this.dgvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignados.Location = new System.Drawing.Point(23, 91);
            this.dgvAsignados.Name = "dgvAsignados";
            this.dgvAsignados.ReadOnly = true;
            this.dgvAsignados.Size = new System.Drawing.Size(323, 184);
            this.dgvAsignados.TabIndex = 6;
            this.dgvAsignados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignados_CellClick);
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Location = new System.Drawing.Point(397, 91);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.ReadOnly = true;
            this.dgvDisponibles.Size = new System.Drawing.Size(323, 184);
            this.dgvDisponibles.TabIndex = 7;
            this.dgvDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisponibles_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Disponibles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Asignados:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(352, 159);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(39, 23);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = ">>";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(352, 188);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(39, 23);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "<<";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 347);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmRol";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.frmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.DataGridView dgvAsignados;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnQuitar;
    }
}