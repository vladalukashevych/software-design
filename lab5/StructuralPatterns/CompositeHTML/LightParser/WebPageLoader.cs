using System.Net;
using System.Text;

namespace CompositeHTML.LightParser
{
    public class WebPageLoader
    {
        private string link;

        public WebPageLoader(string link)
        {
            this.link = link;
        }

        public string GetText()
        {
            var webClient = new WebClient();
            byte[] raw = webClient.DownloadData(link);
            string webData = Encoding.UTF8.GetString(raw);
            return webData;
        }
    }
}
