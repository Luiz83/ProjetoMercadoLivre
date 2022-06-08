using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;
using ProjetoMercadoLivre.Lib.Models;
using ProjetoMercadoLivre.Web.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class VendedorController : ControllerBase
{


    private readonly ILogger<VendedorController> _logger;
    private readonly VendedorRepositorio _repositorio;

    public VendedorController(ILogger<VendedorController> logger, VendedorRepositorio repositorio)
    {
        _logger = logger;
        _repositorio = repositorio;
    }
    [HttpGet("ListarTodos")]
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
    public IActionResult Adicionar(VendedorDTO vendedorDto)
    {
        var vendedor = new Vendedor(vendedorDto.IdVendedor, vendedorDto.Nome, vendedorDto.Email, vendedorDto.Cnpj, vendedorDto.DataCadastro);
        _repositorio.Adicionar(vendedor);
        return Ok("Vendedor adicionado com sucesso");
    }

    [HttpPut("AlterarEmail/{id}/{email}")]
    public IActionResult AlterarEmail(int id, string email)
    {
        _repositorio.AlterarEmail(id, email);
        return Ok("Email alterado com sucesso");
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        _repositorio.Deletar(id);
        return Ok("Removido com sucesso");
    }
}
