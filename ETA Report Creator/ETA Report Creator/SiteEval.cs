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
           // eval_testerName.Text = ReportCreator.testerName;
          
        }

        private void siteEval_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siteEval_done_Click(object sender, EventArgs e)
        {
            bool isAnyRadioButtonChecked = false;
            foreach (RadioButton rdo in panel1.Controls.OfType<RadioButton>())
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
            }
            else
            {
                // Print message no button is selected 
            }
        }
    }
}
