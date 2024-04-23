using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ShowBalance_Click(object sender, EventArgs e)
        {
            textBox3.Text = (sc.ShowBanlance(textBox1.Text)).ToString();
        }

        protected void WithDraw_Click(object sender, EventArgs e)
        {
            textBox3.Text = (sc.WithDraw(Convert.ToDouble(textBox2.Text))).ToString();
        }

        protected void Deposit_Click(object sender, EventArgs e)
        {
            textBox3.Text = (sc.Deposit(Convert.ToDouble(textBox2.Text))).ToString();
        }
    }
}