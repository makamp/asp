using System.Collections.Generic;
using KinopoiskMVC.Core;

namespace KinopoiskMVC.Models.CheckBoxList
{
    public class CheckBoxListModel
    {
        public IDictionary<string, int> Items { get;set;}
        public IList<int> SelectedItems { get; set; }
        public CheckBoxListSettings Settings { get; set; }
    }
}