using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete.Class
{
    internal class Customizar
    {
        public static void CustomizeForm(Form form)
        {
            // Personalize o formulário aqui
            form.BackColor = Color.LightGray;
            form.Font = new Font("Arial", 12);
            // ... adicione outras personalizações conforme necessário
        }

    }
}
