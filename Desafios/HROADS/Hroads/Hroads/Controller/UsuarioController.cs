using Hroads.Domains;
using Hroads.Interfaces;
using Hroads.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hroads.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost("Login")]
        public IActionResult Login(Usuario login)
        {
            Usuario usuario = _usuarioRepository.Login(login.Email, login.Senha);

            if (usuario == null)
            {
                return NotFound("Email ou Senha incorretos");
            }


            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
                new Claim(JwtRegisteredClaimNames.Jti, usuario.IdUsuarios.ToString()),
                new Claim(ClaimTypes.Role, usuario.IdTipoUsuarios.ToString()),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Hroads-Authentication"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "Hroads",
                audience: "Hroads",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }

        [Authorize(Roles = "2")]
        [HttpGet("BuscarId/{id}")]
        public IActionResult BuscarId(int id)
        {
            Usuario usuario = _usuarioRepository.BuscarPorId(id);

            if (usuario == null)
            {
                return NotFound("Email ou Senha incorretos");
            }

            return Ok(usuario);
        }

        [Authorize(Roles = "2")]
        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            return Ok(_usuarioRepository.Listar());
        }

        [Authorize(Roles = "2")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _usuarioRepository.Deletar(id);

            return StatusCode(204);
        }

        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            _usuarioRepository.cadastrar(novoUsuario);

            return StatusCode(201);
        }
    }
}