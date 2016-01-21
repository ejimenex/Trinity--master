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
    public partial class frmListadoCodigoBarra : Form
    {
        public void CargarMontoDesde()
        {
            DataSet dsMontos = new DataSet();
            dsMontos = Data.queries.npgsDataSet(Data.procedures.CargarMontos());
            DataTable dtMontos = new DataTable();
            dtMontos = dsMontos.Tables["Tabla"];
            cboMontoDesde.ValueMember = "codigo";
            cboMontoDesde.DisplayMember = "monto";
            cboMontoDesde.DataSource = dtMontos;
        }

        public void CargarMontoHasta()
        {
            DataSet dsMontos = new DataSet();
            dsMontos = Data.queries.npgsDataSet(Data.procedures.CargarMontos());
            DataTable dtMontos = new DataTable();
            dtMontos = dsMontos.Tables["Tabla"];
            cboMontoHasta.ValueMember = "codigo";
            cboMontoHasta.DisplayMember = "monto";
            cboMontoHasta.DataSource = dtMontos;
        }

        public void Imprimir()
        {
            string sCodigosBarra = "";
            for (int i = 0; i < dgvPrepago.Rows.Count; i++)
            {
                if (dgvPrepago.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    sCodigosBarra = sCodigosBarra + "'" + dgvPrepago.Rows[i].Cells[1].Value + "'" + ",";
                }
            }
            Reportes.CrystalReportViewer.sSelectionFormula = "{ssf_config_prepago_detalle.codigo_barra} in [" + sCodigosBarra.Substring(0, sCodigosBarra.Length - 1) + "]";
            Reportes.CrystalReportViewer.sNombreReporte = "crpCodigoBarra.rpt";
            Reportes.CrystalReportViewer frmCrystalReportViewer = new Reportes.CrystalReportViewer();
            frmCrystalReportViewer.Show();
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("Reportes/crpCodigoBarra.rpt");
            //Reportes.CrystalReportViewer frmViewer = new Reportes.CrystalReportViewer(cryRpt);

        }
        public void CargarClientes()
        {
            DataSet dsClientes = new DataSet();
            dsClientes = Data.queries.npgsDataSet(Data.procedures.CargarClientes());
            DataTable dtClientes = new DataTable();
            dtClientes = dsClientes.Tables["Tabla"];
            cboCliente.ValueMember = "Codigo";
            cboCliente.DisplayMember = "Nombre";
            cboCliente.DataSource = dtClientes;
        }
        public void Buscar()
        {
            string sCadena = "";
            string sQuery = "";
            if (cboCliente.SelectedIndex>0)
            {
                sCadena = " and cp.tkt_cust_id=" + cboCliente.SelectedValue;
            }
            if (chkFecha.Checked==true)
            {
                if(dtpFechaHasta.Value<dtpFechaDesde.Value)
                {
                    MessageBox.Show("La fecha inicial debe ser menor que la final.","Listado Tickets Prepago.");
                    return;
                }
                sCadena = sCadena + " and cpd.fecha between '" + Data.DateHelper.GetFormattedDate(dtpFechaDesde.Value) + "' and '" + Data.DateHelper.GetFormattedDate(dtpFechaHasta.Value) + "'";
            }
            if(chkMonto.Checked==true)
            {
                if (cboMontoDesde.SelectedIndex<0 || cboMontoHasta.SelectedIndex<0)
                {
                    MessageBox.Show("Debe digitar el monto inicial y final.", "Listado Tickets Prepago.");
                    return;
                }
                if (Convert.ToDouble(cboMontoDesde.Text.Substring(3, cboMontoDesde.Text.Length - 3)) > Convert.ToDouble(cboMontoHasta.Text.Substring(3, cboMontoHasta.Text.Length - 3)))
                {
                    MessageBox.Show("El monto inicial debe ser menor que el final.", "Listado Tickets Prepago.");
                    return;
                }
                sCadena = sCadena + " and cpd.monto between " + Convert.ToDouble(cboMontoDesde.Text.Substring(3,cboMontoDesde.Text.Length-3)) + " and " + Convert.ToDouble(cboMontoHasta.Text.Substring(3,cboMontoHasta.Text.Length-3));
            }
            if(sCadena=="")
            {
                MessageBox.Show("No ha registrado ningun criterio de busqueda.", "Listado Tickets Prepago.");
                return;
            }
            sQuery = "Select cpd.codigo_barra,cpd.monto,cpd.consumido,cpd.fecha,cpd.hora,tc.tkt_cust_name as cliente from ssf_config_prepago cp,ssf_config_prepago_detalle cpd,ssf_tkt_customers tc";
            sQuery = sQuery + " where tc.tkt_cust_id=cp.tkt_cust_id and cp.codigo_prepago=cpd.codigo_prepago and cpd.activo=1 " + sCadena;
            DataSet dsCodigoPrepago = Data.queries.npgsDataSet(sQuery);
            DataTable dtCodigoPrepago = new DataTable();
            dtCodigoPrepago = dsCodigoPrepago.Tables["Tabla"];
            dgvPrepago.Rows.Clear();
            foreach(DataRow drFila in dtCodigoPrepago.Rows)
            {
                dgvPrepago.Rows.Add(1,drFila["codigo_barra"].ToString(), drFila["monto"].ToString(), drFila["consumido"].ToString(), drFila["fecha"].ToString(), drFila["hora"].ToString(), drFila["cliente"].ToString());
            }
            dgvPrepago.RowTemplate.Height = 50;
            dgvPrepago.Columns[0].Width = 80;
            dgvPrepago.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[1].Width = 180;
            dgvPrepago.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[2].Width = 120;
            dgvPrepago.Columns[2].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[3].Width = 120;
            dgvPrepago.Columns[3].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[4].Width = 130;
            dgvPrepago.Columns[4].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[5].Width = 110;
            dgvPrepago.Columns[5].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[6].Width = 180;
            dgvPrepago.Columns[6].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            
            foreach (DataGridViewColumn c in dgvPrepago.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
        }
        public frmListadoCodigoBarra()
        {
            InitializeComponent();
        }

        private void frmListadoCodigoBarra_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            CargarClientes();
            CargarMontoDesde();
            CargarMontoHasta();
        }

        private void chkMontoCant_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMonto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonto.Checked == true)
            {
                cboMontoDesde.Enabled = true;
                cboMontoHasta.Enabled = true;
            }
            else
            {
                cboMontoDesde.Enabled = false;
                cboMontoHasta.Enabled = false;
            }
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFecha.Checked==true)
            {
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
            else
            {
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void frmListadoCodigoBarra_Deactivate(object sender, EventArgs e)
        {
          mdiSpirit.sFormulario  = "frmPrepago";
        }
    }
}
