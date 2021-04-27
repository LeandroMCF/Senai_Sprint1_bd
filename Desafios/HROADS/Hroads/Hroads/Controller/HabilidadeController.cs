using Hroads.Domains;
using Hroads.Interfaces;
using Hroads.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadeController : ControllerBase
    {
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadeController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            return Ok(_habilidadeRepository.Listar());
        }

        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar(Habilidade novaHabilidade)
        {
            _habilidadeRepository.Cadastrar(novaHabilidade);

            return StatusCode(202);
        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            _habilidadeRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}