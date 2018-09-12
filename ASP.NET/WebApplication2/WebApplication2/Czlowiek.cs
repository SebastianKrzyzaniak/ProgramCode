using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication2
{
    public class Czlowiek
    {
        public String imie; 
        public String nazwisko;
        public int wiek;
        public Czlowiek(int wiek)
        {
            this.wiek = wiek;
        }

        public string Gett()
        {
            string ge = "https://www.facebook.com/";

            var req = HttpWebRequest.CreateHttp(ge + "gentelman.ez?ref=bookmarks");

            return ge;
        }
    }
}