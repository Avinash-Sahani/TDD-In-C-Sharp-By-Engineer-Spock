namespace TDD_In_C_Sharop_By_Engineer_Spock.TicTacToe;

public class Game
{
    public int MoveCounter { private set; get; } = 0;
    public State[] Board { set; get; } = new State[9];


    public State GetState(int index)=> Board[index-1];
}