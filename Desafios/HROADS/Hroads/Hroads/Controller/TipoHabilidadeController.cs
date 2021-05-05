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
    public class TipoHabilidadeController : ControllerBase
    {
        private ITipoHabilidadeRepository _tipoHabilidadeRepository { get; set; }

        public TipoHabilidadeController()
        {
            _tipoHabilidadeRepository = new TipoHabilidadeRepository();
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            return Ok(_tipoHabilidadeRepository.Listar());
        }

        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar(TipoHabilidade novoTipo)
        {
            _tipoHabilidadeRepository.Cadastrar(novoTipo);

            return StatusCode(202);
        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            _tipoHabilidadeRepository.Deletar(id);

            return StatusCode(204);
        }

        [HttpPut("Atualizar/{id}")]
        public IActionResult Atualizar(int id, TipoHabilidade novoTipo)
        {
            _tipoHabilidadeRepository.Atualizar(id, novoTipo);

            if (novoTipo.TipoHabilidades == null)
            {
                return BadRequest("O tipo habilidade não pode ser vazio");
            }

            return StatusCode(205);
        }
    }
}