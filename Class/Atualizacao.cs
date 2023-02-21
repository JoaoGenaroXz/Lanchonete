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
        string linha;
        string[] arquivo;
        

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
            
            if (Directory.Exists(Path))
            {
                try
                {
                    arquivo = Directory.GetFiles(Path, "*.SQL");
                    for (int a = 0; a < arquivo.Length; a++)
                    {
                        while (arquivo.Length != -1)
                        {
                            StreamReader lendo = new StreamReader(arquivo[a]);
                            while (linha != "exist")
                            {
                                linha = lendo.ReadLine();
                                var dadosI = Program.cx.ExecutaSql(linha);
                            }
                            lendo.Close();
                            File.Delete(arquivo[a]);
                        }
                    }
                }
                catch( Exception erro)
                {
                    this.MsgErro = erro.Message.ToString();
                }
            }
        }
    }
}
