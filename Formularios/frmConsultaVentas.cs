using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using ClosedXML.Excel;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace spirit.Formularios
{
    public partial class frmConsultaVentas : Form
    {
        DataTable dtExcel = new DataTable();

        public frmConsultaVentas()
        {                     
            InitializeComponent(); 
            rellenarCheckedListBox();
            //Hacer que el DateTimePicker sirva solo como reloj.
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.ShowUpDown = true;
            //Establecer valores a los datetimepicker para la hora.
            dtpHoraInicio.Value = DateTime.Parse("00:00:00");
            //establecer los datetimepicker de fechas a fechas actuales
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
            dtpFechaFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            LlenarEncabezados();
        }

        private void frmConsultaVentas_Load(object sender, EventArgs e)
        {
                       
        }
        private static frmConsultaVentas m_FormeDefInstance;
        public static frmConsultaVentas DefInstance
        {
            get
            {
                if (m_FormeDefInstance == null || m_FormeDefInstance.IsDisposed)
                    m_FormeDefInstance = new frmConsultaVentas();
                return m_FormeDefInstance;
            }
            set
            {
                m_FormeDefInstance = value;
            }
        }        

        public void rellenarCheckedListBox()
        {
                              
            //Aqui se rellena el checkedListBox para presentar los surtidores a buscar.
            DataSet dsCheckListBoxSurtidores = new DataSet();
            dsCheckListBoxSurtidores = Data.queries.npgsDataSet(Data.procedures.buscarSurtidores());
            DataTable dtCheckListSurtidores = new DataTable();
            dtCheckListSurtidores = dsCheckListBoxSurtidores.Tables["Tabla"];
            
            
            foreach (DataRow row in dtCheckListSurtidores.Rows)
            {
                clbSurtidores.Items.Add(row["hose_desc"].ToString());
            }

            //Aqui se rellena el datagridview que presentan los productos
            DataSet dsProductos = new DataSet();
            dsProductos = Data.queries.npgsDataSet(Data.procedures.buscarIDProdcuto());
            DataTable dtProductos = new DataTable();
            dtProductos = dsProductos.Tables["Tabla"];
            dataGridView1.Rows.Clear();

            foreach(DataRow row in dtProductos.Rows){
                dataGridView1.Rows.Add(0,row["tkt_plu_id"],row["tkt_plu_long_desc"]);
            }
        }


        public void buscarVentas()
        {               
            string fechaInicio, fechaFin, horaInicio, horaFin;

            //Convertir al formato de Postgres
            fechaInicio = Funciones.Helper.convertirFechaPSQL(dtpFechaInicio.Value.ToString());
            fechaFin = Funciones.Helper.convertirFechaPSQL(dtpFechaFin.Value.ToString());
            horaInicio = Funciones.Helper.convertirHoraFormatoPSLQ(dtpHoraInicio.Value.ToLongTimeString());
            horaFin = Funciones.Helper.convertirHoraFormatoPSLQ(dtpHoraFin.Value.ToLongTimeString());
            
            string sWhere = " where sps.grade_id=stpg.tkt_grade_id and stpg.tkt_plu_id=stp.tkt_plu_id ";
            string strSurtidores = "(";
            string strProductos = "(";
            int dgvCuenta = dataGridView1.RowCount;

            if (cbFechaHora.Checked == true)
            {
                sWhere = sWhere + " and (sps.start_date || ' ' || sps.start_time) >= '" + fechaInicio + " " + horaInicio + "' "
                        + " and (sps.end_date || ' ' || sps.end_time) <= '" + fechaFin + " " + horaFin + "' ";
            }

            if (clbSurtidores.CheckedIndices.Count > 0)
            {

                foreach (var indexChecked in clbSurtidores.CheckedIndices)
                {
                    strSurtidores = strSurtidores + (Convert.ToInt32(indexChecked) + 1).ToString() + ",";
                }
                strSurtidores = strSurtidores.Substring(0, strSurtidores.Length - 1) + ")";
                sWhere = sWhere + " and sps.pump_id in " + strSurtidores;
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Elegir"].Value) != false)
                {
                    dgvCuenta++;
                    strProductos = strProductos + dataGridView1.Rows[i].Cells["ID"].Value.ToString() + ",";
                }
            }
            strProductos = strProductos.Substring(0, strProductos.Length - 1) + ")";
            if (strProductos != ")")
            {
                sWhere = sWhere + " and sps.grade_id in " + strProductos;
            }
           
           
            DataSet dsVentas = new DataSet();
            dsVentas = Data.queries.npgsDataSet(Data.procedures.consultarVentas(sWhere));
            DataTable dtVentas = new DataTable();
            dtVentas = dsVentas.Tables["Tabla"];
            dgvVentas.Rows.Clear();

            dtExcel = dtVentas;

            double totalMonto = 0;
            double totalVolumen = 0;
            foreach (DataRow row in dtVentas.Rows)
            {
                
                double total = Convert.ToDouble(row["volume"]) * Convert.ToDouble(row["ppu"]);

                totalMonto = totalMonto + total;
                totalVolumen = totalVolumen + Convert.ToDouble(row["volume"]);
               
                dgvVentas.Rows.Add(Funciones.Helper.convertirFechaFormatoApp(row["end_date"].ToString()), 
                                   Funciones.Helper.convertirHoraFormatoApp(row["end_time"].ToString()),
                                   row["pump_id"], row["tkt_plu_long_desc"], Convert.ToDouble(row["volume"]).ToString("###########0.##0"), Convert.ToDouble(row["ppu"]).ToString("############.##0"), total.ToString("###########0.##0"));                                
            }
            totalMonto = Math.Round(totalMonto, 3);
            totalVolumen = Math.Round(totalVolumen, 4);
            txtTotalMonto.Text = totalMonto.ToString("############.##0");
            txtTotalVolumen.Text = totalVolumen.ToString("############.##0");
            txtCantDesp.Text = (dgvVentas.RowCount - 1).ToString();

            foreach (DataGridViewColumn c in dgvVentas.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.5F, GraphicsUnit.Pixel);
            }
        }

        public void LlenarEncabezados()
        {
            dgvVentas.RowTemplate.Height = 40;
            dgvVentas.ColumnCount = 7;
            dgvVentas.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvVentas.Columns[0].Name = "Fecha";
            dgvVentas.Columns[0].Width = 135;
            dgvVentas.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvVentas.Columns[1].Name = "Hora";
            dgvVentas.Columns[1].Width = 125;
            dgvVentas.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvVentas.Columns[2].Name = "Surtidor";
            dgvVentas.Columns[2].Width = 125;
            dgvVentas.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvVentas.Columns[3].Name = "Producto";
            dgvVentas.Columns[3].Width = 125;
            dgvVentas.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvVentas.Columns[4].Name = "Volumen";
            dgvVentas.Columns[4].Width = 125;
            dgvVentas.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvVentas.Columns[5].Name = "Precio";
            dgvVentas.Columns[5].Width = 125;
            dgvVentas.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvVentas.Columns[6].Name = "Monto Total";
            dgvVentas.Columns[6].Width = 125;
            //Change cell font
            foreach (DataGridViewColumn c in dgvVentas.Columns)
            {

                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 30.5F, GraphicsUnit.Pixel);
            }
        }

        //Metodo para enviar los datos a formato CSV para que puedan ser exportados a Excel.
        public void importarDataGridViewAexcel(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dgvVentas.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            stOutput = stOutput +"" +""+ "\r\n"+"Totales:";
            stOutput = stOutput + "" + "" + "\r\n" + "Total Monto: " + txtTotalMonto.Text;
            stOutput = stOutput + "" + "" + "\r\n" + "Cantidad de Despacho: " + txtCantDesp.Text;
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
            
        }

        //Metodo para exportar datos a Excel ya procesados como CSV.
        public void generarExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                importarDataGridViewAexcel(dgvVentas, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }

        private void frmConsultaVentas_Load_1(object sender, EventArgs e)
        {

        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            buscarVentas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generarExcel();
        }
    }   
}
