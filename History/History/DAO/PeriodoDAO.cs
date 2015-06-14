using History.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace History.DAO
{
    public class PeriodoDAO
    {
        private OleDbConnection _MDBConnection = Connection.AccessConnection();
        private DataTable GetPeriodoDataTable()
        {
            try
            {
                _MDBConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("select codPeriodo,dtInicialPeriodo, dtFinalPeriodo from Periodo Order By dtInicialPeriodo, dtFinalPeriodo", _MDBConnection);

                DataTable dt = new DataTable("Periodo");
                dt.Load(aCommand.ExecuteReader());

                return dt;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _MDBConnection.Close();
            }
        }
        private DataTable GetPeriodoDataTableByPais(Int32 CodPais)
        {
            try
            {
                _MDBConnection.Open();
                OleDbCommand command = new OleDbCommand("SELECT Periodo.codPeriodo, Periodo.dtInicialPeriodo, Periodo.dtFinalPeriodo " +
                                                        " FROM Periodo, PeriodoPais " +
                                                        " WHERE PeriodoPais.codPeriodo = Periodo.codPeriodo " +
                                                        " AND codPais = " + CodPais.ToString() +
                                                        " Order By dtInicialPeriodo, dtFinalPeriodo", _MDBConnection);

                DataTable dtTable = new DataTable("Periodo");
                dtTable.Load(command.ExecuteReader());

                return dtTable;
            }
            finally
            {
                _MDBConnection.Close();
            }
        }

        public void FillListPeriodo(List<Periodo> LstPeriodo, Int32 CodPais = -1)
        {
            if (LstPeriodo == null) return;

            LstPeriodo.Clear();

            DataTable periodoDtTable = null;
            if (CodPais == -1)
            {
                periodoDtTable = GetPeriodoDataTable();
            }
            else
            {
                periodoDtTable = GetPeriodoDataTableByPais(CodPais);
            }

            if (periodoDtTable == null) return;

            foreach (DataRow dtRow in periodoDtTable.Rows)
            {
                LstPeriodo.Add(
                    new Periodo()
                    {
                        codPeriodo = Convert.ToInt32(dtRow["codPeriodo"]),
                        dtInicialPeriodo = Convert.ToInt32(dtRow["dtInicialPeriodo"]),
                        dtFinalPeriodo = Convert.ToInt32(dtRow["dtFinalPeriodo"])
                    });
            }
        }
    }
}
