using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UI_Click(object sender, EventArgs e)
        {

        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            panel3.Height = menu_btn.Height;
            panel3.Top = menu_btn.Top;
            panel3.Left = menu_btn.Left;
            menu_btn.BackColor = Color.FromArgb(57, 104, 143);
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            panel3.Height = info_btn.Height;
            panel3.Top = info_btn.Top;
            panel3.Left = info_btn.Left;
            info_btn.BackColor = Color.FromArgb(57, 104, 143);
        }

        private void text_btn_Click(object sender, EventArgs e)
        {
            panel3.Height = text_btn.Height;
            panel3.Top = text_btn.Top;
            panel3.Left = text_btn.Left;
            text_btn.BackColor = Color.FromArgb(57, 104, 143);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            panel3.Height = update_btn.Height;
            panel3.Top = update_btn.Top;
            panel3.Left = update_btn.Left;
            update_btn.BackColor = Color.FromArgb(57, 104, 143);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            panel3.Height = about_btn.Height;
            panel3.Top = about_btn.Top;
            panel3.Left = about_btn.Left;
            about_btn.BackColor = Color.FromArgb(57, 104, 143);
        }

        private void update_btn_Leave(object sender, EventArgs e)
        {
            update_btn.BackColor = Color.FromArgb(22, 40, 60);
        }

        private void text_btn_Leave(object sender, EventArgs e)
        {
            text_btn.BackColor = Color.FromArgb(22, 40, 60);
        }

        private void info_btn_Leave(object sender, EventArgs e)
        {
            info_btn.BackColor = Color.FromArgb(22, 40, 60);
        }

        private void menu_btn_Leave(object sender, EventArgs e)
        {
            menu_btn.BackColor = Color.FromArgb(22, 40, 60);
        }

        private void about_btn_Leave(object sender, EventArgs e)
        {
            about_btn.BackColor = Color.FromArgb(22, 40, 60);
        }
    }
}
