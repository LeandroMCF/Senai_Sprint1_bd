using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SP_Medical_Group.Domains;
using SP_Medical_Group.Interfaces;
using SP_Medical_Group.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP_Medical_Group.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProntuarioController : ControllerBase
    {
        IProntuario _prontuario { get; set; }

        public ProntuarioController()
        {
            _prontuario = new ProntuarioRepository();
        }

        [Authorize(Roles = "1, 2")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_prontuario.ListarProntuario());
        }

        [Authorize(Roles = "1, 2")]
        [HttpPost]
        public IActionResult BuscarCPF(Prontuario prontuario)
        {
            return Ok(_prontuario.BuscarPorCpf(prontuario.Cpf));
        }

        [Authorize(Roles = "1")]
        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar(Prontuario novoProntuario)
        {
            _prontuario.CadastrarProntuario(novoProntuario);

            return StatusCode(202);
        }
    }
}
