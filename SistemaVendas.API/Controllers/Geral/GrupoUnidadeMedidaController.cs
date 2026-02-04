using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Dominio.Interfaces.Repository;

namespace SistemaVendas.API.Controllers.Geral;

[Route("api/[controller]")]
[ApiController]
public class GrupoUnidadeMedidaController(IGrupoUnidadeMedidaOdbcRepository grupoUnidadeMedidaOdbcRepository) : ControllerBase
{
    private readonly IGrupoUnidadeMedidaOdbcRepository _grupoUnidadeMedidaOdbcRepository = grupoUnidadeMedidaOdbcRepository;

    [HttpGet("Lista")]
    public IActionResult GetAll()
    {
        return Ok(new { mensagem = "Lista Geral" });
    }

    [HttpGet("Obter")]
    public async Task<IActionResult> ObterAsync(int id, CancellationToken cancellationToken = default)
    {
        var resultado = await _grupoUnidadeMedidaOdbcRepository.ObterAsync(id, cancellationToken);

        if (!resultado.Sucesso)
            return BadRequest(resultado.MensagemErro);

        var grupo = resultado.ObterValor();

        if (grupo is null) return NoContent();

        return Ok(grupo);
    }

    [HttpPost]
    public IActionResult Create([FromBody] object item)
    {
        return CreatedAtAction(nameof(ObterAsync), new { id = 1 }, item);
    }

    [HttpPatch]
    public IActionResult Load([FromBody] object item)
    {
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteById(int id)
    {
        return Ok();
    }
}
