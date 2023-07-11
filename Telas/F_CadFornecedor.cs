using Lanchonete.Class;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Lanchonete.Telas
{
    public partial class F_CadFornecedor : Form
    {
        public F_CadFornecedor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// VARIAVEL QUE PODE SER ULTILIZADO NA TELA INTEIRA///
        /// </summary>
        int cod = 0;
        int padraoCod = 9;
        string cellCod = "";
        string pesq = "";

        private void f_Cadfornecedor_Load(object sender, EventArgs e)
        {
            p_cadastrofor.Visible = false;
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

            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            DataTable fornecedor = fornecedorDAO.ListarAtivos();
            dg_fornecedor.DataSource = fornecedor;
            dg_fornecedor.Refresh();

            ///Configuracao da apresentacao do DATAGRID///

            dg_fornecedor.DefaultCellStyle.BackColor = Color.LightSteelBlue;
            string format = "000000000";
            dg_fornecedor.Columns[0].DefaultCellStyle.Format = format;

            ////////////////////////////////////////////////////////////////////

            if (dg_fornecedor.Rows.Count > 0)
            {
                int lastRowIndex = dg_fornecedor.Rows.Count - 1;
                object lastRow = dg_fornecedor.Rows[lastRowIndex];

                // Definir o foco na última linha
                dg_fornecedor.FirstDisplayedScrollingRowIndex = lastRowIndex;
                dg_fornecedor.CurrentCell = dg_fornecedor.Rows[lastRowIndex].Cells[0];
                // Definir o foco na última linha
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            ///variavel de uso so para o evento///
            int codBanco = 0;
            /////////////////////////////////////

            p_cadastrofor.Visible = true;
            lb_status.Text = "Alterar";
            tb_codigo.Enabled = false;

            bt_cep.Enabled = true;

            tb_nome.Enabled = true;
            tb_apelido.Enabled = true;
            msk_cpfcnpj.Enabled = true;
            tb_rg.Enabled = true;
            tb_endereco.Enabled = true;
            tb_numero.Enabled = true;
            msk_cep.Enabled = true;
            tb_bairro.Enabled = true;
            tb_cidade.Enabled = true;
            tb_complemento.Enabled = true;
            tb_email.Enabled = true;
            msk_telefone.Enabled = true;
            msk_celular.Enabled = true;
            msk_telefone2.Enabled = true;
            msk_celular2.Enabled = true;
            tb_contato.Enabled = true;

            Fornecedor fornecedor = new Fornecedor();
            codBanco = int.Parse(cellCod);


            string cmdSql = "SELECT * FROM fornecedor WHERE codigo = '" + codBanco + "'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if ((dadosS != null))
            {
                DataRow linhaDados = dadosS.Rows[0];

                tb_codigo.Text = linhaDados["codigo"].ToString().PadLeft(padraoCod, '0');
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
            bt_confirmar.Enabled = true;

            tb_codigo.Text = cod.ToString().PadLeft(padraoCod, '0');
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

            string codBanco;

            p_cadastrofor.Visible = true;
            lb_status.Text = "Incluir";
            tb_codigo.Enabled = true;

            string cmdSql = "SELECT MAX(codigo) as max_codigo FROM fornecedor";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                DataRow linhaDados = dadosS.Rows[0];
                codBanco = linhaDados["max_codigo"].ToString();
                if (codBanco == "")
                {
                    codBanco = "0";
                    cod = int.Parse(codBanco);
                    cod++;
                }
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

            p_cadastrofor.Visible = false;
        }

        private void bt_cep_Click(object sender, EventArgs e)
        {
            //consulta no site dos correios//
            CorreioService consulta = new CorreioService();
            Fornecedor fornecedor = new Fornecedor();
            msk_cep.Mask = "";      
            fornecedor.Cep = msk_cep.Text;

            //chamar o metodo da classe CorreioService//
            if (!string.IsNullOrEmpty(fornecedor.Cep))
            {
                string end = consulta.ConsultaCep(fornecedor.Cep);
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

        private void bt_confirmar_Click(object sender, EventArgs e)
        {

            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Codigo = int.Parse(tb_codigo.Text);
            fornecedor.Nome = tb_nome.Text;
            fornecedor.Apelido = tb_apelido.Text;
            fornecedor.Cpfcnpj = msk_cpfcnpj.Text;
            fornecedor.Rg = tb_rg.Text;
            fornecedor.Endereco = tb_endereco.Text;
            fornecedor.Numero = tb_numero.Text;
            fornecedor.Cep = msk_cep.Text;
            fornecedor.Bairro = tb_bairro.Text;
            fornecedor.Cidade = tb_cidade.Text;
            fornecedor.Complemento = tb_complemento.Text;
            fornecedor.Email = tb_email.Text;
            fornecedor.Telefone = msk_telefone.Text;
            fornecedor.Celular = msk_celular.Text;
            fornecedor.Telefone2 = msk_telefone2.Text;
            fornecedor.Celular2 = msk_celular2.Text;
            fornecedor.Contato = tb_contato.Text;

            // Chama o evento de validação do campo de CPF/CNPJ
            CancelEventArgs args = new CancelEventArgs();
            msk_cpfcnpj_Validating(msk_cpfcnpj, args);
            CancelEventArgs argsCep = new CancelEventArgs();
            msk_cep_Validating(msk_cep, argsCep);

            // Verifica se houve algum erro de validação
            if (args.Cancel)
            {
                // Caso haja, exibe uma mensagem de erro para o usuário
                MessageBox.Show("O campo CPF/CNPJ é obrigatório. Por favor, preencha-o corretamente.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (argsCep.Cancel)
            {
                MessageBox.Show("O campo CEP é obrigatório. Por favor, preencha-o corretamente.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fornecedor.GravaBanco();
                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                DataTable fornec = fornecedorDAO.ListarAtivos();
                dg_fornecedor.DataSource = fornec;
                dg_fornecedor.Refresh();

                cod++;
                tb_codigo.Text = cod.ToString().PadLeft(padraoCod, '0');
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

        private void dg_cliente_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dg_fornecedor.SelectedCells.Count == 0 && dg_fornecedor.Rows.Count > 0)
            {
                // Selecione a última linha
                int lastIndex = dg_fornecedor.Rows.Count - 1;
                dg_fornecedor.Rows[lastIndex].Selected = true;
                if (dg_fornecedor.Rows[lastIndex].Cells.Count > 0 && dg_fornecedor.Rows[lastIndex].Cells[0].Value != null)
                {
                    cellCod = dg_fornecedor.Rows[lastIndex].Cells[0].Value.ToString();
                }
            }
            else if (dg_fornecedor.SelectedCells.Count > 0)
            {
                int rowIndex = dg_fornecedor.SelectedCells[0].RowIndex;
                // Selecione a linha inteira
                dg_fornecedor.Rows[rowIndex].Selected = true;
                if (dg_fornecedor.Rows.Count > rowIndex && dg_fornecedor.Rows[rowIndex].Cells.Count > 0 && dg_fornecedor.Rows[rowIndex].Cells[0].Value != null)
                {
                    cellCod = dg_fornecedor.Rows[rowIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void bt_desativa_Click(object sender, EventArgs e)
        {
            if (bt_desativa.Text == "Desativar")
            {
                var dataHora = DateTime.Now;

                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Codigo = int.Parse(cellCod);
                fornecedor.DataHora = dataHora.ToString();
                fornecedor.Desativado = "S";
                fornecedor.Desativar();

                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                DataTable fornec = fornecedorDAO.ListarAtivos();
                dg_fornecedor.DataSource = fornec;

            }
            else if (bt_desativa.Text == "Ativar")
            {
                var dataHora = DateTime.Now;

                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Codigo = int.Parse(cellCod);
                fornecedor.DataHora = dataHora.ToString();
                fornecedor.Desativado = "N";
                fornecedor.Desativar();

                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                DataTable fornec = fornecedorDAO.ListarAtivos();
                dg_fornecedor.DataSource = fornec;
            }
        }

        private void bt_alternar_Click(object sender, EventArgs e)
        {
            lb_statusfor.Text = "FORNEC. DESATIVADOS";
            dg_fornecedor.DefaultCellStyle.BackColor = Color.Tomato;

            if (bt_desativa.Text == "Ativar")
            {
                lb_statusfor.Text = "FORNEC. ATIVOS";
                dg_fornecedor.DefaultCellStyle.BackColor = Color.LightSteelBlue;

                lb_statusfor.ForeColor = Color.DarkBlue;
                bt_desativa.Text = "Desativar";
                bt_incluir.Visible = true;
                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                DataTable fornecedor = fornecedorDAO.ListarAtivos();
                dg_fornecedor.DataSource = fornecedor;
                dg_fornecedor.Refresh();
            }
            else
            {
                lb_statusfor.ForeColor = Color.Red;
                bt_desativa.Text = "Ativar";
                bt_confirmar.Visible = false;
                bt_incluir.Visible = false;
                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                DataTable fornecedor = fornecedorDAO.ListarDesativados();
                dg_fornecedor.DataSource = fornecedor;
                dg_fornecedor.Refresh();
            }
        }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            ///variavel de uso so para o evento///
            int codBanco = 0;
            /////////////////////////////////////

            p_cadastrofor.Visible = true;
            lb_status.Text = "Visualizar";
            tb_codigo.Enabled = false;
            bt_confirmar.Visible = false;
            bt_cep.Enabled = false;

            tb_nome.Enabled = false;
            tb_apelido.Enabled = false;
            msk_cpfcnpj.Enabled = false;
            tb_rg.Enabled = false;
            tb_endereco.Enabled = false;
            tb_numero.Enabled = false;
            msk_cep.Enabled = false;
            tb_bairro.Enabled = false;
            tb_cidade.Enabled = false;
            tb_complemento.Enabled = false;
            tb_email.Enabled = false;
            msk_telefone.Enabled = false;
            msk_celular.Enabled = false;
            msk_telefone2.Enabled = false;
            msk_celular2.Enabled = false;
            tb_contato.Enabled = false;

            Fornecedor fornecedor = new Fornecedor();
            codBanco = int.Parse(cellCod);

            string cmdSql = "SELECT * FROM fornecedor WHERE codigo = '" + codBanco + "'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if ((dadosS != null))
            {
                DataRow linhaDados = dadosS.Rows[0];

                tb_codigo.Text = linhaDados["codigo"].ToString().PadLeft(padraoCod, '0');
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

        private void bt_altPesq_Click(object sender, EventArgs e)
        {

            switch (lb_pesq.Text)
            {
                case "Codigo":
                    lb_pesq.Text = "Apelido";
                    break;
                case "Apelido":
                    lb_pesq.Text = "Nome";
                    break;
                case "Nome":
                    lb_pesq.Text = "Codigo";
                    break;
            }
        }

        private void Pesquisar(string tipoPesquisa, string valorPesquisa)
        {
            bool encontrado = false;
            int rowIndex = 0;

            foreach (DataGridViewRow row in dg_fornecedor.Rows)
            {
                string valor = row.Cells[tipoPesquisa].Value.ToString();
                if (valor.Contains(valorPesquisa))
                {
                    dg_fornecedor.CurrentCell = row.Cells[tipoPesquisa];
                    dg_fornecedor.FirstDisplayedScrollingRowIndex = rowIndex;
                    encontrado = true;
                    break;
                }
                rowIndex++;
            }

            if (!encontrado)
            {
                MessageBox.Show("Nenhum resultado encontrado!");
            }
        }

        private void bt_pesq_Click(object sender, EventArgs e)
        {
            pesq = tb_pesq.Text;
            Pesquisar(lb_pesq.Text, pesq);
        }
    }
}
          