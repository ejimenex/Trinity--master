//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//namespace spirit.Formularios
//{
//    public partial class frmPeriodo : Form
//    {

//        private static frmPeriodo m_FormDefInstance;
//        public static frmPeriodo DefInstance
//        {
//            get
//            {
//                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
//                    m_FormDefInstance = new frmPeriodo();
//                return m_FormDefInstance;
//            }
//            set
//            {
//                m_FormDefInstance = value;
//            }
//        }

//        public void CargarTurnoAbierto()
//        {
//            string sHoraInicio;
//            string sFechaInicio;
//            DataSet dsTurnoAbierto = new DataSet();
//            dsTurnoAbierto = Data.queries.npgsDataSet(Data.procedures.CargarTurnoAbierto());

//            DataTable dtTurnoAbierto = new DataTable();
//            dtTurnoAbierto = dsTurnoAbierto.Tables["Tabla"];
//            dgvPeriodos.Rows.Clear();
//            foreach (DataRow drFila in dtTurnoAbierto.Rows)
//            {
//                sHoraInicio = drFila["hora_inicio_periodo"].ToString().Substring(0, 2) + ":" + drFila["hora_inicio_periodo"].ToString().Substring(2, 2) + ":" + drFila["hora_inicio_periodo"].ToString().Substring(4, 2);
//                sFechaInicio = drFila["fecha_inicio_periodo"].ToString().Substring(0, 10);
//                dgvPeriodos.Rows.Add(drFila["id_periodo"].ToString(), drFila["lado"].ToString(), drFila["status_periodo"].ToString(), sFechaInicio, sHoraInicio);
//            }
//        }

//        public void CargarTurnosCerrados()
//        {
//            string sFechaInicio = "", sFechaFin = "", sHoraInicio="",sHoraFin="";
//            DataSet dsTurnosCerrados = new DataSet();
//            dsTurnosCerrados = Data.queries.npgsDataSet(Data.procedures.CargarTurnosCerrados());

//            DataTable dtTurnosCerrados = new DataTable();
//            dtTurnosCerrados = dsTurnosCerrados.Tables["Tabla"];
//            dgvPeriodosCerrados.Rows.Clear();
//            foreach (DataRow drFila in dtTurnosCerrados.Rows)
//            {
//                sFechaInicio = drFila["fecha_inicio_periodo"].ToString().Substring(0, 10);
//                sFechaFin = drFila["fecha_fin_periodo"].ToString().Substring(0, 10);
//                sHoraInicio = drFila["hora_inicio_periodo"].ToString().Substring(0, 2) + ":" + drFila["hora_inicio_periodo"].ToString().Substring(2, 2) + ":" + drFila["hora_inicio_periodo"].ToString().Substring(4, 2);
//                sHoraFin = drFila["hora_fin_periodo"].ToString().Substring(0, 2) + ":" + drFila["hora_fin_periodo"].ToString().Substring(2, 2) + ":" + drFila["hora_fin_periodo"].ToString().Substring(4, 2);
//                dgvPeriodosCerrados.Rows.Add(drFila["id_periodo"].ToString(), drFila["lado"].ToString(), sFechaInicio, sHoraInicio, sFechaFin, sHoraFin);
//            }
//        }

//        public void CargarLados()
//        {
//            DataSet dsLados = new DataSet();
//            dsLados = Data.queries.npgsDataSet(Data.procedures.BuscarLados());

//            DataTable dtLados = new DataTable();
//            dtLados = dsLados.Tables["Tabla"];
//            clbLado.Items.Clear();
//            foreach (DataRow drFila in dtLados.Rows)
//            {
//                clbLado.Items.Add(drFila["pump_id"].ToString());
//            }
//        }

//        public void LlenarEncabezados()
//        {
//            //periodo abierto
//            dgvPeriodos.RowTemplate.Height = 50;
//            dgvPeriodos.ColumnCount = 5;
//            dgvPeriodos.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodos.Columns[0].Name = "Periodo";
//            dgvPeriodos.Columns[0].Width = 100;
//            dgvPeriodos.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodos.Columns[1].Name = "Lado";
//            dgvPeriodos.Columns[1].Width = 100;
//            dgvPeriodos.Columns[2].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodos.Columns[2].Name = "Estado";
//            dgvPeriodos.Columns[2].Width = 100;
//            dgvPeriodos.Columns[3].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodos.Columns[3].Name = "Fecha Inicio";
//            dgvPeriodos.Columns[3].Width = 140;
//            dgvPeriodos.Columns[4].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodos.Columns[4].Name = "Hora Inicio";
//            dgvPeriodos.Columns[4].Width = 140;            

//            //Change cell font
//            foreach (DataGridViewColumn c in dgvPeriodos.Columns)
//            {

//                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            }

