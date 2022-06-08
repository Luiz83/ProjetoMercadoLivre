using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;
using ProjetoMercadoLivre.Lib.Models;
using ProjetoMercadoLivre.Web.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class TransportadoraController : ControllerBase
{


    private readonly ILogger<TransportadoraController> _logger;
    private readonly TransportadoraRepositorio _repositorio;

    public TransportadoraController(ILogger<TransportadoraController> logger, TransportadoraRepositorio repositorio)
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
    public IActionResult Adicionar(TransportadoraDTO transportadoraDto)
    {
        var transportadora = new Transportadora(transportadoraDto.IdTransportadora, transportadoraDto.Nome, transportadoraDto.Telefone, transportadoraDto.Email);
        _repositorio.Adicionar(transportadora);
        return Ok("Transportadora adionada com sucesso");
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
