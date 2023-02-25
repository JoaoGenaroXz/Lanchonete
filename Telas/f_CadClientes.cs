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
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            p_cadastrocli.Visible = true;
            lb_status.Text = "Incluir";
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            p_cadastrocli.Visible = false;
        }
    }
}
