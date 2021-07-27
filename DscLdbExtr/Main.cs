using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DscLdbExtr
{
    public partial class DscLdbExtr : Form
    {
        public DscLdbExtr()
        {
            InitializeComponent();
        }

        async void nothingFound()
        {
            colorPanel.BackColor = Color.Red;
            await Task.Delay(500);
            colorPanel.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            dropText.ForeColor = Color.FromArgb(200, 200, 200);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string content = File.ReadAllText(file);
                
                Match match = Regex.Match(content, "(?<=oken)(.*)(?=\")", RegexOptions.RightToLeft);
                if (match.Success)
                {
                    content = match.Value + '"';
                    Match match2 = Regex.Match(content, "\"(.*?)\"");
                    if (match2.Success)
                    {
                        string token = match2.Value;
                        if(token.Contains(".")) gridView.Rows.Add(token);
                        else nothingFound();
                    }
                } 
                else
                {
                    nothingFound();
                }
            }
        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
                dropText.ForeColor = Color.FromArgb(80, 80, 80);
            }
        }

        private void dropPanel_DragLeave(object sender, EventArgs e)
        {
            dropText.ForeColor = Color.FromArgb(200, 200, 200);
        }
    }
}