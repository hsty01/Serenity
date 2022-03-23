using Serenity.Navigation;
using Administration = LatihanSerenity.Administration.Pages;
using MyPages = LatihanSerenity.MasterData.Pages;
using MovieDB = LatihanSerenity.MovieDB.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "MasterData", icon: "fa-university")]
[assembly: NavigationLink(2100, "MasterData/Siswa", typeof(MyPages.SiswaController), icon: "fa-tags")]
// [assembly: NavigationLink(2300, "MasterData/Pelanggaran", typeof(MyPages.PelanggaranController), icon: "fa-list")]

[assembly: NavigationMenu(3000, "Movie Database", icon: "fa-database")]
[assembly: NavigationLink(3100, "Movie Database/Movie", typeof(MovieDB.MovieController), icon: "fa-film")]
[assembly: NavigationLink(3200, "Movie Database/Genre", typeof(MovieDB.GenreController), icon: "fa-thumb-tack")]
[assembly: NavigationLink(3300, "Movie Database/Person", typeof(MovieDB.PersonController), icon: "fa-user")]