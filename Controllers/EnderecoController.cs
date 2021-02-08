using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_agendaLanlink.Models;
using WEB_agendaLanlink.Repositories.Contractors;

namespace WEB_agendaLanlink.Controllers
{
    [Route("api/[controller]")]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository enderecoRepository;

        public EnderecoController(IEnderecoRepository _enderecoRepository)
        {
            enderecoRepository = _enderecoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try 
            {
                return Ok(enderecoRepository.ObterTodos());
            }
            catch (Exception ex )
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Endereco endereco)
        {
            try
            {
                if(endereco.Id > 0)
                {
                    enderecoRepository.Update(endereco);
                }
                else
                {
                    enderecoRepository.Add(endereco);
                }

                return Created( "api/endereco", endereco );
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
