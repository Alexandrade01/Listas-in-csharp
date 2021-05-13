using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoLista
{
    class Program
    {
        static void Listagem(List<string> Lista)
        {
            foreach (object obj in Lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------");
        }
        static void Main(string[] args)
        { // criação de lista -- pode se usar Add para adicionar
            List<string> Lista = new List<string>() { "Joao", "Pedro", "Lucas", "Barnabé", "Tiago", "Judas", "Tomé" };
           
            // ordem alfabetica
           // Lista.Sort();
            //Listagem(Lista);
           
            // Insert -- insere na posição 2
            Lista.Insert(2, "Maria");
            Listagem(Lista);
            
            // Find--- retorna o primeiro elemento que atende o predicado
            string s1 = Lista.Find(x => x[0].Equals('T'));
            Console.WriteLine(s1);
           
            // FindaLast ---- retorna o ultimo elementro que atende o predicado
            string s2 =Lista.FindLast(y => y[0].Equals('T'));
            Console.WriteLine(s2);
            
            // FindIndex -- retorna a primeira posição que atende o precidado
            int s3  = Lista.FindIndex(z => z[1].Equals('u'));
            Console.WriteLine(s3);
           
            // FindaIndexLast -- retorna a ultima posição que atende o predicado
            int s4 = Lista.FindLastIndex(n => n[1].Equals('u'));
            Console.WriteLine(s4);
            
            // FindAll  --- retorna todos os elementos que atende o predicado
            List<string>Lista2 = Lista.FindAll(x => x[x.Length - 1] == 'o');
            Listagem(Lista2);
           
            //Remove --- remove elemento caso encontado
            Lista.Remove("Lucas");
            Listagem(Lista);
           
            // RemoveAll --- remove todos que atendem o predicado
            Lista.RemoveAll(x=>x[0] == 'J');
            Listagem(Lista);
           
            //RemoveAt --- remove a posição
            Lista.RemoveAt(2);
            Listagem(Lista);
            
            //RemoveRange --- primeiro parametro a posição inicial, segundo parametro quantos elementos irao ser removidos
            Lista.RemoveRange(0, 2);
            Listagem(Lista);

            
                   
        }
    }
}
