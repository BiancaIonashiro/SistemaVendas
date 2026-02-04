namespace SistemaVendas.Dominio.Entidades.Geral;

public sealed class GrupoUnidadeMedida(int id, string codigo, string descricao)
{
    public int Id { get; } = id;
    public string Codigo { get; } = codigo;
    public string Descricao { get; } = descricao;
}