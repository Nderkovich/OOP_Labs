namespace Lab_5
{
    partial class FormLabaratory
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.buttonToXml = new System.Windows.Forms.Button();
            this.buttonFromXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(776, 324);
            this.listBox1.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 418);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(243, 60);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(280, 418);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(243, 60);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(545, 418);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(243, 60);
            this.buttonPrice.TabIndex = 4;
            this.buttonPrice.Text = "Price";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonToXml
            // 
            this.buttonToXml.Location = new System.Drawing.Point(545, 360);
            this.buttonToXml.Name = "buttonToXml";
            this.buttonToXml.Size = new System.Drawing.Size(116, 30);
            this.buttonToXml.TabIndex = 5;
            this.buttonToXml.Text = "Save to XML";
            this.buttonToXml.UseVisualStyleBackColor = true;
            this.buttonToXml.Click += new System.EventHandler(this.buttonToXml_Click);
            // 
            // buttonFromXml
            // 
            this.buttonFromXml.Location = new System.Drawing.Point(667, 360);
            this.buttonFromXml.Name = "buttonFromXml";
            this.buttonFromXml.Size = new System.Drawing.Size(121, 30);
            this.buttonFromXml.TabIndex = 6;
            this.buttonFromXml.Text = "Get from XML";
            this.buttonFromXml.UseVisualStyleBackColor = true;
            this.buttonFromXml.Click += new System.EventHandler(this.buttonFromXml_Click);
            // 
            // FormLabaratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.buttonFromXml);
            this.Controls.Add(this.buttonToXml);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listBox1);
            this.Name = "FormLabaratory";
            this.Text = "FormLabaratory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.Button buttonToXml;
        private System.Windows.Forms.Button buttonFromXml;
    }
}