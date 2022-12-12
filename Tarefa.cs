using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"User id:{userId}");
            Console.WriteLine($"id:{id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Concluida: {completed}\n");

        }
    }

 
}
