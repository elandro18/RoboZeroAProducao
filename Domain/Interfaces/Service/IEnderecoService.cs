using RoboZeroAProducao.Models;

namespace RoboZeroAProducao.Interfaces.Service
{
    public interface IEnderecoService
    {
        Task Add(List<EnderecoModel> enderecos);
        Task AtualizarDados(EnderecoModel endereco);
        Task<List<EnderecoModel>> List();
        Task<EnderecoModel> ObterCepParaTratamento(string robo);
    }
}