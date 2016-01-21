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
    public partial class frmDetalleTurnos : Form
    {
        private static frmDetalleTurnos m_FormDefInstance;
        public static frmDetalleTurnos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmDetalleTurnos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public frmDetalleTurnos()
        {
            InitializeComponent();
        }

        private void frmDetalleTurnos_Load(object sender, EventArgs e)
        {

        }
    }
}
