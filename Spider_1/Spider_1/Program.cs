using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spider_1
{
    class Program
    {

        static IEnumerable<string> parString(string url)
        {
            yield return "";
        }

        static void Main(string[] args)
        {
            using (var ctxt = new SpiderEntities())
            {

                var u = new Spider_1.Url();
                u.depth = 0;
                u.type = "text/html";
                u.uri = "http://www.di.unipi.it";

                ctxt.Urls.Add(u);

                ctxt.SaveChanges();

                var q = from uri in ctxt.Urls where uri.depth == 0 select uri;


            }
        }
    }
}
