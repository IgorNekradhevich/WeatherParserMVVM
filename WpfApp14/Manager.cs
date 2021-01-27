namespace WpfApp14
{
   abstract class Manager
    {
        protected SiteParser MySiteParser { get; set; }
        protected Cutter MyCutter { get; set; }
        public Manager(SiteParser siteParser)
        {
            MySiteParser = siteParser;
            MyCutter = new Cutter(MySiteParser.GetHTML());
        }
        abstract public string GetInfo();

    }
}
