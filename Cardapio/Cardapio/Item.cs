public partial class Item
{
    public required string Nome { get; set; }
    public required List<string> Ingredientes { get; set; }
    public decimal Preco { get; set; }
}