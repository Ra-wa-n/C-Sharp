using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab9_winforms
{
    public partial class MainDialog : Form
    {
        //? without this attribute give error
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NewText
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OldString
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Font SelectedFont
        {
            get; set;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float SelectedFontSize { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SelectedColor { get; set; }

        public MainDialog()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = SelectedColor;
            DialogResult colorres = colorDialog.ShowDialog();
            if (colorres == DialogResult.OK)
                SelectedColor = colorDialog.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void SizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (s16.Checked)
                SelectedFontSize = 16;
            else if (s20.Checked)
                SelectedFontSize = 20;
            else if (s24.Checked)
                SelectedFontSize = 24;
        }
        private void FontRadio_CheckedChanged(object sender, EventArgs e)
        {
            string fontName = SelectedFont?.FontFamily.Name ?? "Arial";
            if (courier.Checked)  fontName = "Courier New"; 
            else if (timesnew.Checked) fontName = "Times New Roman"; 
            else if (arial.Checked) fontName = "Arial"; 
            SelectedFont = new Font(fontName, SelectedFontSize);
        }
        
        public void Load()
        {
            textBox1.Text = OldString;
            textBox2.Text = OldString;
            if (SelectedFont.Name == "Times New Roman") timesnew.Checked = true;
            else if (SelectedFont.Name == "Arial") arial.Checked = true;
            else if (SelectedFont.Name == "Courier New") courier.Checked = true;
            float size = SelectedFont.Size;
            if (size == 16) s16.Checked = true;
            else if (size == 20) s20.Checked = true;
            else if (size == 24) s24.Checked = true;
            textBox1.ForeColor = SelectedColor;
        }

    }
}
