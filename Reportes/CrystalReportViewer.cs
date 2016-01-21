using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.Configuration;

namespace spirit.Reportes
{
    public partial class CrystalReportViewer : Form
    {
        public static string sNombreReporte;
        public static string sSelectionFormula;

        public static string pFechaInicio;
        public static string pHoraInicio;
        public static string pFechaFin;
        public static string pHoraFin;
        public static int pTurno;//*

        public static ReportDocument cryRpt = new ReportDocument();
        public static int comprobador;

       public CrystalReportViewer()
        {
            InitializeComponent();
        }

        private void CrystalReportViewer_Load(object sender, EventArgs e)
        {
            if (sNombreReporte == "crpTurnos.rpt")
            {
                ParameterFields pFields = new ParameterFields();
                ParameterField pField = new ParameterField();
                ParameterDiscreteValue pDiscreteValue = new ParameterDiscreteValue();

                pField.Name = "pFechaInicio";
                pDiscreteValue.Value = pFechaInicio;
                pField.CurrentValues.Add(pDiscreteValue);
                pFields.Add(pField);

                //agregamos el parametro con la hora de inicio
                pField = new ParameterField();
                pDiscreteValue = new ParameterDiscreteValue();
                pField.Name = "pHoraInicio";
                pDiscreteValue.Value = pHoraInicio;
                pField.CurrentValues.Add(pDiscreteValue);
                pFields.Add(pField);

                //agregamos el parametro con la fecha de fin
                pField = new ParameterField();
                pDiscreteValue = new ParameterDiscreteValue();
                pField.Name = "pFechaFin";
                pDiscreteValue.Value = pFechaFin;
                pField.CurrentValues.Add(pDiscreteValue);
                pFields.Add(pField);

                //agregamos el parametro con la hora de fin
                pField = new ParameterField();
                pDiscreteValue = new ParameterDiscreteValue();
                pField.Name = "pHoraFin";
                pDiscreteValue.Value = pHoraFin;
                pField.CurrentValues.Add(pDiscreteValue);
                pFields.Add(pField);

                crystalReportViewer1.ParameterFieldInfo = pFields;
            }

            //cryRpt = new ReportDocument();
            
            //int iPosBin = Application.StartupPath.IndexOf("bin");
            //string strRuta = Application.StartupPath.Substring(0, iPosBin - 1);
            
            //cryRpt.Load(strRuta + "\\Reportes\\" + sNombreReporte);
            cryRpt.Load(ConfigurationManager.AppSettings["rutareportes"] + "\\" + sNombreReporte);            

            if (comprobador == 1)
            {
                //Funcion para exportar de Crystal Reports a Excel via c#.
                string rutaExportacion = "c:/tanques/Turno " + pTurno + " (" + Funciones.Helper.convertirFechaPSQL(pFechaInicio)
                                + " - " + Funciones.Helper.convertirFechaPSQL(pFechaFin) + ").xls";
                cryRpt.ExportToDisk(ExportFormatType.Excel, rutaExportacion);
            }
            
            {cryRpt.Refresh();}

            //agregamos el parametro con la fecha de inicio

            crystalReportViewer1.ReportSource = cryRpt;

            if (sNombreReporte == "crpDetalleVenta.rpt")
            { 
                crystalReportViewer1.SelectionFormula = sSelectionFormula; 
            }            
            
            crystalReportViewer1.Refresh();
        } 
        
    }
}
