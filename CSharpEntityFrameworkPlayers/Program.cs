// See https://aka.ms/new-console-template for more information
using CSharpEntityFrameworkPlayers;

using (PlayerContext db= new PlayerContext())
{
    Player player1 = new Player() { Name = "Aldo", Surname = "Baglio", Score = 10, MatchesPlayed = 10, MatchesWon = 10 };
    db.Add(player1);
    db.SaveChanges();
    Console.WriteLine("E' stato registrato con successo Nome: " + player1.Name);
}

/*using (SchoolContext db = new SchoolContext())
{
    CourseImage corsoImmagine = new CourseImage() { Caption = "Corso per diventare info", ImageRoute = "Path immagine" };
    Course corsoNuovo = new Course() { ImageCourse = corsoImmagine, Name = "Informatica" };
    Student studenteMate = new Student() { Name = "Ver", Surname = "Cia", Email = "dffdf", AttendedCourses = new List<Course>() };

    //corsoNuovo.ImageCourse= corsoImmagine; inserito già sopra
    studenteMate.AttendedCourses.Add(corsoNuovo);


    db.Add(corsoImmagine);
    db.Add(corsoNuovo);
    db.Add(studenteMate);
    db.SaveChanges();
} */
