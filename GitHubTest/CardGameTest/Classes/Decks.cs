namespace CardGameTest.Classes;
// Decks should hold cards in them for use and keep track of which cards are still in the deck and which cards have been drawn.
// They should also hold a full deck of 52 standard playing cards and be able to reshuffle cards back into the deck and redistribute the cards in a random order.
public class Decks
{
        // figure out how to get a random card from the deck and display that here. also figure out how to remember which card was drawn.
    //public void Draw()
    //{
    //    Console.WriteLine($"You Draw {CardInfo} from the deck.");
    //}
        // Randomize a list of cards in the deck and pick the top card to draw.
    //public void Shuffle()
    //{
    //    Random random = new Random();
    //    Rank = random.Next(1, 14) switch
    //    {
    //        1 => "Ace",
    //        11 => "Jack",
    //        12 => "Queen",
    //        13 => "King",
    //        var n => n.ToString()
    //    };
    //    Suit = random.Next(0, 4) switch
    //    {
    //        0 => "Hearts",
    //        1 => "Diamonds",
    //        2 => "Clubs",
    //        3 => "Spades",
    //        _ => throw new InvalidOperationException("Invalid suit index")
    //    };
    //    Console.WriteLine("The deck has been shuffled.");
    //}

        // A deck should contain a list of cards, and methods to shuffle, draw, and discard cards.

    // Suggest thinking about moving the card logic into the Decks class, as it might be more appropriate to manage the cards collectively rather than individually.
    // Then the card only needs to know about itself
}
