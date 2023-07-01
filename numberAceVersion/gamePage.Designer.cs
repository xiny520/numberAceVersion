namespace numberAceVersion
{
    partial class gamePage
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
            this.components = new System.ComponentModel.Container();
            this.lblMini = new System.Windows.Forms.Label();
            this.timerscreen = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.scorePoints = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gameQuestionBack = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsPanel1 = new System.Windows.Forms.Panel();
            this.optionButton1 = new System.Windows.Forms.Button();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.totalScore = new System.Windows.Forms.Label();
            this.optionsPanel2 = new System.Windows.Forms.Panel();
            this.optionButton3 = new System.Windows.Forms.Button();
            this.optionButton4 = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.miniTimer = new System.Windows.Forms.Timer(this.components);
            this.beginButton = new System.Windows.Forms.Button();
            this.countdownPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameLbl = new System.Windows.Forms.Label();
            this.rankingLbl = new System.Windows.Forms.Label();
            this.gameQuestionBack.SuspendLayout();
            this.optionsPanel1.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.optionsPanel2.SuspendLayout();
            this.countdownPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMini
            // 
            this.lblMini.AutoSize = true;
            this.lblMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblMini.Location = new System.Drawing.Point(95, 46);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(630, 211);
            this.lblMini.TabIndex = 25;
            this.lblMini.Text = "Ready";
            this.lblMini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerscreen
            // 
            this.timerscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerscreen.Location = new System.Drawing.Point(502, 12);
            this.timerscreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerscreen.Name = "timerscreen";
            this.timerscreen.Size = new System.Drawing.Size(348, 116);
            this.timerscreen.TabIndex = 22;
            this.timerscreen.Text = "START!";
            this.timerscreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerscreen.Visible = false;
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AllowDrop = true;
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(557, 142);
            this.highScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(235, 51);
            this.highScoreLabel.TabIndex = 24;
            this.highScoreLabel.Text = "High Score";
            // 
            // scorePoints
            // 
            this.scorePoints.AutoSize = true;
            this.scorePoints.Location = new System.Drawing.Point(529, 179);
            this.scorePoints.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scorePoints.Name = "scorePoints";
            this.scorePoints.Size = new System.Drawing.Size(0, 25);
            this.scorePoints.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::numberAceVersion.Properties.Resources.back_24838_640__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 272);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameQuestionBack
            // 
            this.gameQuestionBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gameQuestionBack.Controls.Add(this.optionsPanel2);
            this.gameQuestionBack.Controls.Add(this.optionsPanel1);
            this.gameQuestionBack.Controls.Add(this.label1);
            this.gameQuestionBack.Controls.Add(this.questionPanel);
            this.gameQuestionBack.Controls.Add(this.totalScore);
            this.gameQuestionBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.gameQuestionBack.Location = new System.Drawing.Point(935, 0);
            this.gameQuestionBack.Margin = new System.Windows.Forms.Padding(6);
            this.gameQuestionBack.Name = "gameQuestionBack";
            this.gameQuestionBack.Size = new System.Drawing.Size(1018, 1152);
            this.gameQuestionBack.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(92, 1350);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 83);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Score = ";
            // 
            // optionsPanel1
            // 
            this.optionsPanel1.Controls.Add(this.optionButton1);
            this.optionsPanel1.Controls.Add(this.optionButton2);
            this.optionsPanel1.Location = new System.Drawing.Point(139, 381);
            this.optionsPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.optionsPanel1.Name = "optionsPanel1";
            this.optionsPanel1.Size = new System.Drawing.Size(781, 209);
            this.optionsPanel1.TabIndex = 8;
            // 
            // optionButton1
            // 
            this.optionButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton1.Location = new System.Drawing.Point(0, 0);
            this.optionButton1.Margin = new System.Windows.Forms.Padding(4);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(350, 209);
            this.optionButton1.TabIndex = 3;
            this.optionButton1.Text = "Option1";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // optionButton2
            // 
            this.optionButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.optionButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton2.Location = new System.Drawing.Point(431, 0);
            this.optionButton2.Margin = new System.Windows.Forms.Padding(4);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(350, 209);
            this.optionButton2.TabIndex = 4;
            this.optionButton2.Text = "Option 2";
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click);
            // 
            // questionPanel
            // 
            this.questionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.questionPanel.Controls.Add(this.questionLabel);
            this.questionPanel.Location = new System.Drawing.Point(87, 90);
            this.questionPanel.Margin = new System.Windows.Forms.Padding(6);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(857, 217);
            this.questionPanel.TabIndex = 7;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(252, 56);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(400, 102);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalScore
            // 
            this.totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalScore.Location = new System.Drawing.Point(528, 1350);
            this.totalScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(204, 83);
            this.totalScore.TabIndex = 8;
            this.totalScore.Text = "0";
            // 
            // optionsPanel2
            // 
            this.optionsPanel2.Controls.Add(this.optionButton3);
            this.optionsPanel2.Controls.Add(this.optionButton4);
            this.optionsPanel2.Location = new System.Drawing.Point(139, 671);
            this.optionsPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.optionsPanel2.Name = "optionsPanel2";
            this.optionsPanel2.Size = new System.Drawing.Size(781, 209);
            this.optionsPanel2.TabIndex = 9;
            // 
            // optionButton3
            // 
            this.optionButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton3.Location = new System.Drawing.Point(0, 0);
            this.optionButton3.Margin = new System.Windows.Forms.Padding(4);
            this.optionButton3.Name = "optionButton3";
            this.optionButton3.Size = new System.Drawing.Size(350, 209);
            this.optionButton3.TabIndex = 3;
            this.optionButton3.Text = "Option3";
            this.optionButton3.UseVisualStyleBackColor = true;
            this.optionButton3.Click += new System.EventHandler(this.optionButton3_Click);
            // 
            // optionButton4
            // 
            this.optionButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.optionButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton4.Location = new System.Drawing.Point(431, 0);
            this.optionButton4.Margin = new System.Windows.Forms.Padding(4);
            this.optionButton4.Name = "optionButton4";
            this.optionButton4.Size = new System.Drawing.Size(350, 209);
            this.optionButton4.TabIndex = 4;
            this.optionButton4.Text = "Option 4";
            this.optionButton4.UseVisualStyleBackColor = true;
            this.optionButton4.Click += new System.EventHandler(this.optionButton4_Click);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // miniTimer
            // 
            this.miniTimer.Interval = 1000;
            this.miniTimer.Tick += new System.EventHandler(this.miniTimer_Tick);
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(44, 944);
            this.beginButton.Margin = new System.Windows.Forms.Padding(4);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(178, 137);
            this.beginButton.TabIndex = 35;
            this.beginButton.Text = "BEGIN";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // countdownPanel
            // 
            this.countdownPanel.Controls.Add(this.lblMini);
            this.countdownPanel.Location = new System.Drawing.Point(61, 337);
            this.countdownPanel.Name = "countdownPanel";
            this.countdownPanel.Size = new System.Drawing.Size(806, 306);
            this.countdownPanel.TabIndex = 36;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.rankingLbl);
            this.gamePanel.Controls.Add(this.gameLbl);
            this.gamePanel.Location = new System.Drawing.Point(328, 671);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(578, 311);
            this.gamePanel.TabIndex = 37;
            // 
            // gameLbl
            // 
            this.gameLbl.AutoSize = true;
            this.gameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLbl.Location = new System.Drawing.Point(67, 75);
            this.gameLbl.Name = "gameLbl";
            this.gameLbl.Size = new System.Drawing.Size(472, 91);
            this.gameLbl.TabIndex = 0;
            this.gameLbl.Text = "Game Over!";
            // 
            // rankingLbl
            // 
            this.rankingLbl.AutoSize = true;
            this.rankingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingLbl.Location = new System.Drawing.Point(227, 185);
            this.rankingLbl.Name = "rankingLbl";
            this.rankingLbl.Size = new System.Drawing.Size(173, 63);
            this.rankingLbl.TabIndex = 1;
            this.rankingLbl.Text = "label2";
            // 
            // gamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1953, 1152);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.countdownPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timerscreen);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.scorePoints);
            this.Controls.Add(this.gameQuestionBack);
            this.Name = "gamePage";
            this.Text = "gamePage";
            this.Load += new System.EventHandler(this.gamePage_Load);
            this.gameQuestionBack.ResumeLayout(false);
            this.optionsPanel1.ResumeLayout(false);
            this.questionPanel.ResumeLayout(false);
            this.optionsPanel2.ResumeLayout(false);
            this.countdownPanel.ResumeLayout(false);
            this.countdownPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label timerscreen;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label scorePoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel gameQuestionBack;
        private System.Windows.Forms.Panel optionsPanel2;
        private System.Windows.Forms.Button optionButton3;
        private System.Windows.Forms.Button optionButton4;
        private System.Windows.Forms.Panel optionsPanel1;
        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel questionPanel;
        public System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer miniTimer;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Panel countdownPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label rankingLbl;
        private System.Windows.Forms.Label gameLbl;
    }
}