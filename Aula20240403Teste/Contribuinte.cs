using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240403Teste
{
    public abstract class Contribuinte
    {
        protected string nome;
        protected double rendaBruta;

        public Contribuinte(string nome, double rendaBruta)
        {
            this.nome = nome;
            this.rendaBruta = rendaBruta;
        }

        public abstract double CalcularImposto();

        public virtual string GetDadosContribuinte() { 
        
            return $"\nNome: {nome}\n"+
                $"Renda Bruta: R$ {rendaBruta:F2}\n";
        }
    }
}
