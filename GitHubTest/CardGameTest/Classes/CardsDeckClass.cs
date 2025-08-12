namespace CardGameTest.Classes;
// Each Card has 2 variables, a Rank and a Suit.
// Each card has several possible actions, Draw, Discard and Play.
// Each card is also stored in a deck but idk how to figure that out yet
public class PlayingCard //Singular naming normally
{
    public string Rank { get; set; } = default!;
    public string Suit { get; set; }= default!;
    public string CardInfo => $"{Rank} of {Suit}";



    public void Play()
    {
        Console.WriteLine($"You Play the {CardInfo}");
    }
    public void Discard()
    {
        // figure out how  these things are stored and how to put them into new places
        // Cards should only be allowed to Discard if you have already drawn them, you should also be allowed to select which card you discard.
        Console.WriteLine($"You Discard {CardInfo}.");
    }
}
