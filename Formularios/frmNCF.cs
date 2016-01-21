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
    public partial class frmNCF : Form
    {
        private static frmNCF m_FormDefInstance;
        public static frmNCF DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmNCF();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public frmNCF()
        {
            InitializeComponent();
        }

        public bool isInt32(String num)
        {
            try
            {
                Int32.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo para buscar el NCF correspondiente segun el tipo que se elija en el ComboBox
        public void BuscarNCF()
        {
            DataSet dsDatosNCF = new DataSet();
            dsDatosNCF = Data.queries.npgsDataSet(Data.procedures.BuscarNFC(cbTipoComprobante.Text));
            DataTable dtDatosNCF = new DataTable();
            dtDatosNCF = dsDatosNCF.Tables["Tabla"];
            if (dtDatosNCF.Rows.Count > 0)
            {
                foreach (DataRow drFila in dtDatosNCF.Rows)
                {                    
                    txtPrefijo.Text = drFila["prefijo"].ToString();
                    txtDesde.Text = drFila["desde"].ToString();
                    txtHasta.Text = drFila["hasta"].ToString();
                    txtConsecutivo.Text = drFila["consecutivo"].ToString();
                    txtFecha.Text = drFila["fecha"].ToString();
                    txtUsuario.Text = drFila["id_usuario"].ToString();
                    cbTipoComprobante.Text = drFila["descripcion"].ToString();
                    txtPrefijo.Focus();
                }
                noNCF.Text = txtPrefijo.Text + txtConsecutivo.Text.PadLeft(8, '0').ToString();
            }
        }

        public void Nuevo()
        {
            txtConsecutivo.Text = "";            
            txtDesde.Text = "";
            txtHasta.Text = "";
            txtPrefijo.Text = "";
            txtUsuario.Text = "";
            txtFecha.Text = "";
            noNCF.Text = "";
            txtPrefijo.Focus();
        }

        public void GuardarNCF()
        {
            Int32 iResultado;
            if(txtPrefijo.Text=="")
            {
                MessageBox.Show("Debe registrar el codigo prefijo.","Numero de Comprobante Fiscal");
                return;
            }
            if(txtPrefijo.Text.Length!=11)
            {
                MessageBox.Show("El codigo prefijo debe tener 11 digitos.", "Numero de Comprobante Fiscal");
                return;
            }
            //if (txtDescripcion.Text == "")
            //{
            //    MessageBox.Show("Debe registrar la descripcion.", "Numero de Comprobante Fiscal");
            //    return;
            //}
            if (txtDesde.Text=="")
            {
                MessageBox.Show("Debe registrar el valor desde.", "Numero de Comprobante Fiscal");
                return;
            }
            if(isInt32(txtDesde.Text)==false)
            {
                MessageBox.Show("El valor desde debe ser numerico.", "Numero de Comprobante Fiscal");
                return;
            }
            if (txtHasta.Text == "")
            {
                MessageBox.Show("Debe registrar el valor hasta.", "Numero de Comprobante Fiscal");
                return;
            }
            if (isInt32(txtHasta.Text) == false)
            {
                MessageBox.Show("El valor hasta debe ser numerico.", "Numero de Comprobante Fiscal");
                return;
            }
            if (isInt32(txtConsecutivo.Text) == false)
            {
                MessageBox.Show("El valor consecutivo debe ser numerico.", "Numero de Comprobante Fiscal");
                return;
            }
                        
            DataSet dsDatosNCF = new DataSet();
            dsDatosNCF = Data.queries.npgsDataSet(Data.procedures.BuscarNFC(cbTipoComprobante.Text));
            DataTable dtDatosNCF = new DataTable();
            dtDatosNCF = dsDatosNCF.Tables["Tabla"];
            if (dtDatosNCF.Rows.Count > 0)
            {
                iResultado = Data.queries.Execute(Data.procedures.UpdateNCF(txtPrefijo.Text,Convert.ToInt32(txtDesde.Text),Convert.ToInt32(txtHasta.Text),spirit.Formularios.mdiSpirit.sUsuario,Data.DateHelper.GetFormattedDate(DateTime.Now),DateTime.Now.ToString("hhmmss"),Convert.ToInt32(txtConsecutivo.Text)));
                //Se inserta una copia de lo que se actualizo arriba en la tabal de backup de ventas con comprobantes
                iResultado = Data.queries.Execute(Data.procedures.insertarNCFcopia(txtPrefijo.Text, cbTipoComprobante.Text, Convert.ToInt32(txtDesde.Text), Convert.ToInt32(txtHasta.Text), spirit.Formularios.mdiSpirit.sUsuario, Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), Convert.ToInt32(txtConsecutivo.Text), obtenerCodigoNCF()));
            }
            else{                
                iResultado = Data.queries.Execute(Data.procedures.InsertNCF(txtPrefijo.Text, cbTipoComprobante.Text, Convert.ToInt32(txtDesde.Text), Convert.ToInt32(txtHasta.Text), spirit.Formularios.mdiSpirit.sUsuario, Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), Convert.ToInt32(txtConsecutivo.Text), obtenerCodigoNCF()));
                //Se inserta una copia de lo que se inserto arriba en la tabal de backup de ventas con comprobantes
                iResultado = Data.queries.Execute(Data.procedures.insertarNCFcopia(txtPrefijo.Text, cbTipoComprobante.Text, Convert.ToInt32(txtDesde.Text), Convert.ToInt32(txtHasta.Text), spirit.Formularios.mdiSpirit.sUsuario, Data.DateHelper.GetFormattedDate(DateTime.Now), DateTime.Now.ToString("hhmmss"), Convert.ToInt32(txtConsecutivo.Text), obtenerCodigoNCF()));
            }
            MessageBox.Show("El registro de comprobante ha sido guardado de forma satisfactoria.", this.Text);
            this.Nuevo();
        }

        private void frmNCF_Load(object sender, EventArgs e)
        {

        }

        //private void txtPrefijo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(e.KeyChar==(char)13)
        //    {
        //        BuscarNCF();
        //    }
        //}

        private void cbTipoComprobante_TextChanged(object sender, EventArgs e)
        {

        }

        //Metodo evento que llama al metodo BUSCARncf() al cambiar de item en el combobox
        private void cbTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarNCF();
        }

        //Metodo para obtener el codigo tipo del comprobaste fiscal segun el tipo de comprobante que se seleccione en el combobox
        public string obtenerCodigoNCF()
        {
            if (cbTipoComprobante.Text.Equals("01 Facturas que Generan Crédito y Sustentan Costos y/o Gastos"))
            {
                return "01";
            }
            if (cbTipoComprobante.Text.Equals("02 Facturas para Consumidores Finales"))
            {
                return "02";
            }
            if (cbTipoComprobante.Text.Equals("03 Nota de Débito"))
            {
                return "03";
            }
            if (cbTipoComprobante.Text.Equals("04 Nota de Crédito"))
            {
                return "04";
            }
            if (cbTipoComprobante.Text.Equals("11 Proveedores Informales"))
            {
                return "11";
            }
            if (cbTipoComprobante.Text.Equals("12 Registro Único de Ingresos"))
            {
                return "12";
            }
            if (cbTipoComprobante.Text.Equals("13 Gastos Menores"))
            {
                return "13";
            }
            if (cbTipoComprobante.Text.Equals("14 Regímenes Especiales de Tributación"))
            {
                return "14";
            }
            return "15";
        }
    }
}
