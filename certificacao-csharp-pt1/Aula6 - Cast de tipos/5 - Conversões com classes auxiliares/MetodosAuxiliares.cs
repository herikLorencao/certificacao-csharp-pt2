using System;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_tipos._5___Conversões_com_classes_auxiliares
{
    public class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";

            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            // numeroConvertido = int.Parse(textoDigitado);
            int.TryParse(textoDigitado, out numeroConvertido);

            if (int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine(numeroConvertido);
            }
            else
            {
                Console.WriteLine("O texto não é um número");
            }

            textoDigitado = "123.45";
            decimal.TryParse(
                textoDigitado,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal valorConvertido
            );
            Console.WriteLine(valorConvertido);
        }
    }
}