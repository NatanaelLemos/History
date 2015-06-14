using History.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace History.DAO
{
    public class PeriodoPaisDAO
    {
        private OleDbConnection _MDBConnection = Connection.AccessConnection();
        private DataTable GetPeriodoPaisDataTable(Int32 CodPeriodo, Int32 CodPais)
        {
            try
            {
                _MDBConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("SELECT codPerPais,codPais,codPeriodo,txNomeRei,txDescricao " +
                    " FROM PeriodoPais WHERE codPais = " + CodPais.ToString() + " AND codPeriodo = " + CodPeriodo.ToString(), _MDBConnection);

                DataTable dt = new DataTable("PeriodoPais");
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

        private DataTable GetImageDataTable(Int32 CodPeriodoPais)
        {
            try
            {
                _MDBConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("SELECT * FROM Imagem WHERE codPerPais = " + CodPeriodoPais.ToString(), _MDBConnection);

                DataTable dt = new DataTable("Imagem");
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

        public void FillPeriodoPais(PeriodoPais PeriodoPais, Int32 CodPeriodo, Int32 CodPais)
        {
            DataTable dtTable = GetPeriodoPaisDataTable(CodPeriodo, CodPais);
            if (dtTable == null || dtTable.Rows.Count <= 0) return;

            PeriodoPais.codPerPais = Convert.ToInt32(dtTable.Rows[0]["codPerPais"]);
            PeriodoPais.txNomeRei = dtTable.Rows[0]["txNomeRei"].ToString();
            PeriodoPais.txDescricao = dtTable.Rows[0]["txDescricao"].ToString();
        }

        public void FillImageList(List<Imagem> LstImagens, Int32 CodPeriodoPais)
        {
            LstImagens.Clear();
            foreach (DataRow dtRow in GetImageDataTable(CodPeriodoPais).Rows)
            {
                LstImagens.Add(
                    new Imagem()
                    {
                        codImagem = Convert.ToInt32(dtRow["codImagem"]),
                        txNomeImagem = dtRow["txNomeImagem"].ToString(),
                        txDescricaoImagem = dtRow["txDescricaoImagem"].ToString(),
                        codPerPais = CodPeriodoPais,
                        txEnderecoImg = dtRow["txEnderecoImg"].ToString()
                    });
            }
        }

        //private Boolean PaisPertenceAoPeriodo() 
        }
}
