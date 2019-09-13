using LojaNatural.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNatural.Dominio.Repositorio
{
    interface ICadastroRepositorio
    {
        void Inserir(Produto produto);
    }
}
