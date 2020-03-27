namespace Lab_5
{
    partial class FormVideoCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textManufacturer = new System.Windows.Forms.TextBox();
            this.textSeries = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textFrequency = new System.Windows.Forms.TextBox();
            this.textMemory = new System.Windows.Forms.TextBox();
            this.checkDirectX = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "DirectX Support";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Memory";
            // 
            // textManufacturer
            // 
            this.textManufacturer.Location = new System.Drawing.Point(64, 87);
            this.textManufacturer.Name = "textManufacturer";
            this.textManufacturer.Size = new System.Drawing.Size(231, 22);
            this.textManufacturer.TabIndex = 0;
            // 
            // textSeries
            // 
            this.textSeries.Location = new System.Drawing.Point(64, 167);
            this.textSeries.Name = "textSeries";
            this.textSeries.Size = new System.Drawing.Size(231, 22);
            this.textSeries.TabIndex = 1;
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(64, 235);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(231, 22);
            this.textModel.TabIndex = 2;
            // 
            // textFrequency
            // 
            this.textFrequency.Location = new System.Drawing.Point(64, 314);
            this.textFrequency.Name = "textFrequency";
            this.textFrequency.Size = new System.Drawing.Size(105, 22);
            this.textFrequency.TabIndex = 3;
            this.textFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // textMemory
            // 
            this.textMemory.Location = new System.Drawing.Point(64, 434);
            this.textMemory.Name = "textMemory";
            this.textMemory.Size = new System.Drawing.Size(105, 22);
            this.textMemory.TabIndex = 5;
            this.textMemory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textMemory.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // checkDirectX
            // 
            this.checkDirectX.AutoSize = true;
            this.checkDirectX.Location = new System.Drawing.Point(175, 374);
            this.checkDirectX.Name = "checkDirectX";
            this.checkDirectX.Size = new System.Drawing.Size(18, 17);
            this.checkDirectX.TabIndex = 4;
            this.checkDirectX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "GHz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gb";
            // 
            // FormVideoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 552);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkDirectX);
            this.Controls.Add(this.textMemory);
            this.Controls.Add(this.textFrequency);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textSeries);
            this.Controls.Add(this.textManufacturer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVideoCard";
            this.Text = "FormVideoCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textManufacturer;
        private System.Windows.Forms.TextBox textSeries;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textFrequency;
        private System.Windows.Forms.TextBox textMemory;
        private System.Windows.Forms.CheckBox checkDirectX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}