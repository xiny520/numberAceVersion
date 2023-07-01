using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberAceVersion
{
    public partial class gamePage : Form
    {
        public static int seconds; // create an int(numbers) variable named seconds
        public static bool op1; // create a bool(true or false) variable named op1
        public static bool op2; // create a bool variable named op2
        public static bool op3; // create a bool variable named op3
        public static bool op4; // create a bool variable named op4
        public static int score; // create an int variable name score
        public static int highscore = 0;
        public static int answer; // create an int variable named answer
        public static string Ans; // create a string named Ans
        public static int quesRan; // create an int variable named quesRan
        public static int num1; // create an int variable named num1
        public static int num2; // create an int variable named num2
        public static int correctCount; // create an int variable named correctCount
        public static bool stop = false; // create a bool variable and make stop false

        public gamePage()
        {
            InitializeComponent();
        }

        private void gamePage_Load(object sender, EventArgs e)
        {

        }

        public void addGo(object sender, EventArgs e)
        {
            answer = num1 + num2;
            questionLabel.Text = num1.ToString() + " + " + num2.ToString();
        }
        public void subGo(object sender, EventArgs e)
        {
            answer = num1 - num2;
            questionLabel.Text = num1.ToString() + " - " + num2.ToString();
        }
        public void mulGo(object sender, EventArgs e)
        {
            answer = num1 * num2;
            questionLabel.Text = num1.ToString() + " x " + num2.ToString();
        }
        public void divGo(object sender, EventArgs e)
        {
            int multi = num1 * num2;
            answer = num1;
            questionLabel.Text = multi.ToString() + " ÷ " + num2.ToString();
        }

        private void generate_Question(object sender, EventArgs e)
        {

            // basically resetting everything
            op1 = false; // set op1 as false
            op2 = false; // set op2 as false
            op3 = false; // set op3 as false
            op4 = false; // set op4 as false

            Random rnd = new Random(); // create a new Random variable called rnd
            num1 = rnd.Next(0, 3); // generate random int x
            num2 = rnd.Next(0, 3); // generate random int y
            int optionRan = rnd.Next(1, 5); // 
            customPage f = new customPage();

            if (f.additionCheck.Checked == true)
            {
                if (f.subtractionCheck.Checked == true)
                {
                    if (f.multipCheck.Checked == true)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 5); // generate random option int (1 
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 4)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (f.diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 4); // generate random option int (1 
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                mulGo(sender, e);
                            }
                        }
                    }
                    if (f.multipCheck.Checked == false)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 4);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (f.diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                        }
                    }
                }
                if (f.subtractionCheck.Checked == false)
                {
                    if (f.multipCheck.Checked == true)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 4);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                divGo(sender, e);
                            }

                        }
                        if (f.diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                        }
                    }
                    if (f.multipCheck.Checked == false)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (f.diviCheck.Checked == false)
                        {
                            addGo(sender, e);
                        }
                    }
                }
            }

            if (f.additionCheck.Checked == false)
            {
                if (f.subtractionCheck.Checked == true)
                {
                    if (f.multipCheck.Checked == true)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 4);
                            if (quesRan == 1)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (f.diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                        }
                    }
                    if (f.multipCheck.Checked == false)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (f.diviCheck.Checked == false)
                        {
                            subGo(sender, e);
                        }
                    }
                }
                if (f.subtractionCheck.Checked == false)
                {
                    if (f.multipCheck.Checked == true)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                divGo(sender, e);
                            }

                        }
                        if (f.diviCheck.Checked == false)
                        {
                            mulGo(sender, e);
                        }

                    }
                    if (f.multipCheck.Checked == false)
                    {
                        if (f.diviCheck.Checked == true)
                        {
                            divGo(sender, e);
                        }
                        if (f.diviCheck.Checked == false)
                        {
                            questionLabel.Text = "You didn't pick anything!!";
                        }
                    }
                }
            }

            Ans = answer.ToString();

            if (optionRan == 1) // if random option int is 1
            {
                optionButton1.Text = Ans; // text on optionButton1 = string answer
                optionButton2.Text = (answer - 1).ToString(); // text on optionbutton2 = int answer - 1 (string format)
                optionButton3.Text = (answer + 2).ToString(); // text on optionbutton3 = int answer + 2 (string format)
                optionButton4.Text = (answer + 1).ToString(); // text on optionbutton4 = int answer + 1 (string format)
                op1 = true; // set op1 as true because optionButton1 has the correct answer
            }
            else if (optionRan == 2)
            {
                optionButton1.Text = (answer - 1).ToString();
                optionButton2.Text = Ans; // text on optionButton1 = string answer
                optionButton3.Text = (answer + 1).ToString();
                optionButton4.Text = (answer + 2).ToString();
                op2 = true; // set op2 as true because optionButton3 has the correct answer
            }
            else if (optionRan == 3)
            {
                optionButton1.Text = (answer + 1).ToString();
                optionButton2.Text = (answer - 1).ToString();
                optionButton3.Text = Ans; // text on optionButton1 = string answer
                optionButton4.Text = (answer - 2).ToString();
                op3 = true; // set op3 as true because optionButton3 has the correct answer
            }
            else if (optionRan == 4)
            {
                optionButton1.Text = (answer - 1).ToString();
                optionButton2.Text = (answer + 2).ToString();
                optionButton3.Text = (answer + 1).ToString();
                optionButton4.Text = Ans;
                op4 = true; // set op3 as true because optionButton3 has the correct answer
            }

            if (correctCount > 8)
            {
                carImg.Location = new Point(200, 700);
                correctCount = 0;
            }
        }
        private void correct_Answer(object sender, EventArgs e) // method for correct answer
        {
            score++; // add 1 to score
            scorePoints.Text = "+1"; // write "+1"
            totalScore.Text = score.ToString(); // display (new) total score
            carImg.Top = carImg.Top - 80; // move car up
            //ding.Play();
            gameQuestionBack.BackColor = Color.Green;
            correctCount++;
        }
        private void incorrect_Answer(object sender, EventArgs e)
        {
            score--; // minus 1 from score
            scorePoints.Text = "-1"; // write "-1"
            totalScore.Text = score.ToString(); //// display (new) total score
            //horn.Play();
            gameQuestionBack.BackColor = Color.Red;
        }

        public void endGame(object sender, EventArgs e)
        {
            countdownTimer.Stop(); // stop timer
            questionLabel.Text = ""; // empty the question
            optionButton1.Enabled = false;
            optionButton2.Enabled = false;
            optionButton3.Enabled = false;
            optionButton4.Enabled = false;
            optionButton1.Text = ""; // and this option button
            optionButton2.Text = ""; // and this one
            optionButton3.Text = ""; // and this one
            optionButton4.Text = ""; // and this one
            totalScore.Text = score.ToString(); // write in the totalScore label: "Total Score = (insert score)"
            
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            seconds = 3;
            miniTimer.Start();
            countdownPanel.Visible = false;
            lblMini.Visible = false;
            gamePanel.Visible = false;
            if (stop == true)
            {
                countdownTimer.Start();
            }
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            timerscreen.Text = seconds--.ToString();
            if (seconds < 0) // when timer ends basically
            {
                //endGame(sender, e);
                if (score > highscore)
                {
                    highscore = score;
                }
                
            }
            if (carImg.Bounds.IntersectsWith(finishImg.Bounds))
            {
                endGame(sender,e);
                gamePanel.Visible = true;
                rankingLbl.Text = "Hooray! You ranked 1st!";
                carImg.BringToFront();

                if (AlCar1.Bounds.IntersectsWith(finishImg.Bounds))
                {
                    gamePanel.Visible = true;
                    rankingLbl.Text = "Better job next time! You ranked 2nd!";

                    if (AlCar1.Bounds.IntersectsWith(finishImg.Bounds))
                    {
                        gamePanel.Visible = true;
                        rankingLbl.Text = "Better job next time! You ranked 3rd!";
                    }

                }
                if (AlCar2.Bounds.IntersectsWith(finishImg.Bounds))
                {
                    gamePanel.Visible = true;
                    rankingLbl.Text = "Better job next time! You ranked 2nd!";

                    if (AlCar1.Bounds.IntersectsWith(finishImg.Bounds))
                    {
                        gamePanel.Visible = true;
                        rankingLbl.Text = "Better job next time! You ranked 3rd!";
                    }
                }

            }
        }

        private void miniTimer_Tick(object sender, EventArgs e)
        {
            countdownPanel.Visible = true;
            lblMini.Visible = true;
            lblMini.Text = seconds--.ToString();

            if (seconds < 0)
            {
                miniTimer.Stop(); // stop the shorter timer
                lblMini.Visible = false; // make the label displaying the shorter timer invisible
                timerscreen.Visible = true; // make the label displaying the longer timer visible 
                countdownTimer.Start(); // start the countdown timer 
                seconds = 5; // set the countdown timer to 20 seconds
                generate_Question(sender, e); // go the generate_Question method (down below!)
                highScoreLabel.Text = highscore.ToString();
                score = 0;
                //panel6.Location = new Point(200, 700);
                optionButton1.Enabled = true;
                optionButton2.Enabled = true;
                optionButton3.Enabled = true;
                optionButton4.Enabled = true;
                //panel5.Visible = false;
                correctCount = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo); // the message box
            if (dialogResult == DialogResult.Yes) // if the yes button is chosen
            {
                this.Hide(); // hide this form (gamepage)
                customPage back = new customPage(); // link to customPage
                back.Show(); // show customPage form
            }
            else if (dialogResult == DialogResult.No) // if the no button is chosen
            {

            }
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            if (op1 == true) // if optionbutton1 is the one with the correct answer
            {
                generate_Question(sender, e); // do generate_Question method (reset the options and generate another question)
                correct_Answer(sender, e); // do correct_Answer method
            }
            else
            {
                incorrect_Answer(sender, e);  // do incorrect_Answer method
            }
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            if (op2 == true) // if optionbutton2 is the one with the correct answer
            {
                generate_Question(sender, e);
                correct_Answer(sender, e);
            }
            else
            {
                incorrect_Answer(sender, e);
            }
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            if (op3 == true) // if optionbutton3 is the one with the correct answer
            {
                generate_Question(sender, e);
                correct_Answer(sender, e);
            }
            else
            {
                incorrect_Answer(sender, e);
            }
        }

        private void optionButton4_Click(object sender, EventArgs e)
        {
            if (op4 == true) // if optionbutton4 is the one with the correct answer
            {
                generate_Question(sender, e);
                correct_Answer(sender, e);
            }
            else
            {
                incorrect_Answer(sender, e);
            }
        }
    }
}
