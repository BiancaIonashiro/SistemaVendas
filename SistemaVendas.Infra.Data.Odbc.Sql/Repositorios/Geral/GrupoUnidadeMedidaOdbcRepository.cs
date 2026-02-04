using SistemaVendas.Dominio.Entidades;
using SistemaVendas.Dominio.Interfaces.Repository;
using SistemaVendas.Dominio.Models.Compra;

namespace SistemaVendas.Infra.Data.Odbc.Sql.Repositorios.Geral;

public class GrupoUnidadeMedidaOdbcRepository : IGrupoUnidadeMedidaOdbcRepository
{
    public async Task<Resultado<GrupoUnidadeMedidaModel>> ObterAsync(int id, CancellationToken cancellationToken = default)
    {
        //TODO: Implementar consulta ODBC pelo Dapper



        var dado = new GrupoUnidadeMedidaModel() { Id = id, Codigo = "VOL", Descricao = "Volume" };

        return Resultado<GrupoUnidadeMedidaModel>.Ok(dado);
    }
}