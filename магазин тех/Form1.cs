using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace магазин_тех
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vhod_Click(object sender, EventArgs e)
        {
            if (File.Exists(name.Text))
            {
                FileStream file = new FileStream(name.Text, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string pass = reader.ReadLine();
                if (pass == password.Text)
                {
                    reader.Close();
                    file.Close();
                    Form3 form3 = new Form3();
                    this.Hide();
                    form3.ShowDialog();
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

        private void create_Click(object sender, EventArgs e)
        {
            if (!File.Exists(regname.Text))
            {
                if (regpassword.Text == regpassword1.Text)
                {
                    FileStream file = new FileStream(regname.Text, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);
                    writer.Write(regpassword.Text);
                    writer.Close();
                    file.Close();
                }
                else
                {
                    MessageBox.Show("пароль неверный", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("такого пользавателя нету", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool isanim = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isanim == true)
            {
                if (panel1.Location.X >= 1)
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
                if (panel1.Location.X <= 246)
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
    }
}
