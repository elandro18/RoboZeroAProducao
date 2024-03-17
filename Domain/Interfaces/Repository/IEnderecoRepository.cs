using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoboZeroAProducao.Entidades;

namespace RoboZeroAProducao.Interfaces.Repository
{
    public interface IEnderecoRepository
    {
        Task Add(List<Endereco> enderecos);
        Task AtualizarDados(Endereco endereco);
        Task<Endereco?> Get(int id);
        Task<List<Endereco>> List();
        Task<Endereco?> ObterCepParaTratamento(string robo);
    }
}