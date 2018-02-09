using AppTestes.Models;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace AppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task.Run(async () =>
            //{
            //    await Execute();
            //});

            //var deb = new Debugar();

            //Task.Run(async () =>
            //{
            //    Console.WriteLine("Inicio de envio de emails.");
            //    await Tarefa.EnviarEmailAsync();
            //    Tarefa.EnviarEmail();

            //    Console.WriteLine("Fim de execução.");
            //}).Wait();

            ReflectionTest();

            Console.ReadLine();
        }

       static void ReflectionTest()
       {
            var metodo = "Executar";

            var parametros = new string[]{ "Laranja", "Maça", "Banana" };

            Type type = typeof(Methods);
            MethodInfo info = type.GetMethod(metodo);
            
            foreach(var param in parametros)
            {
                info.Invoke(null, new object[] { param });
            }

        }

        private static async Task Execute()
        {
            var resultado = await Skip_Take.GetSkip();

            var resultado2 = await Skip_Take.GetTake();

            resultado.ForEach(c => Console.WriteLine(c));

            resultado2.ForEach(c => Console.WriteLine(c));

        }
    }
}
