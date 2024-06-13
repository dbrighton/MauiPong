namespace MauiPong.State;

public record class MainState(PongGameState GameSate);
public class MainFeatureState : Feature<MainState>
{
    public override string GetName() => nameof(MainFeatureState);

    protected override MainState GetInitialState()
    {
        return new MainState();
    }
}


