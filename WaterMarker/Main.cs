using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Main_Load(object sender, EventArgs e)
        {
            Placement.BackColor = Color.FromArgb(84, 0, 214);

        }

        private void ButtonChooseFiles_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }


        private void Placement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseFiles_MouseEnter(object sender, EventArgs e)
        {
            ButtonChooseFiles.UseVisualStyleBackColor = false;
            ButtonChooseFiles.BackColor = Color.Transparent;
        }
        private void ChooseFiles_MouseLeave(object sender, EventArgs e)
        {
            ButtonChooseFiles.UseVisualStyleBackColor = true;
        }

        private void ChooseFiles_MouseHover(object sender, EventArgs e)
        {
            ButtonChooseFiles.UseVisualStyleBackColor = false;
            ButtonChooseFiles.BackColor = Color.Transparent;
        }
    }
}
