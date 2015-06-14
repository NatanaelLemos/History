using History.DAO;
using System;
using System.Collections.Generic;

namespace History.Models
{
    public class PeriodoPais
    {
        private PeriodoPaisDAO _PeriodoPaisDAO = new PeriodoPaisDAO();
        public Int32 codPerPais { get; set; }
        public String txNomeRei { get; set; }

        #region DescricaoHelpers
        public String txDescricao { set { _Descricao = value; } }

        private String _Descricao;
        #endregion
        public String Descricao { get { return _Descricao; } }

        public List<Imagem> lstImagens { get; set; }

        private Pais _pais;
        public Pais pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
                LoadPeriodoPais();
            }
        }

        private Periodo _periodo;
        public Periodo periodo
        {
            get
            {
                return _periodo;
            }
            set
            {
                _periodo = value;
                LoadPeriodoPais();
            }
        }

        private void LoadPeriodoPais()
        {
            if (_pais != null && _periodo != null)
            {
                _PeriodoPaisDAO.FillPeriodoPais(this, _periodo.codPeriodo, _pais.codPais);

                if (lstImagens == null) lstImagens = new List<Imagem>();
                _PeriodoPaisDAO.FillImageList(lstImagens, codPerPais);
            }
        }
    }
}
