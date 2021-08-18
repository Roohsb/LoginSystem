using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        int r = 255, g = 0, b = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        //--Botão de efetuar o login --//
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "testelogin" && textBox2.Text == "testesenha")
            {
                MessageBox.Show("Você efetuou o login!!");
                Process.Start("https://github.com/Roohsb/LoginSystem");
            }
            else
            {
                MessageBox.Show("Verifique o login e senha!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        //--Fechar Form--//
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://facebook.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://instagram.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://twitter.com");
        }

        //--Label De forgot password --//
        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Roohsb/LoginSystem");
        }


        //--RGB SYSTEM--//
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(r, g, b);
            panel1.BackColor = Color.FromArgb(r, g, b);
            panel2.BackColor = Color.FromArgb(r, g, b);
            textBox1.ForeColor = Color.FromArgb(r, g, b);
            textBox2.ForeColor = Color.FromArgb(r, g, b);
            label1.ForeColor = Color.FromArgb(r, g, b);

            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }

            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }

            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }
        }
    }
}
