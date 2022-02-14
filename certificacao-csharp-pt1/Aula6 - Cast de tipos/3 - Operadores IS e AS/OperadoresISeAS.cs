using System;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_tipos._3___Operadores_IS_e_AS
{
    public class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            // as - cast seguro
            // x = obj as cliente
            // x será null e não lancará exception

            if (obj is Animal animal)
            {
                animal.Andar();
                animal.Beber();
                animal.Comer();
                return;
            }

            Console.WriteLine("O objeto não é do tipo Animal!");
        }
    }
}