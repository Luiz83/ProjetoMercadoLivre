using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class TransportadoraController : ControllerBase
{


    private readonly ILogger<TransportadoraController> _logger;
    private readonly ProjetoMLContext _context;

    public TransportadoraController(ILogger<TransportadoraController> logger, ProjetoMLContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var transportadoras = _context.Transportadoras.ToList();
        return Ok(transportadoras);
    }

    [HttpGet("ListarPorId/{id}")]
    public IActionResult ListarPorId(int id)
    {
        var transportadora = _context.Transportadoras.Find(id);
        return Ok(transportadora);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(Transportadora transportadora)
    {
        _context.Transportadoras.Add(transportadora);
        _context.SaveChanges();
        return Ok(transportadora);
    }

    [HttpPut("AlterarEmail/{id}/{email}")]
    public IActionResult AlterarValor(int id,string email)
    {
        var transportadora = _context.Transportadoras.Find(id);
        transportadora.Email = email;
        _context.SaveChanges();
        return Ok(transportadora);
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var transportadora = _context.Transportadoras.Find(id);
        _context.Transportadoras.Remove(transportadora);
        _context.SaveChanges();
        return Ok("Removido com sucesso");
    }
}
