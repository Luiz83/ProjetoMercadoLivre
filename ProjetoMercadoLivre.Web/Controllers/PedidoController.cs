using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;
using ProjetoMercadoLivre.Lib.Models;
using ProjetoMercadoLivre.Web.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class PedidoController : ControllerBase
{


    private readonly ILogger<PedidoController> _logger;
    private readonly PedidoRepositorio _repositorio;

    public PedidoController(ILogger<PedidoController> logger, PedidoRepositorio repositorio)
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
    public IActionResult Adicionar(PedidoDTO pedidoDto)
    {
        var pedido = new Pedido(pedidoDto.IdPedido, pedidoDto.IdTransportadora, pedidoDto.IdUsuario, pedidoDto.DataPedido, pedidoDto.StatusPedido);
        _repositorio.Adicionar(pedido);
        return Ok("Pedido adicionado com sucesso");
    }

    [HttpPut("AlterarStatus/{id}/{status}")]
    public IActionResult AlterarStatus(int id, string status)
    {
        _repositorio.AlterarStatus(id, status);
        return Ok("Status alterado com sucesso");
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        _repositorio.Deletar(id);
        return Ok("Removido com sucesso");
    }
}
