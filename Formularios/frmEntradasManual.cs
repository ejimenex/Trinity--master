using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace spirit.Formularios
{
    public partial class frmEntradasManual : Form
    {
        public frmEntradasManual()
        {
            InitializeComponent();
          
        }

        private void CargarDgvProductos()
        {
            DataSet dsProductos = new DataSet();
            dsProductos = Data.queries.npgsDataSet(Data.procedures.Cargar_ssf_tkt_plu());

            DataTable dtProductos = new DataTable();
            dtProductos = dsProductos.Tables["Tabla"];
            
            dgvEntradaManual.Rows.Clear();
            
            foreach(DataRow fila in dtProductos.Rows){
                dgvEntradaManual.Rows.Add(fila["tkt_plu_long_desc"].ToString(), fila["tkt_plu_id"].ToString(), null, null);
              }

            foreach(DataGridViewRow row in dgvEntradaManual.Rows){
                row.Cells[1].ReadOnly = false;
            }
       
             
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int turno;
            bool codigoTurnoCorrecto = int.TryParse(txtTurno.Text, out turno);
            if (codigoTurnoCorrecto && TurnoExiste(turno))
            {
                CargarDgvProductos();
            }
            else
            {
                txtTurno.Text = string.Empty;
                MessageBox.Show("El numero de turno no es valido");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           if(!ValidarCampos()){return;};

               decimal monto_efectivo = 0;
               decimal monto_tarjeta = 0;
               decimal monto_prepago = 0;
               decimal monto_credito = 0;

           int ssf_addin_shifts_data_periodo_id = int.Parse(txtTurno.Text);
            if(txtEfectivo.Text !=null)
                 monto_efectivo =  decimal.Parse(txtEfectivo.Text);
            if (txtTarjeta.Text != null)
                 monto_tarjeta = decimal.Parse(txtTarjeta.Text);
            if (txtPrepago.Text != null)
                 monto_prepago = decimal.Parse(txtPrepago.Text);
            if (txtCredito.Text != null)
                 monto_credito = decimal.Parse(txtCredito.Text);



            Data.queries.npgsDataSet(Data.procedures.EliminarDesgloseEntradaManualPorTurnoId(ssf_addin_shifts_data_periodo_id));
             Data.queries.npgsDataSet(Data.procedures.GuardarEntradaManual(ssf_addin_shifts_data_periodo_id, monto_efectivo, monto_tarjeta, monto_prepago, monto_credito));
             Data.queries.npgsDataSet(Data.procedures.EliminarDetalleEntradaManualPorTurnoId(ssf_addin_shifts_data_periodo_id));
             foreach (DataGridViewRow dr in dgvEntradaManual.Rows)
             {

                 int idProducto = 0;
                 decimal galones = 0;
                 decimal altura = 0;
               
                  
                   string producto =  dr.Cells["Producto"].Value.ToString();
                   int.TryParse(dr.Cells["IdProducto"].Value.ToString(), out idProducto);
                 decimal.TryParse(dr.Cells["Galones"].Value !=null? dr.Cells["Galones"].Value.ToString():"" ,out galones);
                 decimal.TryParse(dr.Cells["Altura"].Value !=null? dr.Cells["Altura"].Value.ToString():"",out altura);


                 Data.queries.npgsDataSet(Data.procedures.InsertarDetalle_entrada_manual(ssf_addin_shifts_data_periodo_id, galones, altura, idProducto, producto));
            }
             MessageBox.Show("Registro Guardado");
        }

        private bool ValidarCampos()
        {
            decimal outValue;
            int turno;
             
            if (!int.TryParse(txtTurno.Text, out turno))
            {
                MessageBox.Show("El campo 'Turno' debe ser un numero valido");
                return false;
            }

            if (!TurnoExiste(turno))
            {
                MessageBox.Show("El turno registrado no es valido");
                return false;
            }

            if (txtCredito.Text != "" && !decimal.TryParse(txtCredito.Text, out outValue))
            {
                MessageBox.Show("El campo 'Credito' debe ser un numero");
                return false;
            }
            if (txtEfectivo.Text != "" && !decimal.TryParse(txtEfectivo.Text, out outValue))
            {
                MessageBox.Show("El campo 'Efectivo' debe ser un numero");
                return false;
            }
            if (txtTarjeta.Text != "" && !decimal.TryParse(txtTarjeta.Text, out outValue))
            {
                MessageBox.Show("El campo 'Tarjeta' debe ser un numero");
                return false;
            }
            if (txtPrepago.Text != "" && !decimal.TryParse(txtPrepago.Text, out outValue))
            {
                MessageBox.Show("El campo 'Prepago' debe ser un numero");
                return false;
            }
           
            return true;
        }

        public bool TurnoExiste(int turno)
        {
            DataSet dsSsf_addin_shifts_data = new DataSet();
            dsSsf_addin_shifts_data = Data.queries.npgsDataSet(Data.procedures.Buscarssf_addin_shifts_dataPorPeriodo(turno));
            DataTable dtSsf_addin_shifts_data = new DataTable();
            dtSsf_addin_shifts_data = dsSsf_addin_shifts_data.Tables["Tabla"];
            if (dtSsf_addin_shifts_data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        
         
    }
}
