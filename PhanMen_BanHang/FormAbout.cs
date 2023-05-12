using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMen_BanHang
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "mailto:Huynguyen030704@gmail.com";
                process.Start();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "https://github.com/Huynguyen030704/Huynguyen030704";
                process.Start();
            }
        }
    }
}
