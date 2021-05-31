using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppServicos.Models
{
    public class Servico
    {
        [Key]
        [ConcurrencyCheck]
        public Guid Id { get; set; }

        [Required]
        public string Nome { get; set; }
        
        [Required]
        public double ValorHora { get; set; }
        
        public int? Horas { get; set; }
        
        public double Valor => ValorHora * Horas ?? ValorHora;

        public Servico()
        {
            Id = Guid.NewGuid();
            Nome = "";
            ValorHora = 1.0;
        }

        public Servico(string nome, double valorHora)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            ValorHora = valorHora;
        }

    }
}
