using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace spirit.Formularios
{
    public partial class frmLogin : Form
    {
        public mdiSpirit fmdiSpirit = new mdiSpirit();
        public bool bLoginOk = false;
        public void EntradaSpirit()
        {
            if (ValidarLogin() == true)
            {    
                bLoginOk = true;
                spirit.Formularios.mdiSpirit.sUsuario = txtUsuario.Text;
                this.Close();                         
            }
            else
            {
                MessageBox.Show("Los datos de entrada son incorrectos.", "Trinity");
                txtClave.SelectAll();
                txtClave.Focus();
            }
        }
        public bool ValidarLogin()
        {
            //RijndaelManaged myRijndael = new RijndaelManaged();
            //myRijndael.GenerateKey();
            //myRijndael.GenerateIV();
            //Funciones.Cryption Cryption = new Funciones.Cryption(myRijndael.Key.ToString(), myRijndael.IV.ToString());
            //string sPrueba=Cryption.Encrypt("admin");
            
            DataSet dsUsuario = new DataSet();            
            dsUsuario = Data.queries.npgsDataSet(Data.procedures.ValidarUsuario(txtUsuario.Text,txtClave.Text));
            DataTable dtUsuario = new DataTable();
            dtUsuario = dsUsuario.Tables["Tabla"];
            if (dtUsuario.Rows.Count==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            EntradaSpirit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EntradaSpirit();
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EntradaSpirit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
