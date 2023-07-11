using AngleSharp.Dom;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lanchonete.Objetos
{
    internal class Produtos
    {
        private int codigo;
        private string descricao;
        private string abreviado;
        private string marcas;
        private double precoCusto;
        private double margem;
        private double precoVenda;
        private string desativado;
        private string dataHora;

        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Descricao
        {
            set { this.descricao = value; }
            get { return this.descricao; }
        }
        public string Abreviado
        {
            set { this.abreviado = value; }
            get { return this.abreviado; }
        }
        public string Marcas
        {
            set { this.marcas = value; }
            get { return this.marcas; }
        }
        public double PrecoCusto
        {
            set { this.precoCusto = value; }
            get { return this.precoCusto; }
        }
        public double Margem
        {
            set { this.margem = value;} 
            get { return this.margem; }
        }
        public double PrecoVenda
        {
            set { this.precoVenda = value;}
            get { return this.precoVenda;}
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

        public void GravaBanco()
        {
            /*
            string cmdSql = "SELECT * FROM fornecedor WHERE codigo = '" + Codigo + "'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                //atualizar tabela
                string cmdSqlU = "UPDATE fornecedor SET nome = '" + Nome + "', apelido = '" + Apelido + "', cpfcnpj = '" + Cpfcnpj + "', rg = '" + Rg + "' " +
                    ", endereco = '" + Endereco + "', endnum = '" + Numero + "', bairro = '" + Bairro + "', cep = '" + Cep + "', cidade = '" + Cidade + "', complemento = '" + Complemento + "' " +
                    ", telefone = '" + Telefone + "', celular = '" + Celular + "', email = '" + Email + "', telefone2 = '" + Telefone2 + "', celular2 = '" + Celular2 + "', contato = '" + Contato + "' WHERE codigo = '" + Codigo + "'";
                var dadosU = Program.cx.ExecutaSql(cmdSqlU);
            }
            else
            {
                //gravando no banco
                string cmdSqlI = "INSERT INTO fornecedor (codigo, nome, apelido, cpfcnpj, rg, endereco, endnum, bairro, cep, cidade, complemento, telefone, celular, telefone2, celular2, email, contato, desativado) values" +
                "('" + Codigo + "','" + Nome + "','" + Apelido + "','" + Cpfcnpj + "','" + rg + "','" + Endereco + "','" + Numero + "','" + Bairro + "'," +
                     "'" + Cep + "','" + Cidade + "','" + Complemento + "','" + Telefone + "','" + Celular + "','" + Telefone2 + "','" + Celular2 + "','" + Email + "','" + Contato + "','N')";
                var dadosI = Program.cx.ExecutaSql(cmdSqlI);
            }*/
        }
        public void Desativar()
        {
            string cmdSql = "SELECT FROM fornecedor WHERE codigo = '" + Codigo + "'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                string cmdSqlI = "INSERT INTO fornecedor (desativado, datahora) value (" + Desativado + "'," + DataHora + ") WHERE codigo = '" + Codigo + "'";
                var dadosI = Program.cx.ExecutaSql(cmdSqlI);

            }
            else
            {
                string cmdSqlU = "UPDATE fornecedor SET desativado = '" + Desativado + "', datahora ='" + DataHora + "' WHERE codigo = '" + Codigo + "'";
                var dadosU = Program.cx.ExecutaSql(cmdSqlU);
            }
        }
        public double Markup(double PrecoCusto, double Margem)
        {
            double _marge = 10;
            Margem = (Margem - _marge) / 100;
            PrecoVenda = PrecoCusto / Margem;
            return PrecoVenda;
        }
    }
}
