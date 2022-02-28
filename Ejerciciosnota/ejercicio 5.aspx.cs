using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejerciciosnota
{
    public partial class ejercicio_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double pedi, trauma, gineco, presup,presuan ;
            presuan = Convert.ToDouble(Txtpreanual.Text);
            presup = presuan *1;
            pedi = presup * 0.3;
            trauma = presup * 0.3;
            gineco = presup * 0.4;
            Lblresulgineco.Text = System.Convert.ToString(gineco);
            Lblresultpedia.Text = System.Convert.ToString(pedi);
            Lblresultrauma.Text = System.Convert.ToString(trauma);

        }
    }
}