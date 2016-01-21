using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using ClosedXML.Excel;

namespace spirit.Formularios
{
    public partial class mdiSpirit : Form
    {
        public static string sFormulario="";
        public frmPrepago ffrmPrepago=new frmPrepago();
        public frmConsumoPrepago ffrmConsumoPrepago = new frmConsumoPrepago();
        public frmListadoVentas ffrmListadoVentas = new frmListadoVentas();
        public frmNCF ffrmNCF = new frmNCF();
        public static string sUsuario;
        private int childFormNumber = 0;
        public static Int32 idTicketVenta = 0;
        public static string sFechaInicioPeriodo;
        public static string sFechaFinPeriodo;
        public static string sHoraInicioPeriodo;
        public static string sHoraFinPeriodo;
        public static string sCodigoTurno;
        
        public mdiSpirit()
        {
            InitializeComponent();           
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if(sFormulario == "frmPrepago")
            {
                frmPrepago.DefInstance.Limpiar();
            }
            else if (sFormulario == "frmNCF")
            {
                frmNCF.DefInstance.Nuevo();
            }
            else if (sFormulario=="frmRol")
            {
                frmRol.DefInstance.Nuevo();
            }
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            //childForm.Show();
            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (sFormulario == "frmPrepago")
            {
                sFormulario="frmListadoCodigoBarra";
                frmPrepago.DefInstance.Buscar();
            }
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sFormulario = "frmPrepago";
            frmPrepago.DefInstance.MdiParent = this;
            frmPrepago.DefInstance.Show();
            /*ffrmPrepago = new frmPrepago();
            sFormulario = "frmPrepago";
            ffrmPrepago.MdiParent = this;
            ffrmPrepago.WindowState = FormWindowState.Normal;
            ffrmPrepago.Show();*/
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (sFormulario == "frmPrepago")
            {
                frmPrepago.DefInstance.Imprimir();
            }
            else if (sFormulario=="frmListadoCodigoBarra")
            {
                frmPrepago.DefInstance.ffrmListadoCodigoBarra.Imprimir();
            }
            else if (sFormulario == "frmListadoVentas")
            {
                frmListadoVentas.DefInstance.Imprimir(idTicketVenta);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (sFormulario == "frmPrepago")
            {
                frmPrepago.DefInstance.Registrar();
            }
            else if (sFormulario == "frmConsumoPrepago")
            {
                frmConsumoPrepago.DefInstance.GuardarConsumo();
            }
            else if (sFormulario == "frmNCF")
            {
                frmNCF.DefInstance.GuardarNCF();
            }
            else if (sFormulario=="frmRol")
            {
                frmRol.DefInstance.Guardar();
            }
        }

        private void mdiSpirit_Load(object sender, EventArgs e)
        {
                tsslUsuario.Text = "Usuario: " + spirit.Formularios.mdiSpirit.sUsuario;
                tsslFechaHora.Text ="Trinity - " + DateTime.Now.ToString();
                tsslVersion.Text ="Version - " + ConfigurationManager.AppSettings["version"];
                    
                //DataSet dsMenusUsuario = new DataSet();
                //dsMenusUsuario = Data.queries.npgsDataSet(Data.procedures.CargarMenusUsuario(sUsuario));
                //DataTable dtMenusUsuario = new DataTable();
                //dtMenusUsuario = dsMenusUsuario.Tables["Tabla"];
                //foreach (DataRow row in dtMenusUsuario.Rows)
                //{

                //    List<ToolStripMenuItem> myItems = new List<ToolStripMenuItem>();
                //    myItems = Funciones.GetAllMenuStripItems.GetItems(MainMenuStrip);
                //    foreach (ToolStripMenuItem menuItem in myItems)
                //    {
                //        //if (menuItem.Equals(row["Desc_Menu"].ToString()))
                //        if (row["Desc_Menu"].ToString() == menuItem.Name.ToString())
                //        {
                //            menuItem.Enabled = true;
                //        }
                //    }
                //}

            }

        public void exportarExcel()
        {            
            var wb = new XLWorkbook();

            DataSet dsExcel = new DataSet();
            dsExcel = Data.queries.npgsDataSet("Select * from ssf_facturas_comprobantes");
            DataTable dtExcel = new DataTable();
            dtExcel = dsExcel.Tables["Tabla"];

            wb.Worksheets.Add(dtExcel);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsm";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                 wb.SaveAs(sfd.FileName);
            }
        }

