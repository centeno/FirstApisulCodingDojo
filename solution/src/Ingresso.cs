using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoCinema.src
{
    class Ingresso
    {

        internal static decimal CalcularPreco(TipoPessoa tipoPessoa, DayOfWeek dayOfWeek)
        {
            decimal valor = 0M;

            switch (tipoPessoa)
            {
                case TipoPessoa.CRIANCA:
                    valor = 4.95M;
                    break;
                case TipoPessoa.IDOSO:
                    valor = 5.40M;
                    break;
                case TipoPessoa.ESTUDANTE:
                    valor = 7.20M;
                    break;
                default:
                    break;
            }

            return valor;
        }
    }
}
