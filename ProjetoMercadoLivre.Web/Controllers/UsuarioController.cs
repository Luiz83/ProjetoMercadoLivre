using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class UsuarioController : ControllerBase
{


    private readonly ILogger<UsuarioController> _logger;
    private readonly ProjetoMLContext _context;

    public UsuarioController(ILogger<UsuarioController> logger, ProjetoMLContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var usuarios = _context.Usuarios.ToList();
        return Ok(usuarios);
    }

    [HttpGet("ListarPorId/{id}")]
    public IActionResult ListarPorId(int id)
    {
        var usuario = _context.Usuarios.Find(id);
        return Ok(usuario);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return Ok(usuario);
    }

    [HttpPut("AlterarSenha/{id}/{senha}")]
    public IActionResult AlterarValor(int id,string senha)
    {
        var usuario = _context.Usuarios.Find(id);
        usuario.Senha = senha;
        _context.SaveChanges();
        return Ok(usuario);
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var usuario = _context.Usuarios.Find(id);
        _context.Usuarios.Remove(usuario);
        _context.SaveChanges();
        return Ok("Removido com sucesso");
    }
}
