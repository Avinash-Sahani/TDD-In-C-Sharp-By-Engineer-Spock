namespace TDD_In_C_Sharop_By_Engineer_Spock.TicTacToe;

public class Game
{
    public Game()
    {
        MoveCounter = 0;
        for (var i = 0; i < Board.Length; i++)
            Board[i] = State.Unset;
        
    }

    public int MoveCounter { private set; get; } 
    public State[] Board { set; get; } = new State[9];


    public State GetState(int index)
    { 
        ThrowExceptionIfInvalidIndex(index);
       return Board[index-1];
    }
        
    

    public void Move(int index)
    {
        ThrowExceptionIfInvalidIndex(index);
        if (GetState(index) != State.Unset)
            throw new InvalidOperationException();

        Board[index - 1] = MoveCounter % 2 == 0 ? State.Cross : State.Zero;
        MoveCounter++;
        
    }

    private static void ThrowExceptionIfInvalidIndex(int index)
    {
        if (index is < 1 or > 9)
            throw new ArgumentOutOfRangeException();
    }
}