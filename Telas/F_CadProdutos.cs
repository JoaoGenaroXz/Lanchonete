using AngleSharp.Text;
using Lanchonete.Class;
using Lanchonete.Objetos;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class F_CadProdutos : Form
    {
        public F_CadProdutos()
        {
            InitializeComponent();
        }

        int cod = 0;
        int padraoCod = 9;
        string cellCod = "";
        string pesq = "";

        private void bt_confirma_Click(object sender, EventArgs e)
        {

        }
        private void F_CadProdutos_Load(object sender, EventArgs e)
        {
            p_cadprod.Visible = false;
            /*ProdutoDAO produtoDAO = new ProdutoDAO();
            DataTable produto = produtoDAO.ListarAtivos();
            dg_Produtos.DataSource = produto;
            dg_Produtos.Refresh();



            ///Configuracao da apresentacao do DATAGRID///

            dg_Produtos.DefaultCellStyle.BackColor = Color.LightSteelBlue;
            string format = "000000000";
            dg_Produtos.Columns[0].DefaultCellStyle.Format = format;

            ////////////////////////////////////////////////////////////////////

            if (dg_Produtos.Rows.Count > 0)
            {
                int lastRowIndex = dg_Produtos.Rows.Count - 1;
                object lastRow = dg_Produtos.Rows[lastRowIndex];

                // Definir o foco na última linha
                dg_Produtos.FirstDisplayedScrollingRowIndex = lastRowIndex;
                dg_Produtos.CurrentCell = dg_Produtos.Rows[lastRowIndex].Cells[0];
                // Definir o foco na última linha
            }*/
        }

        private void bt_desativa_Click(object sender, EventArgs e)
        {
            if (bt_desativa.Text == "Desativar")
            {
                var dataHora = DateTime.Now;

                Clientes clientes = new Clientes();
                clientes.Codigo = int.Parse(cellCod);
                clientes.DataHora = dataHora.ToString();
                clientes.Desativado = "S";
                clientes.Desativar();

                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable client = clienteDAO.ListarAtivos();
                dg_Produtos.DataSource = client;

            }
            else if (bt_desativa.Text == "Ativar")
            {
                var dataHora = DateTime.Now;

                Clientes clientes = new Clientes();
                clientes.Codigo = int.Parse(cellCod);
                clientes.DataHora = dataHora.ToString();
                clientes.Desativado = "N";
                clientes.Desativar();

                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable client = clienteDAO.ListarDesativados();
                dg_Produtos.DataSource = client;
            }
        }

        private void bt_alternar_Click(object sender, EventArgs e)
        {
            lb_statuspro.Text = "DESATIVADOS";

            if (bt_desativa.Text == "Ativar")
            {
                lb_statuspro.Text = "ATIVOS";
                lb_statuspro.ForeColor = Color.DarkBlue;
                bt_desativa.Text = "Desativar";
                bt_incluir.Visible = true;
                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable clientes = clienteDAO.ListarAtivos();
                dg_Produtos.DataSource = clientes;
                dg_Produtos.Refresh();
            }
            else
            {
                lb_statuspro.ForeColor = Color.Red;
                bt_desativa.Text = "Ativar";
                //bt_confirmar.Visible = false;
                bt_incluir.Visible = false;
                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable clientes = clienteDAO.ListarDesativados();
                dg_Produtos.DataSource = clientes;
                dg_Produtos.Refresh();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            p_cadprod.Visible = false;
        }

        private void bt_altPesq_Click(object sender, EventArgs e)
        {

            switch (lb_pesq.Text)
            {
                case "Codigo":
                    lb_pesq.Text = "Apelido";
                    break;
                case "Apelido":
                    lb_pesq.Text = "Descrição";
                    break;
                case "Descrição":
                    lb_pesq.Text = "Codigo";
                    break;
            }
        }

        private void Pesquisar(string tipoPesquisa, string valorPesquisa)
        {
            bool encontrado = false;
            int rowIndex = 0;

            foreach (DataGridViewRow row in dg_Produtos.Rows)
            {
                string valor = row.Cells[tipoPesquisa].Value.ToString();
                if (valor.Contains(valorPesquisa))
                {
                    dg_Produtos.CurrentCell = row.Cells[tipoPesquisa];
                    dg_Produtos.FirstDisplayedScrollingRowIndex = rowIndex;
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

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            p_cadprod.Visible = true;
        }

        private void bt_cadGrupo_Click(object sender, EventArgs e)
        {
            ///
            ///chama a tela de grupos(como fazer?) 
            ///
            ///prod 1>>n grupo(sql)
        }

        private void dg_produto_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dg_Produtos.SelectedCells.Count == 0 && dg_Produtos.Rows.Count > 0)
            {
                // Selecione a última linha
                int lastIndex = dg_Produtos.Rows.Count - 1;
                dg_Produtos.Rows[lastIndex].Selected = true;
                if (dg_Produtos.Rows[lastIndex].Cells.Count > 0 && dg_Produtos.Rows[lastIndex].Cells[0].Value != null)
                {
                    cellCod = dg_Produtos.Rows[lastIndex].Cells[0].Value.ToString();
                }
            }
            else if (dg_Produtos.SelectedCells.Count > 0)
            {
                int rowIndex = dg_Produtos.SelectedCells[0].RowIndex;
                // Selecione a linha inteira
                dg_Produtos.Rows[rowIndex].Selected = true;
                if (dg_Produtos.Rows.Count > rowIndex && dg_Produtos.Rows[rowIndex].Cells.Count > 0 && dg_Produtos.Rows[rowIndex].Cells[0].Value != null)
                {
                    cellCod = dg_Produtos.Rows[rowIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void tb_margem_Leave(object sender, EventArgs e)
        {
            if(tb_margem.Text != "")
            {
                Produtos produtos = new Produtos();
                produtos.PrecoCusto = Convert.ToDouble(tb_custo.Text);
                produtos.Margem = Convert.ToDouble(tb_margem.Text);
                tb_venda.Text = Convert.ToString(produtos.Markup(produtos.Margem, produtos.PrecoCusto));
            }
        }
    }
}
