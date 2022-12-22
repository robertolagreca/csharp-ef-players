// See https://aka.ms/new-console-template for more information
using CSharpEntityFrameworkPlayers;

using (PlayerContext db = new PlayerContext())
{
    Player player1 = new Player() { Name = "Giovanni", Surname = "Baglioni", Score = 10, MatchesPlayed = 10, MatchesWon = 10 };
    db.Add(player1);
    db.SaveChanges();
    
    Console.WriteLine("Reading dopo aggiunta players");
    List<Player> players = db.Players.OrderBy(player => player.Name).ToList<Player>();
    Console.WriteLine();

    Console.WriteLine("Modifica di un record in corso");
    player1.Name = "Veronica";
    Console.WriteLine(players);
    db.SaveChanges();
    Console.WriteLine();

    db.Remove(player1);
    db.SaveChanges();

}
