

namespace Cards_DecksClass;
// Each Card has 2 variables, a Rank and a Suit.
// Each card has several possible actions, Draw, Discard and Play.
// Each card is also stored in a deck but idk how to figure that out yet
public class Cards
{
    // we want the Cards to have a numerical value related to their rank, i can do that manually but if i can tie it to the rank string that would be nice.
    public string Rank { get; set; }
    public string Suit { get; set; }
    public string CardInfo => $"{Rank} of {Suit}";

    // figure out how to get user input for these actions. Console.Readline() ? no idea how to get that working between project files.
    public void Draw()
    {
        // figure out how to get a random card from the deck and display that here. also figure out how to remember which card was drawn.
        Console.WriteLine($"You Draw {CardInfo} from the deck.");
    }
    public void Discard()
    {
        // figure out how  these things are stored and how to put them into new places
        // Cards should only be allowed to Discard if you have already drawn them, you should also be allowed to select which card you discard.
        Console.WriteLine($"You Discard {CardInfo}.");
    }
    public void Play()
    {
        // figure out how to get the total numerical value of all cards played and display it
        Console.WriteLine($"You Play the {CardInfo}");
    }
}

// Decks should hold cards in them for use and keep track of which cards are still in the deck and which cards have been drawn.
// They should also hold a full deck of 52 standard playing cards and be able to reshuffle cards back into the deck and redistribute the cards in a random order.
public class Decks
{
    //i have no idea where to start here
}
