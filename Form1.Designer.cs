namespace _11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фігуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.еліпсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямокутникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полігонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лініяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняФігуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 48;
            this.listBox1.Location = new System.Drawing.Point(10, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 532);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фігуриToolStripMenuItem,
            this.налаштуванняФігуриToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1883, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фігуриToolStripMenuItem
            // 
            this.фігуриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.еліпсToolStripMenuItem,
            this.прямокутникToolStripMenuItem,
            this.полігонToolStripMenuItem,
            this.тестToolStripMenuItem,
            this.лініяToolStripMenuItem});
            this.фігуриToolStripMenuItem.Name = "фігуриToolStripMenuItem";
            this.фігуриToolStripMenuItem.Size = new System.Drawing.Size(156, 52);
            this.фігуриToolStripMenuItem.Text = "Фігури";
            // 
            // еліпсToolStripMenuItem
            // 
            this.еліпсToolStripMenuItem.Name = "еліпсToolStripMenuItem";
            this.еліпсToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.еліпсToolStripMenuItem.Text = "Еліпс";
            this.еліпсToolStripMenuItem.Click += new System.EventHandler(this.еліпсToolStripMenuItem_Click);
            // 
            // прямокутникToolStripMenuItem
            // 
            this.прямокутникToolStripMenuItem.Name = "прямокутникToolStripMenuItem";
            this.прямокутникToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.прямокутникToolStripMenuItem.Text = "Прямокутник";
            this.прямокутникToolStripMenuItem.Click += new System.EventHandler(this.прямокутникToolStripMenuItem_Click);
            // 
            // полігонToolStripMenuItem
            // 
            this.полігонToolStripMenuItem.Name = "полігонToolStripMenuItem";
            this.полігонToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.полігонToolStripMenuItem.Text = "Полігон";
            this.полігонToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.полігонToolStripMenuItem_MouseDown);
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.тестToolStripMenuItem.Text = "Текст";
            // 
            // лініяToolStripMenuItem
            // 
            this.лініяToolStripMenuItem.Name = "лініяToolStripMenuItem";
            this.лініяToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.лініяToolStripMenuItem.Text = "Лінія";
            this.лініяToolStripMenuItem.Click += new System.EventHandler(this.лініяToolStripMenuItem_Click);
            // 
            // налаштуванняФігуриToolStripMenuItem
            // 
            this.налаштуванняФігуриToolStripMenuItem.Name = "налаштуванняФігуриToolStripMenuItem";
            this.налаштуванняФігуриToolStripMenuItem.Size = new System.Drawing.Size(404, 52);
            this.налаштуванняФігуриToolStripMenuItem.Text = "Налаштування фігури";
            this.налаштуванняФігуриToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняФігуриToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(617, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1266, 532);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.полігонToolStripMenuItem_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 55);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 779);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem фігуриToolStripMenuItem;
        private ToolStripMenuItem еліпсToolStripMenuItem;
        private ToolStripMenuItem прямокутникToolStripMenuItem;
        private ToolStripMenuItem полігонToolStripMenuItem;
        private ToolStripMenuItem тестToolStripMenuItem;
        private ToolStripMenuItem лініяToolStripMenuItem;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ToolStripMenuItem налаштуванняФігуриToolStripMenuItem;
    }
}