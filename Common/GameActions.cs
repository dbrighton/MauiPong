
using static Common.PongStore;

namespace Common;

public record PongStateReducerAction(PongState PongState);

public record IsGamePausedAction(bool IsPaused);
public record IsGameEndedAction(bool IsEnded);
public record SetPlayer1ScoreAction(int Score);
public record SetPlayer2ScoreAction(int Score);
public record ReverseBallAction(double Direction);
public record LastPlayerScoredOnAction(int Player);
public record SetBallPositionAction(double X, double Y);
public record SetBallDirectionXAction(double Direction);
public record SetBallDirectionYAction(double Direction);
public record SetLastUpdateAction(DateTime TimeStamp);
public record MoveLeftPaddleYAction(double PositionY);
public record MoveRightPaddleYAction(double PositionY);

public record ErrorAction(Exception ex);