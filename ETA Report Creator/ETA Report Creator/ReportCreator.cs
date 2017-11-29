using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETA_Report_Creator
{

    public partial class ReportCreator : Form
    {
        public static string siteName;
        public static string testerName;

        public ReportCreator()
        {
            InitializeComponent();
            reportCreator_date.Text = DateTime.Now.ToShortDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void reportCreator_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void reportCreator_next_Click(object sender, EventArgs e)
        {
            siteName = reportCreator_siteNameText.ToString();
            testerName = reportCreator_testerNameText.ToString();

            //Close current form and open SiteEval form
            this.Hide();
            var form2 = new SiteEval();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
