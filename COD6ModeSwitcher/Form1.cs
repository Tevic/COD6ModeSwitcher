using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Reflection;

namespace COD6ModeSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSingle_Click(object sender, EventArgs e)
        {
            FileInfo FStreamAPI = new FileInfo("steam_api.single.dll");
            if (FStreamAPI.Exists)
            {
                File.Copy("steam_api.single.dll", "steam_api.dll", true);
                BtnSingle.Enabled = false;
                BtnMulti.Enabled = true;
                LabelCurMode.Text = "Current Mode : SinglePlayer";
                MessageBox.Show("Switch To SinglePlayer Success!", "Mode Switch", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can't Find steam_api.single.dll !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Environment.Exit(0);
            }

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            FileInfo FStreamAPI = new FileInfo("steam_api.single.dll");
            if (FStreamAPI.Exists)
            {
                File.Copy("steam_api.multi.dll", "steam_api.dll", true);
                BtnMulti.Enabled = false;
                BtnSingle.Enabled = true;
                LabelCurMode.Text = "Current Mode : MultiPlayer";
                MessageBox.Show("Switch To MultiPlayer Success!\nDo You Want To Start Game Now?", "Mode Switch", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can't Find steam_api.multi.dll !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelAbout.Text += Environment.OSVersion.ToString();
            FileInfo FStreamAPI = new FileInfo("steam_api.dll");
            if (FStreamAPI.Exists)
            {
                //写出文件
                if (!File.Exists("steam_api.multi.dll"))
                {
                    byte[] steamFile = Properties.Resources.steam_api_multi;
                    File.WriteAllBytes("steam_api.multi.dll", steamFile);
                }

                if (!File.Exists("steam_api.single.dll"))
                {
                    byte[] steamFile = Properties.Resources.steam_api_single;
                    File.WriteAllBytes("steam_api.single.dll", steamFile);
                }

                //判断当前模式
                if (FStreamAPI.Length > 115961 && FStreamAPI.Length < 223233)
                {
                    LabelCurMode.Text = "Current Mode : MultiPlayer";
                    BtnMulti.Enabled = false;
                }
                else if (FStreamAPI.Length < 115961)
                {
                    LabelCurMode.Text = "Current Mode : SinglePlayer";
                    BtnSingle.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please Put The Executable File Into COD6 Directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Environment.Exit(0);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (LabelCurMode.Text == "Current Mode : SinglePlayer")
            {
                if (File.Exists("iw4sp.exe"))
                    System.Diagnostics.Process.Start("iw4sp.exe");
                else
                    MessageBox.Show("Can't Find Executable File!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LabelCurMode.Text == "Current Mode : MultiPlayer")
            {
                if (File.Exists("iw4mp.exe"))
                    System.Diagnostics.Process.Start("iw4mp.exe");
                else
                    MessageBox.Show("Can't Find Executable File!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
