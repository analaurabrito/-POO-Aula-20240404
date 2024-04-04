using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240403Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Contribuinte> contribuintes= new List<Contribuinte>();
            contribuintes.Add(new PessoaFisica("João Santos",3000,"11111"));
            contribuintes.Add(new PessoaJuridica("Lojas AA", 150000, "10055"));
            contribuintes.Add(new PessoaFisica("Maria Soares", 500, "22222"));
            contribuintes.Add(new PessoaJuridica("Supermercados B", 200000, "10066"));

            Console.WriteLine("**Lista de Contribuintes e IR**");

            foreach (Contribuinte c in contribuintes) {
                Console.WriteLine("--------------------------");
                Console.WriteLine(c.GetDadosContribuinte());
                Console.WriteLine($"Imposto de Renda: {c.CalcularImposto():F2}");

            }
        }
    }
}
