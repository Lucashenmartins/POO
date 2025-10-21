// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("jp-JP");

Card baseCard = new Card();
baseCard.Debit(100);

Console.WriteLine("---DebitCard---");
DebitCard debitCard = new DebitCard();
debitCard.Debit(100);