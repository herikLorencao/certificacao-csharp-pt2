using System;
using System.Dynamic;
using Newtonsoft.Json;

namespace certificacao_csharp_roteiro.Aula7___Lidar_com_tipos_dinâmicos._4___Adicionando_Membros_Dinamicamente
{
    public class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                          "\"Para\": \"Guilherme Silveira\"}";

            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);
            mensagem.Texto = "Olá " + mensagem.Para;

            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(() =>
            {
                var aux = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
                mensagem.Texto = "Olá " + mensagem.Para;
            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }
}