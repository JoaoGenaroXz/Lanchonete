using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lanchonete.Class
{
    class Atualizacao
    {
        private string path;
        private string msgErro;

        public string Path
        {
            set { this.path = value; }
            get { return this.path; }
        }
        public string MsgErro
        {
            set { this.msgErro = value; }
            get { return this.msgErro; }
        }
        public void Atualiza(string Path)
        {
            try
            {
                if (Directory.Exists(Path))
                {
                    string[] arquivos = Directory.GetFiles(Path, "*.SQL");
                    foreach (string arquivo in arquivos)
                    {
                        using (StreamReader lendo = new StreamReader(arquivo))
                        {
                            string linha;
                            while ((linha = lendo.ReadLine()) != null)
                            {
                                Program.cx.ExecutaSql(linha);
                            }
                        }
                        File.Delete(arquivo);
                    }
                }
                ////
                ///fazer ele pegar sem ter um diretorio
                ///
               /* else
                {
                    string[] arquivos = GetFiles("*.SQL");
                    foreach (string arquivo in arquivos)
                    {
                        using (StreamReader lendo = new StreamReader(arquivo))
                        {
                            string linha;
                            while ((linha = lendo.ReadLine()) != null)
                            {
                                Program.cx.ExecutaSql(linha);
                            }
                        }
                        File.Delete(arquivo);
                    }
                }*/
            }
            catch (Exception erro)
            {
                this.MsgErro = erro.Message.ToString();
            }
            /*finally
            {
                
            }*/
        }
    }
}
