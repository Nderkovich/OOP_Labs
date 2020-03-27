namespace Lab_5
{
    partial class FormSearch
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listSearchResult = new System.Windows.Forms.ListBox();
            this.buttonSortFreq = new System.Windows.Forms.Button();
            this.buttonSortRam = new System.Windows.Forms.Button();
            this.buttonToXml = new System.Windows.Forms.Button();
            this.comboSearchOption = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(28, 32);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(410, 22);
            this.textSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(28, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(251, 55);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listSearchResult
            // 
            this.listSearchResult.FormattingEnabled = true;
            this.listSearchResult.HorizontalScrollbar = true;
            this.listSearchResult.ItemHeight = 16;
            this.listSearchResult.Location = new System.Drawing.Point(12, 130);
            this.listSearchResult.Name = "listSearchResult";
            this.listSearchResult.Size = new System.Drawing.Size(443, 324);
            this.listSearchResult.TabIndex = 2;
            // 
            // buttonSortFreq
            // 
            this.buttonSortFreq.Location = new System.Drawing.Point(12, 460);
            this.buttonSortFreq.Name = "buttonSortFreq";
            this.buttonSortFreq.Size = new System.Drawing.Size(220, 44);
            this.buttonSortFreq.TabIndex = 3;
            this.buttonSortFreq.Text = "Sort Frequency";
            this.buttonSortFreq.UseVisualStyleBackColor = true;
            this.buttonSortFreq.Click += new System.EventHandler(this.buttonSortFreq_Click);
            // 
            // buttonSortRam
            // 
            this.buttonSortRam.Location = new System.Drawing.Point(235, 460);
            this.buttonSortRam.Name = "buttonSortRam";
            this.buttonSortRam.Size = new System.Drawing.Size(220, 44);
            this.buttonSortRam.TabIndex = 4;
            this.buttonSortRam.Text = "Sort RAM";
            this.buttonSortRam.UseVisualStyleBackColor = true;
            this.buttonSortRam.Click += new System.EventHandler(this.buttonSortRam_Click);
            // 
            // buttonToXml
            // 
            this.buttonToXml.Location = new System.Drawing.Point(129, 510);
            this.buttonToXml.Name = "buttonToXml";
            this.buttonToXml.Size = new System.Drawing.Size(220, 44);
            this.buttonToXml.TabIndex = 5;
            this.buttonToXml.Text = "To xml";
            this.buttonToXml.UseVisualStyleBackColor = true;
            this.buttonToXml.Click += new System.EventHandler(this.buttonToXml_Click);
            // 
            // comboSearchOption
            // 
            this.comboSearchOption.FormattingEnabled = true;
            this.comboSearchOption.Items.AddRange(new object[] {
            "MANUFACTURER",
            "MODEL"});
            this.comboSearchOption.Location = new System.Drawing.Point(285, 85);
            this.comboSearchOption.Name = "comboSearchOption";
            this.comboSearchOption.Size = new System.Drawing.Size(153, 24);
            this.comboSearchOption.TabIndex = 6;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 708);
            this.Controls.Add(this.comboSearchOption);
            this.Controls.Add(this.buttonToXml);
            this.Controls.Add(this.buttonSortRam);
            this.Controls.Add(this.buttonSortFreq);
            this.Controls.Add(this.listSearchResult);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearch);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listSearchResult;
        private System.Windows.Forms.Button buttonSortFreq;
        private System.Windows.Forms.Button buttonSortRam;
        private System.Windows.Forms.Button buttonToXml;
        private System.Windows.Forms.ComboBox comboSearchOption;
    }
}