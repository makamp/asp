using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace KinopoiskMVC.Core
{
    public static class Controls
    {
        public static MvcHtmlString CheckBoxList(this HtmlHelper helper, IDictionary<string, int> items, IList<int> selectedCheckBoxes, CheckBoxListSettings settings)
        {
            var htmlTable = new HtmlTable();

            var tempTableRow = new HtmlTableRow();
            
            foreach (var item in items)
            {
                if (tempTableRow.Cells.Count >= ((int)settings.CblRepeatColumns))
                {
                    htmlTable.Rows.Add(tempTableRow);
                    tempTableRow = new HtmlTableRow();
                }

                var tableCell = GetCompleteHtmlTableCell(item, settings, selectedCheckBoxes);
                tempTableRow.Cells.Add(tableCell);
            }

            if(tempTableRow.Cells.Count>0)
            {
                htmlTable.Rows.Add(tempTableRow);
            }

            string result;
            using (var sw = new StringWriter())
            {
                htmlTable.RenderControl(new HtmlTextWriter(sw));
                result = sw.ToString();
            }
            return new MvcHtmlString(result);
        }
        
        private static HtmlTableCell GetCompleteHtmlTableCell(KeyValuePair<string, int> item, CheckBoxListSettings settings, IList<int> selectedCheckBoxes)
        {
            //Add checkBox
            var htmlTableCheckboxCell = new HtmlTableCell
            {
                InnerHtml = GenerateHtmlMarkupCheckBox(item, settings, selectedCheckBoxes) + GenerateHtmlMarkupLabel(item)
            };
            return htmlTableCheckboxCell;
        }

        private static string GenerateHtmlMarkupCheckBox(KeyValuePair<string, int> item, CheckBoxListSettings settings, IList<int> selectedCheckBoxes)
        {
            var tagBuilder = new TagBuilder("input");

            tagBuilder.MergeAttribute("type", "checkbox");
            tagBuilder.MergeAttribute("name", settings.CblName);
            tagBuilder.MergeAttribute("value", item.Value.ToString(CultureInfo.InvariantCulture));

            if (selectedCheckBoxes != null)
            {
                if (selectedCheckBoxes.Contains(item.Value))
                {
                    tagBuilder.MergeAttribute("checked", null);
                }
            }

            return tagBuilder.ToString(TagRenderMode.SelfClosing);
        }

        private static string GenerateHtmlMarkupLabel(KeyValuePair<string, int> item)
        {
            var tagBuilder = new TagBuilder("label");
            tagBuilder.SetInnerText(item.Key);
            return tagBuilder.ToString(TagRenderMode.Normal);
        }      
    }


    public enum Layoutt
    {
        Table = 0,
        Flow = 1
    }

    public enum Direction
    {
        Horizontal = 0,
        Vertical = 1
    }

    public enum RepeatColumns
    {
        OneColumn = 1,
        TwoColumns = 2,
        ThreeColumns = 3,
        FourColumns = 4,
        FiveColumns = 5
    }

    public class CheckBoxListSettings
    {
        public string CblName = "SelectedGenres";

        public Layoutt CblLayout = Layoutt.Table;
        public Direction CblDirection = Direction.Horizontal;
        public RepeatColumns CblRepeatColumns = RepeatColumns.FiveColumns;
    }
}