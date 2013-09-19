using System.Linq;
using System.Web.Mvc;
using KinopoiskMVC.FilmsServiceReference;
using KinopoiskMVC.Models;
using KinopoiskMVC.Models.ViewModels;

namespace KinopoiskMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilmModels _filmModels;

        public HomeController()
        {
            _filmModels = new FilmModels();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View(_filmModels.GetAllFilms());
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddFilm()
        {
            var genres = _filmModels.GetAllGenres().ToDictionary(genre => genre.Title, genre => genre.GenreID);

            var modelAddFilm = new ViewModelAddFilm
            {
                Genres = genres,
            };

            return View(modelAddFilm);
        }

        [HttpPost]
        public ActionResult AddFilm(ViewModelAddFilm viewModelAddFilm)
        {
            var selectedGenres = _filmModels.GetAllGenres().Where(p => viewModelAddFilm.SelectedGenres.Contains(p.GenreID));
            var completeFilm = viewModelAddFilm.Film;
            completeFilm.Genres = new System.Collections.Generic.List<Genre>();
            completeFilm.Genres.AddRange(selectedGenres);
            _filmModels.AddFilm(completeFilm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditFilm(int id)
        {
            var genres = _filmModels.GetAllGenres().ToDictionary(genre => genre.Title, genre => genre.GenreID);

            var film = _filmModels.GetFilmById(id);

            var selectedGenres = film.Genres.Select(p => p.GenreID).ToList();

            var viewModelEditFilm = new ViewModelEditFilm
                {
                    Film = film, 
                    Genres = genres,
                    SelectedGenres = selectedGenres
                };

            return View(viewModelEditFilm);
        }

        [HttpPost]
        public ActionResult EditFilm(ViewModelEditFilm viewModelEditFilm)
        {
            var selectedGenres = _filmModels.GetAllGenres().Where(p => viewModelEditFilm.SelectedGenres.Contains(p.GenreID));
            var completeFilm = viewModelEditFilm.Film;
            completeFilm.Genres = new System.Collections.Generic.List<Genre>();
            completeFilm.Genres.AddRange(selectedGenres);
            _filmModels.EditFilm(completeFilm);
            
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFilm(int id)
        {
            _filmModels.DeleteFilm(id);
            return RedirectToAction("Index");
        }
    }
}
