using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lanchonete.Class
{
    class Usuario
    {

        private string nome;
        private int codigo;
        private string senha;
        private string userLogado;
        public bool valido;
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public string UserLogado
        {
            set { this.userLogado = value; }
            get { return this.userLogado; }
        }
        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Senha
        {
            set { this.senha = value; }
            get { return this.senha; }
        }
        //metodos
        public bool Autenticar(string Nome,string Senha)
        {
            valido = false;
            var dados = Program.cx.ExecutaSql ("SELECT * FROM usuario WHERE nomeuser = '"+ Nome + "' and senhauser = '"+ Senha + "'");

            if (dados != null)
            {
                DataRow linhaDados = dados.Rows[0];
                string loginBanco = linhaDados["nomeuser"].ToString();
                if (loginBanco == Nome)
                {
                    string senhaBanco = linhaDados["senhauser"].ToString();
                    if (senhaBanco == Senha)
                    {
                       //UserLogado = Nome;
                       valido = true;
                    }
                }
            }
            return valido;
        }
    }
}
