namespace магазин_тех
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.regname = new System.Windows.Forms.TextBox();
            this.regpassword1 = new System.Windows.Forms.TextBox();
            this.vhod = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regpassword = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(59, 109);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 20);
            this.name.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(59, 148);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(147, 20);
            this.password.TabIndex = 1;
            // 
            // regname
            // 
            this.regname.Location = new System.Drawing.Point(311, 105);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(164, 20);
            this.regname.TabIndex = 2;
            // 
            // regpassword1
            // 
            this.regpassword1.Location = new System.Drawing.Point(311, 144);
            this.regpassword1.Name = "regpassword1";
            this.regpassword1.Size = new System.Drawing.Size(164, 20);
            this.regpassword1.TabIndex = 3;
            // 
            // vhod
            // 
            this.vhod.Location = new System.Drawing.Point(72, 176);
            this.vhod.Name = "vhod";
            this.vhod.Size = new System.Drawing.Size(123, 32);
            this.vhod.TabIndex = 4;
            this.vhod.Text = "войти";
            this.vhod.UseVisualStyleBackColor = true;
            this.vhod.Click += new System.EventHandler(this.vhod_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(331, 205);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(123, 32);
            this.create.TabIndex = 5;
            this.create.Text = "создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(246, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 310);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "создайте логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "создайте пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "повтори пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "создать аккаунт";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "войти в аккаунт";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // regpassword
            // 
            this.regpassword.Location = new System.Drawing.Point(311, 183);
            this.regpassword.Name = "regpassword";
            this.regpassword.Size = new System.Drawing.Size(164, 20);
            this.regpassword.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regpassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.vhod);
            this.Controls.Add(this.regpassword1);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox regname;
        private System.Windows.Forms.TextBox regpassword1;
        private System.Windows.Forms.Button vhod;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regpassword;
        private System.Windows.Forms.Timer timer1;
    }
}

