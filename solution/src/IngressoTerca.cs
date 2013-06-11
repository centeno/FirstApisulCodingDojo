using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoCinema.src
{
    class IngressoTerca
    {
        private Pessoa p;

        public IngressoTerca(Pessoa p)
        {
            this.p = p;
        }

        public decimal valor()
        {
            if(p.GetType() == typeof(Estudante))
                return p.Valor * 0.95M;
            else
                return p.Valor * 0.85M;
        }
    }
}
