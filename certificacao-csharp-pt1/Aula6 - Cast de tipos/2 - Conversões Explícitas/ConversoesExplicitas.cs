using System;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_tipos._2___Conversões_Explícitas
{
    public class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida = 1_258_357_246.12;
            // long copia = divida;

            double salario = 1_237.89;
            long copiaSalario = (long) salario;
            Console.WriteLine(copiaSalario);

            Animal animal = new Gato();
            Gato gato = (Gato) animal;
            Console.WriteLine(gato.GetType());
        }
    }
}