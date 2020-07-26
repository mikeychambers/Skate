using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Skate
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            RoadAnimation();
        }

//Values
        int speed = 5;
        int ollie = 60;
        int airTime;
        readonly int slowInterval = 1250;
        int score;
        bool inair = false;
        
        
 
//Road Timer
        void RoadAnimation()
        {
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(Timer1_Tick);
        }

        private void Moveline()
        {
//Create Lines
            int x = roadMarking1.Location.X;
            int y = roadMarking1.Location.Y;
            int x2 = roadMarking2.Location.X;
            int y2 = roadMarking2.Location.Y;
            int x3 = roadMarking3.Location.X;
            int y3 = roadMarking3.Location.Y;
            int xo = obsticle.Location.X;
            int yo = obsticle.Location.Y;

//Animation
            roadMarking1.Location = new Point(x - speed, y);
            roadMarking2.Location = new Point(x2 - speed, y2);
            roadMarking3.Location = new Point(x3 - speed, y3);
            obsticle.Location = new Point(xo - speed, yo);


            if (obsticle.Bounds.IntersectsWith(Skater.Bounds) || airTime > 7)
            {
                Bail();
            }

            
//Looping Animation
            if (x < -137)
            {
                roadMarking1.Location = new Point(this.Width, 385);
            }

            if (x2 < -137)
            {
                roadMarking2.Location = new Point(this.Width, 385);
            }

           if (x3 < -137)
            {
                roadMarking3.Location = new Point(this.Width, 385);
            }

            if (xo < -137)
            {
                obsticle.Location = new Point(this.Width + 1000, 361);
            }
        }

//Controls
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            int sy = Skater.Location.Y;
            int sx = Skater.Location.X;
            SpaceDown();

            if (e.KeyCode == Keys.D)
            {
                if (inair == false)
                {
                    speed = 12;
                    SoundPlayer push = new SoundPlayer(Properties.Resources.CutPush);
                    push.Play();
                }
                else
                {
                    speed = 5;
                }
                
            }

            void SpaceDown()
            {
                if (e.KeyCode == Keys.Space)
                {
                    inair = true;
                    Skater.Location = new Point(sx, sy - ollie);
                    SoundPlayer ollieup = new SoundPlayer(Properties.Resources.CutOllieUp);
                    ollieup.Play();
                }
                               
                if (sy < 143)
                {
                    Skater.Location = new Point(sx, sy);
                }

                if (sy < road.Location.Y)
                {
                    airTime++;

                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int sy = Skater.Location.Y;
            int sx = Skater.Location.X;
            ollie = 60;

            if (e.KeyCode == Keys.D)
            {
                if (inair == false)
                {
                    speed = 10;
                    Slow();
                }
                else
                {
                    speed = 5; 
                }
            }

            
            
            if (e.KeyCode == Keys.Space)
            {
                inair = false;
                Skater.Location = new Point(sx, sy + ollie);
                airTime = 0;
                SoundPlayer olliedown = new SoundPlayer(Properties.Resources.CutOllieLand);
                olliedown.Play();
            }
          
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p')
            {
                timer1.Start();
                (textBox1).Hide();
           
            }
           
        }


//Slowdown Push
        private void Slow()
        {
            timer2.Start();
            timer2.Interval = slowInterval;
            timer2.Tick += new EventHandler(Timer2_Tick); 
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {                       
            if (speed > 5)
            {
                speed--;
            }
        }

        //High Score
        public void Timer3_Tick(object sender, EventArgs e)
        {
            highscore.Text = score.ToString();
        }

        public void ConvertScore()
        {
            Int32.TryParse(highscore.Text, out int hscore);
            if (score > hscore)
            {
                timer3.Enabled = true;
            }

        }

        //Bail
        private void Bail()
        {
            score = 0;
            timer3.Enabled = false;
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            Moveline();
            ConvertScore();
            score++;
            scorelabel.Text = score.ToString();
        }
    
    }
}
