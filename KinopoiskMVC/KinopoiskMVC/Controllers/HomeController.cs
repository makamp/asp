using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
            ViewBag.AllGenres = _filmModels.GetAllGenres();
            ViewBag.GenreId = 0;

            return View(new FilterParams());
        }

        [HttpPost]
        public ActionResult Index(int genreId)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewBag.AllGenres = _filmModels.GetAllGenres().Select(p => p.GenreID).ToArray();
            ViewBag.GenreId = genreId;
            return View();
        }

        public ActionResult FilterFilms(FilterParams filterParams)
        {
            var films = _filmModels.GetAllFilms().ToList();

            if (filterParams.YearFrom.HasValue)
            {
                films = films.Where(p => p.Year >= filterParams.YearFrom).ToList();
            }
            if (filterParams.YearTo.HasValue)
            {
                films = films.Where(p => p.Year <= filterParams.YearTo).ToList();
            }
            if (!string.IsNullOrEmpty(filterParams.SearchString) && filterParams.SearchString!="null")
            {
                films = films.Where(p => p.Title.StartsWith(filterParams.SearchString)).ToList();
            }

            var filmsInfo = films.Select(film => new FilmInfo
                {
                    Title = film.Title, 
                    OriginalTitle = film.OriginalTitile, 
                    Year = film.Year
                }).ToList();


            return Json(new ListResult { Data = filmsInfo });
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

    public class ListResult
        {
        public IEnumerable<FilmInfo> Data { get; set; }
        }
}
