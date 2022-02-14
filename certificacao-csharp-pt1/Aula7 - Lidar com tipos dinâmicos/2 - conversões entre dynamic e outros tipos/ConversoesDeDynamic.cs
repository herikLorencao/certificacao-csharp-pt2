using System;
using System.Collections.Generic;

namespace certificacao_csharp_roteiro.Aula7___Lidar_com_tipos_dinâmicos._2___conversões_entre_dynamic_e_outros_tipos
{
    public class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic d1 = 7;
            dynamic d2 = "essa é uma string qualquer";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 123, 456, 789 };

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            List<int> lista = d4;
            
            Console.WriteLine(i);
            Console.WriteLine(str);
            Console.WriteLine(dt);
            Console.WriteLine(lista);

            // Gera exceção em tempo de execução
            // int inteiro = d2;
        }
    }
}