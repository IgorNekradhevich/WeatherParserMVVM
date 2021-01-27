
namespace WpfApp14
{
    class WeatherManager : Manager
    {
        public WeatherManager(SiteParser siteParser) : base(siteParser) { }
        public override string GetInfo()
        {
            string result = MyCutter.Cut("Текущая", "</div>");
            MyCutter.Text = result;
            result = MyCutter.Cut("\">", "</span>");
            MyCutter = new Cutter(MySiteParser.GetHTML());
                 return result;
        }
    }
}
