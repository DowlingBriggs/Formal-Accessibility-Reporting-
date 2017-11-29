namespace ETA_Report_Creator
{
    partial class ReportCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportCreator_siteNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportCreator_testerNameText = new System.Windows.Forms.TextBox();
            this.reportCreator_date = new System.Windows.Forms.Label();
            this.reportCreator_next = new System.Windows.Forms.Button();
            this.reportCreator_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportCreator_siteNameText
            // 
            this.reportCreator_siteNameText.Location = new System.Drawing.Point(12, 29);
            this.reportCreator_siteNameText.Name = "reportCreator_siteNameText";
            this.reportCreator_siteNameText.Size = new System.Drawing.Size(197, 20);
            this.reportCreator_siteNameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tester Name";
            // 
            // reportCreator_testerNameText
            // 
            this.reportCreator_testerNameText.Location = new System.Drawing.Point(12, 83);
            this.reportCreator_testerNameText.Name = "reportCreator_testerNameText";
            this.reportCreator_testerNameText.Size = new System.Drawing.Size(197, 20);
            this.reportCreator_testerNameText.TabIndex = 3;
            // 
            // reportCreator_date
            // 
            this.reportCreator_date.AutoSize = true;
            this.reportCreator_date.Location = new System.Drawing.Point(9, 121);
            this.reportCreator_date.Name = "reportCreator_date";
            this.reportCreator_date.Size = new System.Drawing.Size(82, 13);
            this.reportCreator_date.TabIndex = 4;
            this.reportCreator_date.Text = "Date: aa/aa/aa";
            this.reportCreator_date.Click += new System.EventHandler(this.label3_Click);
            // 
            // reportCreator_next
            // 
            this.reportCreator_next.Location = new System.Drawing.Point(12, 149);
            this.reportCreator_next.Name = "reportCreator_next";
            this.reportCreator_next.Size = new System.Drawing.Size(75, 23);
            this.reportCreator_next.TabIndex = 7;
            this.reportCreator_next.Text = "Next";
            this.reportCreator_next.UseVisualStyleBackColor = true;
            // 
            // reportCreator_cancel
            // 
            this.reportCreator_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.reportCreator_cancel.Location = new System.Drawing.Point(134, 149);
            this.reportCreator_cancel.Name = "reportCreator_cancel";
            this.reportCreator_cancel.Size = new System.Drawing.Size(75, 23);
            this.reportCreator_cancel.TabIndex = 8;
            this.reportCreator_cancel.Text = "Cancel";
            this.reportCreator_cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 183);
            this.Controls.Add(this.reportCreator_cancel);
            this.Controls.Add(this.reportCreator_next);
            this.Controls.Add(this.reportCreator_date);
            this.Controls.Add(this.reportCreator_testerNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportCreator_siteNameText);
            this.Name = "Form1";
            this.Text = "Report Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reportCreator_siteNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reportCreator_testerNameText;
        private System.Windows.Forms.Label reportCreator_date;
        private System.Windows.Forms.Button reportCreator_next;
        private System.Windows.Forms.Button reportCreator_cancel;
    }
}

