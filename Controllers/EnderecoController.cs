using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RoboZeroAProducao.Interfaces.Service;
using RoboZeroAProducao.Models;

namespace RoboZeroAProducao.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private IEnderecoService _service;

        public EnderecoController(IEnderecoService service)
        {
            service = _service;
        }
        [HttpPost]
        [Route("List")]
        public async Task<IActionResult> Add(List<EnderecoModel> model)
        {
            await _service.Add(model);
            return Ok(new {Message = "Ceps Cadastrato com sucesso"});
        }
        
    }
}