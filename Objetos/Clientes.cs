using AngleSharp.Dom;
using Lanchonete.WSCorreios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lanchonete.Class
{
    internal class Clientes
    {
        private int codigo;
        private string nome;
        private string apelido;
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
        private string telefone2;
        private string celular2;
        private string email;
        private string contato;
        private string desativado;
        private string dataHora;
        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public string Apelido
        {
            set { this.apelido = value; }
            get { return this.apelido; }
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
        public string Telefone2
        {
            set { this.telefone2 = value; }
            get { return this.telefone2; }
        }
        public string Celular2
        {
            set { this.celular2 = value; }
            get { return this.celular2; }
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
        public string Desativado
        {
            set { this.desativado = value; }
            get { return this.desativado; }
        }
        public string DataHora
        {
            set { this.dataHora = value; }
            get { return this.dataHora; }
        }


        ////////////METODOS DO CLIENTE//////////
        public void GravaBanco()
        {
            string cmdSql = "SELECT * FROM clientes WHERE codigo = '" + Codigo+ "'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                //atualizar tabela
                string cmdSqlU = "UPDATE clientes SET nome = '" + Nome + "', apelido = '" + Apelido + "', cpfcnpj = '" + Cpfcnpj + "', rg = '" + Rg + "' " +
                    ", endereco = '" + Endereco + "', endnum = '" + Numero + "', bairro = '" + Bairro + "', cep = '" + Cep + "', cidade = '" + Cidade + "', complemento = '" + Complemento + "' " +
                    ", telefone = '" + Telefone + "', celular = '" + Celular + "', email = '" + Email + "', telefone2 = '" + Telefone2 + "', celular2 = '" + Celular2 + "', contato = '" + Contato + "' WHERE codigo = '" + Codigo + "'";
                var dadosU = Program.cx.ExecutaSql(cmdSqlU);
            }
            else
            {
                //gravando no banco
                string cmdSqlI = "INSERT INTO clientes (codigo, nome, apelido, cpfcnpj, rg, endereco, endnum, bairro, cep, cidade, complemento, telefone, celular, telefone2, celular2, email, contato, desativado) values" +
                     "('" + Codigo + "','" + Nome + "','" + Apelido + "','" + Cpfcnpj + "','" + rg + "','" + Endereco + "','" + Numero + "','" + Bairro + "'," +
                     "'" + Cep + "','" + Cidade + "','" + Complemento + "','" + Telefone + "','" + Celular + "','" + Telefone2 + "','" + Celular2 + "','" + Email + "','" + Contato + "','N')";
                var dadosI = Program.cx.ExecutaSql(cmdSqlI);
            }
        }
        public void Desativar()
        {
            string cmdSql = "SELECT FROM clientes WHERE codigo = '" + Codigo + "'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if(dadosS != null)
            {
                string cmdSqlI = "INSERT INTO clientes (desativado, datahora) value (" + Desativado + "'," + DataHora + ") WHERE codigo = '" + Codigo + "'";
                var dadosI = Program.cx.ExecutaSql(cmdSqlI);
               
            }
            else
            {
                string cmdSqlU = "UPDATE clientes SET desativado = '" + Desativado + "', datahora ='" + DataHora + "' WHERE codigo = '" + Codigo + "'";
                var dadosU = Program.cx.ExecutaSql(cmdSqlU);
            }
        }
    }
}








