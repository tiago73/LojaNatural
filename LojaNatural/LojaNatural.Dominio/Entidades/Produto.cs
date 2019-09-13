using LojaNatural.Shered.identity;
using Microsoft.Build.Framework;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaNatural.Dominio.Entidades
{
    public class Produto:Identity
    {
        [Required(ErrorMessage = "O campo Nome é obrigatorio")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nome precisa ter entre 3 ou 30 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo Discrção é obrigatorio")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "Descrição precisa ter entre 20 ou 200 caracteres")]
        public string Descricao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data no formato incorreto")]
        [Required(ErrorMessage = "O campo data é obrigatorio")]
        public DateTime Data { get; set; }

        [Display(Name = "Preço")]
        [Range(1, 500, ErrorMessage = "O valor de 1 a 500")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        [Column(TypeName = "Decimal(18,2)")]
        public decimal Preco { get; set; }
    }
}
