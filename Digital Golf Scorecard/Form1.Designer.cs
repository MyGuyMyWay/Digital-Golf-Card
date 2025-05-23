namespace Digital_Golf_Scorecard
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
            appTitle = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            roundList = new DataGridView();
            courseNameText = new TextBox();
            courseNameLabel = new Label();
            dateLabel = new Label();
            dateText = new TextBox();
            hole1Label = new Label();
            hole1Text = new TextBox();
            hole2Label = new Label();
            hole2Text = new TextBox();
            hole3Label = new Label();
            hole3Text = new TextBox();
            hole4Label = new Label();
            hole4Text = new TextBox();
            hole5Label = new Label();
            hole5Text = new TextBox();
            hole6Label = new Label();
            hole6Text = new TextBox();
            hole7Label = new Label();
            hole7Text = new TextBox();
            hole8Label = new Label();
            hole8Text = new TextBox();
            hole9Label = new Label();
            hole9Text = new TextBox();
            hole10Label = new Label();
            hole10Text = new TextBox();
            hole11Label = new Label();
            hole11Text = new TextBox();
            hole12Label = new Label();
            hole12Text = new TextBox();
            hole13Label = new Label();
            hole13Text = new TextBox();
            hole14Label = new Label();
            hole14Text = new TextBox();
            hole15Label = new Label();
            hole15Text = new TextBox();
            hole16Label = new Label();
            hole16Text = new TextBox();
            hole17Label = new Label();
            hole17Text = new TextBox();
            hole18Label = new Label();
            hole18Text = new TextBox();
            ((System.ComponentModel.ISupportInitialize)roundList).BeginInit();
            SuspendLayout();
            // 
            // appTitle
            // 
            appTitle.Font = new Font("Lato", 25.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appTitle.ForeColor = Color.White;
            appTitle.Location = new Point(597, 19);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(632, 70);
            appTitle.TabIndex = 0;
            appTitle.Text = "Digital Golf Score Card";
            appTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // newButton
            // 
            newButton.Font = new Font("Lato", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newButton.Location = new Point(465, 92);
            newButton.Name = "newButton";
            newButton.Size = new Size(203, 61);
            newButton.TabIndex = 1;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Lato", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.Location = new Point(691, 92);
            editButton.Name = "editButton";
            editButton.Size = new Size(203, 61);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(149, 6, 6);
            deleteButton.Font = new Font("Lato", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.FromArgb(255, 255, 255);
            deleteButton.Location = new Point(911, 92);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(203, 61);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(0, 100, 0);
            saveButton.Font = new Font("Lato", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.FromArgb(255, 255, 255);
            saveButton.Location = new Point(1134, 92);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(203, 61);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // roundList
            // 
            roundList.BackgroundColor = Color.FromArgb(59, 59, 59);
            roundList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roundList.Location = new Point(12, 171);
            roundList.Name = "roundList";
            roundList.RowHeadersWidth = 62;
            roundList.Size = new Size(1000, 667);
            roundList.TabIndex = 5;
            // 
            // courseNameText
            // 
            courseNameText.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseNameText.Location = new Point(1062, 308);
            courseNameText.Name = "courseNameText";
            courseNameText.Size = new Size(528, 46);
            courseNameText.TabIndex = 7;
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseNameLabel.ForeColor = Color.White;
            courseNameLabel.Location = new Point(1053, 261);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(143, 44);
            courseNameLabel.TabIndex = 8;
            courseNameLabel.Text = "Course:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = Color.White;
            dateLabel.Location = new Point(1613, 261);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(108, 44);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // dateText
            // 
            dateText.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateText.Location = new Point(1622, 308);
            dateText.Name = "dateText";
            dateText.Size = new Size(214, 46);
            dateText.TabIndex = 10;
            // 
            // hole1Label
            // 
            hole1Label.AutoSize = true;
            hole1Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole1Label.ForeColor = Color.White;
            hole1Label.Location = new Point(1082, 396);
            hole1Label.Name = "hole1Label";
            hole1Label.Size = new Size(40, 44);
            hole1Label.TabIndex = 11;
            hole1Label.Text = "1";
            // 
            // hole1Text
            // 
            hole1Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole1Text.Location = new Point(1082, 443);
            hole1Text.Name = "hole1Text";
            hole1Text.Size = new Size(51, 46);
            hole1Text.TabIndex = 6;
            // 
            // hole2Label
            // 
            hole2Label.AutoSize = true;
            hole2Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole2Label.ForeColor = Color.White;
            hole2Label.Location = new Point(1159, 396);
            hole2Label.Name = "hole2Label";
            hole2Label.Size = new Size(40, 44);
            hole2Label.TabIndex = 13;
            hole2Label.Text = "2";
            // 
            // hole2Text
            // 
            hole2Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole2Text.Location = new Point(1159, 443);
            hole2Text.Name = "hole2Text";
            hole2Text.Size = new Size(51, 46);
            hole2Text.TabIndex = 12;
            // 
            // hole3Label
            // 
            hole3Label.AutoSize = true;
            hole3Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole3Label.ForeColor = Color.White;
            hole3Label.Location = new Point(1236, 396);
            hole3Label.Name = "hole3Label";
            hole3Label.Size = new Size(40, 44);
            hole3Label.TabIndex = 15;
            hole3Label.Text = "3";
            // 
            // hole3Text
            // 
            hole3Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole3Text.Location = new Point(1236, 443);
            hole3Text.Name = "hole3Text";
            hole3Text.Size = new Size(51, 46);
            hole3Text.TabIndex = 14;
            // 
            // hole4Label
            // 
            hole4Label.AutoSize = true;
            hole4Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole4Label.ForeColor = Color.White;
            hole4Label.Location = new Point(1316, 396);
            hole4Label.Name = "hole4Label";
            hole4Label.Size = new Size(40, 44);
            hole4Label.TabIndex = 17;
            hole4Label.Text = "4";
            // 
            // hole4Text
            // 
            hole4Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole4Text.Location = new Point(1316, 443);
            hole4Text.Name = "hole4Text";
            hole4Text.Size = new Size(51, 46);
            hole4Text.TabIndex = 16;
            // 
            // hole5Label
            // 
            hole5Label.AutoSize = true;
            hole5Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole5Label.ForeColor = Color.White;
            hole5Label.Location = new Point(1402, 396);
            hole5Label.Name = "hole5Label";
            hole5Label.Size = new Size(40, 44);
            hole5Label.TabIndex = 19;
            hole5Label.Text = "5";
            // 
            // hole5Text
            // 
            hole5Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole5Text.Location = new Point(1402, 443);
            hole5Text.Name = "hole5Text";
            hole5Text.Size = new Size(51, 46);
            hole5Text.TabIndex = 18;
            // 
            // hole6Label
            // 
            hole6Label.AutoSize = true;
            hole6Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole6Label.ForeColor = Color.White;
            hole6Label.Location = new Point(1484, 396);
            hole6Label.Name = "hole6Label";
            hole6Label.Size = new Size(40, 44);
            hole6Label.TabIndex = 21;
            hole6Label.Text = "6";
            // 
            // hole6Text
            // 
            hole6Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole6Text.Location = new Point(1484, 443);
            hole6Text.Name = "hole6Text";
            hole6Text.Size = new Size(51, 46);
            hole6Text.TabIndex = 20;
            // 
            // hole7Label
            // 
            hole7Label.AutoSize = true;
            hole7Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole7Label.ForeColor = Color.White;
            hole7Label.Location = new Point(1561, 396);
            hole7Label.Name = "hole7Label";
            hole7Label.Size = new Size(40, 44);
            hole7Label.TabIndex = 23;
            hole7Label.Text = "7";
            // 
            // hole7Text
            // 
            hole7Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole7Text.Location = new Point(1561, 443);
            hole7Text.Name = "hole7Text";
            hole7Text.Size = new Size(51, 46);
            hole7Text.TabIndex = 22;
            // 
            // hole8Label
            // 
            hole8Label.AutoSize = true;
            hole8Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole8Label.ForeColor = Color.White;
            hole8Label.Location = new Point(1632, 396);
            hole8Label.Name = "hole8Label";
            hole8Label.Size = new Size(40, 44);
            hole8Label.TabIndex = 25;
            hole8Label.Text = "8";
            // 
            // hole8Text
            // 
            hole8Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole8Text.Location = new Point(1632, 443);
            hole8Text.Name = "hole8Text";
            hole8Text.Size = new Size(51, 46);
            hole8Text.TabIndex = 24;
            // 
            // hole9Label
            // 
            hole9Label.AutoSize = true;
            hole9Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole9Label.ForeColor = Color.White;
            hole9Label.Location = new Point(1705, 396);
            hole9Label.Name = "hole9Label";
            hole9Label.Size = new Size(40, 44);
            hole9Label.TabIndex = 27;
            hole9Label.Text = "9";
            // 
            // hole9Text
            // 
            hole9Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole9Text.Location = new Point(1705, 443);
            hole9Text.Name = "hole9Text";
            hole9Text.Size = new Size(51, 46);
            hole9Text.TabIndex = 26;
            // 
            // hole10Label
            // 
            hole10Label.AutoSize = true;
            hole10Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole10Label.ForeColor = Color.White;
            hole10Label.Location = new Point(1072, 567);
            hole10Label.Name = "hole10Label";
            hole10Label.Size = new Size(61, 44);
            hole10Label.TabIndex = 29;
            hole10Label.Text = "10";
            // 
            // hole10Text
            // 
            hole10Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole10Text.Location = new Point(1082, 614);
            hole10Text.Name = "hole10Text";
            hole10Text.Size = new Size(51, 46);
            hole10Text.TabIndex = 28;
            // 
            // hole11Label
            // 
            hole11Label.AutoSize = true;
            hole11Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole11Label.ForeColor = Color.White;
            hole11Label.Location = new Point(1149, 567);
            hole11Label.Name = "hole11Label";
            hole11Label.Size = new Size(61, 44);
            hole11Label.TabIndex = 31;
            hole11Label.Text = "11";
            // 
            // hole11Text
            // 
            hole11Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole11Text.Location = new Point(1159, 614);
            hole11Text.Name = "hole11Text";
            hole11Text.Size = new Size(51, 46);
            hole11Text.TabIndex = 30;
            // 
            // hole12Label
            // 
            hole12Label.AutoSize = true;
            hole12Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole12Label.ForeColor = Color.White;
            hole12Label.Location = new Point(1226, 567);
            hole12Label.Name = "hole12Label";
            hole12Label.Size = new Size(61, 44);
            hole12Label.TabIndex = 33;
            hole12Label.Text = "12";
            // 
            // hole12Text
            // 
            hole12Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole12Text.Location = new Point(1236, 614);
            hole12Text.Name = "hole12Text";
            hole12Text.Size = new Size(51, 46);
            hole12Text.TabIndex = 32;
            // 
            // hole13Label
            // 
            hole13Label.AutoSize = true;
            hole13Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole13Label.ForeColor = Color.White;
            hole13Label.Location = new Point(1306, 567);
            hole13Label.Name = "hole13Label";
            hole13Label.Size = new Size(61, 44);
            hole13Label.TabIndex = 35;
            hole13Label.Text = "13";
            // 
            // hole13Text
            // 
            hole13Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole13Text.Location = new Point(1316, 614);
            hole13Text.Name = "hole13Text";
            hole13Text.Size = new Size(51, 46);
            hole13Text.TabIndex = 34;
            // 
            // hole14Label
            // 
            hole14Label.AutoSize = true;
            hole14Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole14Label.ForeColor = Color.White;
            hole14Label.Location = new Point(1382, 567);
            hole14Label.Name = "hole14Label";
            hole14Label.Size = new Size(61, 44);
            hole14Label.TabIndex = 37;
            hole14Label.Text = "14";
            // 
            // hole14Text
            // 
            hole14Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole14Text.Location = new Point(1392, 614);
            hole14Text.Name = "hole14Text";
            hole14Text.Size = new Size(51, 46);
            hole14Text.TabIndex = 36;
            // 
            // hole15Label
            // 
            hole15Label.AutoSize = true;
            hole15Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole15Label.ForeColor = Color.White;
            hole15Label.Location = new Point(1458, 567);
            hole15Label.Name = "hole15Label";
            hole15Label.Size = new Size(61, 44);
            hole15Label.TabIndex = 39;
            hole15Label.Text = "15";
            // 
            // hole15Text
            // 
            hole15Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole15Text.Location = new Point(1468, 614);
            hole15Text.Name = "hole15Text";
            hole15Text.Size = new Size(51, 46);
            hole15Text.TabIndex = 38;
            // 
            // hole16Label
            // 
            hole16Label.AutoSize = true;
            hole16Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole16Label.ForeColor = Color.White;
            hole16Label.Location = new Point(1540, 567);
            hole16Label.Name = "hole16Label";
            hole16Label.Size = new Size(61, 44);
            hole16Label.TabIndex = 41;
            hole16Label.Text = "16";
            // 
            // hole16Text
            // 
            hole16Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole16Text.Location = new Point(1550, 614);
            hole16Text.Name = "hole16Text";
            hole16Text.Size = new Size(51, 46);
            hole16Text.TabIndex = 40;
            // 
            // hole17Label
            // 
            hole17Label.AutoSize = true;
            hole17Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole17Label.ForeColor = Color.White;
            hole17Label.Location = new Point(1622, 567);
            hole17Label.Name = "hole17Label";
            hole17Label.Size = new Size(61, 44);
            hole17Label.TabIndex = 43;
            hole17Label.Text = "17";
            // 
            // hole17Text
            // 
            hole17Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole17Text.Location = new Point(1632, 614);
            hole17Text.Name = "hole17Text";
            hole17Text.Size = new Size(51, 46);
            hole17Text.TabIndex = 42;
            // 
            // hole18Label
            // 
            hole18Label.AutoSize = true;
            hole18Label.Font = new Font("Lato", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hole18Label.ForeColor = Color.White;
            hole18Label.Location = new Point(1705, 567);
            hole18Label.Name = "hole18Label";
            hole18Label.Size = new Size(61, 44);
            hole18Label.TabIndex = 45;
            hole18Label.Text = "18";
            // 
            // hole18Text
            // 
            hole18Text.Font = new Font("Lato", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hole18Text.Location = new Point(1715, 614);
            hole18Text.Name = "hole18Text";
            hole18Text.Size = new Size(51, 46);
            hole18Text.TabIndex = 44;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1882, 845);
            Controls.Add(hole18Label);
            Controls.Add(hole18Text);
            Controls.Add(hole17Label);
            Controls.Add(hole17Text);
            Controls.Add(hole16Label);
            Controls.Add(hole16Text);
            Controls.Add(hole15Label);
            Controls.Add(hole15Text);
            Controls.Add(hole14Label);
            Controls.Add(hole14Text);
            Controls.Add(hole13Label);
            Controls.Add(hole13Text);
            Controls.Add(hole12Label);
            Controls.Add(hole12Text);
            Controls.Add(hole11Label);
            Controls.Add(hole11Text);
            Controls.Add(hole10Label);
            Controls.Add(hole10Text);
            Controls.Add(hole9Label);
            Controls.Add(hole9Text);
            Controls.Add(hole8Label);
            Controls.Add(hole8Text);
            Controls.Add(hole7Label);
            Controls.Add(hole7Text);
            Controls.Add(hole6Label);
            Controls.Add(hole6Text);
            Controls.Add(hole5Label);
            Controls.Add(hole5Text);
            Controls.Add(hole4Label);
            Controls.Add(hole4Text);
            Controls.Add(hole3Label);
            Controls.Add(hole3Text);
            Controls.Add(hole2Label);
            Controls.Add(hole2Text);
            Controls.Add(hole1Label);
            Controls.Add(dateText);
            Controls.Add(dateLabel);
            Controls.Add(courseNameLabel);
            Controls.Add(courseNameText);
            Controls.Add(hole1Text);
            Controls.Add(roundList);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(appTitle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)roundList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appTitle;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView roundList;
        private TextBox hole1Text;
        private TextBox courseNameText;
        private Label courseNameLabel;
        private Label dateLabel;
        private TextBox dateText;
        private Label hole1Label;
        private Label hole2Label;
        private TextBox hole2Text;
        private Label hole3Label;
        private TextBox hole3Text;
        private Label hole4Label;
        private TextBox hole4Text;
        private Label hole5Label;
        private TextBox hole5Text;
        private Label hole6Label;
        private TextBox hole6Text;
        private Label hole7Label;
        private TextBox hole7Text;
        private Label hole8Label;
        private TextBox hole8Text;
        private Label hole9Label;
        private TextBox hole9Text;
        private Label hole10Label;
        private TextBox hole10Text;
        private Label hole11Label;
        private TextBox hole11Text;
        private Label hole12Label;
        private TextBox hole12Text;
        private Label hole13Label;
        private TextBox hole13Text;
        private Label hole14Label;
        private TextBox hole14Text;
        private Label hole15Label;
        private TextBox hole15Text;
        private Label hole16Label;
        private TextBox hole16Text;
        private Label hole17Label;
        private TextBox hole17Text;
        private Label hole18Label;
        private TextBox hole18Text;
    }
}
