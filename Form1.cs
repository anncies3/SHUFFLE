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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.BackgroundImage = pictureBox1.BackgroundImage;
                pictureBox2.BackColor = Color.Gray;
                pictureBox1.BackgroundImage = Properties.Resources.pic00;
                pictureBox1.BackColor = Color.White;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.BackgroundImage = pictureBox1.BackgroundImage;
                pictureBox5.BackColor = Color.Gray;
                pictureBox1.BackgroundImage = Properties.Resources.pic00;
                pictureBox1.BackColor = Color.White;
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
            }
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackgroundImage = pictureBox2.BackgroundImage;
                pictureBox3.BackColor = Color.Gray;
                pictureBox2.BackgroundImage = Properties.Resources.pic00;
                pictureBox2.BackColor = Color.White;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackgroundImage = pictureBox2.BackgroundImage;
                pictureBox6.BackColor = Color.Gray;
                pictureBox2.BackgroundImage = Properties.Resources.pic00;
                pictureBox2.BackColor = Color.White;
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
            }
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.BackgroundImage = pictureBox3.BackgroundImage;
                pictureBox4.BackColor = Color.Gray;
                pictureBox3.BackgroundImage = Properties.Resources.pic00;
                pictureBox3.BackColor = Color.White;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackgroundImage = pictureBox3.BackgroundImage;
                pictureBox7.BackColor = Color.Gray;
                pictureBox3.BackgroundImage = Properties.Resources.pic00;
                pictureBox3.BackColor = Color.White;
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
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.BackgroundImage = pictureBox4.BackgroundImage;
                pictureBox8.BackColor = Color.Gray;
                pictureBox4.BackgroundImage = Properties.Resources.pic00;
                pictureBox4.BackColor = Color.White;
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
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackgroundImage = pictureBox5.BackgroundImage;
                pictureBox6.BackColor = Color.Gray;
                pictureBox5.BackgroundImage = Properties.Resources.pic00;
                pictureBox5.BackColor = Color.White;
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.BackgroundImage = pictureBox5.BackgroundImage;
                pictureBox9.BackColor = Color.Gray;
                pictureBox5.BackgroundImage = Properties.Resources.pic00;
                pictureBox5.BackColor = Color.White;
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
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.BackgroundImage = pictureBox6.BackgroundImage;
                pictureBox5.BackColor = Color.Gray;
                pictureBox6.BackgroundImage = Properties.Resources.pic00;
                pictureBox6.BackColor = Color.White;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackgroundImage = pictureBox6.BackgroundImage;
                pictureBox7.BackColor = Color.Gray;
                pictureBox6.BackgroundImage = Properties.Resources.pic00;
                pictureBox6.BackColor = Color.White;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackgroundImage = pictureBox6.BackgroundImage;
                pictureBox10.BackColor = Color.Gray;
                pictureBox6.BackgroundImage = Properties.Resources.pic00;
                pictureBox6.BackColor = Color.White;
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
            }
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackgroundImage = pictureBox7.BackgroundImage;
                pictureBox3.BackColor = Color.Gray;
                pictureBox7.BackgroundImage = Properties.Resources.pic00;
                pictureBox7.BackColor = Color.White;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.BackgroundImage = pictureBox7.BackgroundImage;
                pictureBox8.BackColor = Color.Gray;
                pictureBox7.BackgroundImage = Properties.Resources.pic00;
                pictureBox7.BackColor = Color.White;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox7.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox7.BackgroundImage = Properties.Resources.pic00;
                pictureBox7.BackColor = Color.White;
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
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackgroundImage = pictureBox8.BackgroundImage;
                pictureBox7.BackColor = Color.Gray;
                pictureBox8.BackgroundImage = Properties.Resources.pic00;
                pictureBox8.BackColor = Color.White;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.BackgroundImage = pictureBox8.BackgroundImage;
                pictureBox12.BackColor = Color.Gray;
                pictureBox8.BackgroundImage = Properties.Resources.pic00;
                pictureBox8.BackColor = Color.White;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackgroundImage = pictureBox9.BackgroundImage;
                pictureBox3.BackColor = Color.Gray;
                pictureBox9.BackgroundImage = Properties.Resources.pic00;
                pictureBox9.BackColor = Color.White;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackgroundImage = pictureBox9.BackgroundImage;
                pictureBox10.BackColor = Color.Gray;
                pictureBox9.BackgroundImage = Properties.Resources.pic00;
                pictureBox9.BackColor = Color.White;
            }
            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.BackgroundImage = pictureBox9.BackgroundImage;
                pictureBox13.BackColor = Color.Gray;
                pictureBox9.BackgroundImage = Properties.Resources.pic00;
                pictureBox9.BackColor = Color.White;
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
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.BackgroundImage = pictureBox10.BackgroundImage;
                pictureBox9.BackColor = Color.Gray;
                pictureBox10.BackgroundImage = Properties.Resources.pic00;
                pictureBox10.BackColor = Color.White;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox10.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox10.BackgroundImage = Properties.Resources.pic00;
                pictureBox10.BackColor = Color.White;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.BackgroundImage = pictureBox10.BackgroundImage;
                pictureBox14.BackColor = Color.Gray;
                pictureBox10.BackgroundImage = Properties.Resources.pic00;
                pictureBox10.BackColor = Color.White;
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
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackgroundImage = pictureBox11.BackgroundImage;
                pictureBox10.BackColor = Color.Gray;
                pictureBox11.BackgroundImage = Properties.Resources.pic00;
                pictureBox11.BackColor = Color.White;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.BackgroundImage = pictureBox11.BackgroundImage;
                pictureBox12.BackColor = Color.Gray;
                pictureBox11.BackgroundImage = Properties.Resources.pic00;
                pictureBox11.BackColor = Color.White;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.BackgroundImage = pictureBox11.BackgroundImage;
                pictureBox15.BackColor = Color.Gray;
                pictureBox11.BackgroundImage = Properties.Resources.pic00;
                pictureBox11.BackColor = Color.White;
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
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox12.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox12.BackgroundImage = Properties.Resources.pic00;
                pictureBox12.BackColor = Color.White;
            }
            if (pictureBox16.BackColor == Color.White)
            {
                pictureBox16.BackgroundImage = pictureBox12.BackgroundImage;
                pictureBox16.BackColor = Color.Gray;
                pictureBox12.BackgroundImage = Properties.Resources.pic00;
                pictureBox12.BackColor = Color.White;
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
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.BackgroundImage = pictureBox13.BackgroundImage;
                pictureBox14.BackColor = Color.Gray;
                pictureBox13.BackgroundImage = Properties.Resources.pic00;
                pictureBox13.BackColor = Color.White;
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
            }
            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.BackgroundImage = pictureBox14.BackgroundImage;
                pictureBox13.BackColor = Color.Gray;
                pictureBox14.BackgroundImage = Properties.Resources.pic00;
                pictureBox14.BackColor = Color.White;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.BackgroundImage = pictureBox14.BackgroundImage;
                pictureBox15.BackColor = Color.Gray;
                pictureBox14.BackgroundImage = Properties.Resources.pic00;
                pictureBox14.BackColor = Color.White;
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
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackgroundImage = pictureBox15.BackgroundImage;
                pictureBox11.BackColor = Color.Gray;
                pictureBox15.BackgroundImage = Properties.Resources.pic00;
                pictureBox15.BackColor = Color.White;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.BackgroundImage = pictureBox15.BackgroundImage;
                pictureBox14.BackColor = Color.Gray;
                pictureBox15.BackgroundImage = Properties.Resources.pic00;
                pictureBox15.BackColor = Color.White;
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
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.BackgroundImage = pictureBox16.BackgroundImage;
                pictureBox15.BackColor = Color.Gray;
                pictureBox16.BackgroundImage = Properties.Resources.pic00;
                pictureBox16.BackColor = Color.White;
            }
        }

    }
}
