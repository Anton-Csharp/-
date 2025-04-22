using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace магазин_тех
{
    public partial class UserControl1 : UserControl
    {
        Form3 Form3;
        public UserControl1(Form3 form3)
        {
            InitializeComponent();
            Form3 = form3;  
        }
        public string Nameitem
        {
            get
            {
                return Namelabel.Text;
            }
            set
            {
                Namelabel.Text = value;
            }
        }
        public Image Imageitem
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string Priceitem
        {
            get
            {
                return Pricelabel.Text;
            }
            set
            {
                Pricelabel.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
