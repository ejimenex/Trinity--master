namespace spirit.Formularios
{
    partial class frmRealizarVenta
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
            this.btnTicketPrepago = new System.Windows.Forms.Button();
            this.btnTarjetaDeCredito = new System.Windows.Forms.Button();
            this.btnAlContado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Metodos de Pago";
            // 
            // btnTicketPrepago
            // 
            this.btnTicketPrepago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTicketPrepago.Image = global::spirit.Properties.Resources._1448508609_Cinema_ticket_2;
            this.btnTicketPrepago.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTicketPrepago.Location = new System.Drawing.Point(150, 264);
            this.btnTicketPrepago.Name = "btnTicketPrepago";
            this.btnTicketPrepago.Size = new System.Drawing.Size(158, 64);
            this.btnTicketPrepago.TabIndex = 2;
            this.btnTicketPrepago.Text = "Ticket Prepago";
            this.btnTicketPrepago.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTicketPrepago.UseVisualStyleBackColor = true;
            // 
            // btnTarjetaDeCredito
            // 
            this.btnTarjetaDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTarjetaDeCredito.Image = global::spirit.Properties.Resources._1448508547_visa;
            this.btnTarjetaDeCredito.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTarjetaDeCredito.Location = new System.Drawing.Point(150, 172);
            this.btnTarjetaDeCredito.Name = "btnTarjetaDeCredito";
            this.btnTarjetaDeCredito.Size = new System.Drawing.Size(158, 64);
            this.btnTarjetaDeCredito.TabIndex = 1;
            this.btnTarjetaDeCredito.Text = "Tarjeta de Crédito";
            this.btnTarjetaDeCredito.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTarjetaDeCredito.UseVisualStyleBackColor = true;
            this.btnTarjetaDeCredito.Click += new System.EventHandler(this.btnTarjetaDeCredito_Click);
            // 
            // btnAlContado
            // 
            this.btnAlContado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlContado.Image = global::spirit.Properties.Resources._1448500703_Money;
            this.btnAlContado.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAlContado.Location = new System.Drawing.Point(150, 78);
            this.btnAlContado.Name = "btnAlContado";
            this.btnAlContado.Size = new System.Drawing.Size(158, 64);
            this.btnAlContado.TabIndex = 0;
            this.btnAlContado.Text = "Efectivo";
            this.btnAlContado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlContado.UseVisualStyleBackColor = true;
            this.btnAlContado.Click += new System.EventHandler(this.btnAlContado_Click);
            // 
            // frmRealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTicketPrepago);
            this.Controls.Add(this.btnTarjetaDeCredito);
            this.Controls.Add(this.btnAlContado);
            this.Name = "frmRealizarVenta";
            this.Text = "frmRealizarVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlContado;
        private System.Windows.Forms.Button btnTarjetaDeCredito;
        private System.Windows.Forms.Button btnTicketPrepago;
        private System.Windows.Forms.Label label1;

    }
}