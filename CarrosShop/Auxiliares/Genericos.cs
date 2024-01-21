using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosShop.Auxiliares
{
    public class Genericos
    {

        public string FormataValor(decimal valor)
        {
            string valorFormatado;

            if (valor >= 0)
            {
                valorFormatado = valor.ToString("C2");
            }
            else
            {
                valorFormatado = "Não numérico";
            }

            return valorFormatado;
        }


    }
}
