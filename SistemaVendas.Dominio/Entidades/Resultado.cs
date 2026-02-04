namespace SistemaVendas.Dominio.Entidades;

public sealed class Resultado<T>
{
    private readonly T? _valor;

    public string MensagemErro { get; }

    public bool Sucesso => string.IsNullOrWhiteSpace(MensagemErro);

    private Resultado(T? valor, string mensagemErro = "")
    {
        _valor = valor;
        MensagemErro = mensagemErro;
    }

    public static Resultado<T> Ok(T valor) => new(valor);

    public static Resultado<T> Erro(string mensagemErro) => new(default, mensagemErro);

    public T? ObterValor() => _valor;

}