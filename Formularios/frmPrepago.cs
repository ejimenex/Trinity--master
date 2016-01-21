using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace spirit.Formularios
{
    public partial class frmPrepago : Form
    {
        public frmListadoCodigoBarra ffrmListadoCodigoBarra = new frmListadoCodigoBarra();

        private static frmPrepago m_FormDefInstance;
        public static frmPrepago DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmPrepago();
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
            cboMonto.ValueMember = "codigo";
            cboMonto.DisplayMember = "monto";
            cboMonto.DataSource = dtMontos;
        }

        public void Imprimir()
        {
            //if(dgvPrepago.Rows.Count==0)
            //{
            //    MessageBox.Show("No hay codigo de barra disponible para imprimir.", "Generacion de Tickets Prepago");
            //    return;
            //}
            string sCodigosBarra = "";
            for (int i = 0; i< dgvPrepago.Rows.Count;i++ )
            {
                if(dgvPrepago.Rows[i].Cells[0].Value.ToString()=="1")
                {
                    sCodigosBarra = sCodigosBarra + "'" + dgvPrepago.Rows[i].Cells[1].Value + "'" + ",";
                }
            }
            Reportes.CrystalReportViewer.sSelectionFormula = "[" + sCodigosBarra.Substring(0, sCodigosBarra.Length - 1) + "]";
            Reportes.CrystalReportViewer.sNombreReporte = "crpCodigoBarra.rpt";
            Reportes.CrystalReportViewer frmCrystalReportViewer = new Reportes.CrystalReportViewer();            
            frmCrystalReportViewer.Show();
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("Reportes/crpCodigoBarra.rpt");
            //Reportes.CrystalReportViewer frmViewer = new Reportes.CrystalReportViewer(cryRpt);
         
        }

        public void Buscar()
        {            
           ffrmListadoCodigoBarra.ShowDialog();
        }
        public void Limpiar()
        {
            cboCliente.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            nudCantidad.Value=0;
            cboMonto.SelectedIndex=-1;
            cboMonto.Text = "";
            cboCliente.Focus();
        }
        public long GenerarCodigoBarra()
        {
            Random rd = new Random();
            long lCodigoBarra = rd.Next(000000000, 999999999);
            return lCodigoBarra;
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

        public void Registrar()
        {
            //if(dgvPrepago.Rows.Count==0)
            //{ 
            //    MessageBox.Show("No ha registrado ningun codigo de barra.", "Generacion de Tickets Prepago.");
            //    return;
            //}
            DataSet dsCodigoPrepago = new DataSet();
            dsCodigoPrepago = Data.queries.npgsDataSet(Data.procedures.CodigoPrepago());
            DataTable dtCodigoPrepago = new DataTable();
            dtCodigoPrepago = dsCodigoPrepago.Tables["Tabla"];
            Int32 iCodigoPrepago = 0;
            int iResultado = 0;
            foreach (DataRow drFila in dtCodigoPrepago.Rows)
            {
                Int32.TryParse(drFila["CodigoPrepago"].ToString(), out iCodigoPrepago);                
            }
            iCodigoPrepago++;
            iResultado = Data.queries.Execute(Data.procedures.InsertarPrepago(iCodigoPrepago, Convert.ToInt32(cboCliente.SelectedValue), Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), Convert.ToInt32(dgvPrepago.Rows.Count), spirit.Formularios.mdiSpirit.sUsuario), CommandType.Text);               
             
            for (int i = 0; i < dgvPrepago.Rows.Count; i++)
            {
                iResultado = Data.queries.Execute(Data.procedures.InsertarPrepagoDetalle(iCodigoPrepago, dgvPrepago.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dgvPrepago.Rows[i].Cells[3].Value.ToString()), Convert.ToDouble(dgvPrepago.Rows[i].Cells[2].Value.ToString()), Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), spirit.Formularios.mdiSpirit.sUsuario));
            }
            MessageBox.Show("Datos registrados.","Generacion de Tickets Prepago.");
            //btnImprimir.Enabled = true;
        }
       
        public void Guardar()
        {
            if (cboCliente.SelectedIndex==0)
            {
                MessageBox.Show("Debe seleccionar el cliente.", "Generacion de Tickets Prepago");
                cboCliente.Focus();
                return;
            }
            if (cboMonto.SelectedIndex<0)
            {
                MessageBox.Show("Debe elegir el monto.", "Generacion de Tickets Prepago");
                cboMonto.Focus();
                return;
            }
            if (nudCantidad.Value==0)
            {
                MessageBox.Show("Debe registrar la cantidad.", "Generacion de Tickets Prepago");
                nudCantidad.Focus();
                return;
            }
            bool bGrid = false;            
            int i=1;
            while (i <= Convert.ToInt32(nudCantidad.Value))
            {
                string sCodBarra = GenerarCodigoBarra().ToString();
                string sCodAnterior = sCodBarra;
                while (sCodBarra==sCodAnterior)
                {
                    sCodBarra = GenerarCodigoBarra().ToString();                
                }
                DataSet dsValidarCodigoBarra = new DataSet();
                dsValidarCodigoBarra = Data.queries.npgsDataSet(Data.procedures.VerificarCodigoBarra(sCodBarra));
                DataTable dtCodigoBarra = new DataTable();
                dtCodigoBarra = dsValidarCodigoBarra.Tables["Tabla"];

                bGrid = false;
                for (int j = 0; j < dgvPrepago.Rows.Count - 1; j++)
                {
                    if(dgvPrepago.Rows[j].Cells[1].Value.ToString()==sCodBarra)
                    {
                        bGrid = true;
                        j = dgvPrepago.Rows.Count+1;
                    }
                }
                
                if (dtCodigoBarra.Rows.Count == 0 && bGrid==false)
                {
                    i++;
                    dgvPrepago.Rows.Add(1,sCodBarra, cboMonto.Text.Substring(3,cboMonto.Text.Length-3),0,nudCantidad.Value);                    
                }
            }
            dgvPrepago.RowTemplate.Height = 50;
            dgvPrepago.Columns[1].Width = 150;
            dgvPrepago.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[2].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvPrepago.Columns[3].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            foreach (DataGridViewColumn c in dgvPrepago.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
            nudCantidad.Value=0;
            cboMonto.SelectedIndex=-1;
            cboMonto.Focus();
        }
      
        public frmPrepago()
        {
            InitializeComponent();
        }

        private void frmPrepago_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            CargarClientes();
            CargarMontos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void mskCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskMonto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                Guardar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
