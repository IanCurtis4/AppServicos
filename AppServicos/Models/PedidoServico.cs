using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppServicos.Models
{
    public class PedidoServico
    {
        [Key]
        [ConcurrencyCheck]
        public Guid Id { get; set; }

        public List<Servico> Servicos { get; set; }
        
        [Required]
        public string Profissional { get; set; }
        
        [Required]
        public double Imposto { get; set; } 

        public PedidoServico()
        {
            Id = Guid.NewGuid();
            Servicos = new List<Servico>();
            Profissional = "";
            Imposto = 0.0;
        }

        public PedidoServico(string profissional, double imposto)
        {
            Id = Guid.NewGuid();
            Servicos = new List<Servico>();
            Profissional = profissional;
            Imposto = imposto;
        }

    }
}
