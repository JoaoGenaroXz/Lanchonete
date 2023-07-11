using Lanchonete.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Lanchonete.Class;
using System.IO;


namespace Lanchonete
{
  static class Program
  {

       public static Conexao cx = new Conexao("localhost", "5433", "Lanchonete", "postgres", "root");

      /// <summary>
      /// Ponto de entrada principal para o aplicativo.
      /// </summary>
      [STAThread]
      static void Main()
      {
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
      
          if (cx.testarConexao())
          {
              //criando as tabelas
              string cmdSql = "CREATE TABLE IF NOT EXISTS usuario(codigo SERIAL PRIMARY KEY, nomeuser CHARACTER VARYING(50), senhauser CHARACTER VARYING(50) )";
              var dados = Program.cx.ExecutaSql(cmdSql);

              Atualizacao local = new Atualizacao();
              local.Path = (@"E:\Atualização\");
              local.Atualiza(local.Path);

              string cmdSqlS = "SELECT nomeuser FROM usuario WHERE nomeuser = 'teste'";
              var dadosS = Program.cx.ExecutaSql(cmdSqlS);



              if (dadosS != null)
              {
                  F_Login loginU = new F_Login();
                  DialogResult resultadoU = loginU.ShowDialog();

                  if (resultadoU == DialogResult.Yes)
                  {
                      Application.Run(new F_Principal());
                  }
              }
              else
              {
                  var dadosI = Program.cx.ComandoSql("INSERT INTO usuario(nomeuser,senhauser) VALUES ('teste', 'teste')");
                  F_Login login = new F_Login();
                  DialogResult resultado = login.ShowDialog();

                  if (resultado == DialogResult.Yes)
                  {
                      Application.Run(new F_Principal());
                  }
              }
          }
          else
          {
              MessageBox.Show(
                  cx.getMsgErro(),
                      "Erro de conexão",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
          }
      }
  }
}
