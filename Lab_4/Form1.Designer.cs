namespace Lab_4
{
    partial class Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMemPlus = new System.Windows.Forms.Button();
            this.buttonMemMinus = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 70);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(250, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 70);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(30, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 70);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(137, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 70);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(250, 188);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 70);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(30, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(362, 82);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(76, 70);
            this.buttonErase.TabIndex = 10;
            this.buttonErase.Text = "->";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(362, 289);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(76, 70);
            this.buttonDiv.TabIndex = 11;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(362, 392);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(76, 70);
            this.buttonMul.TabIndex = 12;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonClick);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(30, 494);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 70);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(137, 494);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(76, 70);
            this.buttonEqual.TabIndex = 14;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(250, 494);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(76, 70);
            this.buttonPlus.TabIndex = 15;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(362, 494);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(76, 70);
            this.buttonMinus.TabIndex = 16;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(30, 82);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(76, 70);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonMemPlus
            // 
            this.buttonMemPlus.Location = new System.Drawing.Point(137, 82);
            this.buttonMemPlus.Name = "buttonMemPlus";
            this.buttonMemPlus.Size = new System.Drawing.Size(76, 70);
            this.buttonMemPlus.TabIndex = 18;
            this.buttonMemPlus.Text = "M+";
            this.buttonMemPlus.UseVisualStyleBackColor = true;
            this.buttonMemPlus.Click += new System.EventHandler(this.buttonMemPlus_Click);
            // 
            // buttonMemMinus
            // 
            this.buttonMemMinus.Location = new System.Drawing.Point(250, 82);
            this.buttonMemMinus.Name = "buttonMemMinus";
            this.buttonMemMinus.Size = new System.Drawing.Size(76, 70);
            this.buttonMemMinus.TabIndex = 19;
            this.buttonMemMinus.Text = "M-";
            this.buttonMemMinus.UseVisualStyleBackColor = true;
            this.buttonMemMinus.Click += new System.EventHandler(this.buttonMemMinus_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(362, 188);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(76, 70);
            this.buttonMod.TabIndex = 20;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 595);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonMemMinus);
            this.Controls.Add(this.buttonMemPlus);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMemPlus;
        private System.Windows.Forms.Button buttonMemMinus;
        private System.Windows.Forms.Button buttonMod;
    }
}

