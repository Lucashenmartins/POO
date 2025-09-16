public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.MASTERCARD;
    }
    public string NumeroCartao { get; set; }
    public string NomeTitular { get; set; }
    public BandeiraCartao Bandeira { get; set; }
    public DateTime DataValidade { get; set; }
    public string CodigoSeguranca { get; set; }
}

public enum BandeiraCartao
{
    VISA,
    MASTERCARD,
    ELO,
    AMERICANEXPRESS
}
