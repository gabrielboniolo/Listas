using System.Collections.Generic;
using System.Diagnostics;

namespace PraticandoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Declarando e instanciando uma lista:
            List<string> list = new List<string>();

            //Adicionando elementos na lista:
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach(string obj in list) 
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");

            //Tamanho da lista
            Console.WriteLine($"List Count: {list.Count}");

            Console.WriteLine("------------------------------");

            //Primeiro elemento que começa com a letra A:
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");

            //Último elemento que começa com a letra A:
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            //Índice do primeiro elemento que começar com a letra A:
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First position 'A': {pos1}");

            //Índice do último elemento que começar com a letra A:
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");

            Console.WriteLine("------------------------------");

            //Filtrando uma lista (nomes que possuem 5 letras):
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");

            //Removendo itens de uma lista:
            list.Remove("Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");

            //Removendo itens de uma lista (nomes/strings que começarem com M):
            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");

            /*
            //Removendo itens da lista através de seu índice:
            list.RemoveAt(4);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");

            //Removendo itens por quantidade, referente a um determinado índice;
            //Exemplo: Remover 3 itens a partir do índice 0 (incluindo o mesmo):
            list.RemoveRange(0, 3);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
           */
        }
    }
}