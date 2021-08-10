using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cenka_Launcher
{
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
        }
        string discord = "https://discord.gg/rgcjbZaa63";
        private void launcher_Load(object sender, EventArgs e)
        {
            pnlDrag.BackColor = Color.FromArgb(50, 0, 0, 0);
            btnDiscord.BackColor = Color.FromArgb(50, 0, 0, 0);
            btnMTA.BackColor = Color.FromArgb(50, 0, 0, 0);
            btnTS.BackColor = Color.FromArgb(50, 0, 0, 0);
            btnWeb.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMTA_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\MTA San Andreas 1.5\\Multi Theft Auto.exe");
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.chifnat.cf");
        }
    }
}
