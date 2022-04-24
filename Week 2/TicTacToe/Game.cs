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
        if (index < 1 || index > 9) throw new IndexOutOfRangeException();
        
        return Board[index-1];
        
    }
}