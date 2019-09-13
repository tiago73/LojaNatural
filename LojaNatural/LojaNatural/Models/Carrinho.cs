using LojaNatural.Dominio.Entidades;
using LojaNatural.Shered.identity;
using System.Collections.Generic;

namespace LojaNatural.Models
{
    public class Carrinho : Identity
    {
        public IList<Produto> Produto  { get; set; }
        public int Quantidade { get; set; }
    }
}
