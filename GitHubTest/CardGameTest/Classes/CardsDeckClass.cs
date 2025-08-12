namespace CardGameTest.Classes;
// Each Card has 2 variables, a Rank and a Suit.
// Each card has several possible actions, Draw, Discard and Play.
// Each card is also stored in a deck but idk how to figure that out yet
public record PlayingCard //Singular naming normally
{
    public string Rank { get; set; } = default!;
    public string Suit { get; set; }= default!;
    public string CardInfo => $"{Rank} of {Suit}";



    // Below should be in deck.  Its the deck that cares, the card is static, once created it doesn't change
    public void Play()
    {
        Console.WriteLine($"You Play the {CardInfo}");
    }
    //Note from Paul.  Think about this for a moment, when you discard a card, is it the card that you're interacting with or the deck
    public void Discard()
    {
        // figure out how  these things are stored and how to put them into new places
        // Cards should only be allowed to Discard if you have already drawn them, you should also be allowed to select which card you discard.
        Console.WriteLine($"You Discard {CardInfo}.");
    }
}
