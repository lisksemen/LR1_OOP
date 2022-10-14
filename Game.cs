using System.Text.Json;

namespace LR1
{
    internal class Game
    {

        private static int GameID = 1;

        public int ID { get; }
        public string Name { get; }
        public string OpponentName { get; }
        public bool IsWin { get; }
        public int Rating { get; }

        public Game (string name, string opponentName, bool isWin, int rating)
        {
            if (rating < 0)
                throw new ArgumentOutOfRangeException (nameof (rating));

            ID = GameID++;
            Name = name;
            OpponentName = opponentName;
            this.IsWin = isWin;
            Rating = rating;
        }

        public override string? ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
