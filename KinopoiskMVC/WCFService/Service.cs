using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DAL;

namespace WCFService
{
    public class Service : IService
    {
        private readonly DBFilms _db;

        public Service()
        {
            _db = new DBFilms();
        }

        #region Implementation of IService

        public IList<Film> SelectFilms()
        {
            return _db.Films.Include("Genres").ToList();
        }

        public bool AddFilm(Film film)
        {
            var genreIds = film.Genres.Select(p1 => p1.GenreID).ToList();
            var genres = _db.Genres.Where(p => genreIds.Contains(p.GenreID));
            film.Genres = new Collection<Genre>();

            foreach (var genre in genres)
            {
                film.Genres.Add(genre);
            }

            _db.Films.Add(film);
            return _db.SaveChanges() > 0;
        }

        public bool UpdateFilm(Film film)
        {
            var genreIds = film.Genres.Select(p => p.GenreID).ToList();
            var genres = _db.Genres.Where(p => genreIds.Contains(p.GenreID));

            var filmInDb = _db.Films.Include("Genres").FirstOrDefault(p => p.FilmID == film.FilmID);
            if (filmInDb != null)
            {
                //UpdateGenres
                filmInDb.Genres = new Collection<Genre>();
                foreach (var genre in genres)
                {
                    filmInDb.Genres.Add(genre);
                }

                //Update other info
                filmInDb.Title = film.Title;
                filmInDb.OriginalTitile = film.OriginalTitile;
                filmInDb.Year = film.Year;
            }
            return _db.SaveChanges() > 0;
        }

        public bool DeleteFilm(int filmId)
        {
            var filmInDb = _db.Films.FirstOrDefault(p => p.FilmID == filmId);

            if (filmInDb!=null)
            {
                _db.Films.Remove(filmInDb);
            }
            return _db.SaveChanges() > 0;
        }

        public IList<Genre> SelectGenres()
        {
            return _db.Genres.ToList();
        }

        public IList<Film> SelectFilmsByGenreId(int genreId)
        {
            var filmsByGenre = new List<Film>();
            var genre = _db.Genres.Include("Films").FirstOrDefault(p => p.GenreID == genreId);
            if(genre!=null)
            {
                filmsByGenre = genre.Films.ToList();
            }
            return filmsByGenre;
        }

        #endregion
    }
}
