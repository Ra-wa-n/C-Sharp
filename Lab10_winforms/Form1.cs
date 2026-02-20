namespace Lab10_winforms
{
    public partial class Form1 : Form
    {
        ListView lastFocusedList;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }
        private void ShowDrives(ListView lv)
        {
            lv.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    ListViewItem item = new ListViewItem(drive.Name);
                    item.Tag = drive.Name;
                    lv.Items.Add(item);
                }
            }
        }
        private void Form1_Load(object? sender, EventArgs e)
        {
            listView1.View = View.List;
            listView2.View = View.List;
            ShowDrives(listView1);
            ShowDrives(listView2);
        }

        void LoadFolders(string path, ListView lv, TextBox tx)
        {
            lv.Items.Clear();
            try
            {
                ListViewItem goDrives = new ListViewItem("..");
                goDrives.Tag = "DRIVES_ROOT";
                goDrives.ForeColor = Color.Blue;
                lv.Items.Add(goDrives);
                ListViewItem goBack = new ListViewItem(".");
                var parent = Directory.GetParent(path);
                goBack.Tag = (parent != null) ? parent.FullName : "DRIVES_ROOT";
                goBack.ForeColor = Color.Green;
                lv.Items.Add(goBack);
                string[] folders = Directory.GetDirectories(path);
                foreach (string folder in folders)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(folder));
                    item.Tag = folder;
                    lv.Items.Add(item);
                }
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    item.Tag = file;
                    lv.Items.Add(item);
                }
                tx.Text = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0)
            {
                string path = lv.SelectedItems[0].Tag.ToString();
                if (path == "DRIVES_ROOT")
                {
                    ShowDrives(lv);
                }
                else if (Directory.Exists(path))
                {
                    if (lv == listView1)
                    {
                        LoadFolders(path, listView1, textBox1);
                    }
                    else
                    {
                        LoadFolders(path, listView2, textBox2);
                    }
                }
                else if (File.Exists(path))
                {
                    MessageBox.Show("This is a file and can't be opened");
                }

            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            lastFocusedList = (ListView)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lastFocusedList != null && lastFocusedList.FocusedItem != null)
            {
                string sourcePath = lastFocusedList.FocusedItem.Tag.ToString();
                string fileName = Path.GetFileName(sourcePath);
                string targetFolder = (lastFocusedList == listView1) ? textBox2.Text : textBox1.Text;
                string destinationPath = Path.Combine(targetFolder, fileName);
                if (lastFocusedList == listView1)
                {
                    targetFolder = textBox2.Text;
                }

                else
                {
                    targetFolder = textBox1.Text;
                }
                destinationPath = Path.Combine(targetFolder, fileName);

                try
                {
                    File.Move(sourcePath, destinationPath);
                    LoadFolders(textBox1.Text, listView1, textBox1);
                    LoadFolders(textBox2.Text, listView2, textBox2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lastFocusedList != null && lastFocusedList.FocusedItem != null)
            {
                string sourcePath = lastFocusedList.FocusedItem.Tag.ToString();
                string fileName = Path.GetFileName(sourcePath);
                string targetFolder = (lastFocusedList == listView1) ? textBox2.Text : textBox1.Text;
                string destinationPath = Path.Combine(targetFolder, fileName);
                if (lastFocusedList == listView1)
                {
                    targetFolder = textBox2.Text;
                }

                else
                {
                    targetFolder = textBox1.Text;
                }
                destinationPath = Path.Combine(targetFolder, fileName);

                try
                {
                    File.Copy(sourcePath, destinationPath);
                    LoadFolders(textBox1.Text, listView1, textBox1);
                    LoadFolders(textBox2.Text, listView2, textBox2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lastFocusedList == null || lastFocusedList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected");
                return;
            }

            var item = lastFocusedList.SelectedItems[0];

            if (item.Tag == null) return;

            string sourcePath = item.Tag.ToString();

            try
            {
                if (sourcePath == "DRIVES_ROOT")
                    return;
                if (File.Exists(sourcePath))
                {
                    File.Delete(sourcePath);
                }
                else if (Directory.Exists(sourcePath))
                {
                    MessageBox.Show("This is a folder and can't be deleted");
                }
                else
                {
                    MessageBox.Show("Invalid item");
                    return;
                }
                LoadFolders(textBox1.Text, listView1, textBox1);
                LoadFolders(textBox2.Text, listView2, textBox2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox currentTextBox = (lastFocusedList == listView1) ? textBox1 : textBox2;

            if (currentTextBox != null && !string.IsNullOrEmpty(currentTextBox.Text))
            {
                var parentDir = Directory.GetParent(currentTextBox.Text);

                if (parentDir != null)
                {
                    LoadFolders(parentDir.FullName, lastFocusedList, currentTextBox);
                }
                else
                {
                    ShowDrives(lastFocusedList);
                }
            }
        }
    }
}
