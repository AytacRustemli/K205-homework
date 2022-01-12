using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Product
    {
        public int Price;
        public string Name;
        public string Model;


        public string Hash()
        {
            static void SEOLink(string text)
            {
                var seo = text.ToLower().Replace(" ", " -")
                              .Replace("ə", "e")
                              .Replace("ğ", "g")
                              .Replace("ç", "c");

            }
            return Name + " " + Model + " " + Price;
        }
        public int Hash2()
        {
            return Price + Price * 18 / 100;
        }

    }
}
