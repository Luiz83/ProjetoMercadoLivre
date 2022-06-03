using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class PedidoController : ControllerBase
{


    private readonly ILogger<PedidoController> _logger;
    private readonly ProjetoMLContext _context;

    public PedidoController(ILogger<PedidoController> logger, ProjetoMLContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var pedidos = _context.Pedidos.ToList();
        return Ok(pedidos);
    }

    [HttpGet("ListarPorId/{id}")]
    public IActionResult ListarPorId(int id)
    {
        var pedido = _context.Pedidos.Find(id);
        return Ok(pedido);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
        return Ok(pedido);
    }

    [HttpPut("AlterarStatus/{id}/{status}")]
    public IActionResult AlterarStatus(int id,string status)
    {
        var pedido = _context.Pedidos.Find(id);
        pedido.StatusPedido = status;
        _context.SaveChanges();
        return Ok(pedido);
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var pedido = _context.Pedidos.Find(id);
        _context.Pedidos.Remove(pedido);
        _context.SaveChanges();
        return Ok("Removido com sucesso");
    }
}
