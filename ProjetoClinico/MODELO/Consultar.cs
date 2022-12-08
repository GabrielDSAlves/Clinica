using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinico
{
    internal class Consultar
    {
        private int _id;
        private string _dataatual;
        private string _datamarcada;
        private string _horainicio;
        private string _horafim;
        private int _idfunc;
        private int _idpac;
        private int _iddent;


        public Consultar(string dataatual, string datamarcada, string horainicio, string horafim, int idfunc, int idpac, int iddent)
        {
            DataAtual = dataatual;
            DataMarcada = datamarcada;
            HoraFim = horafim;
            Horainicio = horainicio;
            IdFunc = idfunc;
            IdPac = idpac;
            IdDent = iddent;
        }

        public Consultar(int id, string dataatual, string datamarcada, string horainicio, string horafim, int idfunc, int idpac, int iddent)
        {
            _id = id;
            DataAtual = dataatual;
            DataMarcada = datamarcada;
            HoraFim = horafim;
            Horainicio = horainicio;
            IdFunc = idfunc;
            IdPac = idpac;
            IdDent = iddent;

        }

        public int Id
        {
            get { return _id; }
        }
        //Validação do Nome.
        public string DataAtual
        {
            get { return _dataatual; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A data informada não é um texto válido");
                _dataatual = value;
            }
        }

        public string DataMarcada
        {
            get { return _datamarcada; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A data informada não é um texto válido");
                _datamarcada = value;

            }
        }

        public string HoraFim
        {
            get { return _horafim; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A hora informada não é um texto válido");
                _horafim = value;
            }
        }

        public string Horainicio
        {
            get { return _horainicio; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A cidade informado não é um texto válido");
                _horainicio = value;
            }
        }

        public int IdFunc
        {
            get { return _idfunc; }
            set
            {
                if (_idfunc == null)
                    throw new Exception("O id informado não é um texto válido");
                _idfunc = value;
            }
        }
        public int IdPac
        {
            get { return _idpac; }
            set
            {
                if (_idpac == null)
                    throw new Exception("O id informado não é um texto válido");
                _idpac = value;
            }
        }

        public int IdDent
        {
            get { return _iddent; }
            set
            {
                if (_iddent == null)
                    throw new Exception("O id informado não é um texto válido");
                _iddent = value;
            }
        }
    }
}
