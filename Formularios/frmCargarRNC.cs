using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace spirit.Formularios
{
    public partial class frmCargarRNC : Form
    {
        //Thread t;
      
        public frmCargarRNC()
        {
            InitializeComponent();
            //t = new Thread(cargarRNC);
            
        }

        private static frmCargarRNC m_FormeDefInstance;

        public static frmCargarRNC DefInstance
        {
            get
            {
                if (m_FormeDefInstance == null || m_FormeDefInstance.IsDisposed)
                    m_FormeDefInstance = new frmCargarRNC();
                return m_FormeDefInstance;
            }
            set
            {
                m_FormeDefInstance = value;
            }
        }  

        //[STAThread]
        //static void Main()
        //{
        //    //Application.EnableVisualStyles();
        //    //Application.SetCompatibleTextRenderingDefault(false);
        //    Thread.CurrentThread.ApartmentState = ApartmentState.STA;
        //    Application.Run(new frmCargarRNC());
        //}
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            //t.IsBackground = true;
            //t.Start();
            cargarRNC();           
        }

        public void cargarRNC()
        {            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
            
            
            string linea;
            int conteo;
            openFileDialog1.ShowDialog();                        
            //DataSet dsRNC = new DataSet();
            
            //    using (  StreamReader archivo = new StreamReader(openFileDialog1.FileName)) {
            //        while ((linea = archivo.ReadLine()) != null)
            //        {
            //        String[] strCampos = linea.Split('|');
            //        dsRNC = Data.queries.npgsDataSet(Data.procedures.insertarRNC(strCampos[0],strCampos[1],strCampos[2],
            //                                        strCampos[3],strCampos[4],strCampos[5],strCampos[6],strCampos[7],
            //                                        strCampos[8],strCampos[9],strCampos[10]));                                            
            //   }               
            //}
            
                using(StreamReader archivo = new StreamReader(openFileDialog1.FileName))
	            {
		            while ((linea = archivo.ReadLine()) != null)
	                {
	                    String[] strCampos = linea.Split('|');
                         using (Npgsql.NpgsqlConnection npgsCon = new Npgsql.NpgsqlConnection())
                            {
                                npgsCon.ConnectionString = Data.connection.GetPostGresConString();
                                npgsCon.Open();
                                
                                string sql = "INSERT INTO ssf_rnc values('" + strCampos[0] + "','" + strCampos[1] + "','" + strCampos[2]
                                        + "','" + strCampos[3] + "','" + strCampos[4] + "','" + strCampos[5] + "','" + strCampos[6] + "'," + "'" + strCampos[7] + "',"
                                        + "'" + strCampos[8] + "','" + strCampos[9] + "','" + strCampos[10] + "' )";
                                Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql,npgsCon);
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();
                            }
	                }
	            }

                //using (Npgsql.NpgsqlConnection npgsCon = new Npgsql.NpgsqlConnection())
                //{
                //    npgsCon.ConnectionString = Data.connection.GetPostGresConString();
                //    npgsCon.Open();
                //    string sql = "INSERT INTO ssf_rnc values(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,"
                //                                            + "@param9,@param10,@param11)";
                //    Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql,npgsCon);
                //    cmd.Parameters.Add("@param1",);
                //}
        }
    }
}
