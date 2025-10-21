public class Card
{
    //debiting an amount from the card
    public virtual void Debit(decimal amount)
    {
        Console.WriteLine($"Debiting {amount:C} from the card");
    }   
}