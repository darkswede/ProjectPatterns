using System;

namespace ProjectPatterns.Mediator
{
    public class PlayerScoredEventArgs : GameEventArgs
    {
        public string PlayerName;
        public int GoalsScoredSoFar;

        public PlayerScoredEventArgs(string playerName, int goalsScoredSoFar)
        {
            PlayerName = playerName;
            GoalsScoredSoFar = goalsScoredSoFar;
        }

        public override void Print()
        {
            Console.WriteLine($"{PlayerName} scored a goal" +
                              $"that's his {GoalsScoredSoFar} goal");
        }
    }
}