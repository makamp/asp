using System.Collections.Generic;
using KinopoiskMVC.FilmsServiceReference;

namespace KinopoiskMVC.Models.ViewModels
{
    public class ViewModelAddFilm
    {
        public Film Film { get; set; }

        public IDictionary<string, int> Genres { get; set; }
        public int[] SelectedGenres { get; set; }
    }
}