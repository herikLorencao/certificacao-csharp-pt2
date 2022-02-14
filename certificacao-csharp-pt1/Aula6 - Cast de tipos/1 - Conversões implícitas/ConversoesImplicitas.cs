using System;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_tipos._1___Conversões_implícitas
{
    public class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;

            Gato gato = new Gato();
            Animal animal = gato;
            // animal.Miar(); - isso não funciona mesmo com o GetType sendo Gato
            Console.WriteLine(animal.GetType());
            IAnimal ianimal = gato;
            Console.WriteLine(ianimal.GetType());
        }
    }
}