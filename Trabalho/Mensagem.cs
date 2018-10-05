using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    class Mensagem
    {
        public static bool Confirmar(string texto, string titulo)
        {
            DialogResult resultado = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        public static void Aviso(string texto, string titulo)
        {
            MessageBox.Show(texto, titulo);
        }
    }
}
