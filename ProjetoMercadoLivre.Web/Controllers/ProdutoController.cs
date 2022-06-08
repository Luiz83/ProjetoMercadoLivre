using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;
using ProjetoMercadoLivre.Lib.Models;
using ProjetoMercadoLivre.Web.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoController : ControllerBase
{


    private readonly ILogger<ProdutoController> _logger;
    private readonly ProdutoRepositorio _repositorio;

    public ProdutoController(ILogger<ProdutoController> logger, ProdutoRepositorio repositorio)
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

    [HttpGet("BuscarTodosComVendedor")]
    public IActionResult BuscarTodosComVendedor()
    {
        return Ok(_repositorio.BuscarProdutoComVendedor());
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(ProdutoDTO produtoDto)
    {
        var produto = new Produto(produtoDto.IdProduto, produtoDto.IdVendedor, produtoDto.Nome, produtoDto.Descricao, produtoDto.Valor, produtoDto.DataCadastro);
        _repositorio.Adicionar(produto);
        return Ok("Produto adicionado com sucesso");
    }

    [HttpPut("AlterarValor/{id}/{valor}")]
    public IActionResult AlterarValor(int id, double valor)
    {
        _repositorio.AlterarValor(id, valor);
        return Ok("Valor alterado com sucesso");
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        _repositorio.Deletar(id);
        return Ok("Removido com sucesso");
    }

}
