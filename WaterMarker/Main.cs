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

        public string[] files = null; 

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonChooseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RoundProgress.Visible = true;
            RoundProgress.Value = 55;
        }


        private void Placement_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        public void OpenFileDialog()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.RestoreDirectory = true;
            openFile.Title = "Wybierz pliki, które mają zostać poddane obróbce";
            openFile.Multiselect = true;
            openFile.ShowDialog(this);
        }
    }
}
