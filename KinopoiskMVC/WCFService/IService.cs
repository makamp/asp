using System.Collections.Generic;
using System.ServiceModel;
using DAL;

namespace WCFService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        IList<Film> SelectFilms();

        [OperationContract]
        bool AddFilm(Film film);

        [OperationContract]
        bool UpdateFilm(Film film);

        [OperationContract]
        bool DeleteFilm(int filmId);

        [OperationContract]
        IList<Genre> SelectGenres();

        [OperationContract]
        IList<Film> SelectFilmsByGenreId(int genreId);
    }
}