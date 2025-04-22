namespace магазин_тех
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemShowbasket = new System.Windows.Forms.TabPage();
            this.BasketLayoutpanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.itemShowbasket.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 49);
            this.label3.TabIndex = 29;
            this.label3.Text = "onliner";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "лучшие телефоны только у нас!!!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.itemShowbasket);
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 585);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1122, 553);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // itemShowbasket
            // 
            this.itemShowbasket.Controls.Add(this.BasketLayoutpanel2);
            this.itemShowbasket.Location = new System.Drawing.Point(4, 22);
            this.itemShowbasket.Name = "itemShowbasket";
            this.itemShowbasket.Padding = new System.Windows.Forms.Padding(3);
            this.itemShowbasket.Size = new System.Drawing.Size(1131, 559);
            this.itemShowbasket.TabIndex = 1;
            this.itemShowbasket.Text = "tabPage2";
            this.itemShowbasket.UseVisualStyleBackColor = true;
            // 
            // BasketLayoutpanel2
            // 
            this.BasketLayoutpanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BasketLayoutpanel2.Location = new System.Drawing.Point(0, 0);
            this.BasketLayoutpanel2.Name = "BasketLayoutpanel2";
            this.BasketLayoutpanel2.Size = new System.Drawing.Size(1131, 559);
            this.BasketLayoutpanel2.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 668);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.itemShowbasket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage itemShowbasket;
        private System.Windows.Forms.FlowLayoutPanel BasketLayoutpanel2;
    }
}