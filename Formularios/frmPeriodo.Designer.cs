//namespace spirit.Formularios
//{
//    partial class frmPeriodo
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.dgvPeriodosCerrados = new System.Windows.Forms.DataGridView();
//            this.groupBox2 = new System.Windows.Forms.GroupBox();
//            this.dgvPeriodos = new System.Windows.Forms.DataGridView();
//            this.groupBox3 = new System.Windows.Forms.GroupBox();
//            this.btnQuitarSeleccion = new System.Windows.Forms.Button();
//            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
//            this.clbLado = new System.Windows.Forms.CheckedListBox();
//            this.btnCerrarTurno = new System.Windows.Forms.Button();
//            this.groupBox1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodosCerrados)).BeginInit();
//            this.groupBox2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
//            this.groupBox3.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.dgvPeriodosCerrados);
//            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
//            this.groupBox1.Location = new System.Drawing.Point(11, 240);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(821, 266);
//            this.groupBox1.TabIndex = 0;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "Datos de Turnos Cerrados";
//            // 
//            // dgvPeriodosCerrados
//            // 
//            this.dgvPeriodosCerrados.AllowUserToAddRows = false;
//            this.dgvPeriodosCerrados.AllowUserToDeleteRows = false;
//            this.dgvPeriodosCerrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvPeriodosCerrados.Location = new System.Drawing.Point(16, 25);
//            this.dgvPeriodosCerrados.Name = "dgvPeriodosCerrados";
//            this.dgvPeriodosCerrados.ReadOnly = true;
//            this.dgvPeriodosCerrados.Size = new System.Drawing.Size(783, 223);
//            this.dgvPeriodosCerrados.TabIndex = 7;
//            // 
//            // groupBox2
//            // 
//            this.groupBox2.Controls.Add(this.dgvPeriodos);
//            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
//            this.groupBox2.Location = new System.Drawing.Point(169, 56);
//            this.groupBox2.Name = "groupBox2";
//            this.groupBox2.Size = new System.Drawing.Size(663, 178);
//            this.groupBox2.TabIndex = 1;
//            this.groupBox2.TabStop = false;
//            this.groupBox2.Text = "Turnos Abiertos";
//            // 
//            // dgvPeriodos
//            // 
//            this.dgvPeriodos.AllowUserToAddRows = false;
//            this.dgvPeriodos.AllowUserToDeleteRows = false;
//            this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvPeriodos.Location = new System.Drawing.Point(16, 25);
//            this.dgvPeriodos.Name = "dgvPeriodos";
//            this.dgvPeriodos.ReadOnly = true;
//            this.dgvPeriodos.Size = new System.Drawing.Size(625, 147);
//            this.dgvPeriodos.TabIndex = 6;
//            // 
//            // groupBox3
//            // 
//            this.groupBox3.Controls.Add(this.btnQuitarSeleccion);
//            this.groupBox3.Controls.Add(this.btnSeleccionarTodo);
//            this.groupBox3.Controls.Add(this.clbLado);
//            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
//            this.groupBox3.Location = new System.Drawing.Point(12, 12);
//            this.groupBox3.Name = "groupBox3";
//            this.groupBox3.Size = new System.Drawing.Size(151, 222);
//            this.groupBox3.TabIndex = 2;
//            this.groupBox3.TabStop = false;
//            this.groupBox3.Text = "Lado";
//            // 
//            // btnQuitarSeleccion
//            // 
//            this.btnQuitarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
//            this.btnQuitarSeleccion.Location = new System.Drawing.Point(16, 157);
//            this.btnQuitarSeleccion.Name = "btnQuitarSeleccion";
//            this.btnQuitarSeleccion.Size = new System.Drawing.Size(119, 30);
//            this.btnQuitarSeleccion.TabIndex = 2;
//            this.btnQuitarSeleccion.Text = "Quitar Seleccion";
//            this.btnQuitarSeleccion.UseVisualStyleBackColor = true;
//            this.btnQuitarSeleccion.Click += new System.EventHandler(this.btnQuitarSeleccion_Click);
//            // 
//            // btnSeleccionarTodo
//            // 
//            this.btnSeleccionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
//            this.btnSeleccionarTodo.Location = new System.Drawing.Point(10, 119);
//            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
//            this.btnSeleccionarTodo.Size = new System.Drawing.Size(130, 32);
//            this.btnSeleccionarTodo.TabIndex = 1;
//            this.btnSeleccionarTodo.Text = "Seleccionar Todo";
//            this.btnSeleccionarTodo.UseVisualStyleBackColor = true;
//            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
//            // 
//            // clbLado
//            // 
//            this.clbLado.FormattingEnabled = true;
//            this.clbLado.Location = new System.Drawing.Point(16, 25);
//            this.clbLado.Name = "clbLado";
//            this.clbLado.Size = new System.Drawing.Size(120, 88);
//            this.clbLado.TabIndex = 0;
//            // 
//            // btnCerrarTurno
//            // 
//            this.btnCerrarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
//            this.btnCerrarTurno.Location = new System.Drawing.Point(169, 21);
//            this.btnCerrarTurno.Name = "btnCerrarTurno";
//            this.btnCerrarTurno.Size = new System.Drawing.Size(137, 29);
//            this.btnCerrarTurno.TabIndex = 3;
//            this.btnCerrarTurno.Text = "Cerrar Turnos";
//            this.btnCerrarTurno.UseVisualStyleBackColor = true;
//            this.btnCerrarTurno.Click += new System.EventHandler(this.btnCerrarTurno_Click);
//            // 
//            // frmPeriodo
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(844, 518);
//            this.Controls.Add(this.btnCerrarTurno);
//            this.Controls.Add(this.groupBox3);
//            this.Controls.Add(this.groupBox2);
//            this.Controls.Add(this.groupBox1);
//            this.MaximizeBox = false;
//            this.Name = "frmPeriodo";
//            this.Text = "Cierre de Turnos";
//            this.Load += new System.EventHandler(this.frmPeriodo_Load);
//            this.groupBox1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodosCerrados)).EndInit();
//            this.groupBox2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
//            this.groupBox3.ResumeLayout(false);
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.GroupBox groupBox2;
//        private System.Windows.Forms.GroupBox groupBox3;
//        private System.Windows.Forms.CheckedListBox clbLado;
//        private System.Windows.Forms.DataGridView dgvPeriodosCerrados;
//        private System.Windows.Forms.DataGridView dgvPeriodos;
//        private System.Windows.Forms.Button btnQuitarSeleccion;
//        private System.Windows.Forms.Button btnSeleccionarTodo;
//        private System.Windows.Forms.Button btnCerrarTurno;
//    }
//}