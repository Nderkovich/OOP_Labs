namespace Lab_4_2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSortAsc = new System.Windows.Forms.Button();
            this.buttonSortDesc = new System.Windows.Forms.Button();
            this.buttonQuery1 = new System.Windows.Forms.Button();
            this.buttonQuery2 = new System.Windows.Forms.Button();
            this.buttonQuery3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Размер коллекции";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(365, 154);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(308, 81);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Создать коллекцию";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSortAsc
            // 
            this.buttonSortAsc.Location = new System.Drawing.Point(83, 154);
            this.buttonSortAsc.Name = "buttonSortAsc";
            this.buttonSortAsc.Size = new System.Drawing.Size(163, 81);
            this.buttonSortAsc.TabIndex = 5;
            this.buttonSortAsc.Text = "Сортировать по возрастаниею";
            this.buttonSortAsc.UseVisualStyleBackColor = true;
            this.buttonSortAsc.Click += new System.EventHandler(this.buttonSortAsc_Click);
            // 
            // buttonSortDesc
            // 
            this.buttonSortDesc.Location = new System.Drawing.Point(813, 154);
            this.buttonSortDesc.Name = "buttonSortDesc";
            this.buttonSortDesc.Size = new System.Drawing.Size(163, 81);
            this.buttonSortDesc.TabIndex = 6;
            this.buttonSortDesc.Text = "Сортировать по убыванию";
            this.buttonSortDesc.UseVisualStyleBackColor = true;
            this.buttonSortDesc.Click += new System.EventHandler(this.buttonSortDesc_Click);
            // 
            // buttonQuery1
            // 
            this.buttonQuery1.Location = new System.Drawing.Point(158, 267);
            this.buttonQuery1.Name = "buttonQuery1";
            this.buttonQuery1.Size = new System.Drawing.Size(163, 69);
            this.buttonQuery1.TabIndex = 7;
            this.buttonQuery1.Text = "Запрос №1";
            this.buttonQuery1.UseVisualStyleBackColor = true;
            this.buttonQuery1.Click += new System.EventHandler(this.buttonQuery1_Click);
            // 
            // buttonQuery2
            // 
            this.buttonQuery2.Location = new System.Drawing.Point(445, 267);
            this.buttonQuery2.Name = "buttonQuery2";
            this.buttonQuery2.Size = new System.Drawing.Size(163, 69);
            this.buttonQuery2.TabIndex = 8;
            this.buttonQuery2.Text = "Запрос №2";
            this.buttonQuery2.UseVisualStyleBackColor = true;
            this.buttonQuery2.Click += new System.EventHandler(this.buttonQuery2_Click);
            // 
            // buttonQuery3
            // 
            this.buttonQuery3.Location = new System.Drawing.Point(701, 267);
            this.buttonQuery3.Name = "buttonQuery3";
            this.buttonQuery3.Size = new System.Drawing.Size(163, 69);
            this.buttonQuery3.TabIndex = 9;
            this.buttonQuery3.Text = "Запрос №3";
            this.buttonQuery3.UseVisualStyleBackColor = true;
            this.buttonQuery3.Click += new System.EventHandler(this.buttonQuery3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 373);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(413, 227);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 373);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(413, 227);
            this.textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 612);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonQuery3);
            this.Controls.Add(this.buttonQuery2);
            this.Controls.Add(this.buttonQuery1);
            this.Controls.Add(this.buttonSortDesc);
            this.Controls.Add(this.buttonSortAsc);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSortAsc;
        private System.Windows.Forms.Button buttonSortDesc;
        private System.Windows.Forms.Button buttonQuery1;
        private System.Windows.Forms.Button buttonQuery2;
        private System.Windows.Forms.Button buttonQuery3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

