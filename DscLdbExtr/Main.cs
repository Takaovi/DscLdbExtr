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

        Regex regex = new Regex("mfa(.*)\"");

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
                Match match = regex.Match(content);
                if (match.Success)
                {
                    string token = match.Value.Remove(match.Value.IndexOf('"'));
                    gridView.Rows.Add(token);
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