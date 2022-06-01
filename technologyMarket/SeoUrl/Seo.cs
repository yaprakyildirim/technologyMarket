using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace technologyMarket.SeoUrl
{
    public class Seo
    {
        public static string AdresDuzenle(object a)
        {
            string s = a.ToString();

            //s = oncul + id + "-" + s;
            if (string.IsNullOrEmpty(s))//string yok veya bos ise true döndürür
            {
                return "";
            }
            if(s.Length > 80)
            {
                s = s.Substring(0, 80); //stringden belli karakter alır.
            }
            s = s.Replace("ş", "s");
            s = s.Replace("Ş", "S");
            s = s.Replace("ğ", "g");
            s = s.Replace("Ğ", "G");
            s = s.Replace("İ", "I");
            s = s.Replace("ı", "i");
            s = s.Replace("ç", "c");
            s = s.Replace("Ç", "C");
            s = s.Replace("ö", "o");
            s = s.Replace("Ö", "O");
            s = s.Replace("ü", "u");
            s = s.Replace("Ü", "U");
            s = s.Replace("'", "");
            s = s.Replace("\"", "");
            Regex r = new Regex("[^a-zA-Z0-9_-]");
            //if(r.IsMatch(s))
            s = r.Replace(s, "-");
            if (!string.IsNullOrEmpty(s))
                while (s.IndexOf("--") > -1)
                    s = s.Replace("--", "-");
                if (s.StartsWith("-")) s = s.Substring(1);
                if (s.EndsWith("-")) s = s.Substring(0, s.Length - 1);
                return s;
        }
    }
}