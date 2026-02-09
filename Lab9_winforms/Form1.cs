using System.ComponentModel;

namespace Lab9_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDialog mainDialog = new MainDialog();
            mainDialog.OldString = label1.Text;
            mainDialog.SelectedFont = label1.Font;
            mainDialog.SelectedFontSize = label1.Font.Size;
            mainDialog.SelectedColor = label1.ForeColor;
            mainDialog.Load();  
            DialogResult result = mainDialog.ShowDialog();
            if (result == DialogResult.OK) {
                if (!string.IsNullOrWhiteSpace(mainDialog.NewText))
                {
                    label1.Text = mainDialog.NewText;
                }
                if (mainDialog.SelectedFont != null && mainDialog.SelectedFontSize>0)
                  label1.Font = new Font(mainDialog.SelectedFont.FontFamily, mainDialog.SelectedFontSize);
       
                  label1.ForeColor = mainDialog.SelectedColor;
                
            }
        }
     



    }
}
