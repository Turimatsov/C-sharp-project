namespace WindowsFormsApplication6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.въведиДанниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоЖанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поАвторИлиЗаглавиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиОтПоследните3ГодиниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данниToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.tXTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данниToolStripMenuItem
            // 
            this.данниToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въведиДанниToolStripMenuItem,
            this.списъкToolStripMenuItem});
            this.данниToolStripMenuItem.Name = "данниToolStripMenuItem";
            this.данниToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.данниToolStripMenuItem.Text = "Данни";
            // 
            // въведиДанниToolStripMenuItem
            // 
            this.въведиДанниToolStripMenuItem.Name = "въведиДанниToolStripMenuItem";
            this.въведиДанниToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.въведиДанниToolStripMenuItem.Text = "Въведи данни";
            this.въведиДанниToolStripMenuItem.Click += new System.EventHandler(this.въведиДанниToolStripMenuItem_Click);
            // 
            // списъкToolStripMenuItem
            // 
            this.списъкToolStripMenuItem.Name = "списъкToolStripMenuItem";
            this.списъкToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.списъкToolStripMenuItem.Text = "Списък";
            this.списъкToolStripMenuItem.Click += new System.EventHandler(this.списъкToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаПоЖанрToolStripMenuItem,
            this.поАвторИлиЗаглавиеToolStripMenuItem,
            this.книгиОтПоследните3ГодиниToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // справкаПоЖанрToolStripMenuItem
            // 
            this.справкаПоЖанрToolStripMenuItem.Name = "справкаПоЖанрToolStripMenuItem";
            this.справкаПоЖанрToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.справкаПоЖанрToolStripMenuItem.Text = "Справка по жанр";
            this.справкаПоЖанрToolStripMenuItem.Click += new System.EventHandler(this.справкаПоЖанрToolStripMenuItem_Click);
            // 
            // поАвторИлиЗаглавиеToolStripMenuItem
            // 
            this.поАвторИлиЗаглавиеToolStripMenuItem.Name = "поАвторИлиЗаглавиеToolStripMenuItem";
            this.поАвторИлиЗаглавиеToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.поАвторИлиЗаглавиеToolStripMenuItem.Text = "По автор или заглавие";
            this.поАвторИлиЗаглавиеToolStripMenuItem.Click += new System.EventHandler(this.поАвторИлиЗаглавиеToolStripMenuItem_Click);
            // 
            // книгиОтПоследните3ГодиниToolStripMenuItem
            // 
            this.книгиОтПоследните3ГодиниToolStripMenuItem.Name = "книгиОтПоследните3ГодиниToolStripMenuItem";
            this.книгиОтПоследните3ГодиниToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.книгиОтПоследните3ГодиниToolStripMenuItem.Text = "Книги от последните 3 години";
            this.книгиОтПоследните3ГодиниToolStripMenuItem.Click += new System.EventHandler(this.книгиОтПоследните3ГодиниToolStripMenuItem_Click);
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTFILEToolStripMenuItem});
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.tXTToolStripMenuItem.Text = "TXT";
            // 
            // tXTFILEToolStripMenuItem
            // 
            this.tXTFILEToolStripMenuItem.Name = "tXTFILEToolStripMenuItem";
            this.tXTFILEToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.tXTFILEToolStripMenuItem.Text = "TXT FILE";
            this.tXTFILEToolStripMenuItem.Click += new System.EventHandler(this.tXTFILEToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication6.Properties.Resources.dreams_metroeve_exit_dreams_meaning;
            this.pictureBox2.Location = new System.Drawing.Point(766, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApplication6.Properties.Resources._4K_Books_Wallpaper_Full_HD;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(797, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(714, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Часът е:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Програма-106828";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem въведиДанниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem списъкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаПоЖанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАвторИлиЗаглавиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиОтПоследните3ГодиниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTFILEToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

