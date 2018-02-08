using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppTestes.Models
{
    public class Tarefa
    {

        public static async Task EnviarEmailAsync()
        {
            await Task.Run(() => Thread.Sleep(500)); // simula envio de email, que dure 500ms       
            Console.WriteLine("Email A enviado.");
        }

        public static async void EnviarEmail()
        {
            await Task.Run(() => Thread.Sleep(500)); // simula envio de email, que dure 500ms       
            Console.WriteLine("Email B enviado.");
        }

    }
}
