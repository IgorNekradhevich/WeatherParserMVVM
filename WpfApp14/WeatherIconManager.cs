
namespace WpfApp14
{
    class WeatherIconManager : Manager
    {
        public WeatherIconManager(SiteParser siteParser) : base(siteParser) { }
        public override string GetInfo()
        {
            string result = MyCutter.Cut("Текущая", "body");
            MyCutter.Text = result;
            result = MyCutter.Cut("src=\"", "\"/");
            MyCutter = new Cutter(MySiteParser.GetHTML());
            return result;
        }
    }
}
