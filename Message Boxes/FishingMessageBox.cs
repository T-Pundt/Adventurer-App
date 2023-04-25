using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FishingMessageBox : Form
    {
        public string DataFromFormtwo
        {
            get { return DisplayCurrentDepthForTrackBar.Text; }
        }


        public FishingMessageBox()
        {
            InitializeComponent();
        }

        private void FishingMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TimerToUpdateDepthBar_Tick(object sender, EventArgs e)
        {
            if (WaterDepthBar.Value == 100)
            {
                DisplayCurrentDepthForTrackBar.Text = ">100";
            }
            else
            {
                DisplayCurrentDepthForTrackBar.Text = WaterDepthBar.Value.ToString();
            }
        }
    }
}
