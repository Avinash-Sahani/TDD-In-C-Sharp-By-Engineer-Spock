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
    }

    [Test]
    public void SetMoveByPlayer()
    {
        var game = new Game();
        MakeMoves(game,1,2,3,4,5,6,7,8,9);
        Assert.AreEqual(State.Cross,game.GetState(1));
        Assert.AreEqual(State.Zero,game.GetState(2));
        Assert.AreEqual(State.Cross,game.GetState(3));
        Assert.AreEqual(State.Zero,game.GetState(4));
        Assert.AreEqual(State.Cross,game.GetState(5));
        Assert.AreEqual(State.Zero,game.GetState(6));

    }

    private void MakeMoves(Game game, params int[] moveIndexes)
    {
        moveIndexes.ToList().ForEach(game.Move);
    }

    [Test]
    public void MakingMoveOnAlreadySetBoardNode()
    {
        Game game = new Game();
        game.Move(1);
        game.Move(1);
        game.Move(1);
        game.Move(1);

    }

}