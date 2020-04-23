using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickImages
{
    public partial class FormClickableImages : Form
    {
        public FormClickableImages()
        {
            InitializeComponent();
        }

        private void FormClickableImages_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ONE", "Clickable_Image");
            pictureBox1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TWO", "Clickable_Image");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THREE", "Clickable_Image");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FOUR", "Clickable_Image");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FIVE", "Clickable_Image");
        }
    }
}
