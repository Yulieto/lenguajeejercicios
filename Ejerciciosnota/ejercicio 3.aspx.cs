using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejerciciosnota
{
    public partial class ejercicio_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double salact, salnuevo;
            salact = Convert.ToDouble(Txtsalac.Text);
            salnuevo = salact * 0.25;   
            Lblresultado.Text = System.Convert.ToString(salnuevo);
        }
    }
}