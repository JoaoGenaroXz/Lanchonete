using Lanchonete.Class;
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
    public partial class F_CadClientes : Form
    {
        public F_CadClientes()
        {
            InitializeComponent();
        }

        private void f_CadClientes_Load(object sender, EventArgs e)
        {
            msk_cpfcnpj.Mask = "";
            p_cadastrocli.Visible = false;
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            p_cadastrocli.Visible = true;
            lb_status.Text = "Alterar";
            tb_codigo.Enabled = false;
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            p_cadastrocli.Visible = true;
            lb_status.Text = "Incluir";
            tb_codigo.Enabled = true;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            p_cadastrocli.Visible = false;
        }

        private void msk_cpfcnpj_Leave(object sender, EventArgs e)
        {
            int qtda = msk_cpfcnpj.Text.Length;

            if(qtda == 11)
            {
                msk_cpfcnpj.Mask = "###.###.###-##";
            }
            else if(qtda == 14)
            {
                msk_cpfcnpj.Mask = "##.###.###/####-##";
            }
            else
            {
                msk_cpfcnpj.Mask = "";
                MessageBox.Show("CPF OU CNPJ é invalido, Por favor " +
                    "informe um CPF ou CNPJ valido");
            }
        }

        private void bt_cep_Click(object sender, EventArgs e)
        {
            //consulta no site dos correios//
            CorreioService consulta = new CorreioService();
            Clientes cliente = new Clientes();
            msk_cep.Mask = "";
            cliente.Cep = msk_cep.Text;

            //chamar o metodo da classe CorreioService//
            if (!string.IsNullOrEmpty(cliente.Cep))
            {
                string end = consulta.ConsultaCep(cliente.Cep);
                if (end.Contains("Invalido"))
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
    }
}
