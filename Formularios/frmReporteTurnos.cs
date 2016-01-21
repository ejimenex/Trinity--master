using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

namespace spirit.Formularios
{
    public partial class frmReporteTurnos : Form
    {
        
        private static frmReporteTurnos m_FormDefInstance;
        public static frmReporteTurnos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmReporteTurnos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public void LlenarEncabezados()
        {
            dgvTurnos.RowTemplate.Height = 40;
            dgvTurnos.ColumnCount = 5;
            dgvTurnos.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTurnos.Columns[0].Name = "Turno";
            dgvTurnos.Columns[0].Width = 90;            
            dgvTurnos.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTurnos.Columns[1].Name = "Fecha Inicio";
            dgvTurnos.Columns[1].Width = 140;
            dgvTurnos.Columns[2].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTurnos.Columns[2].Name = "Hora Inicio";
            dgvTurnos.Columns[2].Width = 130;
            dgvTurnos.Columns[3].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTurnos.Columns[3].Name = "Fecha Fin";
            dgvTurnos.Columns[3].Width = 140;
            dgvTurnos.Columns[4].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTurnos.Columns[4].Name = "Hora Fin";
            dgvTurnos.Columns[4].Width = 130;
            
            //Change cell font
            foreach (DataGridViewColumn c in dgvTurnos.Columns)
            {

                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
        }
        public void LlenarComboMes()
        {
            cboMes.Items.Add("Enero");
            cboMes.Items.Add("Febrero");
            cboMes.Items.Add("Marzo");
            cboMes.Items.Add("Abril");
            cboMes.Items.Add("Mayo");
            cboMes.Items.Add("Junio");
            cboMes.Items.Add("Julio");
            cboMes.Items.Add("Agosto");
            cboMes.Items.Add("Septiembre");
            cboMes.Items.Add("Octubre");
            cboMes.Items.Add("Noviembre");
            cboMes.Items.Add("Diciembre");
            cboMes.SelectedIndex = DateTime.Today.Month-1;
        }


        public void CargarDatosTurnos()
        {               
            string sFechaInicio="", sHoraInicio="", sFechaFin="", sHoraFin="";
            int iMes = cboMes.SelectedIndex + 1;
            DataSet dsTurnos = new DataSet();
            sFechaInicio = txtAnio.Text + iMes.ToString("0#") + "01";
            sFechaFin = System.DateTime.DaysInMonth(Convert.ToInt32(txtAnio.Text), iMes).ToString();
            //sFechaFin = txtAnio.Text + iMes.ToString("0#") + "31";
            dsTurnos = Data.queries.npgsDataSet(Data.procedures.BuscarPeriodos(sFechaInicio,sFechaFin));

            //sFechaInicio = txtAnio.Text + "-" + iMes.ToString("0#") + "-" + "01";
            //sFechaFin = txtAnio.Text + "-" + iMes.ToString("0#") + "-" + "31";
            //dsTurnos = Data.queries.npgsDataSet(Data.procedures.BuscarPeriodosTrinity(sFechaInicio, sFechaFin));

            DataTable dtTurnos = new DataTable();
            dtTurnos = dsTurnos.Tables["Tabla"];
            dgvTurnos.Rows.Clear();
            foreach (DataRow drFila in dtTurnos.Rows)
            {
                if (!string.IsNullOrEmpty(drFila["period_start_date"].ToString()))
                {
                    //sFechaInicio = drFila["fecha_inicio_periodo"].ToString().Substring(6, 2) + "/" + drFila["fecha_inicio_periodo"].ToString().Substring(4, 2) + "/" + drFila["fecha_inicio_periodo"].ToString().Substring(0, 4);
                    sFechaInicio = drFila["period_start_date"].ToString().Substring(6, 2) + "/" + drFila["period_start_date"].ToString().Substring(4, 2) + "/" + drFila["period_start_date"].ToString().Substring(0, 4);
                }
                else 
                {
                    sFechaInicio = "";
                }
                if (!string.IsNullOrEmpty(drFila["period_start_time"].ToString()))
                {
                    sHoraInicio = drFila["period_start_time"].ToString().Substring(0, 2) + ":" + drFila["period_start_time"].ToString().Substring(2, 2) + ":" + drFila["period_start_time"].ToString().Substring(4, 2);
                }
                else
                {
                    sHoraInicio = "";
                }
                if (!string.IsNullOrEmpty(drFila["period_end_date"].ToString()))
                {
                    //sFechaFin = drFila["fecha_fin_periodo"].ToString().Substring(6, 2) + "/" + drFila["fecha_fin_periodo"].ToString().Substring(4, 2) + "/" + drFila["fecha_fin_periodo"].ToString().Substring(0, 4);
                    sFechaFin = drFila["period_end_date"].ToString().Substring(6, 2) + "/" + drFila["period_end_date"].ToString().Substring(4, 2) + "/" + drFila["period_end_date"].ToString().Substring(0, 4);
                }
                else 
                {
                    sFechaFin = DateTime.Today.ToShortDateString();
                }
                if (!string.IsNullOrEmpty(drFila["period_end_time"].ToString()))
                {
                    sHoraFin = drFila["period_end_time"].ToString().Substring(0, 2) + ":" + drFila["period_end_time"].ToString().Substring(2, 2) + ":" + drFila["period_end_time"].ToString().Substring(4, 2);
                }
                else 
                {
                    if (DateTime.Now.ToLongTimeString().Length==7)
                    {
                        sHoraFin ="0" + DateTime.Now.ToLongTimeString();
                    }
                    else
                    { 
                        sHoraFin = DateTime.Now.ToLongTimeString();
                    }
                }
                dgvTurnos.Rows.Add(drFila["period_id"].ToString(), sFechaInicio, sHoraInicio, sFechaFin, sHoraFin);
            }
         
        }

        public void MostrarDetalleTurno(int iRowIndex)
        {
            mdiSpirit.sCodigoTurno = dgvTurnos.Rows[iRowIndex].Cells[0].ToString();
            mdiSpirit.sFechaInicioPeriodo = dgvTurnos.Rows[iRowIndex].Cells[5].ToString();
            mdiSpirit.sHoraInicioPeriodo = dgvTurnos.Rows[iRowIndex].Cells[6].ToString();
            mdiSpirit.sFechaFinPeriodo = dgvTurnos.Rows[iRowIndex].Cells[7].ToString();
            mdiSpirit.sHoraFinPeriodo = dgvTurnos.Rows[iRowIndex].Cells[8].ToString();
            mdiSpirit.sFormulario = "frmDetalleTurnos";
            frmDetalleTurnos.DefInstance.MdiParent = this;
            frmDetalleTurnos.DefInstance.ShowDialog();
        }
               
        public void Imprimir(int iIdTurno, string sFechainicio, string sHoraInicio, string sFechaFin, string sHoraFin)
        {
            int iResultado;
                //public static ParameterField pField;
                //public static ParameterDiscreteValue disVal;
                //public static ParameterFields pFields;

            Reportes.CrystalReportViewer.pFechaInicio = sFechainicio;
            Reportes.CrystalReportViewer.pHoraInicio = sHoraInicio;
            Reportes.CrystalReportViewer.pFechaFin = sFechaFin;
            Reportes.CrystalReportViewer.pHoraFin = sHoraFin;
            Reportes.CrystalReportViewer.pTurno = iIdTurno;
            
            sFechainicio = sFechainicio.Substring(6, 4) + sFechainicio.Substring(3, 2) + sFechainicio.Substring(0, 2);
            sHoraInicio = sHoraInicio.Substring(0, 2) + sHoraInicio.Substring(3, 2) + sHoraInicio.Substring(6, 2);
            if(sFechaFin!="")
            { 
                sFechaFin = sFechaFin.Substring(6, 4) + sFechaFin.Substring(3, 2) + sFechaFin.Substring(0, 2);
                sHoraFin = sHoraFin.Substring(0, 2) + sHoraFin.Substring(3, 2) + sHoraFin.Substring(6, 2);
            }

            //si esta cerrado en la tabla de turnos original, lo cerramos en detalle turno
            DataSet dstatusPeriodo = new DataSet();
            dstatusPeriodo = Data.queries.npgsDataSet(Data.procedures.BuscarStatusPeriodo(iIdTurno));
            DataTable dtStatusPeriodo = new DataTable();
            dtStatusPeriodo = dstatusPeriodo.Tables["Tabla"];
            if (dtStatusPeriodo.Rows.Count > 0)
            {
                iResultado = Data.queries.Execute(Data.procedures.BorrarTablaDetalleTurno(iIdTurno));
                iResultado = Data.queries.Execute(Data.procedures.GuardarDetallePeriodo(iIdTurno, sFechainicio, sHoraInicio, sFechaFin, sHoraFin,"C"));
            }
            
            DataSet dsPeriodo = new DataSet();
            dsPeriodo = Data.queries.npgsDataSet(Data.procedures.BuscarDetallePeriodo(iIdTurno));
            DataTable dtPeriodo = new DataTable();
            dtPeriodo = dsPeriodo.Tables["Tabla"];

            //iResultado = Data.queries.Execute(Data.procedures.BuscarDetallePeriodo(iIdTurno));
            if(dtPeriodo.Rows.Count==0)
            { 
                //if (sFechaFin == "")
                //{
                //    iResultado = Data.queries.Execute(Data.procedures.BorrarTablaDetalleTurno(iIdTurno));
                //    iResultado = Data.queries.Execute(Data.procedures.GuardarDetallePeriodoInicio(iIdTurno, sFechainicio, sHoraInicio, sFechaFin, sHoraFin));
                //}
                //else
                //{
                    iResultado = Data.queries.Execute(Data.procedures.BorrarTablaDetalleTurno(iIdTurno));
                    iResultado = Data.queries.Execute(Data.procedures.GuardarDetallePeriodo(iIdTurno, sFechainicio, sHoraInicio, sFechaFin, sHoraFin,"O"));                    
                //}
            }
           
            iResultado = Data.queries.Execute(Data.procedures.BorrarDetallePeriodo());
            if (sFechaFin == "")
            {
                iResultado = Data.queries.Execute(Data.procedures.DetallePeriodosInicio(iIdTurno, sFechainicio, sHoraInicio));
                iResultado = Data.queries.Execute(Data.procedures.DetallePeriodosFaltantesInicio(sFechainicio, sHoraInicio));                        
            }
            else
            {
                iResultado = Data.queries.Execute(Data.procedures.DetallePeriodos(iIdTurno, sFechainicio, sHoraInicio, sFechaFin, sHoraFin));
                iResultado = Data.queries.Execute(Data.procedures.DetallePeriodosFaltantes(sFechainicio, sHoraInicio, sFechaFin, sHoraFin));                                
            }
            
           
            //Reportes.CrystalReportViewer.sSelectionFormula = "({viewDetalleTurno.start_date}>='" + sFechainicio + "' and {viewDetalleTurno.start_time}>='" + sHoraInicio + "') and ({viewDetalleTurno.end_date}<='" + sFechaFin + "' and {viewDetalleTurno.end_time}<='" + sHoraFin + "')";
            //Reportes.CrystalReportViewer.sNombreReporte = "crpDetalleTurno.rpt";
            Reportes.CrystalReportViewer.sNombreReporte = "crpTurnos.rpt";
            Reportes.CrystalReportViewer frmCrystalReportViewer = new Reportes.CrystalReportViewer();            
            frmCrystalReportViewer.Show();
                      
        }

        public frmReporteTurnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmReporteTurnos_Load(object sender, EventArgs e)
        {
            LlenarEncabezados();
            LlenarComboMes();
            txtAnio.Text = DateTime.Today.Year.ToString();
            cboMes.SelectedIndex = Convert.ToInt32(DateTime.Today.Month.ToString()) - 1;
            CargarDatosTurnos();            
        }
                        
        private void dgvTurnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MostrarDetalleTurno(e.RowIndex);
            if (string.IsNullOrEmpty(dgvTurnos.Rows[e.RowIndex].Cells[1].Value.ToString()))
            {
                MessageBox.Show("El turno esta incompleto.",this.Text);
                return;
            }
            if (string.IsNullOrEmpty(dgvTurnos.Rows[e.RowIndex].Cells[2].Value.ToString()))
            {
                MessageBox.Show("El turno esta incompleto.", this.Text);
                return;
            }
            //if (string.IsNullOrEmpty(dgvTurnos.Rows[e.RowIndex].Cells[3].Value.ToString()))
            //{
            //    MessageBox.Show("El turno debe estar cerrado para poder ver el detalle.", this.Text);
            //    return;
            //}
            //if (string.IsNullOrEmpty(dgvTurnos.Rows[e.RowIndex].Cells[4].Value.ToString()))
            //{
            //    MessageBox.Show("El turno debe estar cerrado para poder ver el detalle.", this.Text);
            //    return;
            //}
            
            Imprimir(Convert.ToInt32(dgvTurnos.Rows[e.RowIndex].Cells[0].Value.ToString()), dgvTurnos.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvTurnos.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvTurnos.Rows[e.RowIndex].Cells[3].Value.ToString(), dgvTurnos.Rows[e.RowIndex].Cells[4].Value.ToString());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatosTurnos();
        }

        private void tmrReporteTurnos_Tick(object sender, EventArgs e)
        {
            CargarDatosTurnos();
        }

        private void chkActualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActualizar.Checked == true)
            {
                //tmrReporteTurnos.Interval = 1 * 60000;
                tmrReporteTurnos.Enabled = true;
            }
            else
            {
                tmrReporteTurnos.Enabled = false;
            }
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
