using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejerciciosnota
{
    public partial class ejercicio_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double pulsa, edad;
            edad = Convert.ToDouble(Txtedad.Text);
            pulsa = (220 - edad) / 10;
            if (edad < 18)
                Lblpuls.Text = System.Convert.ToString(Txtnumpul);
            else
                Lblresultado.Text = System.Convert.ToString(pulsa);
        }
    }
}