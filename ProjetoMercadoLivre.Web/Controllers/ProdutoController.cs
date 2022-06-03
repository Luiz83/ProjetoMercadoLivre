using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoController : ControllerBase
{


    private readonly ILogger<ProdutoController> _logger;
    private readonly ProjetoMLContext _context;

    public ProdutoController(ILogger<ProdutoController> logger, ProjetoMLContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var produtos = _context.Produtos.ToList();
        return Ok(produtos);
    }

    [HttpGet("ListarPorId/{id}")]
    public IActionResult ListarPorId(int id)
    {
        var produto = _context.Produtos.Find(id);
        return Ok(produto);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return Ok(produto);
    }

    [HttpPut("AlterarValor/{id}/{valor}")]
    public IActionResult AlterarValor(int id,double valor)
    {
        var produto = _context.Produtos.Find(id);
        produto.Valor = valor;
        _context.SaveChanges();
        return Ok(produto);
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var produto = _context.Produtos.Find(id);
        _context.Produtos.Remove(produto);
        _context.SaveChanges();
        return Ok("Removido com sucesso");
    }
}
