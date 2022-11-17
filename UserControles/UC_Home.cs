using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hot_Chile_Restaurant.UserControles
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            //Initilizing default(first) image to imagelist
            pictureBox3.InitialImage = imageList1.Images[5];
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Setting  images to imagelist
            if (count < 7)
            {
                pictureBox3.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
                
        }
    }
}
