// See https://aka.ms/new-console-template for more information
using CSharpEntityFrameworkPlayers;
using System.Collections.Generic;

using (PlayerContext db = new PlayerContext())
{

    Team team1= new Team() { Name = "Generation", City = "Milan-Rome", Colors = "Viola-Giallo", Players = new List<Player>()};

    Player player1 = new Player() { Name = "Maccio", Surname = "Capatonda", Score = 1, MatchesPlayed = 1, MatchesWon = 0, TeamId = 1 };

    team1.Players.Add(player1);

    //Add
    db.Add(team1);

    db.Add(player1);

    db.SaveChanges();









    /*Player player1 = new Player() { Name = "Maccio", Surname = "Capatonda", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0, TeamId = 1};

    player1.MatchesWon = StaticRandom.CheckPlayedWon(player1.MatchesPlayed); */








    //Read
    /* List<Player> players = db.Players.OrderBy(player => player.Name).ToList<Player>();
     Console.WriteLine();
     List<Team> teams = db.Teams.OrderBy(team => team.TeamId).ToList<Team>();
     Console.WriteLine(); */


    /* Player player2 = new Player() { Name = "Leslie", Surname = "Nielsen", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0,, TeamId = 1 };

   player2.MatchesWon = StaticRandom.CheckPlayedWon(player1.MatchesPlayed);

   Player player3 = new Player() { Name = "Ricky", Surname = "Gervais", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0,, TeamId = 1 };

   player3.MatchesWon = StaticRandom.CheckPlayedWon(player1.MatchesPlayed); */



    /* Console.WriteLine("Modifica di un record in corso");
     //Update
     player1.Name = "Veronica";
     Console.WriteLine(players);
     db.SaveChanges();
     Console.WriteLine();*/

    //Remove
    /*db.Remove(player1);
    db.SaveChanges(); */


}   //Remove range per eliminare tutto, da capire come funziona
    //db.People.RemoveRange(db.People.Where(x => x.State == "CA"));
    //db.SaveChanges();