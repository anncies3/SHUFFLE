using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SHUFFLE
{
    public partial class SHUFFLE : Form
    {
        public SHUFFLE()
        {
            InitializeComponent();

        }

        private void SHUFFLE_Load(object sender, EventArgs e)
        {

        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = 0.ToString();

            Image[] pic = new Image[15];
            pic[0] = Properties.Resources.pic1;
            pic[1] = Properties.Resources.pic2;
            pic[2] = Properties.Resources.pic3;
            pic[3] = Properties.Resources.pic4;
            pic[4] = Properties.Resources.pic5;
            pic[5] = Properties.Resources.pic6;
            pic[6] = Properties.Resources.pic7;
            pic[7] = Properties.Resources.pic8;
            pic[8] = Properties.Resources.pic9;
            pic[9] = Properties.Resources.pic10;
            pic[10] = Properties.Resources.pic11;
            pic[11] = Properties.Resources.pic12;
            pic[12] = Properties.Resources.pic13;
            pic[13] = Properties.Resources.pic14;
            pic[14] = Properties.Resources.pic15;

            Random r = new Random(); // https://stackoverflow.com/questions/5383498/shuffle-rearrange-randomly-a-liststring
            int n = 15;
            while (n > 0)
            {
                int k = (r.Next(0, n));
                n--;
                Image value = pic[n];
                pic[n] = pic[k];
                pic[k] = value;
            }


            pictureBox1.BackgroundImage = pic[0];
            pictureBox2.BackgroundImage = pic[1];
            pictureBox3.BackgroundImage = pic[2];
            pictureBox4.BackgroundImage = pic[3];
            pictureBox5.BackgroundImage = pic[4];
            pictureBox6.BackgroundImage = pic[5];
            pictureBox7.BackgroundImage = pic[6];
            pictureBox8.BackgroundImage = pic[7];
            pictureBox9.BackgroundImage = pic[8];
            pictureBox10.BackgroundImage = pic[9];
            pictureBox11.BackgroundImage = pic[10];
            pictureBox12.BackgroundImage = pic[11];
            pictureBox13.BackgroundImage = pic[12];
            pictureBox14.BackgroundImage = pic[13];
            pictureBox15.BackgroundImage = pic[14];
            pictureBox16.BackgroundImage = Properties.Resources.pic00;

            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.Gray;
            pictureBox8.BackColor = Color.Gray;
            pictureBox9.BackColor = Color.Gray;
            pictureBox10.BackColor = Color.Gray;
            pictureBox11.BackColor = Color.Gray;
            pictureBox12.BackColor = Color.Gray;
            pictureBox13.BackColor = Color.Gray;
            pictureBox14.BackColor = Color.Gray;
            pictureBox15.BackColor = Color.Gray;
            pictureBox16.BackColor = Color.White;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.BackgroundImage = pictureBox1.BackgroundImage;
                pictureBox2.BackColor = Color.Gray;
                pictureBox1.BackgroundImage = Properties.Resources.pic00;
                pictureBox1.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.BackgroundImage = pictureBox1.BackgroundImage;
                pictureBox5.BackColor = Color.Gray;
                pictureBox1.BackgroundImage = Properties.Resources.pic00;
                pictureBox1.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.BackgroundImage = pictureBox2.BackgroundImage;
                pictureBox1.BackColor = Color.Gray;
                pictureBox2.BackgroundImage = Properties.Resources.pic00;
                pictureBox2.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackgroundImage = pictureBox2.BackgroundImage;
                pictureBox3.BackColor = Color.Gray;
                pictureBox2.BackgroundImage = Properties.Resources.pic00;
                pictureBox2.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackgroundImage = pictureBox2.BackgroundImage;
                pictureBox6.BackColor = Color.Gray;
                pictureBox2.BackgroundImage = Properties.Resources.pic00;
                pictureBox2.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.BackgroundImage = pictureBox3.BackgroundImage;
                pictureBox2.BackColor = Color.Gray;
                pictureBox3.BackgroundImage = Properties.Resources.pic00;
                pictureBox3.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.BackgroundImage = pictureBox3.BackgroundImage;
                pictureBox4.BackColor = Color.Gray;
                pictureBox3.BackgroundImage = Properties.Resources.pic00;
                pictureBox3.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackgroundImage = pictureBox3.BackgroundImage;
                pictureBox7.BackColor = Color.Gray;
                pictureBox3.BackgroundImage = Properties.Resources.pic00;
                pictureBox3.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackgroundImage = pictureBox4.BackgroundImage;
                pictureBox3.BackColor = Color.Gray;
                pictureBox4.BackgroundImage = Properties.Resources.pic00;
                pictureBox4.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.BackgroundImage = pictureBox4.BackgroundImage;
                pictureBox8.BackColor = Color.Gray;
                pictureBox4.BackgroundImage = Properties.Resources.pic00;
                pictureBox4.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.BackgroundImage = pictureBox5.BackgroundImage;
                pictureBox1.BackColor = Color.Gray;
                pictureBox5.BackgroundImage = Properties.Resources.pic00;
                pictureBox5.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackgroundImage = pictureBox5.BackgroundImage;
                pictureBox6.BackColor = Color.Gray;
                pictureBox5.BackgroundImage = Properties.Resources.pic00;
                pictureBox5.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.BackgroundImage = pictureBox5.BackgroundImage;
                pictureBox9.BackColor = Color.Gray;
                pictureBox5.BackgroundImage = Properties.Resources.pic00;
                pictureBox5.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.BackgroundImage = pictureBox6.BackgroundImage;
                pictureBox2.BackColor = Color.Gray;
                pictureBox6.BackgroundImage = Properties.Resources.pic00;
                pictureBox6.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.BackgroundImage = pictureBox6.BackgroundImage;
                pictureBox5.BackColor = Color.Gray;
                pictureBox6.BackgroundImage = Properties.Resources.pic00;
                pictureBox6.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackgroundImage = pictureBox6.BackgroundImage;
                pictureBox7.BackColor = Color.Gray;
                pictureBox6.BackgroundImage = Properties.Resources.pic00;
                pictureBox6.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackgroundImage = pictureBox6.BackgroundImage;
                pictureBox10.BackColor = Color.Gray;
                pictureBox6.BackgroundImage = Properties.Resources.pic00;
                pictureBox6.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackgroundImage = pictureBox7.BackgroundImage;
                pictureBox6.BackColor = Color.Gray;
                pictureBox7.BackgroundImage = Properties.Resources.pic00;
                pictureBox7.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackgroundImage = pictureBox7.BackgroundImage;
                pictureBox3.BackColor = Color.Gray;
                pictureBox7.BackgroundImage = Properties.Resources.pic00;
                pictureBox7.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.BackgroundImage = pictureBox7.BackgroundImage;
                pictureBox8.BackColor = Color.Gray;
                pictureBox7.BackgroundImage = Properties.Resources.pic00;
                pictureBox7.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox7.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox7.BackgroundImage = Properties.Resources.pic00;
                pictureBox7.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.BackgroundImage = pictureBox8.BackgroundImage;
                pictureBox4.BackColor = Color.Gray;
                pictureBox8.BackgroundImage = Properties.Resources.pic00;
                pictureBox8.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackgroundImage = pictureBox8.BackgroundImage;
                pictureBox7.BackColor = Color.Gray;
                pictureBox8.BackgroundImage = Properties.Resources.pic00;
                pictureBox8.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.BackgroundImage = pictureBox8.BackgroundImage;
                pictureBox12.BackColor = Color.Gray;
                pictureBox8.BackgroundImage = Properties.Resources.pic00;
                pictureBox8.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.BackgroundImage = pictureBox9.BackgroundImage;
                pictureBox5.BackColor = Color.Gray;
                pictureBox9.BackgroundImage = Properties.Resources.pic00;
                pictureBox9.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackgroundImage = pictureBox9.BackgroundImage;
                pictureBox10.BackColor = Color.Gray;
                pictureBox9.BackgroundImage = Properties.Resources.pic00;
                pictureBox9.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.BackgroundImage = pictureBox9.BackgroundImage;
                pictureBox13.BackColor = Color.Gray;
                pictureBox9.BackgroundImage = Properties.Resources.pic00;
                pictureBox9.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackgroundImage = pictureBox10.BackgroundImage;
                pictureBox6.BackColor = Color.Gray;
                pictureBox10.BackgroundImage = Properties.Resources.pic00;
                pictureBox10.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.BackgroundImage = pictureBox10.BackgroundImage;
                pictureBox9.BackColor = Color.Gray;
                pictureBox10.BackgroundImage = Properties.Resources.pic00;
                pictureBox10.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox10.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox10.BackgroundImage = Properties.Resources.pic00;
                pictureBox10.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.BackgroundImage = pictureBox10.BackgroundImage;
                pictureBox14.BackColor = Color.Gray;
                pictureBox10.BackgroundImage = Properties.Resources.pic00;
                pictureBox10.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackgroundImage = pictureBox11.BackgroundImage;
                pictureBox7.BackColor = Color.Gray;
                pictureBox11.BackgroundImage = Properties.Resources.pic00;
                pictureBox11.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackgroundImage = pictureBox11.BackgroundImage;
                pictureBox10.BackColor = Color.Gray;
                pictureBox11.BackgroundImage = Properties.Resources.pic00;
                pictureBox11.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.BackgroundImage = pictureBox11.BackgroundImage;
                pictureBox12.BackColor = Color.Gray;
                pictureBox11.BackgroundImage = Properties.Resources.pic00;
                pictureBox11.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.BackgroundImage = pictureBox11.BackgroundImage;
                pictureBox15.BackColor = Color.Gray;
                pictureBox11.BackgroundImage = Properties.Resources.pic00;
                pictureBox11.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.BackgroundImage = pictureBox12.BackgroundImage;
                pictureBox8.BackColor = Color.Gray;
                pictureBox12.BackgroundImage = Properties.Resources.pic00;
                pictureBox12.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox12.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox12.BackgroundImage = Properties.Resources.pic00;
                pictureBox12.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox16.BackColor == Color.White)
            {
                pictureBox16.BackgroundImage = pictureBox12.BackgroundImage;
                pictureBox16.BackColor = Color.Gray;
                pictureBox12.BackgroundImage = Properties.Resources.pic00;
                pictureBox12.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.BackgroundImage = pictureBox13.BackgroundImage;
                pictureBox9.BackColor = Color.Gray;
                pictureBox13.BackgroundImage = Properties.Resources.pic00;
                pictureBox13.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.BackgroundImage = pictureBox13.BackgroundImage;
                pictureBox14.BackColor = Color.Gray;
                pictureBox13.BackgroundImage = Properties.Resources.pic00;
                pictureBox13.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackgroundImage = pictureBox14.BackgroundImage;
                pictureBox10.BackColor = Color.Gray;
                pictureBox14.BackgroundImage = Properties.Resources.pic00;
                pictureBox14.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.BackgroundImage = pictureBox14.BackgroundImage;
                pictureBox13.BackColor = Color.Gray;
                pictureBox14.BackgroundImage = Properties.Resources.pic00;
                pictureBox14.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.BackgroundImage = pictureBox14.BackgroundImage;
                pictureBox15.BackColor = Color.Gray;
                pictureBox14.BackgroundImage = Properties.Resources.pic00;
                pictureBox14.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox16.BackColor == Color.White)
            {
                Cursor.Current = Cursors.Hand;
                pictureBox16.BackgroundImage = pictureBox15.BackgroundImage;
                pictureBox16.BackColor = Color.Gray;
                pictureBox15.BackgroundImage = Properties.Resources.pic00;
                pictureBox15.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox15.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox15.BackgroundImage = Properties.Resources.pic00;
                pictureBox15.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.BackgroundImage = pictureBox15.BackgroundImage;
                pictureBox14.BackColor = Color.Gray;
                pictureBox15.BackgroundImage = Properties.Resources.pic00;
                pictureBox15.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.BackgroundImage = pictureBox16.BackgroundImage;
                pictureBox12.BackColor = Color.Gray;
                pictureBox16.BackgroundImage = Properties.Resources.pic00;
                pictureBox16.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.BackgroundImage = pictureBox16.BackgroundImage;
                pictureBox15.BackColor = Color.Gray;
                pictureBox16.BackgroundImage = Properties.Resources.pic00;
                pictureBox16.BackColor = Color.White;
                label2.Text = label2.Text + 1;
            }
        }

        private void label2_Click()
        {

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

    }
}
