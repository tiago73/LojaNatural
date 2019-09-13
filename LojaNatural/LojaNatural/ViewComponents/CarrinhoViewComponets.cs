using LojaNatural.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaNatural.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponents : ViewComponent
    {           
        public int ItemCarrinho { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto> { new Produto { Descricao = "Mel da florada do espinheiro 1L", Nome = "Mel", Preco = 25, Data = new DateTime(25 / 12 / 2017) } };
        public CarrinhoViewComponents()
        {
            ItemCarrinho = 1;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItemCarrinho); 
        }
    }
}
