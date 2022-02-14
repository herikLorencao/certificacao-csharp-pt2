using System;

namespace certificacao_csharp_roteiro.Aula7___Lidar_com_tipos_dinâmicos._3___Resolução_de_Sobrecarga
{
    public class ResolucaoSobrecarga : IAulaItem
    {
        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;
            
            short short1 = 123;
            short short2 = 456;

            double double1 = 123.45;
            double double2 = 456.78;

            Console.WriteLine(Somar(int1, int2));
            Console.WriteLine(Somar(short1, short2));
            Console.WriteLine(Somar(double1, double2));
            Console.WriteLine(Somar("abc", "def"));
        }

        // int Somar(int valor1, int valor2)
        // {
        //     return valor1 + valor2;
        // }
        //
        // short Somar(short valor1, short valor2)
        // {
        //     return valor1 + valor2;
        // }
        //
        // object Somar(object valor1, object valor2)
        // {
        //     return (double)valor1 + (double)valor2;
        // }

        // o compilador considera como object Somar(object valor1, object valor2)
        dynamic Somar(dynamic valor1, dynamic valor2)
        {
            return valor1 + valor2;
        }
    }
}