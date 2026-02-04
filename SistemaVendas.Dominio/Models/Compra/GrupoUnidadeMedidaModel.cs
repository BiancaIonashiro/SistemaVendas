using SistemaVendas.Dominio.Entidades.Geral;

namespace SistemaVendas.Dominio.Models.Compra;

public class GrupoUnidadeMedidaModel
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    public static implicit operator GrupoUnidadeMedidaModel?(GrupoUnidadeMedida entidade)
    {
        if (entidade is null) return null;

        return new() { Id = entidade.Id, Codigo = entidade.Codigo, Descricao = entidade.Descricao };
    }

    public static implicit operator GrupoUnidadeMedida?(GrupoUnidadeMedidaModel model)
    {
        if (model is null) return null;

        return new GrupoUnidadeMedida(id: model.Id, codigo: model.Codigo, descricao: model.Descricao);
    }
}