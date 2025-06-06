using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO.Model
{
    public class Produto
    {

        public int Id { get; set; }
        public string Descricao { get; set; }

        public Produto() { }

        public Produto(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }




        public void Apresentar(Produto produto)
        {
            Console.WriteLine($"ID: {produto.Id}\n" +
                $"Descricao: {produto.Descricao}");
        }

        public void ApresentarLista(List<Produto> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                foreach (Produto produto in lista)
                {
                    Console.WriteLine($"ID: {produto.Id}\n" +
                     $"Descricao: {produto.Descricao}");
                }
            }
        }
    }
}
