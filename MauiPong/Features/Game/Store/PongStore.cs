namespace Pong.Features.Game.Store;

public class PongStore
{
    public record PongGameState
    {
        // Ball properties

        public double BallSpeed { get; init; } = 5;
        public double BallDirectionX { get; init; } = 1;
        public double BallDirectionY { get; set; } = 1;
        public double BallX { get; init; } = 200;  // Add BallX
        public double BallY { get; init; } = 100;  // Add BallY

        // Paddle properties
        public double LeftPaddleY = 80;
        public double RightPaddleY = 80;
        public double PaddleHeight = 40;
        public double PaddleWidth = 10;
        public double PaddleSpeed = 10;

        // Score properties
        public int Player1Score = 0;
        public int Player2Score = 0;

        public bool IsGamePaused = false;
        public bool IsGameEnded = false;
        public int LastPlayerScoredOn = 0; // 1 for player 1, 2 for player 2
        public int GameSeed = 30; // time in milliseconds

        public int MovementInterval = 30; // Lower value for more responsiveness
        public DateTime LastUpdate = DateTime.Now;
    }

    public class PongGameFeature : Feature<PongGameState>
    {
        public override string GetName() => "Pong";
        protected override PongGameState GetInitialState()
        {
            return new PongGameState();
        }
    }
}