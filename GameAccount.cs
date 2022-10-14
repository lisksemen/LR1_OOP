namespace LR1;
public class GameAccount
{
    public string UserName { get; }
    public int CurrentRating { get; set; }

    public int GamesCount { get; set; }

    private List<Game> GamesHistory;


    public GameAccount(string UserName)
    {
        this.UserName = UserName;
        this.GamesCount = 0;
        this.CurrentRating = 1;
        this.GamesHistory = new List<Game>();
    }

    public void WinGame(string OpponentName, int Rating)
    {
        GamesHistory.Add(new Game(UserName, OpponentName, true, Rating));

        CurrentRating += Rating;

        GamesCount++;
    }

    public void LoseGame(string OpponentName, int Rating)
    {
        GamesHistory.Add(new Game(UserName, OpponentName, false, Rating));

        CurrentRating -= Rating;
        if (CurrentRating < 1)
            CurrentRating = 1;

        GamesCount++;   
    }

    public void GetStats()
    {
        Console.WriteLine("Stats for: " + UserName);
        Console.WriteLine(nameof(CurrentRating) + ": " + CurrentRating);
        Console.WriteLine(nameof(GamesCount) + ": " + GamesCount);
        Console.WriteLine("\nGames history:");
        GamesHistory.ForEach(Console.WriteLine);
    }
}