// See https://aka.ms/new-console-template for more information

using CSharpEntityFrameworkPlayersRemake;

using (PlayerContext db= new PlayerContext())
{
    Team team1 = new Team() { Name = "Generation", City = "Milan-Rome", Colors = "Viola-Giallo", Players = new List<Player>() };
    
    Player player1 = new Player() { Name = "Maccio", Surname = "Capatonda", Score = 1, MatchesPlayed = 1, MatchesWon = 0};

    //team1.Players.Add(player1);
    player1.TeamId= team1.TeamId;

    //Add
    //db.Add(team1);

    db.Players.Add(player1);

    db.SaveChanges();
}
