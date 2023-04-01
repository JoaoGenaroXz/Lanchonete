using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lanchonete.Telas;
using System.Threading;
using Lanchonete.Class;

namespace Lanchonete
{
    public partial class F_Principal : Form
    {
        Thread Principal;

        private void AbrirCadEmpresa(object obj)
        {
            Application.Run(new F_CadEmpresas());
        }
        private void AbrirCadClientes(object obj)
        {
            Application.Run(new F_CadClientes());
        }
        private void AbrirCadFornecedor(object obj)
        {
            Application.Run(new F_CadFornecedor());
        }

        public F_Principal()
        {
            InitializeComponent();

            CustomizeDesing();
            HideSubmenu();
        }
        private void CustomizeDesing()
        {
            painelCadSubmenu.Visible = false;
            painelLanSubmenu.Visible = false;
        }
        private void HideSubmenu()
        {
            if (painelCadSubmenu.Visible == true)
            {
                painelCadSubmenu.Visible = false;
            }

            if (painelLanSubmenu.Visible == true)
            {

            }
        }
        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void F_Principal_Load(object sender, EventArgs e)
        {

        }
        private void Bt_Cadastro_Click(object sender, EventArgs e)
        {
            ShowSubmenu(painelCadSubmenu);
        }

        private void Bt_Lancamento_Click(object sender, EventArgs e)
        {
            ShowSubmenu(painelLanSubmenu);
        }
        private void Bt_Empresa_Click(object sender, EventArgs e)
        {
            Principal = new Thread(AbrirCadEmpresa);
            Principal.SetApartmentState(ApartmentState.STA);
            Principal.Start();
        }
        private void bt_clientes_Click(object sender, EventArgs e)
        {
            Principal = new Thread(AbrirCadClientes);
            Principal.SetApartmentState(ApartmentState.STA);
            Principal.Start();
        }

        private void bt_fornecedor_Click(object sender, EventArgs e)
        {
            Principal = new Thread(AbrirCadFornecedor);
            Principal.SetApartmentState(ApartmentState.STA);
            Principal.Start();
        }
    }
}
