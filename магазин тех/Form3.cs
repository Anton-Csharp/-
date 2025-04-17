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
    public partial class Form3 : Form
    { 
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Button button = sender as Button;
            listBox1.Text  += button ;
           
        }
        bool list = true;
        private void button7_Click(object sender, EventArgs e)
        {
            if (list == true)
            {
                listBox1.Visible = true;
                list = false;
            }
            else
            {
                listBox1.Visible = false;
                list = true;
            }

        }
    }
}
