using System;

namespace certificacao_csharp_roteiro.Aula7___Lidar_com_tipos_dinâmicos._1___string__var__object_e_dynamic
{
    public class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            string s = "Certificação C#";
            var v = "Certificação C#";
            object o = "Certificação C#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string) o).ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            o = 123;
            o = (int)o + 4;

            Console.WriteLine(o);

            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);
            d = 123;
            Console.WriteLine(d);
            d = d + 4;
            Console.WriteLine(d);
        }
    }
}