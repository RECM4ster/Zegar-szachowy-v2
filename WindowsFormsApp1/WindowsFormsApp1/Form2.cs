using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        Form2 otherClock;

        public void SetOtherClock(Form2 otherClock)
        {
            this.otherClock = otherClock;
        }
          
        public Form2(string czas)
        {
            InitializeComponent();

            label2.Text = czas;
            


        }

        public Form2(string czas, Form2 otherClock)
        {
            InitializeComponent();
            label2.Text = czas;
            this.otherClock = otherClock;
            StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Left = 1200, Top =  50);

            




        }
        //Start
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            
        }
        private void button1_Click()
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

        }

        //Stop
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void button2_Click()
        {
            timer1.Stop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
                        
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            var time = int.Parse(label2.Text);
            time -= 1;
            label2.Text = time.ToString();
            updateTime(time);
            label2.Text = time.ToString();
            label2.Refresh();
            if (time <= 0)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Koniec twojego czasu");
                Close();
            }

        }



        private void updateTime(int time)
        {
            int minuty = time / 60;
            int sekundy = time % 60;
            var labelText = "Pozostało " + minuty.ToString() + " minut " + sekundy.ToString() + " sekund ";
            //MessageBox.Show(labelText, "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            label1.Text = String.Format(labelText);
            label1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otherClock.button1_Click();
            button2_Click();
        }
    }
}
