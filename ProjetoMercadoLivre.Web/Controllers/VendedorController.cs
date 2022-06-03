using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class VendedorController : ControllerBase
{


    private readonly ILogger<VendedorController> _logger;
    private readonly ProjetoMLContext _context;

    public VendedorController(ILogger<VendedorController> logger, ProjetoMLContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var vendedores = _context.Vendedores.ToList();
        return Ok(vendedores);
    }

    [HttpGet("ListarPorId/{id}")]
    public IActionResult ListarPorId(int id)
    {
        var vendedor = _context.Vendedores.Find(id);
        return Ok(vendedor);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(Vendedor vendedor)
    {
        _context.Vendedores.Add(vendedor);
        _context.SaveChanges();
        return Ok(vendedor);
    }

    [HttpPut("AlterarEmail/{id}/{email}")]
    public IActionResult AlterarValor(int id,string email)
    {
        var vendedor = _context.Vendedores.Find(id);
        vendedor.Email = email;
        _context.SaveChanges();
        return Ok(vendedor);
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var vendedor = _context.Vendedores.Find(id);
        _context.Vendedores.Remove(vendedor);
        _context.SaveChanges();
        return Ok("Removido com sucesso");
    }
}
