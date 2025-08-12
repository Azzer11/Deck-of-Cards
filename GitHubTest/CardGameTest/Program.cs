//This project should have access to the class library i set up and will be used to execute actual code.
using CardGameTest.Classes;

// Test variables to see if can get get this to display anything before moving forward.
var Card0 = new PlayingCards();
Card0.Rank = "Ace";
Card0.Suit = "Spades";

//this should theoretically create a new List of 52 PlayingCards, not really sure though barely understand this, will have to re-research LINQ to understand this
var NewDeckList = Enumerable.Range(1, 52).Select(Card => new PlayingCards()).ToList();
Console.WriteLine(NewDeckList);

//Card0.Draw();
//Card0.Shuffle();
//Card0.Draw();
//Card0.Shuffle();
//Card0.Draw();
//Card0.Shuffle();
//Card0.Draw();
//Card0.Shuffle();
//Card0.Draw();


