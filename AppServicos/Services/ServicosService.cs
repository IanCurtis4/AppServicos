using AppServicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppServicos.Services
{
    public class ServicosService
    {
        public PedidoServico PedidoServicoAtual { get; set; }

        public bool AdicionarServico(string nome, double valorHora)
        {

            if (!PedidoServicoAtual.Servicos.Select(s => s.Nome).Contains(nome))
            {
                PedidoServicoAtual.Servicos.Add(new Servico(nome, valorHora));
                return true;
            }

            return false;

        }

        public ServicosService()
        {
            PedidoServicoAtual = new PedidoServico();
        }

    }
}
