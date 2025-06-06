using ConsoleAppPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO.Controller
{
    public class BolaController
    {

        List<Bola> listaBola = new List<Bola>();

        public List<Bola> Adicionar(Bola bola)
        {
            listaBola.Add(bola);
            return listaBola;
        }
        public void Listar(List<Bola> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                foreach (Bola bola in lista)
                {
                    Console.WriteLine($"ID: {bola.Id}\n" +
                     $"Descricao: {bola.Descricao}\n" +
                     $"Preço: {bola.Preco}");
                }
            }
        }
    }
}

