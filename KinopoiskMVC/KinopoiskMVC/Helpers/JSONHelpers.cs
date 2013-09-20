using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace KinopoiskMVC.Helpers
{
    public static class JSONHelpers
    {
        public static MvcHtmlString ToJSON(this HtmlHelper htmlHelper, object data)
        {
            var serializer = new JavaScriptSerializer();
            return new MvcHtmlString(serializer.Serialize(data));
        }
    }
}