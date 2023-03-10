using Lanchonete.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
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
        /// <summary>
        /// VARIAVEL QUE PODE SER ULTILIZADO NA TELA INTEIRA///
        /// </summary>
        int cod = 0;
        int padraoCod = 9;


        private void f_CadClientes_Load(object sender, EventArgs e)
        {
            p_cadastrocli.Visible = false;
            tb_codigo.Text = string.Empty;
            tb_nome.Text = string.Empty;
            tb_apelido.Text = string.Empty;
            msk_cpfcnpj.Text = string.Empty;
            msk_cpfcnpj.Mask = "";
            tb_rg.Text = string.Empty;
            tb_endereco.Text = string.Empty;
            tb_numero.Text = string.Empty;
            msk_cep.Text = string.Empty;
            tb_bairro.Text = string.Empty;
            tb_cidade.Text = string.Empty;
            tb_complemento.Text = string.Empty;
            tb_email.Text = string.Empty;
            msk_telefone.Text = string.Empty;
            msk_celular.Text = string.Empty;
            msk_telefone2.Text = string.Empty;
            msk_celular2.Text = string.Empty;
            tb_contato.Text = string.Empty;

            msk_cpfcnpj.Validating += new CancelEventHandler(msk_cpfcnpj_Validating);
            msk_cep.Validating += new CancelEventHandler(msk_cep_Validating);

            ClienteDAO clienteDAO = new ClienteDAO();
            DataTable clientes = clienteDAO.ListarClientes();
            dg_cliente.DataSource = clientes;
            
            dg_cliente.Refresh();


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
            Clientes clientes = new Clientes();

            string cmdSql = "SELECT * FROM clientes WHERE codigo = '" + clientes.Codigo + "'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if ((dadosS != null))
            {
                DataRow linhaDados = dadosS.Rows[0];

                tb_codigo.Text = linhaDados["codigo"].ToString();
                tb_nome.Text = linhaDados["nome"].ToString();
                tb_apelido.Text = linhaDados["apelido"].ToString();
                msk_cpfcnpj.Text = linhaDados["cpfcnpj"].ToString();
                tb_rg.Text = linhaDados["rg"].ToString();
                tb_endereco.Text = linhaDados["endereco"].ToString();
                tb_bairro.Text = linhaDados["bairro"].ToString();
                msk_cep.Text = linhaDados["cep"].ToString();
                msk_telefone.Text = linhaDados["telefone"].ToString();
                msk_celular.Text = linhaDados["celular"].ToString();
                msk_telefone2.Text = linhaDados["telefone2"].ToString();
                msk_celular2.Text = linhaDados["celular2"].ToString();
                tb_email.Text = linhaDados["email"].ToString();
                tb_numero.Text = linhaDados["endnum"].ToString();
                tb_cidade.Text = linhaDados["cidade"].ToString();
                tb_complemento.Text = linhaDados["complemento"].ToString();
                tb_contato.Text = linhaDados["contato"].ToString();
            }
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            string codBanco;
            
            p_cadastrocli.Visible = true;
            lb_status.Text = "Incluir";
            tb_codigo.Enabled = true;

            string cmdSql = "SELECT MAX(codigo) as max_codigo FROM clientes";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                DataRow linhaDados = dadosS.Rows[0];

                codBanco = linhaDados["max_codigo"].ToString();
                cod = int.Parse(codBanco);
                cod++;
            }
            else
            {
                cod++;
            }
            tb_codigo.Text = cod.ToString().PadLeft(padraoCod, '0');
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            p_cadastrocli.Visible = false;
            
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
                if (!end.Contains("Invalido"))
                {
                    string[] texto = end.Split(',');// efetua a quebra do vetor de string//
                    tb_endereco.Text = texto[0].Trim();// trim tira os espaco em branco
                    tb_bairro.Text = texto[1].Trim();
                    tb_cidade.Text = texto[2].Trim();
                    msk_cep.Text = texto[3].Trim();
                    msk_cep.Mask = "#####-###";
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

        private void bt_comfirmar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            cliente.Codigo = int.Parse(tb_codigo.Text);
            cliente.Nome = tb_nome.Text;
            cliente.Apelido = tb_apelido.Text;
            cliente.Cpfcnpj = msk_cpfcnpj.Text;
            cliente.Rg = tb_rg.Text;
            cliente.Endereco = tb_endereco.Text;
            cliente.Numero = tb_numero.Text;
            cliente.Cep = msk_cep.Text;
            cliente.Bairro = tb_bairro.Text;
            cliente.Cidade = tb_cidade.Text;
            cliente.Complemento = tb_complemento.Text;
            cliente.Email = tb_email.Text;
            cliente.Telefone = msk_telefone.Text;
            cliente.Celular = msk_celular.Text;
            cliente.Telefone2 = msk_telefone2.Text;
            cliente.Celular2 = msk_celular2.Text;
            cliente.Contato = tb_contato.Text;

            cliente.GravaBanco();

            cod++;
            tb_codigo.Text =  cod.ToString().PadLeft(padraoCod, '0');
            tb_nome.Text = string.Empty;
            tb_apelido.Text = string.Empty;
            msk_cpfcnpj.Text = string.Empty;
            msk_cpfcnpj.Mask = "";
            tb_rg.Text = string.Empty;
            tb_endereco.Text = string.Empty;
            tb_numero.Text = string.Empty;
            msk_cep.Text = string.Empty;
            tb_bairro.Text = string.Empty;
            tb_cidade.Text = string.Empty;
            tb_complemento.Text = string.Empty;
            tb_email.Text = string.Empty;
            msk_telefone.Text = string.Empty;
            msk_celular.Text = string.Empty;
            msk_telefone2.Text = string.Empty;
            msk_celular2.Text = string.Empty;
            tb_contato.Text = string.Empty;
        }

        private void msk_cpfcnpj_Leave(object sender, EventArgs e)
        {
            int qtda = msk_cpfcnpj.Text.Length;

            if (qtda == 11)
            {
                msk_cpfcnpj.Mask = "###,###,###-##";
            }
            else if (qtda == 14)
            {
                msk_cpfcnpj.Mask = "##,###,###/####-##";
            }
            else
            {
                msk_cpfcnpj.Text = string.Empty;
                msk_cpfcnpj.Mask = "";
                MessageBox.Show("CPF OU CNPJ é invalido, Por favor " +
                    "informe um CPF ou CNPJ valido");
            }
        }

        private void msk_cpfcnpj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(msk_cpfcnpj.Text))
            {
                e.Cancel = true;
                msk_cpfcnpj.Focus();
                errorProvider1.SetError(msk_cpfcnpj, "Este campo é obrigatório.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(msk_cpfcnpj, "");
            }
        }

        private void msk_cep_Validating(object sender, CancelEventArgs e)
        {
            msk_cep.Mask = "";
            if (string.IsNullOrEmpty(msk_cep.Text))
            {
                e.Cancel = true;
                msk_cep.Focus();
                errorProvider2.SetError(msk_cep, "Este campo é obrigatório.");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(msk_cep, "");
            }
            
        }
    }
}
