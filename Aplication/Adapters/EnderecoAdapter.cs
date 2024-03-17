using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoboZeroAProducao.Entidades;
using RoboZeroAProducao.Models;

namespace RoboZeroAProducao.Aplication.Adapters
{
    public class EnderecoAdapter
    {
        public static EnderecoModel Map(Endereco endereco)
        {
            var model = new EnderecoModel
            {
                Id = endereco.Id,
                CEP = endereco.CEP,
                UF = endereco.UF,
                Logradouro = endereco.Logradouro
            };
            return model;
        }
        public static Endereco Map(EnderecoModel model)
        {
            var endereco = new Endereco
            {
                Id = model.Id,
                CEP = model.CEP,
                UF = model.UF,
                Logradouro = model.Logradouro
            };
            return endereco;
        }

        public static List<EnderecoModel> Map(List<Endereco> endereco)
        {
           return  endereco.Select(Map).ToList();
        }
         public static List<Endereco> Map(List<EnderecoModel> enderecoModel)
        {
           return  enderecoModel.Select(Map).ToList();
        }
        
    }
}