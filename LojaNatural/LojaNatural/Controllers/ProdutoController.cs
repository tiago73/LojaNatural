using System;
using System.Collections.Generic;
using LojaNatural.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaNatural.Controllers
{
    public class ProdutoController : Controller
    {
        List<Produto> _Produtos = new List<Produto> { new Produto { Descricao = "Mel da florada do espinheiro 1L", Nome = "Mel", Preco = 25, Data = new DateTime(25/12/2017)} };
        public IActionResult Index()
        {
            return View(_Produtos);
        }
        public IActionResult Adiciona()
        {
            return View();
        }
    }
}