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
    public partial class frmTLS : Form
    {
        public int iIdProbeta = 0;
        private static frmTLS m_FormDefInstance;
        public static frmTLS DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmTLS();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public void Nuevo()
        {
            txtValorMaximo.Text = "";
            txtProductHeight.Text = "";
            txtWaterHeight.Text = "";
            txtTemperature.Text = "";
            txtProductVolume.Text = "";
            txtWaterVolume.Text = "";
            txtProductUllage.Text = "";
            txtProductTCVolume.Text = "";
            txtProductMass.Text = "";
            txtProductDensity.Text = "";           
        }

        public void LlenarEncabezados()
        {
            dgvTLS.RowTemplate.Height = 50;
            dgvTLS.ColumnCount = 10;
            dgvTLS.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[0].Name = "Probeta";
            dgvTLS.Columns[0].Width = 100;
            dgvTLS.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[1].Name = "ProductHeight";
            dgvTLS.Columns[1].Width = 150;
            dgvTLS.Columns[2].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[2].Name = "WaterHeight";
            dgvTLS.Columns[2].Width = 150;
            dgvTLS.Columns[3].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[3].Name = "Temperature";
            dgvTLS.Columns[3].Width = 150;
            dgvTLS.Columns[4].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[4].Name = "ProductVolume";
            dgvTLS.Columns[4].Width = 150;
            dgvTLS.Columns[5].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[5].Name = "WaterVolume";
            dgvTLS.Columns[5].Width = 150;
            dgvTLS.Columns[6].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[6].Name = "ProductUllage";
            dgvTLS.Columns[6].Width = 150;
            dgvTLS.Columns[7].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[7].Name = "ProductTCVolume";
            dgvTLS.Columns[7].Width = 180;
            dgvTLS.Columns[8].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[8].Name = "ProductDensity";
            dgvTLS.Columns[8].Width = 150;
            dgvTLS.Columns[9].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvTLS.Columns[9].Name = "ProductMass";
            dgvTLS.Columns[9].Width = 150;
            //Change cell font
            foreach (DataGridViewColumn c in dgvTLS.Columns)
            {

                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
        }

        public void CargarDatosTLS()
        {
            DataSet dsTLS = new DataSet();
            dsTLS = Data.queries.npgsDataSet(Data.procedures.CargarDatosTLS(Data.DateHelper.GetFormattedDate(dtpTLS.Value)));

            DataTable dtTLS = new DataTable();
            dtTLS = dsTLS.Tables["Tabla"];
            dgvTLS.Rows.Clear();
            foreach (DataRow drFila in dtTLS.Rows)
            {
                dgvTLS.Rows.Add(drFila["tls_id"].ToString(), drFila["productheight"].ToString(), drFila["waterheight"].ToString(), drFila["temperature"].ToString(), drFila["productvolume"].ToString(), drFila["watervolume"].ToString(), drFila["productullage"].ToString(), drFila["producttcvolume"].ToString(), drFila["productdensity"].ToString(), drFila["productmass"].ToString());                
            }
            //tankControl1.MaxValue=1;
            //tankControl1.setValue(1);
        }

        public frmTLS()
        {
            InitializeComponent();
        }

        private void frmTLS_Load(object sender, EventArgs e)
        {
            dtpTLS.Value = DateTime.Today;
            tmrTLS.Interval = Convert.ToInt32(nudTLS.Value) * 1000;
            LlenarEncabezados();
            CargarDatosTLS();
            //pgbTLS.Maximum = 0;
            //pgbTLS.Minimum = 0;
            //pgbTLS.Step = 0;
            //pgbTLS.Value = 0;
        }

        private void nudTLS_ValueChanged(object sender, EventArgs e)
        {
            tmrTLS.Interval = Convert.ToInt32(nudTLS.Value) * 1000;
        }

        private void tmrTLS_Tick(object sender, EventArgs e)
        {
            CargarDatosTLS();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int iResultado;
            double dMaxValue;
            if (double.TryParse(txtValorMaximo.Text, out dMaxValue) == false)
            {
                MessageBox.Show("El valor maximo digitado es invalido.", this.Text);
                return;
            }
            DataSet dsTLS = new DataSet();
            dsTLS = Data.queries.npgsDataSet(Data.procedures.BuscarMaxValueProbeta(iIdProbeta));

            DataTable dtTLS = new DataTable();
            dtTLS = dsTLS.Tables["Tabla"];
            if (dtTLS.Rows.Count > 0)
            {
                iResultado = Data.queries.Execute(Data.procedures.UpdateMaxValueProbeta(iIdProbeta, dMaxValue));
            }
            else
            {
                iResultado = Data.queries.Execute(Data.procedures.InsertMaxValueProbeta(iIdProbeta, dMaxValue));
            }
            //tankControl1.MaxValue = Convert.ToDouble(txtValorMaximo.Text);
            //tankControl1.setValue(Convert.ToDouble(txtProductHeight.Text));
            MessageBox.Show("Actualizado!.",this.Text);
        }

        private void dgvTLS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dgvTLS_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvTLS_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iValorMaximo;
            int iProductHeight;
            string sPorciento;
            double dPorciento;
            Nuevo();
            iIdProbeta = Convert.ToInt32(dgvTLS.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataSet dsTLS = new DataSet();
            dsTLS = Data.queries.npgsDataSet(Data.procedures.BuscarMaxValueProbeta(iIdProbeta));

            DataTable dtTLS = new DataTable();
            dtTLS = dsTLS.Tables["Tabla"];
            if (dtTLS.Rows.Count > 0)
            {
                foreach(DataRow dr in dtTLS.Rows)
                {
                    txtValorMaximo.Text = dr["valormaximo"].ToString();
                }
            }
            else
            {
                txtValorMaximo.Text = "0";
            }
            
            txtProductHeight.Text = dgvTLS.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtWaterHeight.Text = dgvTLS.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTemperature.Text = dgvTLS.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtProductVolume.Text = dgvTLS.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtWaterVolume.Text = dgvTLS.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProductUllage.Text = dgvTLS.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtProductTCVolume.Text = dgvTLS.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtProductDensity.Text = dgvTLS.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtProductMass.Text= dgvTLS.Rows[e.RowIndex].Cells[9].Value.ToString();
            if (txtValorMaximo.Text=="0")
            {
                //pgbTLS.Minimum = 0;
                //pgbTLS.Step = 0;
                //pgbTLS.Value = 0; 
            }
            else
            {
                iValorMaximo = Convert.ToInt32(Math.Round(Convert.ToDecimal(txtValorMaximo.Text), 2));
                pgbTLS.Maximum =   iValorMaximo;
                pgbTLS.Minimum = 1;
                pgbTLS.Step = 1;
                iProductHeight = Convert.ToInt32(Math.Round(Convert.ToDecimal(txtProductHeight.Text), 2));
                pgbTLS.Value = iProductHeight;
                dPorciento = Math.Round(((Convert.ToDouble(txtProductHeight.Text) / Convert.ToDouble(txtValorMaximo.Text)) * 100),2);
                sPorciento = dPorciento.ToString();
                lblPorciento.Text = sPorciento + "%";
                
            }
            //txtValorMaximo.Focus();
        }

        private void dgvTLS_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
