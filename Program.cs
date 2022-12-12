using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto4
{
    internal class Program
    {
      //  public string idnum;
        static void Main(string[] args)
        {
            ReqList();
            Console.Write("Informe o id selecionado: ");
            string idnum = Console.ReadLine();
            ReqUnica(idnum);
            Console.ReadLine();


        }// termino do Main
        static void ReqList()
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");

            requisicao.Method = "GET";
            using (var resposta = requisicao.GetResponse())
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object jsonDados = leitor.ReadToEnd();

                // Console.WriteLine(jsonDados.ToString());
                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(jsonDados.ToString());

                foreach (Tarefa tarefa in tarefas) tarefa.Exibir();
                stream.Close();
                resposta.Close();
            }
        }
        static void ReqUnica(string idnum)
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/"+idnum);

            requisicao.Method = "GET";
            using (var resposta = requisicao.GetResponse())
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object jsonDados = leitor.ReadToEnd();

                // Console.WriteLine(jsonDados.ToString());
                Tarefa tarefa = JsonConvert.DeserializeObject<Tarefa>(jsonDados.ToString());

                tarefa.Exibir();
                stream.Close();
                resposta.Close();
            }
        }
    }//termino do program
}
