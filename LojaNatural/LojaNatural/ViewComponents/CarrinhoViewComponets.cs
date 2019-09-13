using LojaNatural.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaNatural.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponents : ViewComponent
    {           
        public int ItemCarrinho { get; set; }
        public CarrinhoViewComponents()
        {
            ItemCarrinho = 2;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItemCarrinho); 
        }
    }
}
