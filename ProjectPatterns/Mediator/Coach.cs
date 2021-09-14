using System;

namespace ProjectPatterns.Mediator
{
    public class Coach
    {
        private Game _game;

        public Coach(Game game)
        {
            _game = game;
            _game.Events += GameOnEvents;
        }

        private void GameOnEvents(object? sender, GameEventArgs e)
        {
            if (e is PlayerScoredEventArgs scored && scored.GoalsScoredSoFar < 3)
            {
                Console.WriteLine($"goooood, {scored.PlayerName}");
            }
        }
    }
}