using System.Media;

namespace JoshWMathQuiz
{
    public partial class Form1 : Form
    {
        //create object by calliung randomizer to generate random numbers
        Random randomizer = new Random();

        //variables
        int addend1, addend2, minuend, subtrahend, multiplicand, multiplier, dividend, divisor;
        int timeLeft;

        private void Form1_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //true stop timer and show message
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            //false decrease time by 1 second
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "seconds";
                //color control for countdown
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                    SystemSounds.Asterisk.Play();
                }

                if (timeLeft == 0)
                {
                    timeLabel.BackColor = Color.Transparent;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        public void StartTheQuiz()
        {
            //addition
            //fill in blanks
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            //generate string
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            //sum equals zero
            sum.Value = 0;

            //subtraction
            //fill in blanks
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            //generate string
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            //sum equals zero
            difference.Value = 0;

            //multiplication
            //fill in blanks
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            //generate string
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            //sum equals zero
            product.Value = 0;

            //division
            //fill in blanks
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            //generate string
            dividedLeftLabel.Text = dividend.ToString();
            dividedrightLabel.Text = divisor.ToString();
            //sum equals zero
            quotient.Value = 0;

            //start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
        }
        //sound controls for answers
        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (sum.Value == (addend1 + addend2))
            {
                SystemSounds.Beep.Play();
                sum.BackColor = Color.LightGreen;
            }
            else
            {
                sum.BackColor = Color.LightGray;
            }

        }
        private void diff_ValueChanged(object sender, EventArgs e)
        {
            if (difference.Value == (minuend - subtrahend))
            {
                SystemSounds.Beep.Play();
                difference.BackColor = Color.LightGreen;
            }
            else
            {
                difference.BackColor = Color.LightGray;
            }
        }
        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (product.Value == (multiplicand * multiplier))
            {
                SystemSounds.Beep.Play();
                product.BackColor = Color.LightGreen;
            }
            else
            {
                product.BackColor = Color.LightGray;
            }
        }
        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (quotient.Value == (dividend / divisor))
            {
                SystemSounds.Beep.Play();
                quotient.BackColor = Color.LightGreen;
            }
            else
            {
                quotient.BackColor = Color.LightGray;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
       
    }
}