using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO.Model
{
    public class Bola:Produto
    {
        public decimal Preco { get; set; }

        public Bola( int id, string descricao, decimal preco)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
        }
    }
}
