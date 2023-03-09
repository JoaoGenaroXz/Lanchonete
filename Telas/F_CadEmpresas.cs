using Lanchonete.Class;
using Lanchonete.WSCorreios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lanchonete.Telas
{
    public partial class F_CadEmpresas : Form
    {
        public F_CadEmpresas()
        {
            InitializeComponent();
        }
        private void BT_Confirma_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            empresa.Razao = TB_Razao.Text;
            empresa.Fantasia = tb_fantasia.Text;
            empresa.Cnpj = msk_cnpj.Text;
            empresa.InscricaoEstadual = tb_inscEsta.Text;
            empresa.Endereco = tb_endereco.Text;
            empresa.Bairro = tb_bairro.Text;
            empresa.Cep = msk_cep.Text;
            empresa.Cidade = tb_cidade.Text;
            empresa.Email = tb_email.Text;
            empresa.Num = tb_num.Text;
            empresa.Complemento = tb_complemento.Text;
            empresa.Telefone = msk_telefone.Text;
            empresa.Whatsapp = msk_whatsapp.Text;
            
            empresa.GravaBanco();
           
        }
        private void F_CadEmpresas_Load(object sender, EventArgs e)
        {
            TB_Razao.Text = string.Empty;
            tb_fantasia.Text = string.Empty;
            msk_cnpj.Text = string.Empty;
            tb_inscEsta.Text = string.Empty;
            tb_endereco.Text = string.Empty;
            tb_bairro.Text = string.Empty;
            msk_cep.Text = string.Empty;
            msk_telefone.Text = string.Empty;
            msk_whatsapp.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_num.Text = string.Empty;
            tb_cidade.Text = string.Empty;
            tb_complemento.Text = string.Empty;

            string cmdSql = "SELECT * FROM empresa WHERE ctrl = 1";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if ((dadosS != null))
            {
                DataRow linhaDados = dadosS.Rows[0];

                TB_Razao.Text = linhaDados["razao"].ToString();
                tb_fantasia.Text = linhaDados["fantasia"].ToString();
                msk_cnpj.Text = linhaDados["cnpj"].ToString();
                tb_inscEsta.Text = linhaDados["inscesta"].ToString();
                tb_endereco.Text = linhaDados["endereco"].ToString();
                tb_bairro.Text = linhaDados["bairro"].ToString();
                msk_cep.Text = linhaDados["cep"].ToString();
                msk_telefone.Text = linhaDados["telefone"].ToString();
                msk_whatsapp.Text = linhaDados["whatsapp"].ToString();
                tb_email.Text = linhaDados["email"].ToString();
                tb_num.Text = linhaDados["endnum"].ToString();
                tb_cidade.Text = linhaDados["cidade"].ToString();
                tb_complemento.Text = linhaDados["complemento"].ToString();
            }           
        }
        private void bt_cep_Click(object sender, EventArgs e)
        {
            //consulta no site dos correios//
            CorreioService consulta = new CorreioService();
            Empresa empresa = new Empresa();
            msk_cep.Mask = "";
            empresa.Cep = msk_cep.Text;

            //chamar o metodo da classe CorreioService//
            if(!string.IsNullOrEmpty(empresa.Cep))
            {
                string end = consulta.ConsultaCep(empresa.Cep);
                if(!end.Contains("Invalido"))
                {
                    string[] texto = end.Split(',');// efetua a quebra do vetor de string//
                    tb_endereco.Text = texto[0].Trim();// trim tira os espaco em branco
                    tb_bairro.Text = texto[1].Trim();
                    tb_cidade.Text = texto[2].Trim();
                    msk_cep.Text = texto[3].Trim();
                }
                else
                {
                    MessageBox.Show("CEP invalido, por favor informe um CEP valido");
                }
            }
            else
            {
                MessageBox.Show("CEP invalido ou campo esta vazio," +
                    " por favor Preencher o campo");
            }
        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
