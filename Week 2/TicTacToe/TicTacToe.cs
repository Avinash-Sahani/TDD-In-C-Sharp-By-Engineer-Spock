using NUnit.Framework;

namespace TDD_In_C_Sharop_By_Engineer_Spock.TicTacToe;

[TestFixture]
public class TicTacToe
{

    [Test]
    public void IntializeGame()
    {
        var game = new Game();
        Assert.AreEqual(0,game.MoveCounter);
        Assert.AreEqual(State.Unset,game.GetState(0));
    }
 
    
}