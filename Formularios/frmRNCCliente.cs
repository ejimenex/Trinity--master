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
    public partial class frmRNCCliente : Form
    {
        //variables para guardar los datos para la factura con comprobante
        public static int lado;
        public static int manguera;
        public static string combustible;
        public static double volumen;
        public static double monto;
        public static string fecha;
        public static string hora;
        private bool clienteEsNuevo { get; set; }

        string NCF;
        //estas variables se usan apra armar el ncf
        string sufijo = "";
        string prefijo = "";
        //solo es para ejecutar un query 
        int iResultado;

        public frmRNCCliente()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            cbCodigoRNC.SelectedIndex = -1;
            cbCodigoRNC.Text = "";
            txtBuscarRNCCliente.Text = "";
            txtNombreRNC.Text = "";
            txtRNC.Text = "";
            txtTarjeta.Text = "";
            txtPlaca.Text = "";
            cbCodigoRNC.Focus();
        }

        //Metodo para buscar el RNC de un cliente
        public void buscarRNC()
        {
            DataSet dsBuscarRNC = new DataSet();
            dsBuscarRNC = Data.queries.npgsDataSet(Data.procedures.buscarRNC(txtBuscarRNCCliente.Text));

            DataTable dtBuscarRNC = new DataTable();
            dtBuscarRNC = dsBuscarRNC.Tables["Tabla"];
            foreach (DataRow row in dtBuscarRNC.Rows)
            {
                //condiciones para elegir el nombre de la empresa (el comercial o el otro)
                if (row["rnc"].ToString() != null)
                {
                    txtRNC.Text = row["rnc"].ToString();
                }

                if (row["nombre_comercial"].ToString().Equals("''") || row["nombre_comercial"].ToString().Equals("") ||
                     row["nombre_comercial"].ToString().Equals(" ") || row["nombre_comercial"].ToString() == null)
                {
                    txtNombreRNC.Text = row["nombre"].ToString();
                }
                else
                {
                    txtNombreRNC.Text = row["nombre_comercial"].ToString();
                }

            }

            //condicion para habilitar los textbox para digitar el rnc y el campo nombre si no estan en la base de datos
            if (dtBuscarRNC.Rows.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("El RNC no existe en la base de datos,"
                                                                + " ¿desea agregarlo manualmente?", "AVISO",
                                                                   MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    txtRNC.ReadOnly = false;
                    txtNombreRNC.ReadOnly = false;
                    clienteEsNuevo = true;
                }
                else
                {
                    clienteEsNuevo = false;
                    return;
                }
            }
        }

        //Metodo para generar los NCF 
        public void generarNCF()
        {
            DataSet dsNCF = new DataSet();
            dsNCF = Data.queries.npgsDataSet(Data.procedures.generarNCF(cbCodigoRNC.Text));
            DataTable dtNCF = new DataTable();
            dtNCF = dsNCF.Tables["Tabla"];

            foreach (DataRow row in dtNCF.Rows)
            {
                prefijo = row["prefijo"].ToString();
                sufijo = row["consecutivo"].ToString();
            }
            NCF = prefijo + sufijo.PadLeft(8, '0');
        }

        //Metodo para imprimir factura        
        public void imprimirFactura(string ncf, string cliente, string rnc, int lado, int manguera, string combustible,
                                    double volumen, double monto, string fecha, string hora)
        {
            DialogResult dg = MessageBox.Show("¿Esta seguro que desea imprimir esta factura y guardarla en la Base de Datos?", "IMPORTANTE", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {

                int i;
                Int32.TryParse(sufijo, out i);
                i++;

                //la variable complemento es para ponerel final del query, porque cuando se agrega la tarjeta y la placa 
                //queda en coma (,) asi que el complemento es para que si no es elegido solo se cierre el parentesis y 
                //la consulta no de error.
                string complemento;
                if (txtTarjeta.TextLength > 0 && txtPlaca.TextLength > 0)
                {
                    complemento = ", '" + txtTarjeta.Text + "', '" + txtPlaca.Text + "')";
                }
                else
                {
                    complemento = ")";
                }

                 

                //Query para guardar las facturas con comprobantes en al base de datos               
                iResultado = Data.queries.Execute(Data.procedures.insertarEnFacturaComprobante(ncf, cliente, rnc, lado, manguera,
                                                  combustible, volumen, monto, fecha, hora, mdiSpirit.sUsuario, complemento));
                //Query para aumentar el numero oque sigue de los comprobantes fiscales cada vez que se genere una factura.
                iResultado = Data.queries.Execute(Data.procedures.aumentarConsecutivoNCF(i.ToString(), prefijo));

                if (clienteEsNuevo)
                    Data.queries.Execute(Data.procedures.insertarRNC(rnc, cliente));


            }
            else if (dg == DialogResult.No)
            {
                return;
            }
        }

        private void btnBuscarRNC_Click(object sender, EventArgs e)
        {
            buscarRNC();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            { 
            if(cbCodigoRNC.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe seleccionar el tipo de comprobante.",this.Text);
                return;
                
            }
            if (cbCodigoRNC.SelectedIndex.Equals(0) || cbCodigoRNC.SelectedIndex.Equals(7) || cbCodigoRNC.SelectedIndex.Equals(8))
            {
                if(string.IsNullOrEmpty(txtBuscarRNCCliente.Text))
                {
                    MessageBox.Show("Debe digitar el numero de RNC del cliente.",this.Text);
                    return;
                }
            }
            generarNCF();
            imprimirFactura(NCF, txtNombreRNC.Text, txtRNC.Text, lado, manguera, combustible, volumen, monto, fecha,
                                hora);
 

            Reportes.crpVentasComprobantes cryRpt = new Reportes.crpVentasComprobantes();
            cryRpt.SetParameterValue("pTipoComprobante", cbCodigoRNC.Text);
            cryRpt.SetParameterValue("ncf", NCF);
           // cryRpt.RecordSelectionFormula = "{viewVentaComprobantes.ncf}= '"+NCF+"'";
            
            cryRpt.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,this.Text);
                return;
            }
        }

        //evento para que el textbox de las tarjetas solo reciba numeros
        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmRNCCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
