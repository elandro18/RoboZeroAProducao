using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboZeroAProducao.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string? CEP { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public string? UF{ get; set; }
       
    }
}