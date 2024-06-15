using Common;

namespace MauiPong.Components.Pages.Pong.Store;

public class PongReducer
{
    [ReducerMethod(typeof(GameStateChangedAction))]
    public static PongGameState ReducePongGameState(PongGameState state) => state with
    {
        Score = state.Score,
        GameSvg = state.GameSvg,
        BallPosition = state.BallPosition,
        PaddleTwoPosition = state.PaddleTwoPosition,
        PaddleOnePosition = state.PaddleOnePosition
    };
}