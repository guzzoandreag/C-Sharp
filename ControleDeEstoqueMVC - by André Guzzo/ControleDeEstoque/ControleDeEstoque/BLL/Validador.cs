using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque.BLL
{
    class Validador
    {
        public static void ENumero(KeyPressEventArgs caracter)
        {
            if (char.IsDigit(caracter.KeyChar))
            {
                caracter.Handled = false;
            }
            else
            {
                if (char.IsControl(caracter.KeyChar))
                {
                    caracter.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(caracter.KeyChar))
                    {
                        caracter.Handled = false;
                    }
                    else
                    {
                        caracter.Handled = true;
                    }
                }
            }
        }

        public static bool ETexto(string paramCaracteres)
        {
            char[] localCaracteres = paramCaracteres.ToCharArray();
            bool result = false;

            foreach (var caracter in localCaracteres)
            {
                if (char.IsDigit(caracter))
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
