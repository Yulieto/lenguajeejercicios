using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejerciciosnota
{
    public partial class ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double art, ganan;
            art = Convert.ToDouble(txtvalorc.Text);
            ganan = art * 0.30;
            Lblresultado.Text = System.Convert.ToString(ganan);
        }
    }
}