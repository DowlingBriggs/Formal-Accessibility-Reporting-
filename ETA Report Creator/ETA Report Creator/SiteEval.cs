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

                /*
                //Add header into the document
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "Header text goes here";
                }

                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size =10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Footer text goes here";
                }

                //adding text to document
                document.Content.SetRange(0, 0);
                document.Content.Text = "This is test document "+ Environment.NewLine;
                */


                object Title = "Title";
                object Header1 = "Header 1";

                //Report title -- Site name
                Paragraph title1 = document.Content.Paragraphs.Add(ref missing);
                string siteNameCap = ReportCreator.siteName.ToUpper();
                title1.Range.Text = siteNameCap + " ";
                title1.Range.set_Style(ref Title);
                title1.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title1.Range.Font.Size = 22;
                title1.Range.Font.Name = "Candara (Headings)";
                title1.Range.Borders[WdBorderType.wdBorderTop].LineStyle = WdLineStyle.wdLineStyleDot;
                title1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;                
                title1.Range.InsertParagraphAfter();
                //Report title part 2
                Paragraph title2 = document.Content.Paragraphs.Add(ref missing);
                title2.Range.Text = "WEBSITE ACCESSIBILITY REPORT";
                title2.Range.set_Style(ref Title);
                title2.Range.Font.ColorIndex = WdColorIndex.wdBlack;
                title2.Range.Font.Size = 22;
                title2.Range.Font.Name = "Candara (Headings)";
                title2.Range.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleDot;
                title2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title2.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Para 2 text";
                para2.Range.InsertParagraphAfter();

                //Create a 5X5 table and insert some dummy record
                Table firstTable = document.Tables.Add(title1.Range, 5, 5, ref missing, ref missing);
                
                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row
                        if (cell.RowIndex == 1)
                        {
                            cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 10;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            
                        }
                        //Data row
                        else
                        {
                            cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                        }
                    }
                }

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
