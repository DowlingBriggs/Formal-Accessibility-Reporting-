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
            this.reportCreator_pagesTested = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportCreator_pagesTested)).BeginInit();
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
            this.reportCreator_testerNameText.TextChanged += new System.EventHandler(this.reportCreator_testerNameText_TextChanged);
            // 
            // reportCreator_date
            // 
            this.reportCreator_date.AutoSize = true;
            this.reportCreator_date.Location = new System.Drawing.Point(9, 173);
            this.reportCreator_date.Name = "reportCreator_date";
            this.reportCreator_date.Size = new System.Drawing.Size(28, 13);
            this.reportCreator_date.TabIndex = 4;
            this.reportCreator_date.Text = "date";
            this.reportCreator_date.Click += new System.EventHandler(this.label3_Click);
            // 
            // reportCreator_next
            // 
            this.reportCreator_next.Location = new System.Drawing.Point(12, 208);
            this.reportCreator_next.Name = "reportCreator_next";
            this.reportCreator_next.Size = new System.Drawing.Size(75, 23);
            this.reportCreator_next.TabIndex = 9;
            this.reportCreator_next.Text = "Next";
            this.reportCreator_next.UseVisualStyleBackColor = true;
            this.reportCreator_next.Click += new System.EventHandler(this.reportCreator_next_Click);
            // 
            // reportCreator_cancel
            // 
            this.reportCreator_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.reportCreator_cancel.Location = new System.Drawing.Point(134, 208);
            this.reportCreator_cancel.Name = "reportCreator_cancel";
            this.reportCreator_cancel.Size = new System.Drawing.Size(75, 23);
            this.reportCreator_cancel.TabIndex = 10;
            this.reportCreator_cancel.Text = "Cancel";
            this.reportCreator_cancel.UseVisualStyleBackColor = true;
            this.reportCreator_cancel.Click += new System.EventHandler(this.reportCreator_cancel_Click);
            // 
            // reportCreator_pagesTested
            // 
            this.reportCreator_pagesTested.Location = new System.Drawing.Point(12, 136);
            this.reportCreator_pagesTested.Name = "reportCreator_pagesTested";
            this.reportCreator_pagesTested.Size = new System.Drawing.Size(120, 20);
            this.reportCreator_pagesTested.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pages Tested";
            // 
            // ReportCreator
            // 
            this.AcceptButton = this.reportCreator_next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.reportCreator_cancel;
            this.ClientSize = new System.Drawing.Size(218, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportCreator_pagesTested);
            this.Controls.Add(this.reportCreator_cancel);
            this.Controls.Add(this.reportCreator_next);
            this.Controls.Add(this.reportCreator_date);
            this.Controls.Add(this.reportCreator_testerNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportCreator_siteNameText);
            this.Name = "ReportCreator";
            this.Text = "Report Creator";
            ((System.ComponentModel.ISupportInitialize)(this.reportCreator_pagesTested)).EndInit();
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
        private System.Windows.Forms.NumericUpDown reportCreator_pagesTested;
        private System.Windows.Forms.Label label3;
    }
}

