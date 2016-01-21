using spirit.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spirit.Formularios
{
    public partial class frmRealizarVenta : Form
    {               
        public frmRealizarVenta()
        {
            InitializeComponent();           
        }

        private static frmRealizarVenta m_FormeDefInstance;
        public static frmRealizarVenta DefInstance
        {
            get
            {
                if (m_FormeDefInstance == null || m_FormeDefInstance.IsDisposed)
                    m_FormeDefInstance = new frmRealizarVenta();
                return m_FormeDefInstance;
            }
            set
            {
                m_FormeDefInstance = value;
            }
        }

        public void llamarVentanaRNCCliente()
        {
            frmRNCCliente form2 = new frmRNCCliente();
            form2.MdiParent = this.ParentForm;
            form2.Show();
            this.Close();
        }

        public void llamarVentanaRNCCliente2()
        {
            frmRNCCliente form2 = new frmRNCCliente();
            form2.txtTarjeta.ReadOnly = false;
            form2.txtPlaca.ReadOnly = false;
            form2.MdiParent = this.ParentForm;
            form2.Show();
            this.Close();
        }

        private void btnAlContado_Click(object sender, EventArgs e)
        {
            llamarVentanaRNCCliente();         
        }

        private void btnTarjetaDeCredito_Click(object sender, EventArgs e)
        {
            llamarVentanaRNCCliente2();    
        }                  
    }
}
