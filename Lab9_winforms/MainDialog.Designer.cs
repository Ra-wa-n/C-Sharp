namespace Lab9_winforms
{
    partial class MainDialog : Form
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
            button1 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            FontTab = new TabPage();
            courier = new RadioButton();
            arial = new RadioButton();
            timesnew = new RadioButton();
            SizeTab = new TabPage();
            s24 = new RadioButton();
            s20 = new RadioButton();
            s16 = new RadioButton();
            ColorTab = new TabPage();
            button3 = new Button();
            TextTab = new TabPage();
            old = new Label();
            newstr = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            FontTab.SuspendLayout();
            SizeTab.SuspendLayout();
            ColorTab.SuspendLayout();
            TextTab.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(141, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(500, 404);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(SizeTab);
            tabControl1.Controls.Add(FontTab);
            tabControl1.Controls.Add(ColorTab);
            tabControl1.Controls.Add(TextTab);
            tabControl1.Location = new Point(-2, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(809, 369);
            tabControl1.TabIndex = 2;
            // 
            // FontTab
            // 
            FontTab.Controls.Add(courier);
            FontTab.Controls.Add(arial);
            FontTab.Controls.Add(timesnew);
            FontTab.Location = new Point(4, 34);
            FontTab.Name = "FontTab";
            FontTab.Padding = new Padding(3);
            FontTab.Size = new Size(801, 331);
            FontTab.TabIndex = 0;
            FontTab.Text = "Font";
            FontTab.UseVisualStyleBackColor = true;
            // 
            // courier
            // 
            courier.AutoSize = true;
            courier.Location = new Point(311, 195);
            courier.Name = "courier";
            courier.Size = new Size(94, 29);
            courier.TabIndex = 2;
            courier.TabStop = true;
            courier.Text = "Courier";
            courier.UseVisualStyleBackColor = true;
            courier.CheckedChanged += FontRadio_CheckedChanged;
            // 
            // arial
            // 
            arial.AutoSize = true;
            arial.Location = new Point(311, 121);
            arial.Name = "arial";
            arial.Size = new Size(72, 29);
            arial.TabIndex = 1;
            arial.TabStop = true;
            arial.Text = "Arial";
            arial.UseVisualStyleBackColor = true;
            arial.CheckedChanged += FontRadio_CheckedChanged;
            // 
            // timesnew
            // 
            timesnew.AutoSize = true;
            timesnew.Location = new Point(311, 35);
            timesnew.Name = "timesnew";
            timesnew.Size = new Size(128, 54);
            timesnew.TabIndex = 0;
            timesnew.TabStop = true;
            timesnew.Text = "Times New \r\nRoman";
            timesnew.UseVisualStyleBackColor = true;
            timesnew.CheckedChanged += FontRadio_CheckedChanged;
            // 
            // SizeTab
            // 
            SizeTab.Controls.Add(s24);
            SizeTab.Controls.Add(s20);
            SizeTab.Controls.Add(s16);
            SizeTab.Location = new Point(4, 34);
            SizeTab.Name = "SizeTab";
            SizeTab.Padding = new Padding(3);
            SizeTab.Size = new Size(801, 331);
            SizeTab.TabIndex = 1;
            SizeTab.Text = "Size";
            SizeTab.UseVisualStyleBackColor = true;
            // 
            // s24
            // 
            s24.AutoSize = true;
            s24.Location = new Point(309, 210);
            s24.Name = "s24";
            s24.Size = new Size(57, 29);
            s24.TabIndex = 2;
            s24.Text = "24";
            s24.UseVisualStyleBackColor = true;
            s24.CheckedChanged += SizeRadio_CheckedChanged;
            // 
            // s20
            // 
            s20.AutoSize = true;
            s20.Location = new Point(309, 129);
            s20.Name = "s20";
            s20.Size = new Size(57, 29);
            s20.TabIndex = 1;
            s20.Text = "20";
            s20.UseVisualStyleBackColor = true;
            s20.CheckedChanged += SizeRadio_CheckedChanged;
            // 
            // s16
            // 
            s16.AutoSize = true;
            s16.Location = new Point(309, 49);
            s16.Name = "s16";
            s16.Size = new Size(57, 29);
            s16.TabIndex = 0;
            s16.Text = "16";
            s16.UseVisualStyleBackColor = true;
            s16.CheckedChanged += SizeRadio_CheckedChanged;
            // 
            // ColorTab
            // 
            ColorTab.Controls.Add(button3);
            ColorTab.Location = new Point(4, 34);
            ColorTab.Name = "ColorTab";
            ColorTab.Size = new Size(801, 331);
            ColorTab.TabIndex = 2;
            ColorTab.Text = "Color";
            ColorTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(258, 125);
            button3.Name = "button3";
            button3.Size = new Size(194, 47);
            button3.TabIndex = 0;
            button3.Text = "Choose Color";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TextTab
            // 
            TextTab.Controls.Add(old);
            TextTab.Controls.Add(newstr);
            TextTab.Controls.Add(textBox2);
            TextTab.Controls.Add(textBox1);
            TextTab.Location = new Point(4, 34);
            TextTab.Name = "TextTab";
            TextTab.Size = new Size(801, 331);
            TextTab.TabIndex = 3;
            TextTab.Text = "Text";
            TextTab.UseVisualStyleBackColor = true;
            // 
            // old
            // 
            old.AutoSize = true;
            old.Location = new Point(139, 75);
            old.Name = "old";
            old.Size = new Size(76, 25);
            old.TabIndex = 3;
            old.Text = "Old Text";
            // 
            // newstr
            // 
            newstr.AutoSize = true;
            newstr.Location = new Point(139, 155);
            newstr.Name = "newstr";
            newstr.Size = new Size(82, 25);
            newstr.TabIndex = 2;
            newstr.Text = "New Text";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(340, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(340, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // MainDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainDialog";
            Text = "MainDialog";
            tabControl1.ResumeLayout(false);
            FontTab.ResumeLayout(false);
            FontTab.PerformLayout();
            SizeTab.ResumeLayout(false);
            SizeTab.PerformLayout();
            ColorTab.ResumeLayout(false);
            TextTab.ResumeLayout(false);
            TextTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage FontTab;
        private TabPage SizeTab;
        private TabPage ColorTab;
        private TabPage TextTab;
        private RadioButton courier;
        private RadioButton arial;
        private RadioButton timesnew;
        private RadioButton s16;
        private RadioButton s24;
        private RadioButton s20;
        private Button button3;
        private Label old;
        private Label newstr;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}