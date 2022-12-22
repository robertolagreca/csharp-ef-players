// See https://aka.ms/new-console-template for more information

using CSharpEntityFrameworkPlayersRemake2;
using (PlayerContext db = new PlayerContext())
{
    /*Player player1 = new Player() { Name = "Franco", Surname = "Capatonda", Score = 1, MatchesPlayed = 1, MatchesWon = 0 };*/

    Player player1 = new Player() { Name = "Maccio", Surname = "Capatonda", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0};

    player1.MatchesWon = StaticRandom.CheckPlayedWon(player1.MatchesPlayed);


    /*  List<Player> players = db.Players.OrderBy(player => player.Name).ToList<Player>();

      foreach(Player player in players)
      {
          db.Remove(player);
      } */


    //db.Add(player1);
    db.SaveChanges();

}
