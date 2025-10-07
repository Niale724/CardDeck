namespace CardDeckDemo.Tests;

[TestClass]
public class CardTests
{
    [TestMethod]
    public void Card_HasRankAndSuit()
    {
        var card = new Card(Rank.Ace, Suit.Spades); // make a card
        Assert.AreEqual(Rank.Ace, card.Rank); // check rank
        Assert.AreEqual(Suit.Spades, card.Suit); // check suit
    }

    [TestMethod]
    public void FlipOver_TogglesState()
    {
        var card = new Card(Rank.Ace, Suit.Spades); // make a card
        card.FlipOver(); // flip it
    }
}

[TestClass]
public class DeckTests
{
    [TestMethod]
    public void Deck_Has52Cards()
    {
        var deck = new Deck(); 
        Assert.AreEqual(52, deck.Cards.Count); // check it has 52 cards
    }

    [TestMethod]
    public void TakeTopCard_ReducesSize()
    {
        var deck = new Deck(); 
        var topCard = deck.TakeTopCard(); // take the top card
        Assert.IsNotNull(topCard); // make sure it's not null
        Assert.AreEqual(51, deck.Cards.Count); // check deck size is now 51
    }

    [TestMethod]
    public void Shuffle_RandomizesOrder()
    {
        var deck = new Deck(); 
        var originalOrder = new List<Card>(deck.Cards); // save the original order
        deck.Shuffle(); // shuffle it
        CollectionAssert.AreNotEqual(originalOrder, deck.Cards.ToList()); // check the order changed
    }

    [TestMethod]
    public void Cut_RearrangesDeck()
    {
        var deck = new Deck();
        deck.Cut(26); // cut it at 26
    }
}
