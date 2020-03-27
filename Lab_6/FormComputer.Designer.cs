namespace Lab_5
{
    partial class FormComputer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboCompType = new System.Windows.Forms.ComboBox();
            this.labelComputerType = new System.Windows.Forms.Label();
            this.comboRAMType = new System.Windows.Forms.ComboBox();
            this.labelRamType = new System.Windows.Forms.Label();
            this.textMemorySize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDriveType = new System.Windows.Forms.ComboBox();
            this.textDriveSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonProcessor = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonVideoCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCompType
            // 
            this.comboCompType.FormattingEnabled = true;
            this.comboCompType.Items.AddRange(new object[] {
            "Server",
            "Work station",
            "Notebook"});
            this.comboCompType.Location = new System.Drawing.Point(48, 66);
            this.comboCompType.Name = "comboCompType";
            this.comboCompType.Size = new System.Drawing.Size(165, 24);
            this.comboCompType.TabIndex = 0;
            // 
            // labelComputerType
            // 
            this.labelComputerType.AutoSize = true;
            this.labelComputerType.Location = new System.Drawing.Point(45, 46);
            this.labelComputerType.Name = "labelComputerType";
            this.labelComputerType.Size = new System.Drawing.Size(105, 17);
            this.labelComputerType.TabIndex = 2;
            this.labelComputerType.Text = "Computer Type";
            // 
            // comboRAMType
            // 
            this.comboRAMType.FormattingEnabled = true;
            this.comboRAMType.Items.AddRange(new object[] {
            "DDR2",
            "DDR3",
            "DDR4"});
            this.comboRAMType.Location = new System.Drawing.Point(48, 141);
            this.comboRAMType.Name = "comboRAMType";
            this.comboRAMType.Size = new System.Drawing.Size(121, 24);
            this.comboRAMType.TabIndex = 1;
            // 
            // labelRamType
            // 
            this.labelRamType.AutoSize = true;
            this.labelRamType.Location = new System.Drawing.Point(45, 121);
            this.labelRamType.Name = "labelRamType";
            this.labelRamType.Size = new System.Drawing.Size(74, 17);
            this.labelRamType.TabIndex = 1;
            this.labelRamType.Text = "RAM Type";
            // 
            // textMemorySize
            // 
            this.textMemorySize.Location = new System.Drawing.Point(48, 219);
            this.textMemorySize.Name = "textMemorySize";
            this.textMemorySize.Size = new System.Drawing.Size(100, 22);
            this.textMemorySize.TabIndex = 2;
            this.textMemorySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textMemorySize.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Memory size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "GB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Drive Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Drive Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Purchase Date";
            // 
            // comboDriveType
            // 
            this.comboDriveType.FormattingEnabled = true;
            this.comboDriveType.Items.AddRange(new object[] {
            "HDD",
            "SSD"});
            this.comboDriveType.Location = new System.Drawing.Point(48, 292);
            this.comboDriveType.Name = "comboDriveType";
            this.comboDriveType.Size = new System.Drawing.Size(121, 24);
            this.comboDriveType.TabIndex = 3;
            // 
            // textDriveSize
            // 
            this.textDriveSize.Location = new System.Drawing.Point(48, 363);
            this.textDriveSize.Name = "textDriveSize";
            this.textDriveSize.Size = new System.Drawing.Size(100, 22);
            this.textDriveSize.TabIndex = 4;
            this.textDriveSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOnlyInt_KeyPress);
            this.textDriveSize.Validating += new System.ComponentModel.CancelEventHandler(this.textIntText_Validation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "GB";
            // 
            // datePurchaseDate
            // 
            this.datePurchaseDate.Location = new System.Drawing.Point(51, 431);
            this.datePurchaseDate.Name = "datePurchaseDate";
            this.datePurchaseDate.Size = new System.Drawing.Size(195, 22);
            this.datePurchaseDate.TabIndex = 5;
            // 
            // buttonProcessor
            // 
            this.buttonProcessor.Location = new System.Drawing.Point(51, 478);
            this.buttonProcessor.Name = "buttonProcessor";
            this.buttonProcessor.Size = new System.Drawing.Size(175, 35);
            this.buttonProcessor.TabIndex = 6;
            this.buttonProcessor.Text = "Create Processor";
            this.buttonProcessor.UseVisualStyleBackColor = true;
            this.buttonProcessor.Click += new System.EventHandler(this.buttonProcessor_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(140, 653);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(141, 46);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonVideoCard
            // 
            this.buttonVideoCard.Location = new System.Drawing.Point(51, 535);
            this.buttonVideoCard.Name = "buttonVideoCard";
            this.buttonVideoCard.Size = new System.Drawing.Size(175, 35);
            this.buttonVideoCard.TabIndex = 7;
            this.buttonVideoCard.Text = "Create Videocard";
            this.buttonVideoCard.UseVisualStyleBackColor = true;
            this.buttonVideoCard.Click += new System.EventHandler(this.buttonVideoCard_Click);
            // 
            // FormComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 722);
            this.Controls.Add(this.buttonVideoCard);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonProcessor);
            this.Controls.Add(this.datePurchaseDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDriveSize);
            this.Controls.Add(this.comboDriveType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMemorySize);
            this.Controls.Add(this.labelRamType);
            this.Controls.Add(this.comboRAMType);
            this.Controls.Add(this.labelComputerType);
            this.Controls.Add(this.comboCompType);
            this.Name = "FormComputer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCompType;
        private System.Windows.Forms.Label labelComputerType;
        private System.Windows.Forms.ComboBox comboRAMType;
        private System.Windows.Forms.Label labelRamType;
        private System.Windows.Forms.TextBox textMemorySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDriveType;
        private System.Windows.Forms.TextBox textDriveSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePurchaseDate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonProcessor;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonVideoCard;
    }
}

