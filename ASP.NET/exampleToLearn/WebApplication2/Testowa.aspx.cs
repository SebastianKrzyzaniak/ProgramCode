using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Testowa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            /*
             *var istniejacaLista = new List<Czlowiek>();
             var starsi = new List<Czlowiek>();

             var Czlowiek1 = new Czlowiek(10);
             var Czlowiek2 = new Czlowiek(11);
             var Czlowiek3 = new Czlowiek(5);
             var Czlowiek4 = new Czlowiek(20);

             foreach (var c in istniejacaLista)
                 if(c.wiek > 10)
                 {
                     starsi.Add(c);
                 }
            */
            // var starsiLINQ = from c in istniejacaLista where c.wiek > 10  select c;

            // var czl = new Czlowiek(10);

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string n = imie.Value;     //Request.Form["imie"];
            Label1.Text = n;
            if (Label1.Text == "") { Label1.Text = "Wpisz coś"; }       
        }
        /*protected void sss(object sender, EventArgs e)
        {

                //Request.Form["imie"];
            Label1.Text = "ttt";
         
        }
        */

    }
}