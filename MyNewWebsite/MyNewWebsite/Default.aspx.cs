using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyNewWebsite.MyService;

namespace MyNewWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        SampleService obj = new SampleService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Num1.Text);
            b = Convert.ToInt32(Num2.Text);
            c = obj.Add(a, b);
            result.Text = c.ToString(); 
        }
        protected void btnSub_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Num1.Text);
            b = Convert.ToInt32(Num2.Text);
            c = obj.Sub(a, b);
            result.Text = c.ToString(); 
        }
        protected void btnMul_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Num1.Text);
            b = Convert.ToInt32(Num2.Text);
            c = obj.Mul(a, b);
            result.Text = c.ToString();
        }
        protected void btnDiv_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Num1.Text);
            b = Convert.ToInt32(Num2.Text);
            c = obj.Div(a, b);
            result.Text = c.ToString();
        }
    }
}