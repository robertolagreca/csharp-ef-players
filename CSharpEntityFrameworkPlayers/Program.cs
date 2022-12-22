// See https://aka.ms/new-console-template for more information
using CSharpEntityFrameworkPlayers;

using (PlayerContext db = new PlayerContext())
{
    Player player1 = new Player() { Name = "Giovanni", Surname = "Baglioni", Score = 10, MatchesPlayed = 10, MatchesWon = 10 };
    //Add
    db.Add(player1);
    db.SaveChanges();
    
    Console.WriteLine("Reading dopo aggiunta players");
    //Read
    List<Player> players = db.Players.OrderBy(player => player.Name).ToList<Player>();
    Console.WriteLine();

    Console.WriteLine("Modifica di un record in corso");
    //Update
    player1.Name = "Veronica";
    Console.WriteLine(players);
    db.SaveChanges();
    Console.WriteLine();

    //Remove
    db.Remove(player1);
    db.SaveChanges();

}
