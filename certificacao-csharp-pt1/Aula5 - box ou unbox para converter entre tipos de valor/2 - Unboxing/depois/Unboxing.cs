using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;      // tipo de valor
            object caixa = numero;

            try
            {
                int valor = (int)caixa;
                Console.WriteLine($"Valor do cast: {valor}");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Cast inválido");
            }
        }
    }
}
