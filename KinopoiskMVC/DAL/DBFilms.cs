using System.Data.Entity;

namespace DAL
{
    public class DBFilms : DbContext
    {
        static DBFilms()
        {
            Database.SetInitializer(new DBFilmsInitializer());
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Film>().
        //      HasMany(c => c.Genres).
        //      WithMany(p => p.Films).
        //      Map(
        //       m =>
        //       {
        //           m.ToTable("GenreFilms");
        //           m.MapLeftKey("FilmId");
        //           m.MapRightKey("GenreId");
        //       });
        //}
    }

    public class DBFilmsInitializer : DropCreateDatabaseIfModelChanges<DBFilms>
    {
        protected override void Seed(DBFilms context)
        {
            context.Films.Add(new Film
                {
                    Title = "Титаник",
                    OriginalTitile = "Titanic",
                    Year = 1997
                });
            context.Actors.Add(new Actor
                {
                    Name = "Роберт",
                    Surname = "Дауни мл."
                });

            context.Genres.Add(new Genre {OriginalTitle = "animatsiya", Title = "Анимация"});
            context.Genres.Add(new Genre {OriginalTitle = "biografiya", Title = "Биография"});
            context.Genres.Add(new Genre {OriginalTitle = "boevik", Title = "Боевик"});
            context.Genres.Add(new Genre {OriginalTitle = "vestern", Title = "Вестерн"});
            context.Genres.Add(new Genre {OriginalTitle = "voennyj", Title = "Военный"});
            context.Genres.Add(new Genre {OriginalTitle = "detektiv", Title = "Детектив"});
            context.Genres.Add(new Genre {OriginalTitle = "dokumentalnyj", Title = "Документальный"});
            context.Genres.Add(new Genre {OriginalTitle = "drama", Title = "Драма"});
            context.Genres.Add(new Genre {OriginalTitle = "istoricheskiy", Title = "Исторический"});
            context.Genres.Add(new Genre {OriginalTitle = "komediya", Title = "Комедия"});
            context.Genres.Add(new Genre {OriginalTitle = "kriminal", Title = "Криминал"});
            context.Genres.Add(new Genre {OriginalTitle = "melodrama", Title = "Мелодрама"});
            context.Genres.Add(new Genre {OriginalTitle = "mistika", Title = "Мистика"});
            context.Genres.Add(new Genre {OriginalTitle = "muzyka", Title = "Музыка"});
            context.Genres.Add(new Genre {OriginalTitle = "multfilm", Title = "Мультфильм"});
            context.Genres.Add(new Genre {OriginalTitle = "myuzikl", Title = "Мюзикл"});
            context.Genres.Add(new Genre {OriginalTitle = "priklyucheniya", Title = "Приключения"});
            context.Genres.Add(new Genre {OriginalTitle = "raznoe", Title = "Разное"});
            context.Genres.Add(new Genre {OriginalTitle = "romanticheskiy", Title = "Романтический"});
            context.Genres.Add(new Genre {OriginalTitle = "semeynyj", Title = "Семейный"});
            context.Genres.Add(new Genre {OriginalTitle = "sport", Title = "Спорт"});
            context.Genres.Add(new Genre {OriginalTitle = "triller", Title = "Триллер "});
            context.Genres.Add(new Genre {OriginalTitle = "uzhasy", Title = "Ужасы"});
            context.Genres.Add(new Genre {OriginalTitle = "fantastika", Title = "Фантастика"});
            context.Genres.Add(new Genre {OriginalTitle = "fentezi", Title = "Фэнтези"});
            context.Genres.Add(new Genre {OriginalTitle = "erotika", Title = "Эротика"});

            context.SaveChanges();
        }
    }
}