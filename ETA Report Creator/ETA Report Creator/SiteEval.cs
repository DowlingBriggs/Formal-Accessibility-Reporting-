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
    public partial class SiteEval : Form
    {
        public SiteEval()
        {
            InitializeComponent();

            eval_siteName.Text = ReportCreator.siteName;
           // eval_testerName.Text = ReportCreator.testerName; --- not needed
          
        }

        private void siteEval_exit_Click(object sender, EventArgs e)
        {
            //Exits site evaluation form
            this.Close();
        }

        private void siteEval_done_Click(object sender, EventArgs e)
        {
            bool isAnyRadioButtonChecked = false;
            foreach (RadioButton rdo in panel1.Controls.OfType<RadioButton>()) //are we planning on using this foreach method for all panels within groupbox?
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
            }
            if (isAnyRadioButtonChecked)
            {
                // Code here one button is checked
               if( rdoButton1_pass.Checked == true)
                {
                    //Was not sure if we want to send output directly from here or if we are waiting until end.
                    //MessageBox.Show("Pass"); 
                    //return;
                }
            }
            else
            {
                // Print message no button is selected 
                MessageBox.Show("Please select if the site Passes or Fails the specific accessibility evaluation criteria.");
                return;
            }
        }
    }
}
