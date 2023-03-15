using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace Lanchonete.Class
{
    internal class CorreioService
    {
        public  string ConsultaCep(string Cep)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(Cep.Trim());
                    return $"{endereco.end}, {endereco.bairro}, {endereco.cidade} - {endereco.uf}, {endereco.cep}";

                }
                catch (Exception erro)
                {
                   return  erro.Message.ToString();
                }
            }
        }
    }
}
