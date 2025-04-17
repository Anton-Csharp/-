using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace бурбур
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void createACC(object sender, EventArgs e)
        {
            if (!File.Exists(regname.Text))
            {
                if (regpassword.Text == regpassword1.Text )
                {
                    FileStream file = new FileStream(regname.Text, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);
                    writer.Write(regpassword.Text);
                    writer.Close();
                    file.Close();
                }
                else
                {
                    MessageBox.Show("пароль неверный","Уведомление",MessageBoxButtons.OK ,MessageBoxIcon.Error );
                }
            }
            else
            {
                MessageBox.Show("такого пользавателя нету", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool isanim = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isanim ==true)
            {
                if (panel1.Location.X >=1)
                {
                    panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
                }
                else
                {
                    isanim = false;
                    timer1.Stop();
                }
            }
            else
            {
                if (panel1.Location .X <=271)
                {
                    panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);

                }
                else
                {
                    isanim = true;
                    timer1.Stop();
                }
            }
        }

        private void vhod_Click(object sender, EventArgs e)
        {
            if (File.Exists(name.Text))
            {
              FileStream file = new FileStream(name.Text, FileMode.Open , FileAccess.Read );
              StreamReader reader = new StreamReader(file);
              string pass = reader.ReadLine();
                if (pass==password.Text)
                {
                    reader.Close();
                    file.Close();
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("пароль или логин неверный", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                
                    
                
            }
            else
            {
                MessageBox.Show("такого пользавателя нету", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
