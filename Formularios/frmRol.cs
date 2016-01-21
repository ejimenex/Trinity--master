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
    public partial class frmRol : Form
    {
        public int iCodigoRol=0;
        public int iCodigoMenu = 0;

        private static frmRol m_FormDefInstance;
        public static frmRol DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmRol();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public frmRol()
        {
            InitializeComponent();
        }

        public void LlenarComboRoles()
        {
            DataSet dsRol = new DataSet();
            dsRol = Data.queries.npgsDataSet(Data.procedures.BuscarRoles());
            DataTable dtRol = new DataTable();
            dtRol = dsRol.Tables["Tabla"];
            cboRol.ValueMember = "id_rol";
            cboRol.DisplayMember = "desc_rol";
            cboRol.DataSource = dtRol;
        }

        public void LlenarEncabezados()
        {
            dgvRol.RowTemplate.Height = 50;
            dgvRol.ColumnCount = 2;
            dgvRol.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvRol.Columns[0].Name = "Codigo";
            dgvRol.Columns[0].Width = 100;
            dgvRol.Columns[0].Visible = false;
            dgvRol.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvRol.Columns[1].Name = "Rol";
            dgvRol.Columns[1].Width = 250;
            //Change cell font
            foreach (DataGridViewColumn c in dgvRol.Columns)
            {

                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
        }

        public void LlenarAsignados()
        {
            dgvAsignados.RowTemplate.Height = 50;
            dgvAsignados.ColumnCount = 2;
            dgvAsignados.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvAsignados.Columns[0].Name = "Codigo";
            dgvAsignados.Columns[0].Width = 100;
            dgvAsignados.Columns[0].Visible = false;
            dgvAsignados.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvAsignados.Columns[1].Name = "Menu";
            dgvAsignados.Columns[1].Width = 300;
            //Change cell font
            foreach (DataGridViewColumn c in dgvRol.Columns)
            {

                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
        }

        public void LlenarDisponibles()
        {
            dgvDisponibles.RowTemplate.Height = 50;
            dgvDisponibles.ColumnCount = 2;
            dgvDisponibles.Columns[0].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvDisponibles.Columns[0].Name = "Codigo";
            dgvDisponibles.Columns[0].Width = 100;
            dgvDisponibles.Columns[0].Visible = false;
            dgvDisponibles.Columns[1].HeaderCell.Style.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            dgvDisponibles.Columns[1].Name = "Menu";
            dgvDisponibles.Columns[1].Width = 300;
            //Change cell font
            foreach (DataGridViewColumn c in dgvRol.Columns)
            {

                c.DefaultCellStyle.Font = new Font("Arial", 18.5F, GraphicsUnit.Pixel);
            }
        }

        public void CargarRoles()
        {
            DataSet dsRol = new DataSet();
            dsRol = Data.queries.npgsDataSet(Data.procedures.BuscarRoles());
            DataTable dtRol = new DataTable();
            dtRol = dsRol.Tables["Tabla"];
            dgvRol.Rows.Clear();
            foreach(DataRow drFila in dtRol.Rows)
            {
                dgvRol.Rows.Add(drFila["id_rol"], drFila["desc_rol"]);
            }
        }

        public void Nuevo()
        {
            cboRol.Text = "";
            cboRol.SelectedIndex = -1;
            dgvAsignados.Rows.Clear();
            dgvDisponibles.Rows.Clear();
            txtRol.Text = "";
            iCodigoRol = 0;
        }

        public void Guardar()
        {
            int iResultado = 0;
            if(string.IsNullOrEmpty(txtRol.Text))
            {
                MessageBox.Show("Debe digitar el nombre del rol.", this.Text);
                return;
            }
           
            DataSet dsRol = new DataSet();
            dsRol = Data.queries.npgsDataSet(Data.procedures.BuscarRol(iCodigoRol));
            DataTable dtRol = new DataTable();
            dtRol = dsRol.Tables["Tabla"];
            if(dtRol.Rows.Count>0)
            { 
                iResultado=Data.queries.Execute(Data.procedures.UpdateRol(iCodigoRol,txtRol.Text,spirit.Formularios.mdiSpirit.sUsuario,Data.DateHelper.GetFormattedDate(DateTime.Now)));
            }
            else
            {
                DataSet dsMaxRol = new DataSet();
                dsMaxRol = Data.queries.npgsDataSet(Data.procedures.MaxCodigoRol());
                DataTable dtMaxRol = new DataTable();
                dtMaxRol = dsMaxRol.Tables["Tabla"];
                foreach(DataRow drFila in dtMaxRol.Rows)
                {
                    iCodigoRol=Convert.ToInt32(drFila["id_rol"])+1;
                }
                iResultado = Data.queries.Execute(Data.procedures.InsertRol(iCodigoRol, txtRol.Text, spirit.Formularios.mdiSpirit.sUsuario, Data.DateHelper.GetFormattedDate(DateTime.Now)));
            }
            CargarRoles();
            Nuevo();
            LlenarComboRoles();
        }

        public void CargarRolMenus()
        {
            if (cboRol.SelectedIndex > -1)
            {
                DataSet dsRol = new DataSet();
                dsRol = Data.queries.npgsDataSet(Data.procedures.RolMenusAsignados(Convert.ToInt32(cboRol.SelectedValue)));
                DataTable dtRol = new DataTable();
                dtRol = dsRol.Tables["Tabla"];
                dgvAsignados.Rows.Clear();
                foreach (DataRow drFila in dtRol.Rows)
                {
                    dgvAsignados.Rows.Add(drFila["id_menu"], drFila["nombre_menu"]);
                }
            }
        }

        public void CargarMenusDisponibles()
        {
            if (cboRol.SelectedIndex > -1)
            {
                DataSet dsRol = new DataSet();
                dsRol = Data.queries.npgsDataSet(Data.procedures.RolMenusDisponibles(Convert.ToInt32(cboRol.SelectedValue)));
                DataTable dtRol = new DataTable();
                dtRol = dsRol.Tables["Tabla"];
                dgvDisponibles.Rows.Clear();
                foreach (DataRow drFila in dtRol.Rows)
                {
                    dgvDisponibles.Rows.Add(drFila["id_menu"], drFila["nombre_menu"]);
                }
            }
        }

        public void BorrarRolMenu(int iIdRol,int iIdMenu)
        {
            int iResultado;
            iResultado = Data.queries.Execute(Data.procedures.BorrarRolMenu(iIdRol,iIdMenu));
        }

        public void AgregarRolMenu(int iIdRol,int iIdMenu,string sIdUsuario,string sFecha)
        {
            int iResultado;
            iResultado = Data.queries.Execute(Data.procedures.InsertarRolMenu(iIdRol, iIdMenu,sIdUsuario,sFecha));
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            LlenarComboRoles();            
            LlenarEncabezados();
            CargarRoles();
            txtRol.Focus();
        }

        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iCodigoRol = Convert.ToInt32(dgvRol.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtRol.Text = dgvRol.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRol.Focus();
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarAsignados();
            CargarRolMenus();
            LlenarDisponibles();
            CargarMenusDisponibles();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(iCodigoMenu>0 && cboRol.SelectedIndex>-1)
            {
                BorrarRolMenu(Convert.ToInt32(cboRol.SelectedValue), iCodigoMenu);
            }
            LlenarAsignados();
            CargarRolMenus();
            LlenarDisponibles();
            CargarMenusDisponibles();
        }

        private void dgvAsignados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iCodigoMenu = Convert.ToInt32(dgvAsignados.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dgvDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iCodigoMenu = Convert.ToInt32(dgvDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (iCodigoMenu > 0 && cboRol.SelectedIndex > -1)
            {
                AgregarRolMenu(Convert.ToInt32(cboRol.SelectedValue), iCodigoMenu, spirit.Formularios.mdiSpirit.sUsuario, Data.DateHelper.GetFormattedDate(DateTime.Now));
            }
            LlenarAsignados();
            CargarRolMenus();
            LlenarDisponibles();
            CargarMenusDisponibles();
        }
    }
}
