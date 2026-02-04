using Microsoft.AspNetCore.Mvc;

namespace SistemaVendas.API.Controllers.Geral;

[Route("api/[controller]")]
[ApiController]
public class UnidadeMedidaController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new { mensagem = "Lista Geral" });
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(new { id = id, nome = "Item Exemplo" });
    }

    [HttpPost]
    public IActionResult Create([FromBody] object item)
    {
        return CreatedAtAction(nameof(GetById), new { id = 1 }, item);
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