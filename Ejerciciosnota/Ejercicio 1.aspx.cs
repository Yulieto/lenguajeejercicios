using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejerciciosnota
{
    public partial class Ejercicio_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(Txtnum1.Text);
            if (num < 0)
                Lblresult.Text = System.Convert.ToString(num * -1);
            else
                Lblresult.Text = System.Convert.ToString(num);
        }
    }
}