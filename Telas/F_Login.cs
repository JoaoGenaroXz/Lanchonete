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
  public partial class F_Login : Form
  {
    public F_Login()
    {
      InitializeComponent();
    }
        
    private void BT_Confirma_Click(object sender, EventArgs e)
    {
            Usuario login = new Usuario();
            login.Nome = TX_Usuario.Text;
            login.Senha = TX_Senha.Text;
            
            if (login.Autenticar(login.Nome, login.Senha))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Usuario ou senha incoreto");
            }
    }
    private void BT_Cancelar_Click(object sender, EventArgs e)
    {
         this.Close();
    }
  }
}
