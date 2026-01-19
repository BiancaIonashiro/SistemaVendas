namespace SistemaVendas.Dominio.Entidades.Geral;

public sealed class GrupoUnidadeMedida(int VOL, string volume, UnidadeMedida unidadeMedidaPadrao)
{
    public int Codigo { get; } = VOL;
    public string Descricao { get; } = volume;
    public UnidadeMedida UnidadeMedidaPadrao { get;} = unidadeMedidaPadrao;
}