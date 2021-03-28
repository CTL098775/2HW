using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW
{
    public partial class _2HW : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_input = 66;
            int i_sum = 0;
            for (int i = 1; i <= i_input; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    i_sum += i;
                }
            }
            Response.Write(i_sum);
            
        }
    }
}