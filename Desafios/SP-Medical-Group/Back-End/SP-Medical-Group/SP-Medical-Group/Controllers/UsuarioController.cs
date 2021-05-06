﻿using Microsoft.AspNetCore.Authorization;
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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuario _usuario { get; set; }

        public UsuarioController()
        {
            _usuario = new UsuarioRepository();
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            _usuario.cadastrar(novoUsuario);

            return StatusCode(202);
        }

        [Authorize(Roles = "1, 2")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_usuario.Listar());
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            _usuario.Deletar(Id);

            return StatusCode(204);
        }

        [Authorize(Roles = "1, 2")]
        [HttpGet("{Id}")]
        public IActionResult BuscarId(int Id)
        {
            return Ok(_usuario.BuscarPorId(Id));
        }
    }
}
