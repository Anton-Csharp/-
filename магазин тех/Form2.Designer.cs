namespace бурбур
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vhod = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.regname = new System.Windows.Forms.TextBox();
            this.regpassword = new System.Windows.Forms.TextBox();
            this.regpassword1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // vhod
            // 
            this.vhod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vhod.FlatAppearance.BorderSize = 2;
            this.vhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vhod.Location = new System.Drawing.Point(47, 196);
            this.vhod.Name = "vhod";
            this.vhod.Size = new System.Drawing.Size(160, 35);
            this.vhod.TabIndex = 0;
            this.vhod.Text = "войти";
            this.vhod.UseVisualStyleBackColor = true;
            this.vhod.Click += new System.EventHandler(this.vhod_Click);
            // 
            // create
            // 
            this.create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(317, 213);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(182, 35);
            this.create.TabIndex = 1;
            this.create.Text = "создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.createACC);
            // 
            // regname
            // 
            this.regname.Location = new System.Drawing.Point(317, 88);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(182, 20);
            this.regname.TabIndex = 2;
            // 
            // regpassword
            // 
            this.regpassword.Location = new System.Drawing.Point(317, 174);
            this.regpassword.Name = "regpassword";
            this.regpassword.Size = new System.Drawing.Size(182, 20);
            this.regpassword.TabIndex = 4;
            // 
            // regpassword1
            // 
            this.regpassword1.Location = new System.Drawing.Point(317, 135);
            this.regpassword1.Name = "regpassword1";
            this.regpassword1.Size = new System.Drawing.Size(182, 20);
            this.regpassword1.TabIndex = 5;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.name.Location = new System.Drawing.Point(47, 107);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 20);
            this.name.TabIndex = 2;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.password.Location = new System.Drawing.Point(47, 158);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(160, 20);
            this.password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "введите имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "введите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "введите имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "создайте пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "войти в акк";
            this.label6.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "создать акк";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "повторите пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(270, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 293);
            this.panel1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.regpassword1);
            this.Controls.Add(this.regpassword);
            this.Controls.Add(this.name);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.create);
            this.Controls.Add(this.vhod);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vhod;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox regname;
        private System.Windows.Forms.TextBox regpassword;
        private System.Windows.Forms.TextBox regpassword1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}