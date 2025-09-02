public class Televisao
{

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;

    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public void AumentarVolume()
    {
        Volume = Volume++
    }
    
}