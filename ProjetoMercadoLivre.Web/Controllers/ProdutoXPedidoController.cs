using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;
using ProjetoMercadoLivre.Lib.Models;
using ProjetoMercadoLivre.Web.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoXPedidoController : ControllerBase
{


    private readonly ILogger<ProdutoXPedidoController> _logger;
    private readonly ProdutoXPedidoRepositorio _repositorio;

    public ProdutoXPedidoController(ILogger<ProdutoXPedidoController> logger, ProdutoXPedidoRepositorio repositorio)
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
    public IActionResult Adicionar(ProdutoXPedidoDTO produtoXPedidoDto)
    {
        var produtoXPedido = new ProdutoXPedido(produtoXPedidoDto.IdPxp, produtoXPedidoDto.IdProduto, produtoXPedidoDto.IdPedido);
        _repositorio.Adicionar(produtoXPedido);
        return Ok("ProdutoXPedido adicionado");
    }

    [HttpPut("AlterarProduto/{id}/{idProduto}")]
    public IActionResult AlterarProduto(int id, int idProduto)
    {
        _repositorio.AlterarProduto(id, idProduto);
        return Ok("Produto alterado com sucesso");
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        _repositorio.Deletar(id);
        return Ok("Removido com sucesso");
    }
}
