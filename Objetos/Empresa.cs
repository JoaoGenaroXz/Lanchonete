using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Class
{
    class Empresa
    {
        
        private string razao;
        private string fantasia;
        private string cnpj;
        private string inscricaoEstadual;
        private string inscricaoMunicipal;
        private string endereco;
        private string cep;
        private string cidade;
        private string bairro;
        private string telefone;
        private string whatsapp;
        private string email;
        private string num;
        private string complemento;

        public string Razao
        {
            set { this.razao = value; }
            get { return this.razao; }
        }
        public string Fantasia
        {
            set { this.fantasia = value; }
            get { return this.fantasia; }
        }
        public string Endereco
        {
            set { this.endereco = value; }
            get { return this.endereco; }
        }
        public string Cep
        {
            set { this.cep = value; }
            get { return this.cep; }
        }
        public string Bairro
        {
            set { this.bairro = value; }
            get { return this.bairro; }
        }
        public string Cnpj
        {
            set { this.cnpj = value; }
            get { return this.cnpj; }
        }
        public string InscricaoEstadual
        {
            set { this.inscricaoEstadual = value; }
            get { return this.inscricaoEstadual; }

        }
        public string InscricaoMunicipal
        {
            set { this.inscricaoMunicipal = value; }
            get { return this.inscricaoMunicipal; }

        }
        public string Telefone
        {
            set { this.telefone = value; }
            get { return this.telefone; }
        }
        public string Whatsapp
        {
            set { this.whatsapp = value; }
            get { return this.whatsapp; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string Num
        {
            set { this.num = value; }
            get { return this.num; }
        }
        public string Complemento
        {
            set { this.complemento = value; }
            get { return this.complemento; }
        }
        public string Cidade
        {
            set { this.cidade = value; }
            get { return this.cidade; }
        }
        public void GravaBanco()
        {
            string cmdSql = "SELECT * FROM empresa";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if(dadosS != null)
            {
                //atualizar tabela
                string cmdSqlU = "UPDATE empresa SET razao = '"+ Razao +"', fantasia = '"+ Fantasia + "', cnpj = '"+ Cnpj + "', inscesta = '"+ InscricaoEstadual +"' " +
                    ", endereco = '"+ Endereco + "', endnum = '"+ Num + "', bairro = '" + Bairro + "', cep = '"+ Cep + "', cidade = '"+ Cidade + "', complemento = '"+ Complemento +"' " +
                    ", telefone = '"+ Telefone + "', whatsapp = '"+ Whatsapp + "', email = '"+ Email +"' WHERE ctrl = 1";
                var dadosU = Program.cx.ExecutaSql(cmdSqlU);
            }
            else
            {
                //gravando no banco
                string cmdSqlI = "INSERT INTO empresa (razao, fantasia, cnpj, inscesta, endereco, endnum, bairro, cep, cidade, complemento, telefone, whatsapp, email) values" +
                     "('" + Razao + "','" + Fantasia + "','" + Cnpj + "','" + InscricaoEstadual + "','" + Endereco + "','" + Num + "','" + Bairro + "'," +
                     "'" + Cep + "','" + Cidade + "','" + Complemento + "','" + Telefone + "','" + Whatsapp + "','" + Email + "')";
                var dadosI = Program.cx.ExecutaSql(cmdSqlI);
            }

        }

    }
}
