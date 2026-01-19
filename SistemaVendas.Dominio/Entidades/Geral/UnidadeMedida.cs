namespace SistemaVendas.Dominio.Entidades.Geral;

public sealed class UnidadeMedida(int codigo, string descricao, GrupoUnidadeMedida grupo)
{
    public int Codigo { get; } = codigo;
    public string Descricao { get;} = descricao;
    public GrupoUnidadeMedida Grupo { get; } = grupo;
}
