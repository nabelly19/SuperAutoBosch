public class StateBuilder
{
    public Jogo jogo = null;
    public State firstState = null;
    public State lastState = null;

    public StateBuilder SetJogo(Jogo jogo)
    {
        this.jogo = jogo;
        return this;
    }

    public State Build()
    {
        lastState.NextState = firstState;

        this.jogo.State = firstState;
        return firstState;
    }
}
