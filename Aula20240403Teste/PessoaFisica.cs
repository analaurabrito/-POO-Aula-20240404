using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240403Teste
{
    internal class PessoaFisica:Contribuinte, iFinanciamento
    {
        private string cpf;
        public PessoaFisica(string nome, double rendaBruta, string cpf) : base(nome, rendaBruta)
        {
            this.cpf = cpf;
        }

        public override double CalcularImposto()
        {
            double aliquota = 0;
            double parcelaDeduzir = 0;

            if (this.rendaBruta <= 1400)
            {
                aliquota = 0;
                parcelaDeduzir = 0;
            }
            else if (this.rendaBruta <= 2100)
            {
                aliquota = 0.1;
                parcelaDeduzir = 100;
            }
            else if (this.rendaBruta <= 2800)
            {
                aliquota = 0.15;
                parcelaDeduzir = 270;
            }
            else if (this.rendaBruta <= 3600)
            {
                aliquota = 0.25;
                parcelaDeduzir = 500;
            }
            else {
                aliquota = 0.3;
                parcelaDeduzir = 700;
            }

            return (rendaBruta*aliquota)-parcelaDeduzir;
        }
        public override string GetDadosContribuinte()
        {
            return "\nTipo: Pessoa Fisica" + base.GetDadosContribuinte() + $"\nCPF/CNPJ:{this.cpf}";
        }

        public double CalcularJuros(double valor_emprestado)
        {
            return valor_emprestado * 0.20f;
        }
    }
}
