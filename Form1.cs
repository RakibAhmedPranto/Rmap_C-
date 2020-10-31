using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMapNavigator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = tbStreet.Text;
            string city = tbCity.Text;
            string state = tbState.Text;
            string zip = tbZip.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("https://www.google.com/maps?q=");
                if(street != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryData.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryData.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryData.Append(zip + "," + "+");
                }

                webBrowser1.Navigate(queryData.ToString());
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}
