using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;
using ProjetoMercadoLivre.Lib.Models;
using ProjetoMercadoLivre.Web.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class UsuarioController : ControllerBase
{


    private readonly ILogger<UsuarioController> _logger;
    private readonly UsuarioRepositorio _repositorio;

    public UsuarioController(ILogger<UsuarioController> logger, UsuarioRepositorio repositorio)
    {
        _logger = logger;
        _repositorio = repositorio;
    }

    [HttpGet("BuscarTodos")]
    public IActionResult BuscarTodos()
    {
        return Ok(_repositorio.BuscarTodos());
    }

    [HttpGet("BuscarPorId/{id}")]
    public IActionResult BuscarPorId(int id)
    {
        return Ok(_repositorio.BuscarPorId(id));
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(UsuarioDTO usuarioDto)
    {
        var usuario = new Usuario(usuarioDto.IdUsuario, usuarioDto.Nome, usuarioDto.Email, usuarioDto.Cpf, usuarioDto.DataNascimento, usuarioDto.Senha);
        _repositorio.Adicionar(usuario);
        return Ok("Usuario Adicionado com sucesso");
    }

    [HttpPut("AlterarSenha/{id}/{senha}")]
    public IActionResult AlterarValor(int id, string senha)
    {
        _repositorio.AlterarSenha(id, senha);
        return Ok("Senha alterada com sucesso");
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        _repositorio.Deletar(id);
        return Ok("Removido com sucesso");
    }
}
