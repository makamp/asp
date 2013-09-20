using System.Collections.Generic;
using KinopoiskMVC.FilmsServiceReference;

namespace KinopoiskMVC.Models.ViewModels
{
    public class ViewModelEditFilm
    {
        public Film Film { get; set; }

        public IDictionary<string, int> Genres { get; set; }
        public IList<int> SelectedGenres { get; set; }
    }
}