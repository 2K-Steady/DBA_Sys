namespace DBA_Sys
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TestButton_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveScreenShotButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TestDate = new System.Windows.Forms.TextBox();
            this.ProgramOnButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Erangel_CheckBox = new System.Windows.Forms.CheckBox();
            this.Test_Start_Button = new System.Windows.Forms.Button();
            this.TestButtonGroup = new System.Windows.Forms.GroupBox();
            this.WeatherButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VehicleTestButton = new System.Windows.Forms.Button();
            this.timerTestButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TestBuildDown_Button = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logView = new System.Windows.Forms.ListView();
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.substanceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestButtonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestButton_1
            // 
            this.TestButton_1.Location = new System.Drawing.Point(127, 16);
            this.TestButton_1.Name = "TestButton_1";
            this.TestButton_1.Size = new System.Drawing.Size(87, 23);
            this.TestButton_1.TabIndex = 0;
            this.TestButton_1.Text = "TestButton1";
            this.TestButton_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TestButton_1.UseVisualStyleBackColor = true;
            this.TestButton_1.Click += new System.EventHandler(this.TestButton_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Keyword";
            // 
            // SaveScreenShotButton
            // 
            this.SaveScreenShotButton.Location = new System.Drawing.Point(127, 45);
            this.SaveScreenShotButton.Name = "SaveScreenShotButton";
            this.SaveScreenShotButton.Size = new System.Drawing.Size(87, 23);
            this.SaveScreenShotButton.TabIndex = 2;
            this.SaveScreenShotButton.Text = "ScreenShot";
            this.SaveScreenShotButton.UseVisualStyleBackColor = true;
            this.SaveScreenShotButton.Click += new System.EventHandler(this.SaveScreenShotButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "테스트 빌드 넘버 입력:";
            // 
            // TestDate
            // 
            this.TestDate.Location = new System.Drawing.Point(380, 6);
            this.TestDate.Name = "TestDate";
            this.TestDate.Size = new System.Drawing.Size(100, 21);
            this.TestDate.TabIndex = 4;
            // 
            // ProgramOnButton
            // 
            this.ProgramOnButton.Location = new System.Drawing.Point(351, 37);
            this.ProgramOnButton.Name = "ProgramOnButton";
            this.ProgramOnButton.Size = new System.Drawing.Size(129, 23);
            this.ProgramOnButton.TabIndex = 5;
            this.ProgramOnButton.Text = "Support Program";
            this.ProgramOnButton.UseVisualStyleBackColor = true;
            this.ProgramOnButton.Click += new System.EventHandler(this.ProgramOnButton_Click);
            // 
            // Erangel_CheckBox
            // 
            this.Erangel_CheckBox.AutoSize = true;
            this.Erangel_CheckBox.Location = new System.Drawing.Point(307, 20);
            this.Erangel_CheckBox.Name = "Erangel_CheckBox";
            this.Erangel_CheckBox.Size = new System.Drawing.Size(67, 16);
            this.Erangel_CheckBox.TabIndex = 6;
            this.Erangel_CheckBox.Text = "Erangel";
            this.Erangel_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Test_Start_Button
            // 
            this.Test_Start_Button.Location = new System.Drawing.Point(380, 16);
            this.Test_Start_Button.Name = "Test_Start_Button";
            this.Test_Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Test_Start_Button.TabIndex = 7;
            this.Test_Start_Button.Text = "Test_Start";
            this.Test_Start_Button.UseVisualStyleBackColor = true;
            this.Test_Start_Button.Click += new System.EventHandler(this.Test_Start_Button_Click);
            // 
            // TestButtonGroup
            // 
            this.TestButtonGroup.Controls.Add(this.WeatherButton);
            this.TestButtonGroup.Controls.Add(this.label4);
            this.TestButtonGroup.Controls.Add(this.VehicleTestButton);
            this.TestButtonGroup.Controls.Add(this.timerTestButton);
            this.TestButtonGroup.Controls.Add(this.label3);
            this.TestButtonGroup.Controls.Add(this.TestButton_1);
            this.TestButtonGroup.Controls.Add(this.Test_Start_Button);
            this.TestButtonGroup.Controls.Add(this.Erangel_CheckBox);
            this.TestButtonGroup.Controls.Add(this.label1);
            this.TestButtonGroup.Controls.Add(this.SaveScreenShotButton);
            this.TestButtonGroup.Location = new System.Drawing.Point(12, 188);
            this.TestButtonGroup.Name = "TestButtonGroup";
            this.TestButtonGroup.Size = new System.Drawing.Size(461, 105);
            this.TestButtonGroup.TabIndex = 8;
            this.TestButtonGroup.TabStop = false;
            this.TestButtonGroup.Text = "TestButtonGroup";
            // 
            // WeatherButton
            // 
            this.WeatherButton.Location = new System.Drawing.Point(368, 75);
            this.WeatherButton.Name = "WeatherButton";
            this.WeatherButton.Size = new System.Drawing.Size(87, 23);
            this.WeatherButton.TabIndex = 11;
            this.WeatherButton.Text = "Weather Test";
            this.WeatherButton.UseVisualStyleBackColor = true;
            this.WeatherButton.Click += new System.EventHandler(this.WeatherButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vehicle Test";
            // 
            // VehicleTestButton
            // 
            this.VehicleTestButton.Location = new System.Drawing.Point(127, 75);
            this.VehicleTestButton.Name = "VehicleTestButton";
            this.VehicleTestButton.Size = new System.Drawing.Size(87, 23);
            this.VehicleTestButton.TabIndex = 9;
            this.VehicleTestButton.Text = "VehicleTest";
            this.VehicleTestButton.UseVisualStyleBackColor = true;
            this.VehicleTestButton.Click += new System.EventHandler(this.VehicleTestButton_Click);
            // 
            // timerTestButton
            // 
            this.timerTestButton.Location = new System.Drawing.Point(380, 45);
            this.timerTestButton.Name = "timerTestButton";
            this.timerTestButton.Size = new System.Drawing.Size(75, 23);
            this.timerTestButton.TabIndex = 8;
            this.timerTestButton.Text = "Timer Test";
            this.timerTestButton.UseVisualStyleBackColor = true;
            this.timerTestButton.Click += new System.EventHandler(this.timerTestButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Save ScreenShot";
            // 
            // TestBuildDown_Button
            // 
            this.TestBuildDown_Button.Location = new System.Drawing.Point(351, 66);
            this.TestBuildDown_Button.Name = "TestBuildDown_Button";
            this.TestBuildDown_Button.Size = new System.Drawing.Size(129, 22);
            this.TestBuildDown_Button.TabIndex = 9;
            this.TestBuildDown_Button.Text = "TestBuild Download";
            this.TestBuildDown_Button.UseVisualStyleBackColor = true;
            this.TestBuildDown_Button.Click += new System.EventHandler(this.TestBuildDown_Button_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DBA_Sys.Properties.Resources.kejang;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // logView
            // 
            this.logView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeHeader,
            this.substanceHeader});
            this.logView.GridLines = true;
            this.logView.Location = new System.Drawing.Point(13, 299);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(460, 251);
            this.logView.TabIndex = 13;
            this.logView.UseCompatibleStateImageBehavior = false;
            this.logView.View = System.Windows.Forms.View.Details;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time";
            this.timeHeader.Width = 125;
            // 
            // substanceHeader
            // 
            this.substanceHeader.Text = "Substance";
            this.substanceHeader.Width = 332;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(485, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 583);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.logView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TestBuildDown_Button);
            this.Controls.Add(this.ProgramOnButton);
            this.Controls.Add(this.TestDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestButtonGroup);
            this.Name = "MainForm";
            this.Text = "DBA System";
            this.TestButtonGroup.ResumeLayout(false);
            this.TestButtonGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveScreenShotButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TestDate;
        private System.Windows.Forms.Button ProgramOnButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox Erangel_CheckBox;
        private System.Windows.Forms.Button Test_Start_Button;
        private System.Windows.Forms.GroupBox TestButtonGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TestBuildDown_Button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button timerTestButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button VehicleTestButton;
        private System.Windows.Forms.Button WeatherButton;
        public System.Windows.Forms.ListView logView;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ColumnHeader substanceHeader;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

