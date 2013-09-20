using System.Collections.Generic;
using System.Linq;
using KinopoiskMVC.FilmsServiceReference;

namespace KinopoiskMVC.Models
{
    public class FilmModels
    {
        public FilmModels()
        {
            _sc = new ServiceClient();
        }

        private readonly ServiceClient _sc;

        public IList<Film> GetAllFilms()
        {
            return _sc.SelectFilms();
        }

        public IList<Film> GetFilmsByGenreId(int genreId)
        {
            return _sc.SelectFilmsByGenreId(genreId);
        }

        public void AddFilm(Film film)
        {
            _sc.AddFilm(film);
        }

        public Film GetFilmById(int id)
        {
            return _sc.SelectFilms().FirstOrDefault(p => p.FilmID == id);
        }

        public bool EditFilm(Film film)
        {
            return _sc.UpdateFilm(film);
        }

        public bool DeleteFilm(int id)
        {
            return _sc.DeleteFilm(id);
        }

        public List<Genre> GetAllGenres()
        {
            return _sc.SelectGenres();
        }
    }
}