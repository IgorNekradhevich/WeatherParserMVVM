using System;
using System.Net;
using System.IO;

namespace WpfApp14
{
    class SiteParser
    {
       protected string Url { get; set; }
       public SiteParser(string url)
        {
            Url = url;
        }

        public  string GetHTML()
        {
            try
            {
                WebRequest request = WebRequest.Create(Url);
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                return reader.ReadToEnd();
            } catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
