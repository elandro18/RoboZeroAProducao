using RoboZeroAProducao.Aplication.Adapters;
using RoboZeroAProducao.Interfaces.Repository;
using RoboZeroAProducao.Interfaces.Service;
using RoboZeroAProducao.Models;

namespace RoboZeroAProducao.Aplication.Services
{
    public class EnderecosServices : IEnderecoService
    {
        
        private readonly IEnderecoRepository _repository;
        
        public EnderecosServices(IEnderecoRepository repository)
        {
            repository = _repository;
        }
        public async Task Add(List<EnderecoModel> enderecos)
        {
            var domain = EnderecoAdapter.Map(enderecos);
            await _repository.Add(domain);
            
        }

        public async Task AtualizarDados(EnderecoModel endereco)
        {
            var domain = await _repository.Get(endereco.Id);
            if(domain == null)
            {
                 throw new Exception("Cep Não Localizado");
            }
            domain.Logradouro = endereco.Logradouro;
            domain.Bairro = endereco.Bairro;
            domain.UF = endereco.UF;
            domain.Status = Enums.EnumStatus.Finalizado;   

            await _repository.AtualizarDados(domain);
        }
        public async Task<List<EnderecoModel>> List()
        {
            var enderecos = await _repository.List();
            return EnderecoAdapter.Map(enderecos);

        }

        public async Task<EnderecoModel> ObterCepParaTratamento(string robo)
        {
            var domain = await _repository.ObterCepParaTratamento(robo);
            domain.Status = Enums.EnumStatus.EmAndamento;
            domain.Robo = robo;
            
            _repository.AtualizarDados(domain);

            return EnderecoAdapter.Map(domain);
        }
    }
}