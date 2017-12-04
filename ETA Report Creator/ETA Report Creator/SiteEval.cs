using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETA_Report_Creator
{
    public partial class SiteEval : Form
    {
        public string path = @"c:\Users\ETA Etime\Documents\FormCreator_Test.docx";
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
            //Check to make sure all radio box groups are checked -- if so; write code
            bool validate = validateCB();
            if(validate == true)
                {
                //Write word doc
                CreateDocument();

                }
            else
                {
                MessageBox.Show("Please select Pass/Fail for all criteria", "Missing Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            /*
           // FileStream F = new FileStream("testdoc2.docx", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Console.WriteLine("Web Accessibility Report");
            string filename = @"C:\Users\ETA Etime\Documents\FormCreator_Test";
            Console.WriteLine(filename);
            try
            {
                using (FileStream fs = File.OpenWrite(filename))
                {
                    Byte[] content = new UTF8Encoding(true).GetBytes("Hello I am learning C#");
                    fs.Write(content, 0, content.Length);
                }
            }
            catch (Exception Ex)
            {
                Console.Write(e.ToString());
            }
            */

        }

        //Create document method
        private void CreateDocument()
        {
            try
            {
                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.
                winword.Visible = false;
                
                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Styles
                object Title = "Title";
                object Header1 = "Heading 1";
                object SubtleReference = "Subtle Reference";
                object SubtleEmph = "Subtle Emphasis";
                object NoSpacing = "No Spacing";
                object ListPara = "List Paragraph";


                //Title Section 

                //Report title Site name
                Paragraph title1 = document.Content.Paragraphs.Add(ref missing);
                string siteNameCap = ReportCreator.siteName.ToUpper();
                title1.Range.Text = siteNameCap + " ";
                title1.Range.set_Style(ref Title);
                title1.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title1.Range.Font.Size = 22;
                title1.Range.Font.Name = "Candara";
                title1.Range.Borders[WdBorderType.wdBorderTop].LineStyle = WdLineStyle.wdLineStyleDot;
                title1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;                
                title1.Range.InsertParagraphAfter();

                //Report title part 2
                Paragraph title2 = document.Content.Paragraphs.Add(ref missing);
                title2.Range.Text = "WEBSITE ACCESSIBILITY REPORT";
                title2.Range.set_Style(ref Title);
                title2.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title2.Range.Font.Size = 22;
                title2.Range.Font.Name = "Candara";
                title2.Range.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleDot;
                title2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title2.Range.InsertParagraphAfter();
                
                //Report title Tester Name
                Paragraph title3 = document.Content.Paragraphs.Add(ref missing);
                title3.Range.Text = "Submitted by " + ReportCreator.testerName;
                title3.Range.set_Style(ref NoSpacing);
                title3.Range.Font.Name = "Candara";
                title3.Range.Font.Italic = 1;
                title3.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title3.Range.Font.Size = 11;                
                title3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title3.Range.InsertParagraphAfter();

                //Report title ETA
                title3.Range.Text = "Emerging Technology and Accessibility";
                title3.Range.Font.Name = "Candara";
                title3.Range.Font.Italic = 1;
                title3.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title3.Range.Font.Size = 11;
                title3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title3.Range.InsertParagraphAfter();

                //Report title OIT
                title3.Range.Text = "Office of Information Technology";
                title3.Range.Font.Name = "Candara";
                title3.Range.Font.Italic = 1;
                title3.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title3.Range.Font.Size = 11;
                title3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title3.Range.InsertParagraphAfter();

                //Report title Date
                string day = DateTime.Now.Day.ToString();
                string month = DateTime.Now.ToString("MMMM");
                string year = DateTime.Now.Year.ToString();
                title3.Range.Text = day+" "+month+" "+year;
                title3.Range.Font.Name = "Candara";
                title3.Range.Font.Italic = 1;
                title3.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title3.Range.Font.Size = 11;
                title3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title3.Range.InsertParagraphAfter();

                //Summary Section

                //Summary Title
                Paragraph summary1 = document.Content.Paragraphs.Add(ref missing);
                summary1.Range.Text = "SUMMARY";
                summary1.Range.set_Style(ref Header1);
                summary1.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                summary1.Range.Font.Size = 12;
                summary1.Range.Font.Name = "Candara";
                summary1.Range.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleThinThickSmallGap;
                summary1.Range.InsertParagraphAfter();
                summary1.Range.InsertParagraphAfter();

                //Summary paragraph
                Paragraph summary2 = document.Content.Paragraphs.Add(ref missing);
                string pagesTested = ReportCreator.pagesTested;
                summary2.Range.Text = "This report summarizes the accessibility review of University of Alabama Adapted Athletics web pages. "
                    + pagesTested
                    +" pages were examined using a checklist derived from the World Wide Web Consortium Web Content Accessibility Guidelines, the emerging standard for web accessibility."
                    +" The sites/pages were reviewed in Fall 2017 by the Office of Information Technology Emerging Technology and Accessibility (ETA) team."
                    +" It is hoped that this initial evaluation will offer insight into the accessibility of these UA web pages and suggest future steps to"
                    +" improve the accessibility of the Office of Information Technology’s web presence. ";
                summary2.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                summary2.Range.Font.Size = 11;
                summary2.Range.Font.Name = "Candara";
                summary2.Range.InsertParagraphAfter();


                //Review Results Section

                //Review Results Title
                Paragraph results1 = document.Content.Paragraphs.Add(ref missing);
                results1.Range.Text = "REVIEW RESULTS";
                results1.Range.set_Style(ref Header1);
                results1.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                results1.Range.Font.Size = 12;
                results1.Range.Font.Name = "Candara";
                results1.Range.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleThinThickSmallGap;
                results1.Range.InsertParagraphAfter();
                results1.Range.InsertParagraphAfter();

                //Results paragraph
                Paragraph results2 = document.Content.Paragraphs.Add(ref missing);
                results2.Range.Text = "Like many UA web resources, the site does contain issues that can prevent users with disabilities from accessing site contents and functions."
                    +" The results given here summarize the review findings, focusing on the challenges that would interfere most heavily with a user’s experience."
                    +" Individual page checklists are available. ";
                results2.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                results2.Range.Font.Size = 11;
                results2.Range.Font.Name = "Candara";
                results2.Range.InsertParagraphAfter();


                //Results Checklist

                //Create list
                var resultsList = new List<string>();

                // Add items to the list. If radiobutton is false, add related message
                if (rb_f1.Checked == true)
                {
                    resultsList.Add("Not all functionality is available by using only the keyboard (Tab, Shift +Tab, Enter, etc.)");
                }
                if (rb_f2.Checked == true)
                {
                    resultsList.Add("Page structure: Most, if not all, pages examined lack a link that allows users to “skip navigation” or “skip to main content”.");
                }
                if (rb_f3.Checked == true)
                {
                    //resultsList.Add("");
                }
                if (rb_f4.Checked == true)
                {
                    //resultsList.Add("");
                }

                //Convert list to array
                var bulletItems = resultsList.ToArray();

                //Created bulleted list
                Paragraph assets = document.Content.Paragraphs.Add();
                assets.Range.ListFormat.ApplyBulletDefault();
                
                    for (int i = 0; i < bulletItems.Length; i++)
                    {
                        string bulletItem = bulletItems[i];
                        if (i < bulletItems.Length - 1)
                            bulletItem = bulletItem + "\n";
                        assets.Range.InsertBefore(bulletItem);
                    }



                //Potential Next Steps Section

                //Potential Next Steps Title
                Paragraph nextsteps1 = document.Content.Paragraphs.Add(ref missing);
                nextsteps1.Range.Text = "POTENTIAL NEXT STEPS";
                nextsteps1.Range.set_Style(ref Header1);
                nextsteps1.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                nextsteps1.Range.Font.Size = 12;
                nextsteps1.Range.Font.Name = "Candara";
                nextsteps1.Range.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleThinThickSmallGap;
                nextsteps1.Range.InsertParagraphAfter();
                //nextsteps1.Range.InsertParagraphAfter();

                //Create list
                var nextStepsList = new List<string>();

                // Add items to the list. If radiobutton is false, add related message
                if (rb_f1.Checked == true)
                {
                    resultsList.Add("Not all functionality is available by using only the keyboard (Tab, Shift +Tab, Enter, etc.)");
                }
                if (rb_f2.Checked == true)
                {
                    resultsList.Add("Page structure: Most, if not all, pages examined lack a link that allows users to “skip navigation” or “skip to main content”.");
                }
                if (rb_f3.Checked == true)
                {
                    //resultsList.Add("");
                }
                if (rb_f4.Checked == true)
                {
                    //resultsList.Add("");
                }

                //Convert list to array
                var bulletItems_nextSteps = nextStepsList.ToArray();

                //Created bulleted list
                Paragraph nextSteps = document.Content.Paragraphs.Add();
                nextSteps.Range.ListFormat.ApplyBulletDefault();
          
                for (int i = 0; i < bulletItems_nextSteps.Length; i++)
                {
                    string bulletItem_nextSteps = bulletItems_nextSteps[i];
                    if (i < bulletItems_nextSteps.Length - 1)
                        bulletItem_nextSteps = bulletItem_nextSteps + "\n";
                    nextSteps.Range.InsertBefore(bulletItem_nextSteps);
                }


                
                //Testing Process Section

                //Testing Process Title
                Paragraph process1 = document.Content.Paragraphs.Add(ref missing);
                process1.Range.Text = "TESTING PROCESS";
                process1.Range.set_Style(ref Header1);
                process1.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                process1.Range.Font.Size = 12;
                process1.Range.Font.Name = "Candara";
                process1.Range.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleThinThickSmallGap;
                process1.Range.InsertParagraphAfter();

                //Process paragraph
                Paragraph process2 = document.Content.Paragraphs.Add(ref missing);
                process2.Range.Text = "The AMP automated tool (Accessibility Management Platform) was used as an initial evaluation of page accessibility to find potential errors and alerts related to WCAG 2.0 A/AA." 
                    +" Each page was then checked manually based on 37 criteria, summarized below, and status documented as Pass, Fail with explanation, or N/A (not applicable)." 
                    +" Pages were evaluated by at least two individuals from the Center for Instructional Technology Emerging Technology and Accessibility team." 
                    +" Checklists for each page, which include details regarding accessibility issues, are available. ";
                process2.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                process2.Range.Font.Size = 11;
                process2.Range.Font.Name = "Candara";
                process2.Range.InsertParagraphAfter();


                //Process List

                Paragraph p1 = document.Content.Paragraphs.Add();
                //Range range = document.Range(0, 0);
                //p1.Range.ListFormat.ApplyBulletDefault();
                p1.Range.Text = "Birinci";
                p1.Range.ListFormat.ApplyBulletDefault();
                p1.Range.InsertParagraphAfter();
                ListTemplate listTemplate = p1.Range.ListFormat.ListTemplate;

                Range subRange = document.Range(p1.Range.StoryLength - 1, p1.Range.StoryLength - 1);
                subRange.ListFormat.ApplyBulletDefault();
                subRange.ListFormat.ListIndent();
                subRange.Text = "Alt Birinci";
                subRange.InsertParagraphAfter();
                ListTemplate sublistTemplate = subRange.ListFormat.ListTemplate;

                /*
                Range subRange2 = document.Range(subRange.StoryLength - 1, p1.Range.StoryLength - 1);
                subRange2.ListFormat.ApplyListTemplate(sublistTemplate);
                subRange2.ListFormat.ListIndent();
                subRange2.Text = "Alt İkinci";
                subRange2.InsertParagraphAfter();
                */

               /* Range range2 = document.Range(p1.Range.StoryLength - 1);
                range2.ListFormat.ApplyListTemplateWithLevel(listTemplate, true);
                WdContinue isContinue = range2.ListFormat.CanContinuePreviousList(listTemplate);
                range2.Text = "İkinci";
                range2.InsertParagraphAfter();
                */



                //Save the document to My documents folder
                string docfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //Naming the document
                string mnth = DateTime.Now.Month.ToString();
                string yr = DateTime.Now.Year.ToString();
                object filename = docfolder + "\\" + ReportCreator.siteName + "_" + mnth + "_" + yr;
                    
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ApplyListTemplate(Microsoft.Office.Interop.Word.ListGallery listGallery, Microsoft.Office.Interop.Word.ListFormat listFormat, int level = 1)
        {
            listFormat.ApplyListTemplateWithLevel(
                listGallery.ListTemplates[level],
                ContinuePreviousList: true,
                ApplyTo: Microsoft.Office.Interop.Word.WdListApplyTo.wdListApplyToSelection,
                DefaultListBehavior: Microsoft.Office.Interop.Word.WdDefaultListBehavior.wdWord10ListBehavior,
                ApplyLevel: level);
        }

        //Validate to make sure all radio button groups have been selected
        private bool validateCB()
        {
            bool isAnyRadioButtonChecked = false;

            // foreach statement for every radio box group
            //C1.1
            foreach (RadioButton rdo in panel1.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            //C1.2
            foreach (RadioButton rdo in panel2.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            //C1.3
            foreach (RadioButton rdo in panel3.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            // Commented out for testing purposes
            /*
            //C1.4
            foreach (RadioButton rdo in panel4.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            //C1.5
            foreach (RadioButton rdo in panel5.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            //C2.1
            foreach (RadioButton rdo in panel9.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            //C2.2
            foreach (RadioButton rdo in panel8.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            //C2.3
            foreach (RadioButton rdo in panel7.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            //C2.4
            foreach (RadioButton rdo in panel6.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked = true;
                    break;
                }
                else
                {
                    isAnyRadioButtonChecked = false;
                }
            }
            */

            return isAnyRadioButtonChecked;
        }
    }
}
