using LojaNatural.Shered.identity;
using System.Collections.Generic;

namespace LojaNatural.Dominio.Entidades
{
    public class Carrinho:Identity
    {
 
        public IList<Produto> MeusProdutos { get; set; }
        public int Quantida { get; set; }
    }
}
