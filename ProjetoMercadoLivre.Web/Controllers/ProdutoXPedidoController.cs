using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoXPedidoController : ControllerBase
{


    private readonly ILogger<ProdutoXPedidoController> _logger;
    private readonly ProjetoMLContext _context;

    public ProdutoXPedidoController(ILogger<ProdutoXPedidoController> logger, ProjetoMLContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var produtosXPedidos = _context.ProdutosXPedidos.ToList();
        return Ok(produtosXPedidos);
    }

    [HttpGet("ListarPorId/{id}")]
    public IActionResult ListarPorId(int id)
    {
        var produtoXPedido = _context.ProdutosXPedidos.Find(id);
        return Ok(produtoXPedido);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(ProdutoXPedido produtoXPedido)
    {
        _context.ProdutosXPedidos.Add(produtoXPedido);
        _context.SaveChanges();
        return Ok(produtoXPedido);
    }

    [HttpPut("AlterarProduto/{id}/{idProduto}")]
    public IActionResult AlterarValor(int id,int idProduto)
    {
        var produtoXPedido = _context.ProdutosXPedidos.Find(id);
        var produto = _context.Produtos.Find(idProduto);
        produtoXPedido.Produto = produto;
        _context.SaveChanges();
        return Ok("Alteracao bem sucedida!");
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var produtoXPedido = _context.ProdutosXPedidos.Find(id);
        _context.ProdutosXPedidos.Remove(produtoXPedido);
        _context.SaveChanges();
        return Ok("Removido com sucesso");
    }
}
