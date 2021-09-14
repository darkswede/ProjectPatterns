namespace ProjectPatterns.Mediator
{
    public class Player
    {
        private string _name;
        private int _goalsScored = 0;
        private Game _game;

        public Player(string name, Game game)
        {
            _name = name;
            _game = game;
        }

        public void Score()
        {
            _goalsScored++;
            var args = new PlayerScoredEventArgs(_name, _goalsScored);
            _game.Fire(args);
        }
    }
}