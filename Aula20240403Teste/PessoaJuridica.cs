using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240403Teste
{
    public class PessoaJuridica: Contribuinte, iFinanciamento
    {
        private string cnpj;

        public PessoaJuridica(string nome, double rendaBruta, string cnpj): base(nome, rendaBruta)
        {
            this.cnpj = cnpj;
        }

        public override double CalcularImposto()
        {
            return this.rendaBruta * 0.1;
        }

        public override string GetDadosContribuinte()
        {
            return "\nTipo: Pessoa Juridica"+base.GetDadosContribuinte()+$"\nCPF/CNPJ:{this.cnpj}";
        }

        public double CalcularJuros(double valor_emprestado)
        {
            return valor_emprestado * 0.05f;
        }
    }
}
