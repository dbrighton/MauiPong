
using Common;

namespace MauiPong.Components.Pages.Pong.Store;

public record PongState
{
    public PongGameState PongGameState { get; set; } = new();
}

public class PongGameFeature : Feature<PongState>
{
    public override string GetName() => nameof(PongGameFeature);

    protected override PongState GetInitialState()
    {
        return new PongState();
    }
}