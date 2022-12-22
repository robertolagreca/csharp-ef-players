// See https://aka.ms/new-console-template for more information

using CSharpEntityFrameworkPlayersRemake2;
using (PlayerContext db = new PlayerContext())
{
//ISTRUZIONI PER FARE TUTTE LE OPERAZIONI

//1 - PULISCO LE DUE TABELLE DAI DATI

 List<Player> players = db.Players.OrderBy(player => player.Name).ToList<Player>();

 foreach (Player player in players)
 {
     db.Remove(player);
 }


 List<Team> teams = db.Teams.OrderBy(team => team.Name).ToList<Team>();

 foreach (Team team in teams)
 {
     db.Remove(team);
 }
 db.SaveChanges();

 


//2 - INSERISCO UN TEAM E 3 PLAYERS DEL TEAM.

//CREO UN RECORD DI TEAM, LO AGGIUNGO AL DB E SALVO

/*
Team team1 = new Team() { Name = "Ciao", City = "Milano", Coach ="Mourigno", Colors = "Giallo-Viola", Players = new List<Player>() };

db.Add(team1);
db.SaveChanges();

//CREO TRE RECORD DI PLAYER, LO AGGIUNGO AL DB E SALVO

Player player1 = new Player() { Name = "Francesco", Surname = "Capatonda", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0};

//Aggiorno un attributo del player 1
player1.Name = "Maccio";

Player player2 = new Player() { Name = "Victoria", Surname = "De Angelis", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0 };

Player player3 = new Player() { Name = "Leslie", Surname = "Nielsen", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0 };

//Inserisco il teamId ad ogni player. Relazione una squadra molti player
player1.TeamId = team1.TeamId;
player2.TeamId = team1.TeamId;
player3.TeamId = team1.TeamId;

//Metodo che controlla per ogni player
//se i MatchesWon sono minori dei MatchesPlayes

player1.MatchesWon = StaticRandom.CheckPlayedWon(player1.MatchesPlayed);
player2.MatchesWon = StaticRandom.CheckPlayedWon(player2.MatchesPlayed);
player3.MatchesWon = StaticRandom.CheckPlayedWon(player3.MatchesPlayed);



//Aggiungo i tre record alla tabella players e salvo.
db.Add(player1);
db.Add(player2);
db.Add(player3);
db.SaveChanges();


*/


}




// ALCUNE PROVE PRECEDENTI, IN CUI SALVO NUOVI PLAYER CON UN TEAM
// GIA' PRESENTE NEL DB
//Player player2 = new Player() { Name = "Piero", Surname = "Capatonda", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0, TeamId = 4};

//Player player3 = new Player() { Name = "Damiano", Surname = "De Angelis", Score = StaticRandom.RandNumberGenerator_1_10(), MatchesPlayed = StaticRandom.RandNumberGenerator_1_100(), MatchesWon = 0, TeamId = 4 };