using History.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace History.DAO
{
    public class PaisDAO
    {
        private OleDbConnection _MDBConnection = Connection.AccessConnection();
        private DataTable GetPaisDataTable()
        {
            try
            {
                _MDBConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("select codPais,txNomePais from Pais Order By txNomePais", _MDBConnection);

                DataTable dt = new DataTable("Pais");
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

        private DataTable GetPaisDataTableByPeriodo(Int32 CodPeriodo)
        {
            try
            {
                _MDBConnection.Open();
                OleDbCommand command = new OleDbCommand(" SELECT Pais.codPais, Pais.txNomePais " +
                                                        " FROM Pais, PeriodoPais " +
                                                        " WHERE PeriodoPais.codPais = Pais.codPais " +
                                                        " AND codPeriodo = " + CodPeriodo.ToString() +
                                                        "  Order By txNomePais", _MDBConnection);

                DataTable dtTable = new DataTable("Pais");
                dtTable.Load(command.ExecuteReader());

                return dtTable;
            }
            finally
            {
                _MDBConnection.Close();
            }
        }

        public void FillListPais(List<Pais> LstPais, Int32 CodPeriodo = -1)
        {
            if (LstPais == null) return;

            LstPais.Clear();

            DataTable dtPais = null;

            if (CodPeriodo == -1)
            {
                dtPais = GetPaisDataTable();
            }
            else
            {
                dtPais = GetPaisDataTableByPeriodo(CodPeriodo);
            }

            if (dtPais == null || dtPais.Rows.Count <= 0) return;

            foreach (DataRow dtRow in dtPais.Rows)
            {
                LstPais.Add(
                    new Pais()
                    {
                        codPais = Convert.ToInt32(dtRow["codPais"]),
                        txNomePais = dtRow["txNomePais"].ToString()
                    });
            }
        }
    }
}