        private void optConsumoPrepago_Click(object sender, EventArgs e)
        {
            sFormulario = "frmConsumoPrepago";
            frmConsumoPrepago.DefInstance.MdiParent = this;
            frmConsumoPrepago.DefInstance.Show();
            /*ffrmConsumoPrepago = new frmConsumoPrepago();
            sFormulario = "frmConsumoPrepago";            
            ffrmConsumoPrepago.MdiParent = this;
            ffrmConsumoPrepago.WindowState = FormWindowState.Normal;
            ffrmConsumoPrepago.Show();*/
        }

        private void optListadoVentas_Click(object sender, EventArgs e)
        {
            Reportes.CrystalReportViewer.comprobador = 0;
            sFormulario = "frmListadoVentas";
            frmListadoVentas.DefInstance.MdiParent = this;
            frmListadoVentas.DefInstance.Show();
            /*ffrmListadoVentas = new frmListadoVentas();
            sFormulario = "frmListadoVentas";
            ffrmListadoVentas.MdiParent = this;
            ffrmListadoVentas.WindowState = FormWindowState.Normal;
            ffrmListadoVentas.Show();*/
        }

        private void optComprobanteFiscal_Click(object sender, EventArgs e)
        {
            sFormulario = "frmNCF";
            frmNCF.DefInstance.MdiParent = this;
            frmNCF.DefInstance.Show();
            /*ffrmNCF = new frmNCF();
            sFormulario = "frmNCF";
            ffrmNCF.MdiParent = this;
            ffrmNCF.WindowState = FormWindowState.Normal;
            ffrmNCF.Show();*/
        }

        private void optProbetas_Click(object sender, EventArgs e)
        {
            sFormulario = "frmTLS";
            frmTLS.DefInstance.MdiParent = this;
            frmTLS.DefInstance.Show();
        }

        private void optRoles_Click(object sender, EventArgs e)
        {
            sFormulario = "frmRol";
            frmRol.DefInstance.MdiParent = this;
            frmRol.DefInstance.Show();
        }

        private void optReporteTurnos_Click(object sender, EventArgs e)
        {
            Reportes.CrystalReportViewer.comprobador = 1;
            sFormulario = "frmReporteTurnos";
            frmReporteTurnos.DefInstance.MdiParent = this;
            frmReporteTurnos.DefInstance.Show();
        }

        private void btnReporteTurnos_Click(object sender, EventArgs e)
        {
            //sFormulario = "frmReporteTurnos";
            //frmReporteTurnos.DefInstance.MdiParent = this;
            //frmReporteTurnos.DefInstance.Show();
        }

        private void optCierrePeriodos_Click(object sender, EventArgs e)
        {
            //sFormulario = "frmPeriodo";
            //frmPeriodo.DefInstance.MdiParent = this;
            //frmPeriodo.DefInstance.Show();
        }

        private void optConsultarVentas_Click(object sender, EventArgs e){
            sFormulario = "frmCosultaVentas";
            frmConsultaVentas.DefInstance.MdiParent = this;
            frmConsultaVentas.DefInstance.Show();
        }

        private void actualzarBaseDeDatosRNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sFormulario = "fRMCargarRNC";
            frmCargarRNC.DefInstance.MdiParent = this;
            frmCargarRNC.DefInstance.Show();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exportarVentasConComprobanteAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportarExcel();
        }        
    }
}
