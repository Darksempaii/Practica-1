using StartLine_Core;
using System;
using System.Windows.Forms;

namespace Start_Line_ejecutable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Acerca = new AboutBox1();
            Acerca.Show();
        }

        private void libreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Libreria = new Form2();
            Libreria.Show();
        }

        private void Vplayer_Click(object sender, EventArgs e)
        {
            Form VPlayer = new Reproductor();
            VPlayer.Show();
        }

        private void MPlayer_Click(object sender, EventArgs e)
        {
            Form MPlayer = new Mplayer();
            MPlayer.Show();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            Form Calculadora = new Calc();
            Calculadora.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipText = "minimizando en la barra de tareas";
                notifyIcon.BalloonTipTitle = "Start Line";
                notifyIcon.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon.ShowBalloonTip(10000);



            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
