using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace spirit.Data
{
    class procedures
    {
        public static string InsertarPrepago(Int32 iCodigoPrepago, Int32 iCustId, string dtFecha, string sHora, Int32 iCantidad, string sUserId)
        {
            string strInsert = "insert into ssf_config_prepago (codigo_prepago,tkt_cust_id,fecha,hora,cantidad,user_id)"
                            + " values (" + iCodigoPrepago + "," + iCustId + ",'" + dtFecha + "','" + sHora + "'," + iCantidad + ",'" + sUserId + "')";
            return strInsert;
        }

        public static string InsertarPrepagoDetalle(Int32 iCodigoPrepago, string sCodigoBarra, Int32 fConsumido, double fMonto, string sFecha, string sHora, string sUserId)
        {
            string strInsert = "insert into ssf_config_prepago_detalle (codigo_prepago,codigo_barra,consumido,monto,fecha,hora,user_id)"
                            + " values (" + iCodigoPrepago + ",'" + sCodigoBarra + "'," + fConsumido + ",'" + fMonto + "','" + sFecha + "','" + sHora + "','" + sUserId + "')";
            return strInsert;
        }

        public static string CodigoPrepago()
        {
            string sQueryCodigoPrepago = "Select max(codigo_prepago) as CodigoPrepago from ssf_config_prepago";
            return sQueryCodigoPrepago;
        }

        public static string CargarClientes()
        {
            string sQueryClientes = "Select tkt_cust_id as Codigo,tkt_cust_name as Nombre from ssf_tkt_customers";
            return sQueryClientes;
        }

        public static string VerificarCodigoBarra(string sCodigoBarra)
        {
            string sQueryCodigoBarra = "Select codigo_barra from ssf_config_prepago_detalle where codigo_barra='" + sCodigoBarra + "'";
            return sQueryCodigoBarra;
        }

        public static string ValidarUsuario(string sUsuario, string sPassWord)
        {
            string sQueryValidarUsuario = "Select id_usuario,clave from ssf_usuario where id_usuario='" + sUsuario + "' and clave='" + sPassWord + "'";
            return sQueryValidarUsuario;
        }

        public static string CargarMontos()
        {
            string sQueryCodigoBarra = "Select codigo,monto from ssf_config_prepago_monto order by codigo";
            return sQueryCodigoBarra;
        }

        public static string CargarMenusUsuario(string sIdUsuario)
        {
            string sQueryRolUsuario = "Select sm.desc_menu from ssf_rol_usuario sru,ssf_rol_acceso sra,ssf_usuario su,ssf_menu sm"
                                    + " where sra.id_menu=sm.id_menu and sru.id_rol=sra.id_rol and su.id_usuario=sru.id_usuario and su.id_usuario='" + sIdUsuario + "'";
            return sQueryRolUsuario;
        }

        public static string CargarDatosTicketPrepago(string sCodigoBarra)
        {
            string sQueryDatosTPrepago = "select cpd.codigo_barra,cpd.monto,cpd.consumido,cp.tkt_cust_id,tc.tkt_cust_name"
                                     + " from ssf_config_prepago_detalle cpd,ssf_config_prepago cp,ssf_tkt_customers tc"
                                     + " where cpd.codigo_prepago=cp.codigo_prepago and cp.tkt_cust_id=tc.tkt_cust_id and cpd.codigo_barra='" + sCodigoBarra + "'";
            return sQueryDatosTPrepago;
        }

        public static string GuardarConsumoPrepago(string sCodigoBarra, double dConsumo, string dtFecha, string sHora, string sUserId, Int32 iActivo)
        {
            string strUpdate = "update ssf_config_prepago_detalle set consumido=" + dConsumo + ",fecha='" + dtFecha + "',hora='" + sHora + "',user_id='" + sUserId + "',activo=" + iActivo + " where codigo_barra='" + sCodigoBarra + "'";
            return strUpdate;
        }

        public static string CargarVentas(Int32 iPump_Id, Int32 iHose_Id)
        {
            string sWhere = "";
            if (iPump_Id > 0)
            {
                sWhere = " and sps.pump_id=" + iPump_Id;
            }
            if (iHose_Id > 0)
            {
                sWhere = sWhere + " and sps.hose_id=" + iHose_Id;
            }
            string strCargarVentas = "select sps.sale_id,sps.pump_id,sps.hose_id,sps.grade_id,stp.tkt_plu_short_desc,sps.volume,sps.money,"
                                    + " substring(sps.end_date from 7 for 2) || '/' || substring(sps.end_date from 5 for 2) || '/' || substring(sps.end_date from 1 for 4) as end_date,"
                                    + " substring(sps.end_time from 1 for 2) || ':' || substring(sps.end_time from 3 for 2) || ':'  || substring(sps.end_time from 5 for 2) as end_time"
                                    + " from ssf_pump_sales sps,ssf_tkt_plu stp,ssf_tkt_plu_grades stpg where sps.grade_id=stpg.tkt_grade_id and stpg.tkt_plu_id=stp.tkt_plu_id " + sWhere
                                    + " order by (start_date || ' ' || start_time) desc";
            return strCargarVentas;
        }

        public static string CargarDatosTLS(string sFecha)
        {
            string strCargarDatosTLS = "select tls_id,productheight,waterheight,temperature,productvolume,watervolume,productullage,producttcvolume,productdensity,productmass from ssf_tls where fecha='" + sFecha + "'";
            return strCargarDatosTLS;
        }

        public static string BuscarDatosEntradaManualPorTurno(int turno)
        {
            string strEntradaManual = "select tkt_plu_long_desc as producto, '' as Galones, '' as Altura from ssf_reporte_turno ";
            return strEntradaManual; 
        }

        public static string BuscarConfigListadoVenta(string sIdusuario)
        {
            string strBuscar = "select id_usuario,bomba,lado,ultimas from ssf_config_listado_venta where id_usuario='" + sIdusuario + "'";
            return strBuscar;
        }

        public static string InsertConfigListadoVenta(Int32 iBomba, Int32 iLado, Int32 iUltimas, string sIdUsuario, string sFecha, string sHora)
        {
            string strInsert = "insert into ssf_config_listado_venta (bomba,lado,ultimas,id_usuario,fecha,hora) values (" + iBomba + "," + iLado + "," + iUltimas + ",'" + sIdUsuario + "','" + sFecha + "','" + sHora + "')";
            return strInsert;
        }

        public static string UpdateConfigListadoVenta(Int32 iBomba, Int32 iLado, Int32 iUltimas, string sIdUsuario, string sFecha, string sHora)
        {
            string strUpdate = "update ssf_config_listado_venta set bomba=" + iBomba + ",lado=" + iLado + ",ultimas=" + iUltimas + ",fecha='" + sFecha + "',hora='" + sHora + "' where id_usuario='" + sIdUsuario + "'";
            return strUpdate;
        }
                
        //Metodo para buscar el NCF.
        public static string BuscarNFC(string sDescripcion)
        {
            string strBuscar = "select prefijo,descripcion,desde,hasta,consecutivo,id_usuario,to_char(fecha,'dd/MM/yyyy') as fecha,codigo_tipo from ssf_ncf where descripcion='" + sDescripcion + "'";
            return strBuscar;
        }
        
        //modify
        public static string InsertNCF(string sPrefijo, string sDescripcion, Int32 iDesde, Int32 iHasta, string sIdUsuario, string sFecha, string sHora, Int32 iConsecutivo, string codigo_tipo)
        {
            string strInsert = "insert into ssf_ncf (prefijo,descripcion,desde,hasta,id_usuario,fecha,hora,consecutivo,codigo_tipo) values ('" + sPrefijo + "','" + sDescripcion + "'," + iDesde + "," + iHasta + ",'" + sIdUsuario + "','" + sFecha + "','" + sHora + "'," + iConsecutivo +",'"+codigo_tipo+"')";
            return strInsert;
        }

        //modify
        public static string UpdateNCF(string sPrefijo, Int32 iDesde, Int32 iHasta, string sIdUsuario, string sFecha, string sHora, Int32 iConsecutivo)
        {
            string strUpdate = "update ssf_ncf set desde=" + iDesde + ",hasta=" + iHasta + ",id_usuario='" + sIdUsuario + "',fecha='" + sFecha + "',hora='" + sHora + "',consecutivo=" + iConsecutivo + " where prefijo='" + sPrefijo + "'";
            return strUpdate;
        }

        public static string BuscarMaxValueProbeta(int iProbeta)
        {
            string strBuscar = "select valormaximo from ssf_tls_maxvalue where tls_id='" + iProbeta + "'";
            return strBuscar;
        }
        public static string UpdateMaxValueProbeta(int iProbeta, double dMaxValue)
        {
            string strUpdate = "update ssf_tls_maxvalue set valormaximo=" + dMaxValue + " where tls_id=" + iProbeta + "";
            return strUpdate;
        }

        public static string InsertMaxValueProbeta(int iProbeta, double dMaxValue)
        {
            string strUpdate = "insert into ssf_tls_maxvalue (tls_id,valormaximo) values (" + iProbeta + "," + dMaxValue + ")";
            return strUpdate;
        }

        public static string InsertRol(int iCodigoRol, string sRol, string sIdUsuario, string sFecha)
        {
            string strInsertRol = "insert into ssf_rol (id_rol,desc_rol,id_usuario,fecha) values (" + iCodigoRol + ",'" + sRol + "','" + sIdUsuario + "','" + sFecha + "')";
            return strInsertRol;
        }

        public static string UpdateRol(int iCodigoRol, string sRol, string sIdUsuario, string sFecha)
        {
            string strUpdateRol = "update ssf_rol set desc_rol='" + sRol + "',id_usuario='" + sIdUsuario + "',fecha='" + sFecha + "' where id_rol=" + iCodigoRol;
            return strUpdateRol;
        }

        public static string BuscarRol(int iCodigoRol)
        {
            string strBuscar = "select id_rol from ssf_rol where id_rol=" + iCodigoRol;
            return strBuscar;
        }

        public static string BuscarRoles()
        {
            string strBuscar = "select * from ssf_rol order by id_rol";
            return strBuscar;
        }
        public static string MaxCodigoRol()
        {
            string sQueryIdRol = "Select max(id_rol) as id_rol from ssf_rol";
            return sQueryIdRol;
        }

        public static string RolMenusAsignados(int iIdRol)
        {
            string sQueryRolMenus = "select ra.id_rol,ra.id_menu,m.nombre_menu from ssf_rol_acceso ra,ssf_menu m where ra.id_menu=m.id_menu and ra.id_rol=" + iIdRol;
            return sQueryRolMenus;
        }
        public static string RolMenusDisponibles(int iIdRol)
        {
            string sQueryRolMenus = "select m.id_menu,m.nombre_menu from ssf_menu m where m.id_menu not in(select ra.id_menu from ssf_rol_acceso ra,ssf_menu m where ra.id_menu=m.id_menu and ra.id_rol=" + iIdRol + ")";
            return sQueryRolMenus;
        }

        public static string BorrarRolMenu(int iIdRol, int iIdMuenu)
        {
            string sQueryRolMenus = "delete from ssf_rol_acceso where id_menu=" + iIdMuenu + " and id_rol=" + iIdRol;
            return sQueryRolMenus;
        }

        public static string InsertarRolMenu(int iIdRol, int iIdMuenu, string sIdUsuario, string sFecha)
        {
            string sQueryRolMenus = "insert into ssf_rol_acceso (id_menu,id_rol,id_usuario,fecha) values (" + iIdMuenu + "," + iIdRol + ",'" + sIdUsuario + "','" + sFecha + "')";
            return sQueryRolMenus;
        }

        public static string BuscarPeriodos(string sFechaInicio, string sFechaFin)
        {            
            string sQueryPeriodos = "select sd.period_id,sd.period_start_date,sd.period_start_time,sd.period_end_date,sd.period_end_time from ssf_addin_shifts_data sd"
                                 + " where sd.period_type='S' and sd.period_start_date>='" + sFechaInicio + "' and sd.period_start_date<='" + sFechaFin + "' order by sd.period_id desc";
            return sQueryPeriodos;
        }
        public static string BuscarPeriodosTrinity(string sFechaInicio, string sFechaFin)
        {
            string sQueryPeriodos = "select sp.id_periodo,min(sp.fecha_inicio_periodo || ' ' || sp.hora_inicio_periodo) as fecha_inicio_periodo,"
                                + " max(sp.fecha_fin_periodo || ' ' || sp.hora_fin_periodo) as fecha_fin_periodo from ssf_periodo sp"
                                + " where sp.fecha_inicio_periodo>='" + sFechaInicio + "' and sp.fecha_inicio_periodo<='" + sFechaFin + "' group by sp.id_periodo";
            return sQueryPeriodos;
        }

        public static string DetallePeriodos(int iIdTurno, string sFechaInicio, string sHoraInicio, string sFechaFin, string sHoraFin)
        {
            string sQueryDetallePeriodos = "insert into ssf_reporte_turno"
                                         + " select pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,"
                                         + " min(initial_volume) as initial_volume,max(final_volume) as final_volume,"
                                         + " min(start_date) as start_date, min(start_time) as start_time, max(end_date) as end_date, max(end_time) as end_time"
                                         + " ,(select sum(precio) from ssf_detalle_turno where lado=sps.pump_id and manguera=sps.hose_id and codigo_producto=sps.grade_id and id_turno=" + iIdTurno
                                         + " group by lado,manguera,codigo_producto,id_turno) as ppu,"
                                         + " (select id_relacion from ssf_relacion_bombas where pump_id=sps.pump_id) as id_relacion,"
                                         + " (select secuencia from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) as secuencia"
                                         + " from ssf_pump_sales sps, ssf_tkt_plu stp where sps.grade_id=stp.tkt_plu_id"
                                         + " and (start_date || ' ' || start_time) >='" + sFechaInicio + " " + sHoraInicio + "' and (end_date || ' ' || end_time)<='" + sFechaFin + " " + sHoraFin + "'"
                                         + " group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc order by pump_id,hose_id,grade_id";
            
            return sQueryDetallePeriodos;
        }

        public static string DetallePeriodosInicio(int iIdTurno, string sFechaInicio, string sHoraInicio)
        {            
            string sQueryDetallePeriodos = "insert into ssf_reporte_turno"
                                        + " select pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,"
                                        + " min(initial_volume) as initial_volume,max(final_volume) as final_volume,"
                                        + " min(start_date) as start_date, min(start_time) as start_time, max(end_date) as end_date, max(end_time) as end_time"
                                        + " ,(select sapcd.ppu from ssf_addin_prices_change sapc,ssf_addin_prices_change_detail sapcd"
                                        + " where sapc.price_change_id=sapcd.price_change_id and sapcd.grade_id=sps.grade_id and sapcd.price_level=1 and sapc.processed_date>='" + sFechaInicio + "') as ppu,"
                                        + " (select id_relacion from ssf_relacion_bombas where pump_id=sps.pump_id) as id_relacion,"
                                        + " (select secuencia from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) as secuencia"
                                        + " from ssf_pump_sales sps, ssf_tkt_plu stp where sps.grade_id=stp.tkt_plu_id"
                                        + " and (start_date || ' ' || start_time) >='" + sFechaInicio + " " + sHoraInicio + "'"
                                        +" group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc order by pump_id,hose_id,grade_id";            
            return sQueryDetallePeriodos;
        }

        public static string DetallePeriodosFaltantes(string sFechaInicio, string sHoraInicio, string sFechaFin, string sHoraFin)
        {
            string sQueryDetallePeriodos = "insert into ssf_reporte_turno select pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,max(final_volume) as initial_volume,"
                                        + " max(final_volume) as final_volume, max(start_date) as start_date, max(start_time) as start_time, max(end_date) as end_date,"
                                        + " max(end_time) as end_time ,"
                                        + " (select sapcd.ppu from ssf_addin_prices_change sapc,ssf_addin_prices_change_detail sapcd"
                                        + " where sapc.price_change_id=sapcd.price_change_id and sapcd.grade_id=sps.grade_id and sapcd.price_level=1 and sapc.processed_date>='" + sFechaInicio + "') as ppu,"
                                        + " (select id_relacion from ssf_relacion_bombas where pump_id=sps.pump_id) as id_relacion, (select secuencia "
                                        + " from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) as secuencia from ssf_pump_sales sps, ssf_tkt_plu stp "
                                        + " where sps.grade_id=stp.tkt_plu_id  and (end_date || ' ' || end_time) <='" + sFechaInicio + " " + sHoraInicio + "'"
                                        + " and (select secuencia from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) not in"
                                        + " ( select  (select secuencia from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) as secuencia from ssf_pump_sales sps, ssf_tkt_plu stp "
                                        + " where sps.grade_id=stp.tkt_plu_id  and (start_date || ' ' || start_time) >='" + sFechaInicio + " " + sHoraInicio + "' and (end_date || ' ' || end_time)<='" + sFechaFin + " " + sHoraFin + "'"
                                        + " group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc order by pump_id,hose_id,grade_id"
                                        + " ) group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc order by pump_id,hose_id,grade_id";
            return sQueryDetallePeriodos;            
        }

        public static string DetallePeriodosFaltantesInicio(string sFechaInicio, string sHoraInicio)
        {
            string sQueryDetallePeriodos = "insert into ssf_reporte_turno select pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,max(final_volume) as initial_volume,"
                                        + " max(final_volume) as final_volume, max(start_date) as start_date, max(start_time) as start_time, max(end_date) as end_date,"
                                        + " max(end_time) as end_time ,"
                                        + " (select sapcd.ppu from ssf_addin_prices_change sapc,ssf_addin_prices_change_detail sapcd"
                                        + " where sapc.price_change_id=sapcd.price_change_id and sapcd.grade_id=sps.grade_id and sapcd.price_level=1 and sapc.processed_date>='" + sFechaInicio + "') as ppu,"
                                        + " (select id_relacion from ssf_relacion_bombas where pump_id=sps.pump_id) as id_relacion, (select secuencia "
                                        + " from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) as secuencia from ssf_pump_sales sps, ssf_tkt_plu stp "
                                        + " where sps.grade_id=stp.tkt_plu_id  and (end_date || ' ' || end_time) <='" + sFechaInicio + " " + sHoraInicio + "'"
                                        + " and (select secuencia from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) not in"
                                        + " ( select  (select secuencia from ssf_lado_manguera where pump_id=sps.pump_id and hose_id=sps.hose_id) as secuencia from ssf_pump_sales sps, ssf_tkt_plu stp "
                                        + " where sps.grade_id=stp.tkt_plu_id  and (start_date || ' ' || start_time) <='" + sFechaInicio + " " + sHoraInicio + "'"
                                        + " group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc order by pump_id,hose_id,grade_id"
                                        + " ) group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc order by pump_id,hose_id,grade_id";
            return sQueryDetallePeriodos;            
        }

        public static string GuardarDetallePeriodo(int iIdTurno, string sFechaInicio, string sHoraInicio, string sFechaFin, string sHoraFin,string sEstado)
        {
            string sQueryDetallePeriodos = "insert into ssf_detalle_turno (id_turno,fecha_inicio_turno,hora_inicio_turno,fecha_fin_turno,hora_fin_turno,"
                                        + " lado,manguera,codigo_producto,desc_producto,volumen_inicial,volumen_final,precio,estado)"
                                        + " select " + iIdTurno + ",'" + sFechaInicio + "','" + sHoraInicio + "','" + sFechaFin + "','" + sHoraFin + "',"
                                        + " pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,min(initial_volume) as initial_volume,max(final_volume) as final_volume,"
                                        + " (select sapcd.ppu from ssf_addin_prices_change sapc,ssf_addin_prices_change_detail sapcd"
                                        + " where sapc.price_change_id=sapcd.price_change_id and sapcd.grade_id=sps.grade_id and sapcd.price_level=1 and sapc.processed_date between '" + sFechaInicio + "' and '" + sFechaFin + "') as ppu,'"
                                        + sEstado + "' from ssf_pump_sales sps, ssf_tkt_plu stp where sps.grade_id=stp.tkt_plu_id"
                                        + " and (start_date || ' ' || start_time) >='" + sFechaInicio + " " + sHoraInicio + "' and (end_date || ' ' || end_time)<='" + sFechaFin + " " + sHoraFin + "'"
                                        + " group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,sps.ppu order by pump_id,hose_id,grade_id";
            return sQueryDetallePeriodos;
        }

        public static string GuardarDetallePeriodoInicio(int iIdTurno, string sFechaInicio, string sHoraInicio, string sFechaFin, string sHoraFin, string sEstado)
        {
            string sQueryDetallePeriodos = "insert into ssf_detalle_turno (id_turno,fecha_inicio_turno,hora_inicio_turno,fecha_fin_turno,hora_fin_turno,"
                                        + " lado,manguera,codigo_producto,desc_producto,volumen_inicial,volumen_final,precio,estado)"
                                        + " select " + iIdTurno + ",'" + sFechaInicio + "','" + sHoraInicio + "','" + sFechaFin + "','" + sHoraFin + "',"
                                        + " pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,min(initial_volume) as initial_volume,max(final_volume) as final_volume,"
                                        + " (select sapcd.ppu from ssf_addin_prices_change sapc,ssf_addin_prices_change_detail sapcd"
                                        + " where sapc.price_change_id=sapcd.price_change_id and sapcd.grade_id=sps.grade_id and sapcd.price_level=1 and sapc.processed_date between '" + sFechaInicio + "' and '" + sFechaFin + "') as ppu,'"
                                        + sEstado + "' from ssf_pump_sales sps, ssf_tkt_plu stp where sps.grade_id=stp.tkt_plu_id"
                                        + " and (start_date || ' ' || start_time) >='" + sFechaInicio + " " + sHoraInicio + "'"
                                        + " group by pump_id,hose_id,grade_id,stp.tkt_plu_long_desc,sps.ppu order by pump_id,hose_id,grade_id";
            return sQueryDetallePeriodos;
        }

        public static string BorrarDetallePeriodo()
        {
            string sQueryDetallePeriodos = "Delete from ssf_reporte_turno";
            return sQueryDetallePeriodos;
        }

        public static string BorrarTablaDetalleTurno(int iIdTurno)
        {
            string sQueryDetallePeriodos = "Delete from ssf_detalle_turno where id_turno=" + iIdTurno;
            return sQueryDetallePeriodos;
        }

        public static string BuscarDetallePeriodo(int iIdTurno)
        {
            string sQueryDetallePeriodos = "select sdt.id_turno from ssf_detalle_turno sdt where sdt.id_turno=" + iIdTurno + " and sdt.estado='C'";
            return sQueryDetallePeriodos;
        }

        public static string BuscarStatusPeriodo(int iIdTurno)
        {
            string sQueryDetallePeriodos = "select sasd.period_status from ssf_addin_shifts_data sasd,ssf_detalle_turno sdt where sasd.period_id=" + iIdTurno + " and sasd.period_type='S' and sasd.period_status='C'"
                                         + " and sdt.id_turno=sasd.period_id and sdt.estado='O'";
            return sQueryDetallePeriodos;
        }

        public static string BuscarLados()
        {
            string sQueryDetallePeriodos = "select distinct pump_id from ssf_lado_manguera order by pump_id";
            return sQueryDetallePeriodos;
        }

        //Query para buscar los productos en la tabla ssf_tkt_plu.
        public static string buscarProductos()
        {
            string sQueryBuscarProductos = "select tkt_plu_id, tkt_plu_long_desc from ssf_tkt_plu" 
                                           + " where tkt_plu_id < 4 order by tkt_plu_id";
            return sQueryBuscarProductos;
        }

        //Query para buscar los surtidores en la tabla ssf_pump_sales.
        public static string buscarSurtidores()
        {
            string sQueryBuscarSurtidores = "select distinct pump_id, 'Surtidor '|| pump_id as hose_desc from ssf_pump_sales order by pump_id";

            return sQueryBuscarSurtidores;
        }

        //Query para hacer la Consulta de ventas.
        public static string consultarVentas(string sWhere)
        {
            string sQueryConsultarVentas = "select distinct sps.end_date,sps.end_time,sps.pump_id, stp.tkt_plu_long_desc,"
                                         + "sps.volume,(select max(sd.ppu) from ssf_addin_prices_change sc,"
                                         + "ssf_addin_prices_change_detail sd where sc.price_change_id=sd.price_change_id "
                                         + "and sd.grade_id=sps.grade_id and sd.price_level=1 and sc.processed_date="
                                         + "(select max(sapc.processed_date) as processed_date from ssf_addin_prices_change sapc,"
                                         + "ssf_addin_prices_change_detail sapcd where sapcd.price_level=1 and sapc.price_change_id=sapcd.price_change_id "
                                         + "and sapcd.grade_id=sps.grade_id and sapc.processed_date <= sps.end_date)) as ppu "
                                         + "from ssf_pump_sales sps,ssf_tkt_plu stp,ssf_tkt_plu_grades stpg "
                                         + sWhere;
            return sQueryConsultarVentas;
        }

        //Query para buscar el listado de productos y visualizarlos en una tabla para luego ser seleccionados y usarlos para consultar ventgas.
        public static string buscarIDProdcuto()
        {
            string sQueryBuscarIDProducto = "select tkt_plu_id,tkt_plu_long_desc from ssf_tkt_plu "
                                            +"where tkt_plu_id < 9 order by tkt_plu_id";
            return sQueryBuscarIDProducto;
        }

        //Query para insertar los RNC de las empresas con todos sus detalles
        public static string insertarRNC(string rnc, string nombre_Empresa, string nombre_publico,string descripcion, 
                                            string calle, string numero_calle, string sector, string telefono, 
                                            string fecha_inicio, string estatus, string tipo)
        {
            string sQueryInsertarRNC = "INSERT INTO ssf_rnc values('"+rnc+"','"+nombre_Empresa+"','"+nombre_publico
                                        +"','"+descripcion+"','"+calle+"','"+numero_calle+"','"+sector+"',"+"'"+telefono+"',"
                                        +"'"+fecha_inicio+"','"+estatus+"','"+tipo+"' )";
            return sQueryInsertarRNC;
        }

        //Query para buscar los RNC en la base de datos.
        public static string buscarRNC(string rnc)
        {
            string sQueryBuscarRNC = "select RNC,nombre,nombre_comercial from ssf_rnc where RNC = '"+rnc+"'";
            return sQueryBuscarRNC;
        }

        public static string Buscarssf_addin_shifts_dataPorPeriodo(int id)
        {
            string consulta = "select * from ssf_addin_shifts_data where period_id = "+id;
            return consulta;
        }

        public static string InsertarDetalle_entrada_manual(int turnoId,decimal galones,decimal altura,int tipoCombustible,string descripcion)
        {
            string consulta = "insert into ssf_detalle_entrada_manual(turno_id,galones,altura,tipo_compustible_id,tipo_combustible_descripcion)"
                                + "values("+turnoId+"," + galones +","+altura+ "," + tipoCombustible + ",'" + descripcion + "')";
            return consulta;
 
        }

        public static string Cargar_ssf_tkt_plu()
        {

            string consulta = "select * from ssf_tkt_plu";
            return consulta;
        }
        
        //Query para insertar un historial de los diferentes ncf que se registren y sus aumentos.
        public static string insertarNCFcopia(string sPrefijo, string sDescripcion, Int32 iDesde, Int32 iHasta, string sIdUsuario, string sFecha, string sHora, Int32 iConsecutivo, string codigo_tipo)
        {
            string sQueryInsertarNCFcopia = "insert into ssf_ncf_backup values ('" + sPrefijo + "','" + sDescripcion + "'," + iDesde + "," + iHasta + ",'" + sIdUsuario + "','" + sFecha + "','" + sHora + "'," + iConsecutivo + ",'" + codigo_tipo + "')";
            return sQueryInsertarNCFcopia;
        }

        //Query para generar el NCF segun el consecutivo.
        public static string generarNCF(string tipoNCF){
            string sQueryGenerarNCF ="select prefijo,desde,hasta,consecutivo from ssf_ncf where descripcion ='"+tipoNCF+"'";
            return sQueryGenerarNCF;
        }

        //Query para aumentar el numero consecutivo. El numero consecutivo que este en la tabla es el numero que sigue 
        //para el siguiente NCF.
        public static string aumentarConsecutivoNCF(string consecutivo,string prefijo)
        {
            string sQueryAumentarConsecutivo = "UPDATE ssf_ncf set consecutivo =" + consecutivo
                                                + " where prefijo = '" + prefijo + "'";
            return sQueryAumentarConsecutivo;
        }

        public static string insertarRNC(string rnc, string nombre_Empresa)
        {
            string sQueryInsertarRNC = "INSERT INTO ssf_rnc(rnc,nombre,nombre_comercial) values ('"+rnc+"','"+nombre_Empresa+"','"+nombre_Empresa+"')";
            return sQueryInsertarRNC;
        }

        //Query para insertar las ventas con Comprobante Fiscal en una tabla.
        public static string insertarEnFacturaComprobante(string ncf, string cliente, string rnc, int lado, int manguera, 
                                                           string combustible, double volume, double monto, string fecha,
                                                            string hora,string user,string complemento)
        {
            string sQueryInsertar= "insert into ssf_facturas_comprobantes values ('"+ncf+"','"+cliente+"','"+rnc+"',"+lado+","
                                             +manguera+",'"+combustible+"',"+volume+","+monto+",'"+fecha+"','"+hora+"','"
                                             +user+"'"+complemento;
            return sQueryInsertar;
        }

        //query para actualizar el tipo comprobante en la tabla de clientes
        public static string UpdateTipoComprobante(string sTipoComprobante)
        {
            string sQueryUpdate = "update ssf_datos_cliente set tipo_comprobante='" + sTipoComprobante + "'";
            return sQueryUpdate;
        }
   
        public static string GuardarEntradaManual(int id_ssf_reporte_turno,decimal monto_efectivo,decimal monto_tarjeta
            , decimal monto_prepago, decimal monto_credito)
        {
            return "insert into ssf_turnos_desglose(ssf_addin_shifts_data_periodo_id, monto_efectivo, monto_tarjeta,monto_prepago, monto_credito)"
                                           +"values("+id_ssf_reporte_turno+","+monto_efectivo+","+monto_tarjeta+","+monto_prepago+","+monto_credito+")";
        }

        public static string EliminarDetalleEntradaManualPorTurnoId(int periodoId)
        {
            return "delete from ssf_detalle_entrada_manual where turno_id = "+periodoId;
        }

        public static string EliminarDesgloseEntradaManualPorTurnoId(int turnoId)
        {
            return "delete from ssf_turnos_desglose where ssf_addin_shifts_data_periodo_id = "+turnoId;
        }
         

    }
}
