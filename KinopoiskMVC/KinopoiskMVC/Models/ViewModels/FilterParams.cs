namespace KinopoiskMVC.Models.ViewModels
{
    public class FilterParams
    {
        public FilterParams()
        {
            YearFrom = 1990;
            YearTo = 2013;
        }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }
        public string SearchString { get; set; }
    }
}