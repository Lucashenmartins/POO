using System.Runtime.InteropServices;

public class Televisao
{
    public const int VOL_MAX = 10;
    public const int VOL_MIN = 0;
    public const int CANAL_MIN = 0;
    public const int CANAL_MAX = 520;
    public int ULTIMO_CANAL;
    public int ULTIMO_VOLUME;
    public int MUDAR_CANAL;
    public int VOLUME_PADRAO = 5;
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;

        Volume = VOLUME_PADRAO;

    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
        {
            Volume++;
        }
        else
        {
            Volume = VOL_MAX;
            Console.WriteLine("Volume ja esta no maximo");
        }
    }
    public void DiminuirVolume()
    {
        if (Volume > VOL_MIN)
        {
            Volume--;
        }
        else
        {
            Volume = VOL_MIN;
            Console.WriteLine("Volume ja esta no minimo");
        }
    }
    public void BotaoMudoLiga()
    {
        if (Volume > VOL_MIN)
        {
            ULTIMO_VOLUME = Volume;
            Volume = VOL_MIN;
            Console.WriteLine("TV em Modo Mudo");
        }
    }
    public void BotaoMudoDesliga()
    {
        if (Volume == VOL_MIN)
        {
            Volume = ULTIMO_VOLUME;
            Console.WriteLine("TV saiu do Modo Mudo");
        }
    }
    public void MudarUmCanalAcima()
    {
        if (Canal < CANAL_MAX)
        {
            Canal++;
            ULTIMO_CANAL = Canal;
        }
        else
        {
            Canal = CANAL_MIN;
        }
    }
    public void MudarUmCanalAbaixo()
    {
        if (Canal > CANAL_MIN)
        {

            Canal--;
            ULTIMO_CANAL = Canal;
        }
        else
        {
            Canal = CANAL_MAX;
        }
    }
    public void MudarCanalInput()
    {
        Console.WriteLine("Qual canal mudar:");
        MUDAR_CANAL = Convert.ToInt32(Console.ReadLine());

        if (MUDAR_CANAL < CANAL_MIN || MUDAR_CANAL > CANAL_MAX)
        {
            Console.WriteLine("Canal Invalido");
        }
        else
        {
            Canal = MUDAR_CANAL;
        }
   
    }
}