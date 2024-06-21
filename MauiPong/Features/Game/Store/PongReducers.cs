namespace Pong.Features.Game.Store;

public static class PongReducers
{
    [ReducerMethod]
    public static PongStore.PongGameState OnSetBallPositionAction(PongStore.PongGameState state, SetBallPositionAction action)
    {
        return state with
        {
            BallX = action.X,
            BallY = action.Y
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnIsGamePausedAction(PongStore.PongGameState state, IsGamePausedAction action)
    {
        return state with
        {
            IsGamePaused = action.IsPaused
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnIsGameEndedAction(PongStore.PongGameState state, IsGameEndedAction action)
    {
        return state with
        {
            IsGameEnded = action.IsEnded
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnSetPlayer1ScoreAction(PongStore.PongGameState state, SetPlayer1ScoreAction action)
    {
        return state with
        {
            Player1Score = action.Score
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnSetPlayer2ScoreAction(PongStore.PongGameState state, SetPlayer2ScoreAction action)
    {
        return state with
        {
            Player2Score = action.Score
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnReverseBallAction(PongStore.PongGameState state, ReverseBallAction action)
    {
        return state with
        {
            BallDirectionX = action.Direction
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnLastPlayerScoredOnAction(PongStore.PongGameState state, LastPlayerScoredOnAction action)
    {
        return state with
        {
            LastPlayerScoredOn = action.Player
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnSetBallDirectionXAction(PongStore.PongGameState state, SetBallDirectionXAction action)
    {
        return state with
        {
            BallDirectionX = action.Direction
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState On(PongStore.PongGameState state, SetBallDirectionYAction action)
    {
        return state with
        {
            BallDirectionY = action.Direction
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnSetLastUpdateAction(PongStore.PongGameState state, SetLastUpdateAction action)
    {
        return state with
        {
            LastUpdate = action.TimeStamp
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnMoveLeftPaddleYAction(PongStore.PongGameState state, MoveLeftPaddleYAction action)
    {
        return state with
        {
            LeftPaddleY = action.PositionY
        };
    }

    [ReducerMethod]
    public static PongStore.PongGameState OnMoveRightPaddleYAction(PongStore.PongGameState state, MoveRightPaddleYAction action)
    {
        return state with
        {
            RightPaddleY = action.PositionY
        };
    }



}