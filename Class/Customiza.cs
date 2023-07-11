using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete.Class
{
    internal class Customiza
    {
        public class CustomForm : Form
        {
            public CustomForm()
            {
                // Adicione suas personalizações para o formulário aqui
            }
        }

        // Classe personalizada do rótulo (label)
        public class CustomLabel : Label 
        {
            public CustomLabel()
            {
                // Adicione suas personalizações para o rótulo aqui
            }
        }

        // Classe personalizada da caixa de texto (textbox)
        public class CustomTextBox : TextBox
        {
            public CustomTextBox()
            {
                // Adicione suas personalizações para a caixa de texto aqui
            }
        }

        // Classe personalizada da grade de dados (datagrid)
        public class CustomDataGridView : DataGridView
        {
            public CustomDataGridView()
            {
                // Adicione suas personalizações para a grade de dados aqui
            }
        }
    }
}
