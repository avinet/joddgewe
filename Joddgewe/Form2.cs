using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Joddgewe
{
    public partial class Form2 : Form
    {
       // [System.Runtime.InteropServices.DllImport("user32.dll")]
        //internal static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public Form2(Form parent)
        {
            InitializeComponent();
            this.Location = new Point(parent.Location.X + parent.Width - 3 *
                this.Width / 2, parent.Location.Y + parent.Height - 3 * this.Height / 2);
            this.StartPosition = FormStartPosition.Manual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:eirikcsak.knutsen@asplanviak.no?subject=JoddGewe 0.1");
        }


    }
}