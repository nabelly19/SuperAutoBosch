using System.Security.Policy;

public abstract class State
{
    public State NextState { get; set; }
    public Jogo jogo;
}