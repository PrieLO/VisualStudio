using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Spider
{
    class Program
    {


        static void Main(string[] args)
        {
            using (var ctxt = new SpiderEntities ())
            {

                var u = new Spider.Table();
                u.depht = 0;
                u.type = "text/html";
                u.uri = "http://www.di.unipi.it";

                ctxt.Table.Add(u);

                ctxt.SaveChanges();
                
                
                var q = from uri in ctxt.Table where uri.depht == 0 select uri;





            }

        }
    }
}
