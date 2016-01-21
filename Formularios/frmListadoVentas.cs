using spirit.Helper;
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
    public partial class frmListadoVentas : Form
    {
        Venta venta = new Venta();
        
        private static frmListadoVentas m_FormDefInstance;
        public static frmListadoVentas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmListadoVentas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        public void CargarConfigListadoVenta()
        {
            DataSet dsConfigListadoVentas = new DataSet();
            dsConfigListadoVentas = Data.queries.npgsDataSet(Data.procedures.BuscarConfigListadoVenta(spirit.Formularios.mdiSpirit.sUsuario));

            DataTable dtConfigListadoVentas = new DataTable();
            dtConfigListadoVentas = dsConfigListadoVentas.Tables["Tabla"];
            foreach(DataRow rFila in dtConfigListadoVentas.Rows)
            {
                nudBomba.Value=Convert.ToInt32(rFila["bomba"].ToString());
                nudLado.Value = Convert.ToInt32(rFila["lado"].ToString());
                nudUltimasVentas.Value = Convert.ToInt32(rFila["ultimas"].ToString());
            }
        }
        public void GuardarConfigListadoVenta()
        {
            Int32 iResultado;
            DataSet dsConfigListadoVentas = new DataSet();
            dsConfigListadoVentas = Data.queries.npgsDataSet(Data.procedures.BuscarConfigListadoVenta(spirit.Formularios.mdiSpirit.sUsuario));

            DataTable dtConfigListadoVentas = new DataTable();
            dtConfigListadoVentas = dsConfigListadoVentas.Tables["Tabla"];
            if(dtConfigListadoVentas.Rows.Count==0)
            {
                iResultado = Data.queries.Execute(Data.procedures.InsertConfigListadoVenta(Convert.ToInt32(nudBomba.Value),Convert.ToInt32(nudLado.Value),Convert.ToInt32(nudUltimasVentas.Value),spirit.Formularios.mdiSpirit.sUsuario,Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss")));
            }
            else
            {
                iResultado = Data.queries.Execute(Data.procedures.UpdateConfigListadoVenta(Convert.ToInt32(nudBomba.Value), Convert.ToInt32(nudLado.Value), Convert.ToInt32(nudUltimasVentas.Value), spirit.Formularios.mdiSpirit.sUsuario, Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss")));
            }
        }

        public void Imprimir(Int32 idVenta)
        {           
            if(idVenta==0)
            {
                MessageBox.Show("Debe seleccionar la venta que desea imprimir.","Listado de Ultimas Ventas.");
                return;
            }
            Reportes.CrystalReportViewer.sSelectionFormula = "{viewDetalleVenta.sale_id}=" + idVenta;
            Reportes.CrystalReportViewer.sNombreReporte = "crpDetalleVenta.rpt";
            Reportes.CrystalReportViewer frmCrystalReportViewer = new Reportes.CrystalReportViewer();
            frmCrystalReportViewer.Show();         
        }

        public void CargarUltimasVentas(Int32 iPump_Id, Int32 iHose_Id)
        {
            Int32 iVentas = 0;
            DataSet dsListadoVentas = new DataSet();
            dsListadoVentas = Data.queries.npgsDataSet(Data.procedures.CargarVentas(iPump_Id,iHose_Id));

            DataTable dtListadoVentas = new DataTable();
            dtListadoVentas = dsListadoVentas.Tables["Tabla"];
            dgvListadoVentas.Rows.Clear();
            foreach (DataRow drFila in dtListadoVentas.Rows)
            {
                for (int i = 0; i < 10; i++)
                {
                    iVentas++;
                    dgvListadoVentas.Rows.Add(i.ToString(),drFila["pump_id"].ToString(), drFila["hose_id"].ToString(), drFila["grade_id"].ToString(), drFila["tkt_plu_short_desc"].ToString(), drFila["volume"].ToString(), drFila["money"].ToString(), drFila["end_date"].ToString(), drFila["end_time"].ToString(), drFila["sale_id"].ToString());
                    if (iVentas == nudUltimasVentas.Value)
                    {
                        return;
                    }
                }
                //iVentas++;
                //dgvListadoVentas.Rows.Add(drFila["pump_id"].ToString(), drFila["hose_id"].ToString(), drFila["grade_id"].ToString(), drFila["tkt_plu_short_desc"].ToString(), drFila["volume"].ToString(), drFila["money"].ToString(), drFila["end_date"].ToString(), drFila["end_time"].ToString(), drFila["sale_id"].ToString());
                //if(iVentas==nudUltimasVentas.Value)
                //{
                //    return;
                //}
            }
        }

        public void LlenarEncabezados()
        {
            dgvListadoVentas.RowTemplate.Height = 50;
            dgvListadoVentas.ColumnCount = 10;
            dgvListadoVentas.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvListadoVentas.Columns[0].Name = "# Venta";
            dgvListadoVentas.Columns[0].Width = 80;
            dgvListadoVentas.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvListadoVentas.Columns[1].Name = "Lado";                        
            dgvListadoVentas.Columns[1].Width = 80;
            dgvListadoVentas.Columns[2].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvListadoVentas.Columns[2].Name = "Manguera";
            dgvListadoVentas.Columns[2].Width = 100;
            dgvListadoVentas.Columns[3].Name = "IdCombustible";
            dgvListadoVentas.Columns[3].Width = 0;
            dgvListadoVentas.Columns[4].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);            
            dgvListadoVentas.Columns[4].Name = "Combustible";
            dgvListadoVentas.Columns[4].Width = 200;
            dgvListadoVentas.Columns[5].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);            
            dgvListadoVentas.Columns[5].Name = "Volumen";
            dgvListadoVentas.Columns[5].Width = 100;
            dgvListadoVentas.Columns[6].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvListadoVentas.Columns[6].Name = "Monto";
            dgvListadoVentas.Columns[6].Width = 100;
            dgvListadoVentas.Columns[7].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);            
            dgvListadoVentas.Columns[7].Name = "Fecha";
            dgvListadoVentas.Columns[7].Width = 120;
            dgvListadoVentas.Columns[8].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);            
            dgvListadoVentas.Columns[8].Name = "Hora";
            dgvListadoVentas.Columns[8].Width = 120;
            dgvListadoVentas.Columns[9].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);            
            dgvListadoVentas.Columns[9].Name = "sale_id";
            dgvListadoVentas.Columns[9].Width = 100;
            dgvListadoVentas.Columns[3].Visible = false;
            dgvListadoVentas.Columns[9].Visible = false;
            //Change cell font
            foreach (DataGridViewColumn c in dgvListadoVentas.Columns)
            {
                
                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
        }

        public frmListadoVentas()
        {
            InitializeComponent();
        }
        
        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            nudUltimasVentas.Value = 10;
            LlenarEncabezados();            
            CargarConfigListadoVenta();
            CargarUltimasVentas(Convert.ToInt32(nudBomba.Value),Convert.ToInt32(nudLado.Value));
        }

        private void dgvListadoVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            CargarUltimasVentas(Convert.ToInt32(nudBomba.Value), Convert.ToInt32(nudLado.Value));
        }

        private void dgvListadoVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListadoVentas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mdiSpirit.idTicketVenta = Convert.ToInt32(dgvListadoVentas.Rows[e.RowIndex].Cells[9].Value.ToString());
        }

        private void dgvListadoVentas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Imprimir(Convert.ToInt32(dgvListadoVentas.Rows[e.RowIndex].Cells[8].Value.ToString()));
        }

        private void frmListadoVentas_Deactivate(object sender, EventArgs e)
        {
            GuardarConfigListadoVenta();
        }

        private void tmrListadoVentas_Tick(object sender, EventArgs e)
        {
            CargarUltimasVentas(Convert.ToInt32(nudBomba.Value),Convert.ToInt32(nudLado.Value));
        }

        private void chkActualizar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkActualizar.Checked==true)
            {
                tmrListadoVentas.Interval = 5 * 1000;
                tmrListadoVentas.Enabled = true;
            }
            else
            {
                tmrListadoVentas.Enabled = false;
            }
        }

        //public void guardarDatos(int i)
        //{            
        //    DataGridViewRow row = dgvListadoVentas.Rows[i];
            
        //    venta.lado = Convert.ToInt32(row.Cells[1].Value);
        //    venta.manguera = Convert.ToInt32(row.Cells[2].Value);
        //    venta.combustible = row.Cells[4].Value.ToString();
        //    venta.volume = Convert.ToDouble(row.Cells[5].Value);
        //    venta.monto = Convert.ToDouble(row.Cells[6].Value);
        //    venta.fecha = row.Cells[7].Value.ToString();
        //    venta.hora = row.Cells[8].Value.ToString();                
        //}

        private void dgvListadoVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mdiSpirit.idTicketVenta = Convert.ToInt32(dgvListadoVentas.Rows[e.RowIndex].Cells[9].Value.ToString());
            Imprimir(Convert.ToInt32(dgvListadoVentas.Rows[e.RowIndex].Cells[9].Value.ToString()));                 
        }

        //Metodo evento que se ejecuta cuando se marca un nuemro del teclado numerico
        private void dgvListadoVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                //obtiene la informacion de cada celda y la gaurda en uan variable.
                Int32.TryParse(dgvListadoVentas.Rows[0].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[0].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[0].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[0].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[0].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[0].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[0].Cells[8].Value.ToString();
                       
                //llama a una ventana y cierra esta.
                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }

            if (e.KeyCode == Keys.NumPad1)
            {                
                Int32.TryParse(dgvListadoVentas.Rows[1].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[1].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[1].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[1].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[1].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[1].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[1].Cells[8].Value.ToString();

                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }

            if (e.KeyCode == Keys.NumPad2)
            {           
                Int32.TryParse(dgvListadoVentas.Rows[2].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[2].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[2].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[2].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[2].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[2].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[2].Cells[8].Value.ToString();

                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }

            if (e.KeyCode == Keys.NumPad3)
            {
                Int32.TryParse(dgvListadoVentas.Rows[3].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[3].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[3].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[3].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[3].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[3].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[3].Cells[8].Value.ToString();

                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }

            if (e.KeyCode == Keys.NumPad4)
            {               
                Int32.TryParse(dgvListadoVentas.Rows[4].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[4].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[4].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[4].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[4].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[4].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[4].Cells[8].Value.ToString();

                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }

            if (e.KeyCode == Keys.NumPad5)
            {
                Int32.TryParse(dgvListadoVentas.Rows[5].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[5].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[5].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[5].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[5].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[5].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[5].Cells[8].Value.ToString();

                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }

            if (e.KeyCode == Keys.NumPad6)
            {
                Int32.TryParse(dgvListadoVentas.Rows[6].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[6].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[6].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[6].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[6].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[6].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[6].Cells[8].Value.ToString();

                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }

            if (e.KeyCode == Keys.NumPad7)
            {
                Int32.TryParse(dgvListadoVentas.Rows[7].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                Int32.TryParse(dgvListadoVentas.Rows[7].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                frmRNCCliente.combustible = dgvListadoVentas.Rows[7].Cells[4].Value.ToString();
                Double.TryParse(dgvListadoVentas.Rows[7].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                Double.TryParse(dgvListadoVentas.Rows[7].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                frmRNCCliente.fecha = dgvListadoVentas.Rows[7].Cells[7].Value.ToString();
                frmRNCCliente.hora = dgvListadoVentas.Rows[7].Cells[8].Value.ToString();

                frmRealizarVenta form2 = new frmRealizarVenta();
                form2.MdiParent = this.ParentForm;
                form2.Show();
                this.Close();
            }
                if (e.KeyCode == Keys.NumPad8)
                {                    
                    Int32.TryParse(dgvListadoVentas.Rows[8].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                    Int32.TryParse(dgvListadoVentas.Rows[8].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                    frmRNCCliente.combustible = dgvListadoVentas.Rows[8].Cells[4].Value.ToString();
                    Double.TryParse(dgvListadoVentas.Rows[8].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                    Double.TryParse(dgvListadoVentas.Rows[8].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                    frmRNCCliente.fecha = dgvListadoVentas.Rows[8].Cells[7].Value.ToString();
                    frmRNCCliente.hora = dgvListadoVentas.Rows[8].Cells[8].Value.ToString();

                    frmRealizarVenta form2 = new frmRealizarVenta();
                    form2.MdiParent = this.ParentForm;
                    form2.Show();
                    this.Close();
                }

                if (e.KeyCode == Keys.NumPad9)
                {
                    Int32.TryParse(dgvListadoVentas.Rows[9].Cells[1].Value.ToString(), out frmRNCCliente.lado);
                    Int32.TryParse(dgvListadoVentas.Rows[9].Cells[2].Value.ToString(), out frmRNCCliente.manguera);
                    frmRNCCliente.combustible = dgvListadoVentas.Rows[9].Cells[4].Value.ToString();
                    Double.TryParse(dgvListadoVentas.Rows[9].Cells[5].Value.ToString(), out frmRNCCliente.volumen);
                    Double.TryParse(dgvListadoVentas.Rows[9].Cells[6].Value.ToString(), out frmRNCCliente.monto);
                    frmRNCCliente.fecha = dgvListadoVentas.Rows[9].Cells[7].Value.ToString();
                    frmRNCCliente.hora = dgvListadoVentas.Rows[9].Cells[8].Value.ToString();

                    frmRealizarVenta form2 = new frmRealizarVenta();
                    form2.MdiParent = this.ParentForm;
                    form2.Show();
                    this.Close();
                }            
        }       
    }
}
