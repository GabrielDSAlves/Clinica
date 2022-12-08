using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinico
{
    internal class ConsultaJoin
    {
        private int _id;
        private string _dataatual;
        private string _datamarcada;
        private string _horainicio;
        private string _horafim;
        private string _nomepac;
        private string _nomefunc;
        private string _nomedent;


        public ConsultaJoin(string dataatual, string datamarcada, string horainicio, string horafim, string nomepac, string nomefunc, string nomedent)
        {
            DataAtual = dataatual;
            DataMarcada = datamarcada;
            HoraFim = horafim;
            Horainicio = horainicio;
            NomePac = nomepac;
            NomeFunc = nomefunc;
            NomeDent = nomedent;
        }

        public ConsultaJoin(int id, string dataatual, string datamarcada, string horainicio, string horafim, string nomepac, string nomefunc, string nomedent)
        {
            _id = id;
            DataAtual = dataatual;
            DataMarcada = datamarcada;
            HoraFim = horafim;
            Horainicio = horainicio;
            NomePac = nomepac;
            NomeFunc = nomefunc;
            NomeDent = nomedent;

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

        public string NomePac
        {
            get { return _nomepac; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O Nome informado não é um texto válido");
                _nomepac = value;
            }
        }
        public string NomeFunc
        {
            get { return _nomefunc; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O Nome informado não é um texto válido");
                _nomefunc = value;
            }
        }
        public string NomeDent
        {
            get { return _nomedent; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O Nome informado não é um texto válido");
                _nomedent = value;
            }
        }
    }
}
