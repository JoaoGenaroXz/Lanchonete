using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Class
{
    internal class Clientes
    {
        private int codigo;
        private string nome;
        private string cpfcnpj;
        private string rg;
        private string endereco;
        private string numero;
        private string cidade;
        private string bairro;
        private string complemento;
        private string cep;
        private string telefone;
        private string celular;
        private string email;
        private string contato;

        public int Codigo
        {
            set { this.Codigo = value; }
            get { return this.Codigo; }
        }
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public string Cpfcnpj
        {
            set { this.cpfcnpj = value; }
            get { return this.cpfcnpj;}
        }
        public string Rg
        {
            set { this.rg = value; }
            get { return this.rg; }
        }
        public string Endereco
        {
            set { this.endereco = value; }
            get { return this.endereco; }
        }
        public string Numero
        {
            set { this.numero = value; }
            get { return this.numero; }
        }
        public string Cidade 
        {
            set { this.cidade = value; }
            get { return this.cidade; }
        }
        public string Bairro
        {
            set { this.bairro = value; }
            get { return this.bairro; }
        }
        public string Complemento
        {
            set { this.complemento = value;}
            get { return this.complemento; }
        }
        public string Cep
        {
            set { this.cep = value; }
            get { return this.cep; }
        }
        public string Telefone
        {
            set { this.telefone = value;}
            get { return this.telefone; }
        }
        public string Celular
        {
            set { this.celular = value; }
            get { return this.celular; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email;}
        }
        public string Contato
        {
            set { this.contato = value; }
            get { return this.contato; }
        }

    }
}