//            //periodos cerrados
//            dgvPeriodosCerrados.RowTemplate.Height = 50;
//            dgvPeriodosCerrados.ColumnCount = 6;
//            dgvPeriodosCerrados.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodosCerrados.Columns[0].Name = "Periodo";
//            dgvPeriodosCerrados.Columns[0].Width = 100;
//            dgvPeriodosCerrados.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodosCerrados.Columns[1].Name = "Lado";
//            dgvPeriodosCerrados.Columns[1].Width = 100;
//            dgvPeriodosCerrados.Columns[2].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodosCerrados.Columns[2].Name = "Fecha Inicio";
//            dgvPeriodosCerrados.Columns[2].Width = 140;
//            dgvPeriodosCerrados.Columns[3].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodosCerrados.Columns[3].Name = "Hora Inicio";
//            dgvPeriodosCerrados.Columns[3].Width = 140;
//            dgvPeriodosCerrados.Columns[4].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodosCerrados.Columns[4].Name = "Fecha Fin";
//            dgvPeriodosCerrados.Columns[4].Width = 140;
//            dgvPeriodosCerrados.Columns[5].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            dgvPeriodosCerrados.Columns[5].Name = "Hora Fin";
//            dgvPeriodosCerrados.Columns[5].Width = 140;            

//            //Change cell font
//            foreach (DataGridViewColumn c in dgvPeriodosCerrados.Columns)
//            {

//                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
//            }
//        }

//        public void QuitarSeleccion()
//        {
//            for (int i = 0; i < clbLado.Items.Count; i++)
//            {
//                clbLado.SetItemChecked(i, false);
//            }
//        }

//        public void SeleccionarTodo()
//        {
//            for (int i = 0; i < clbLado.Items.Count; i++)
//            {
//                clbLado.SetItemChecked(i, true);
//            }
//        }

//        public frmPeriodo()
//        {
//            InitializeComponent();
//        }

//        private void frmPeriodo_Load(object sender, EventArgs e)
//        {
//            LlenarEncabezados();
//            CargarLados();
//            CargarTurnoAbierto();
//            CargarTurnosCerrados();
//        }

//        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
//        {
//            SeleccionarTodo();
//        }

//        private void btnQuitarSeleccion_Click(object sender, EventArgs e)
//        {
//            QuitarSeleccion();
//        }

//        private void btnCerrarTurno_Click(object sender, EventArgs e)
//        {
//            int iResultado,iCodigoPeriodo=0;            
//            string sFechaFinPeriodo="",sHoraFinPeriodo="";
//            if(clbLado.CheckedItems.Count==0)
//            {
//                MessageBox.Show("Debe seleccionar por lo menos un lado para cerrar el periodo.",this.Text);
//                return;                
//            }
            
//            foreach (string sItem in clbLado.CheckedItems)
//            {
//                double dVolumenFinal=0;
//                iCodigoPeriodo = 0;
                
//                DataSet dsPeriodo = new DataSet();
//                dsPeriodo = Data.queries.npgsDataSet(Data.procedures.MaxPeriodo(Convert.ToInt32(sItem)));

//                DataTable dtPeriodo = new DataTable();
//                dtPeriodo = dsPeriodo.Tables["Tabla"];
//                if (dtPeriodo.Rows.Count > 0)
//                {
//                    foreach (DataRow drFila in dtPeriodo.Rows)
//                    {
//                        if (!string.IsNullOrEmpty(drFila["id_periodo"].ToString()))
//                        {
//                            iCodigoPeriodo = Convert.ToInt32(drFila["id_periodo"].ToString());
//                        }
//                        if (!string.IsNullOrEmpty(drFila["fecha_fin_periodo"].ToString()))
//                        {
//                            sFechaFinPeriodo = drFila["fecha_fin_periodo"].ToString();
//                        }
//                        if (!string.IsNullOrEmpty(drFila["hora_fin_periodo"].ToString()))
//                        {
//                            sHoraFinPeriodo = drFila["hora_fin_periodo"].ToString();
//                        }
//                    }
//                }

//                //buscamos el volumen final
//                DataSet dsVolFinal = new DataSet();
//                dsVolFinal = Data.queries.npgsDataSet(Data.procedures.BuscarVolumenFinal(Convert.ToInt32(sItem)));

//                DataTable dtVolFinal = new DataTable();
//                dtVolFinal = dsVolFinal.Tables["Tabla"];
//                foreach (DataRow drFila in dtVolFinal.Rows)
//                {
//                    if (!string.IsNullOrEmpty(drFila["attr_value"].ToString()))
//                    {
//                        dVolumenFinal = Convert.ToDouble(drFila["attr_value"].ToString());
//                    }
//                }

//                iResultado = Data.queries.Execute(Data.procedures.CerrarPeriodo(iCodigoPeriodo, Convert.ToInt32(sItem), 0, Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), dVolumenFinal, spirit.Formularios.mdiSpirit.sUsuario));
//                iCodigoPeriodo++;
//                iResultado = Data.queries.Execute(Data.procedures.AbrirPeriodo(iCodigoPeriodo, 1, Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), Convert.ToInt32(sItem), dVolumenFinal, spirit.Formularios.mdiSpirit.sUsuario));
//            }
//            QuitarSeleccion();
//            CargarTurnoAbierto();
//            CargarTurnosCerrados();
//        }
//    }
//}
