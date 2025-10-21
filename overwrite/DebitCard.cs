public class DebitCard : Card
{
    //overriding the Debit method to provide specific implementation for DebitCard
    public override void Debit(decimal amount)
    {
        Console.WriteLine($"Purchased {amount:C} from the debit card");
    }
}