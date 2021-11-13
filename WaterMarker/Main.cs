using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterMarker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public List<string> files = new List<string>();
        public string waterMark = null;
        int len = 0;

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonChooseFiles_Click(object sender, EventArgs e)
        {

            files.Clear();
            OpenFileDialog dlg = OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
               foreach (string file in dlg.FileNames)
               {
                    files.Add(file);
               }
            }
            len = files.Count;
            LabelCounter.Text = len.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (len != 0 && waterMark != null)
            {
                RoundProgress.Visible = true;
                RoundProgress.Value = 0;
                saveFiles();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tipply.pl/u/agoral");
        }

        

        private void ChooseWaterMark_Click(object sender, EventArgs e)
        {

            waterMark = null;
            OpenFileDialog dial = OpenFileDialog(false);

            if (dial.ShowDialog() == DialogResult.OK)
            {
                waterMark = dial.FileName;
            }
            
        }

        private void saveFiles()
        {
            string executableName = Application.ExecutablePath;
            FileInfo executableFileInfo = new FileInfo(executableName);
            string executableDirectoryName = executableFileInfo.DirectoryName;
            string uploadDirectory = executableDirectoryName + "\\upload";
            if (!Directory.Exists(uploadDirectory))
            {
                DirectoryInfo di = Directory.CreateDirectory(uploadDirectory);
            }
            string filesUploadDir = uploadDirectory + "\\";

            int i = 1;
            foreach(string file in files)
            {
                CombineImages(file, waterMark, filesUploadDir);
                RoundProgress.Value = countPercent(len, i);
                RoundProgress.Text = RoundProgress.Value.ToString() + "%";
                i++;
            }
        }

        private void CombineImages(string filePath, string waterMark, string uploadDir)
        {
            string finalFileName = "waterMarked" + Path.GetFileName(filePath);
            FileInfo fileInfo = new FileInfo(filePath);
            FileInfo waterMarkInfo = new FileInfo(waterMark);

            Image imgFile = Image.FromFile(fileInfo.FullName);
            Image imgWaterMark = Image.FromFile(waterMarkInfo.FullName);
            Image image = resizeImage(imgWaterMark, new Size(imgFile.Width / 2, imgFile.Height / 2));
            imgWaterMark = image;

            Bitmap img3 = new Bitmap(filePath);
            Graphics graphics = Graphics.FromImage(img3);

            graphics.DrawImage(imgWaterMark, new Point(imgFile.Width/2, imgFile.Height/2));
            graphics.Dispose();
            img3.Save(uploadDir + finalFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            img3.Dispose();
        }
        
        public OpenFileDialog OpenFileDialog(bool multi = true)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.RestoreDirectory = true;
            openFile.Title = "Wybierz pliki, które mają zostać poddane obróbce";
            openFile.Multiselect = multi;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            return openFile;
        }

        public int countPercent(int len, int actual)
        {
            return (actual / len) * 100;
        }

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
