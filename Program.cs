namespace LR1;
class Test
{
    public static void Main(string[] args)
    {
       GameAccount FirstPlayer = new("Tarik");
       GameAccount SecondPlayer = new("Tarak");

       for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                FirstPlayer.WinGame(SecondPlayer.UserName, i);
                SecondPlayer.LoseGame(FirstPlayer.UserName, i);
                continue;
            }
            FirstPlayer.LoseGame(SecondPlayer.UserName, i);
            SecondPlayer.WinGame(FirstPlayer.UserName, i);
        }

        Console.WriteLine("-----------------------");
        FirstPlayer.GetStats();

        Console.WriteLine("-----------------------");
        SecondPlayer.GetStats();
    }
}