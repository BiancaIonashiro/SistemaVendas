using SistemaVendas.Dominio.Entidades;
using SistemaVendas.Dominio.Models.Compra;

namespace SistemaVendas.Dominio.Interfaces.Repository;

public interface IGrupoUnidadeMedidaOdbcRepository
{
    Task<Resultado<GrupoUnidadeMedidaModel>> ObterAsync(int id, CancellationToken cancellationToken = default);
}