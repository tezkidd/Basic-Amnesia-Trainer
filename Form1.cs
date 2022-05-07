using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Memory;
using System.Diagnostics;

namespace Amnesia_Trainer
{
    public partial class Form1 : Form
    {

        Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
            CheckGameRunning.Start();
        }

        private void CheckGameRunning_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Amnesia").Count() > 0)
            {
                m.OpenProcess("Amnesia");
                CheckGameRunningLabel.Text = "Game Found!";
                CheckGameRunningLabel.ForeColor = Color.Green;
                CheckGameRunningLabel2.Text = "Game Found!";
                CheckGameRunningLabel2.ForeColor = Color.Green;

                return;
            }

        }


        private void HealthCheck_CheckedChanged(object sender) //first
        {
            if (HealthCheck.Checked)
                m.FreezeValue("base+00768C54,54,38,84", "Float", "100");
            else
            {
                if (!HealthCheck.Checked)
                    m.UnfreezeValue("base+00768C54,54,38,84");
            }
        }

        private void SanityCheck_CheckedChanged(object sender)
        {
            if (SanityCheck.Checked)
                m.FreezeValue("base+00768C54,54,38,88", "Float", "100");
            else
            {
                if (!SanityCheck.Checked)
                    m.UnfreezeValue("base+00768C54,54,38,88");
            }
        }

        private void LanternOilCheck_CheckedChanged(object sender)
        {
            if (LanternOilCheck.Checked)
                m.FreezeValue("base+00768C54,84,8C", "Float", "100");
            else
            {
                if (!LanternOilCheck.Checked)
                    m.UnfreezeValue("base+00768C54,84,8C");
            }
        }

        private void TinderBoxCheck_CheckedChanged(object sender)
        {
            if (TinderBoxCheck.Checked)
                m.FreezeValue("base+00768C54,84,264,30,98", "int", "999");
            else
            {
                if (!TinderBoxCheck.Checked)
                    m.UnfreezeValue("base+00768C54,84,264,30,98");
            }
        }

        private void OilCheck_CheckedChanged(object sender)
        {
            if (OilCheck.Checked)
                m.FreezeValue("base+00768C54,78,7C,4,B4", "int", "999");
            else
            {
                if (!OilCheck.Checked)
                    m.UnfreezeValue("base+00768C54,78,7C,4,B4");
            }
        }

        private void WalkSpeedCheck_CheckedChanged(object sender)
        {
            if (WalkSpeedCheck.Checked)
                m.FreezeValue("base+00768C54,418,1C,D4", "Float", "2");
            else
            {
                m.FreezeValue("base+00768C54,418,1C,D4", "Float", "1");
            }
        }

        private void RunSpeedCheck_CheckedChanged(object sender)
        {
            if (RunSpeedCheck.Checked)
                m.FreezeValue("base+00768C54,84,D0", "Float", "2");
            else
            {
                if (!RunSpeedCheck.Checked)
                    m.FreezeValue("base+00768C54,84,D0", "Float", "1");
            }
        }

        private void CrouchSpeedCheck_CheckedChanged(object sender)
        {
            if (CrouchSpeedCheck.Checked)
                m.FreezeValue("base+00768C54,54,38,D8", "Float", "2");
            else
            {
                m.FreezeValue("base+00768C54,54,38,D8", "Float", "1");
            }
        }

        private void JumpHeightCheck_CheckedChanged(object sender)
        {
            if (JumpHeightCheck.Checked)
                m.FreezeValue("base+00768C54,418,0,38,E4", "Float", "2");
            else
            {
                m.FreezeValue("base+00768C54,418,0,38,E4", "Float", "1");
            }
        }

        private void Info1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trainer Created By: tezkidd");
        }

        private void Info2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trainer Created By: LASANGEMAN \nWith help from: IStrikeoutI");
        }
    }
}
