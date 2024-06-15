
using System.Drawing;

namespace Common;

public record PongGameState
{
    public Point BallPosition { get; set; }
    public Point PaddleOnePosition { get; set; }
    public Point PaddleTwoPosition { get; set; }
    public Score Score { get; set; } = new Score();
    public string GameSvg { get; set; } = string.Empty;
}