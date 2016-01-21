using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace spirit.Formularios
{
    public partial class frmConsumoPrepago : Form
    {
        private static frmConsumoPrepago m_FormDefInstance;
        public static frmConsumoPrepago DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmConsumoPrepago();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public void CargarMontos()
        {
            DataSet dsMontos = new DataSet();
            dsMontos = Data.queries.npgsDataSet(Data.procedures.CargarMontos());
            DataTable dtMontos = new DataTable();
            dtMontos = dsMontos.Tables["Tabla"];
            cboMontoConsumo.ValueMember = "codigo";
            cboMontoConsumo.DisplayMember = "monto";
            cboMontoConsumo.DataSource = dtMontos;
        }

        public void CargarDatosTicket(string sCodigoBarra)
        {
            DataSet dsDatosTicket = new DataSet();
            dsDatosTicket = Data.queries.npgsDataSet(Data.procedures.CargarDatosTicketPrepago(sCodigoBarra));
            DataTable dtDatosTicket = new DataTable();
            dtDatosTicket = dsDatosTicket.Tables["Tabla"];
            if(dtDatosTicket.Rows.Count>0)
            {
                foreach (DataRow drFila in dtDatosTicket.Rows)
                {
                    double dMonto,dConsumido,dPendiente;
                    double.TryParse(drFila["monto"].ToString(), out dMonto);
                    double.TryParse(drFila["consumido"].ToString(), out dConsumido);
                    txtCodigo.Text = drFila["codigo_barra"].ToString();
                    txtCliente.Text = drFila["tkt_cust_name"].ToString();
                    txtMontoTicket.Text = drFila["monto"].ToString();
                    dPendiente = dMonto - dConsumido;
                    txtMontoPendiente.Text = dPendiente.ToString();
                }
            }
        }

        public void GuardarConsumo()
        {   
            Int32 iActivo=1;
            int iResultado = 0;
            double dMontoPendiente;
            double dMontoConsumo;
            double dMontoTicket;
            double dConsumoActual;

            if(txtMontoTicket.Text=="")
            {
                MessageBox.Show("Debe seleccionar el ticket prepago.","Consumo de Ticket Prepago.");
                return;
            }
            if(cboMontoConsumo.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar el monto consumido.","Consumo de Ticket Prepago.");
                return;
            }
            double.TryParse(txtMontoPendiente.Text, out dMontoPendiente);
            double.TryParse(cboMontoConsumo.Text.Substring(3, cboMontoConsumo.Text.Length - 3), out dMontoConsumo);
            double.TryParse(txtMontoTicket.Text, out dMontoTicket);
            if(dMontoConsumo>dMontoPendiente)
            {
                MessageBox.Show("El monto del consumo no puede ser mayor que el monto pendiente.", "Consumo de Ticket Prepago.");
                return;
            }
            if ((dMontoConsumo + dMontoPendiente) >= dMontoTicket)
            {
                iActivo=0;
            }
            dConsumoActual = (dMontoTicket - dMontoPendiente) + dMontoConsumo;
            iResultado = Data.queries.Execute(Data.procedures.GuardarConsumoPrepago(txtCodigo.Text, dConsumoActual, Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), spirit.Formularios.mdiSpirit.sUsuario, iActivo));
            MessageBox.Show("El consumo ha sido registrado de forma satisfactoria.", "Consumo de Ticket Prepago.");
        }

        public frmConsumoPrepago()
        {
            InitializeComponent();
        }

        private void frmConsumoPrepago_Load(object sender, EventArgs e)
        {
            CargarMontos();
        }

        private void frmConsumoPrepago_Deactivate(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==Convert.ToChar("\r"))
            {
                CargarDatosTicket(txtCodigo.Text);
            }
        }

        private void txtMontoTicket_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
