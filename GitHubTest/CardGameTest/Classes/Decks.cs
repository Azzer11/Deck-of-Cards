
namespace CardGameTest.Classes;
// Decks should hold cards in them for use and keep track of which cards are still in the deck and which cards have been drawn.
// They should also hold a full deck of 52 standard playing cards and be able to reshuffle cards back into the deck and redistribute the cards in a random order.
public class Deck
{

    public Deck()
    {
        OpenANewPack();

    }


    // A deck holds up to 52 cards
    private List<PlayingCard> Cards = []; // start with no cards
    private void OpenANewPack()
    {
        Console.WriteLine("You take the wrapper off a brand new pack... Hmm, fresh");
        var random = new Random();
        for (int suit = 0; suit < 4; suit++)
        {
            for (int rank = 1; rank < 14; rank++)
            {

                var card = new PlayingCard
                {
                    Rank = rank switch
                    {
                        1 => "Ace",
                        11 => "Jack",
                        12 => "Queen",
                        13 => "King",
                        var n => n.ToString()
                    },
                    Suit = suit switch
                    {
                        0 => "Hearts",
                        1 => "Diamonds",
                        2 => "Clubs",
                        3 => "Spades",
                        _ => throw new InvalidOperationException("Invalid suit index")
                    }

                }
                ;
                Cards.Add(card);
            }

            // this creates the pack, but, like all new packs, they are in order

        }
    }



    public void Shuffle()
    {
        var rng = new Random();
        int n = Cards.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (Cards[i], Cards[j]) = (Cards[j], Cards[i]);
        }
        Console.WriteLine("The deck has been shuffled.");
    }

    public PlayingCard? Draw()
    {
        // get the first one
        var card = Cards.FirstOrDefault();
        if (card != null)
        {
            Console.WriteLine($"You Draw {card.CardInfo} from the deck.");
            Cards.Remove(card);
            return card;
        }
        Console.WriteLine($"No more cards!");
        return null;
    }
}
