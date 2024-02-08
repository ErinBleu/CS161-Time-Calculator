namespace TimeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            secondsTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            minutesLabel = new Label();
            hoursLabel = new Label();
            daysLabel = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 76);
            label1.TabIndex = 0;
            label1.Text = "Enter amount of seconds here:";
            // 
            // secondsTextBox
            // 
            secondsTextBox.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secondsTextBox.Location = new Point(153, 47);
            secondsTextBox.Margin = new Padding(2, 2, 2, 2);
            secondsTextBox.Name = "secondsTextBox";
            secondsTextBox.Size = new Size(106, 26);
            secondsTextBox.TabIndex = 1;
            secondsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 2;
            label2.Text = "Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 3;
            label3.Text = "Hours";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 4;
            label4.Text = "Days";
            // 
            // minutesLabel
            // 
            minutesLabel.BorderStyle = BorderStyle.FixedSingle;
            minutesLabel.Location = new Point(167, 116);
            minutesLabel.Margin = new Padding(2, 0, 2, 0);
            minutesLabel.Name = "minutesLabel";
            minutesLabel.Size = new Size(62, 24);
            minutesLabel.TabIndex = 5;
            // 
            // hoursLabel
            // 
            hoursLabel.BorderStyle = BorderStyle.FixedSingle;
            hoursLabel.Location = new Point(167, 141);
            hoursLabel.Margin = new Padding(2, 0, 2, 0);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(62, 24);
            hoursLabel.TabIndex = 6;
            // 
            // daysLabel
            // 
            daysLabel.BorderStyle = BorderStyle.FixedSingle;
            daysLabel.Location = new Point(167, 166);
            daysLabel.Margin = new Padding(2, 0, 2, 0);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new Size(62, 24);
            daysLabel.TabIndex = 7;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(307, 32);
            calculateButton.Margin = new Padding(2, 2, 2, 2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(78, 20);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(307, 91);
            clearButton.Margin = new Padding(2, 2, 2, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(78, 20);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(307, 154);
            exitButton.Margin = new Padding(2, 2, 2, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(78, 20);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 209);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(daysLabel);
            Controls.Add(hoursLabel);
            Controls.Add(minutesLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(secondsTextBox);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Time Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox secondsTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label minutesLabel;
        private Label hoursLabel;
        private Label daysLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
