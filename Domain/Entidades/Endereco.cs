using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RoboZeroAProducao.Enums;

namespace RoboZeroAProducao.Entidades
{
    public class Endereco
    {  
        [Key]
        public int Id { get; set; }
        public string? CEP { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public EnumStatus Status { get; set; } = EnumStatus.Aberto;
        public string? UF{ get; set; }
        public string? Robo { get; set; }
    }
}
