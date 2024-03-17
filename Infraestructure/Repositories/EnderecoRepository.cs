using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using RoboZeroAProducao.Entidades;
using RoboZeroAProducao.Interfaces.Repository;

namespace RoboZeroAProducao.Infraestructure.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly BraboDbContext _dbContext;

        public EnderecoRepository(BraboDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(List<Endereco> enderecos)
        {
            await _dbContext.BulkInsertAsync(enderecos);
        }

        public async Task AtualizarDados(Endereco endereco)
        {
           _dbContext.Enderecos.Update(endereco);
           await _dbContext.SaveChangesAsync();

        }

        public async Task<Endereco?> Get(int id)
        {
            return _dbContext.Enderecos.Where(x=> x.Id == id).FirstOrDefault();

        }

        public async Task<List<Endereco>> List()
        {
            return _dbContext.Enderecos.ToList();
        }

        public async Task<Endereco?> ObterCepParaTratamento(string robo)
        {
            var cep = _dbContext.Enderecos.Where(x =>
           (x.Status == Enums.EnumStatus.EmAndamento && x.Robo == robo) || 
           (x.Status == Enums.EnumStatus.Aberto && x.Robo == robo)).FirstOrDefault();
            
            return cep;
        }
    }
}