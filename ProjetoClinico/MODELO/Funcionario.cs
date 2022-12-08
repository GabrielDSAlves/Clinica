using System;


namespace ProjetoClinico
{
    public class Funcionario
    {
        private int _id;
        private string _nome;
        private string _cpf;
        private string _dataNascimento;
        private string _cidade;
        private string _endereco;
        private string _numero;
        private string _bairro;
        private string _email;
        private string _telefone;
        private string _senha;
        private string _cargo;


        public Funcionario(string nome, string cpf, string dataNascimento, string cidade, string endereco, string numero, string bairro, string email, string telefone, string senha, string cargo)
        {
            Nome = nome;
            Cpf = cpf;
            Datanascimento = dataNascimento;
            Cidade = cidade;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            Cargo = cargo;
        }

        public Funcionario(int id, string nome, string cpf, string dataNascimento, string cidade, string endereco, string numero, string bairro, string email, string telefone, string senha, string cargo)
        { 
            _id = id;
            Nome = nome;
            Cpf = cpf;
            Datanascimento = dataNascimento;
            Cidade = cidade;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            Cargo = cargo;
        }

        static bool ValidarEMAIL(string Email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == Email;
            }
            catch (Exception)
            {
                return false;
            }
        }


        static bool validarTELEFONE(string Telefone)
        {

            Telefone = Telefone.Trim();
            Telefone = Telefone.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            if (Telefone.Length < 11)// (12) 99700*0000
                return false;

            return true;
        }

        static bool validarCPF(string Cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma = 0;
            int resto;
            Cpf = Cpf.Trim();
            Cpf = Cpf.Replace(".", "").Replace("-", "");
            if (Cpf.Length != 11)
                return false;
            tempCpf = Cpf.Substring(0, 9);


            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return Cpf.EndsWith(digito);
        }


        public int Id
        {
            get { return _id; }
        }
        //Validação do Nome.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _nome = value;
            }
        }

        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O CPF informado não é um texto válido");
                _cpf = value;

                if (validarCPF(_cpf) == false)
                    throw new ArgumentException("O CPF informado não é um texto válido");
            }
        }

        public string Datanascimento
        {
            get { return _dataNascimento; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A data de nascimento informado não é um texto válido");
                _dataNascimento = value;
            }
        }

        public string Cidade
        {
            get { return _cidade; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A cidade informado não é um texto válido");
                _cidade = value;
            }
        }
        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O endereço informado não é um texto válido");
                _endereco = value;
            }
        }

        public string Numero
        {
            get { return _numero; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O numero informado não é um texto válido");
                _numero = value;
            }
        }

        public string Bairro
        {
            get { return _bairro; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O bairro informado não é um texto válido");
                _bairro = value;
            }
        }

        //Validação do Email
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O E-Mail fornecido não é valido!");
                _email = value;

                if (ValidarEMAIL(Email) == false)
                    throw new ArgumentException("O E-Mail fornecido não é valido!");
            }
        }

        //Validação do Telefone
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;

                if (validarTELEFONE(Telefone) == false)
                    throw new ArgumentException("O telefone informado não é um texto válido\nEntre com o DDD mais 9 digitos do telefone");

            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha informado não é um texto válido");
                _senha = value;
            }
        }
        public string Cargo
        {
            get { return _cargo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O cargo informado não é um texto válido");
                _cargo = value;
            }
        }
    }
}
