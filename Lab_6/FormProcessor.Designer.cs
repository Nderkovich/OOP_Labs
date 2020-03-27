﻿namespace Lab_5
{
    partial class FormProcessor
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
            this.textManufacturer = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textSeries = new System.Windows.Forms.TextBox();
            this.textBaseFrequency = new System.Windows.Forms.TextBox();
            this.textNumberOfCores = new System.Windows.Forms.TextBox();
            this.textMaxFrequency = new System.Windows.Forms.TextBox();
            this.textCacheSize = new System.Windows.Forms.TextBox();
            this.comboUnstructionSet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textManufacturer
            // 
            this.textManufacturer.Location = new System.Drawing.Point(72, 47);
            this.textManufacturer.Name = "textManufacturer";
            this.textManufacturer.Size = new System.Drawing.Size(207, 22);
            this.textManufacturer.TabIndex = 0;
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(72, 154);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(100, 22);
            this.textModel.TabIndex = 2;
            // 
            // textSeries
            // 
            this.textSeries.Location = new System.Drawing.Point(72, 99);
            this.textSeries.Name = "textSeries";
            this.textSeries.Size = new System.Drawing.Size(207, 22);
            this.textSeries.TabIndex = 1;
            // 
            // textBaseFrequency
            // 
            this.textBaseFrequency.Location = new System.Drawing.Point(72, 297);
            this.textBaseFrequency.Name = "textBaseFrequency";
            this.textBaseFrequency.Size = new System.Drawing.Size(100, 22);
            this.textBaseFrequency.TabIndex = 4;
            this.textBaseFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textBaseFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // textNumberOfCores
            // 
            this.textNumberOfCores.Location = new System.Drawing.Point(72, 218);
            this.textNumberOfCores.Name = "textNumberOfCores";
            this.textNumberOfCores.Size = new System.Drawing.Size(100, 22);
            this.textNumberOfCores.TabIndex = 3;
            this.textNumberOfCores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textNumberOfCores.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // textMaxFrequency
            // 
            this.textMaxFrequency.Location = new System.Drawing.Point(72, 377);
            this.textMaxFrequency.Name = "textMaxFrequency";
            this.textMaxFrequency.Size = new System.Drawing.Size(100, 22);
            this.textMaxFrequency.TabIndex = 5;
            this.textMaxFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textMaxFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // textCacheSize
            // 
            this.textCacheSize.Location = new System.Drawing.Point(72, 514);
            this.textCacheSize.Name = "textCacheSize";
            this.textCacheSize.Size = new System.Drawing.Size(100, 22);
            this.textCacheSize.TabIndex = 7;
            this.textCacheSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textCacheSize.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // comboUnstructionSet
            // 
            this.comboUnstructionSet.FormattingEnabled = true;
            this.comboUnstructionSet.Items.AddRange(new object[] {
            "32 bit",
            "64 bit"});
            this.comboUnstructionSet.Location = new System.Drawing.Point(72, 441);
            this.comboUnstructionSet.Name = "comboUnstructionSet";
            this.comboUnstructionSet.Size = new System.Drawing.Size(121, 24);
            this.comboUnstructionSet.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number Of Cores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Base Frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max Frequency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Instruction Set";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cache size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "GHz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "GHz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "MB";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(72, 572);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 19;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 630);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboUnstructionSet);
            this.Controls.Add(this.textCacheSize);
            this.Controls.Add(this.textMaxFrequency);
            this.Controls.Add(this.textNumberOfCores);
            this.Controls.Add(this.textBaseFrequency);
            this.Controls.Add(this.textSeries);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textManufacturer);
            this.Name = "FormProcessor";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textManufacturer;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textSeries;
        private System.Windows.Forms.TextBox textBaseFrequency;
        private System.Windows.Forms.TextBox textNumberOfCores;
        private System.Windows.Forms.TextBox textMaxFrequency;
        private System.Windows.Forms.TextBox textCacheSize;
        private System.Windows.Forms.ComboBox comboUnstructionSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSubmit;
    }
}