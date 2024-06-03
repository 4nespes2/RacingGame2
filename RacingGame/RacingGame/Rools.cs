using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RacingGame
{
    public partial class Rools : Form
    {
        Thread th;
        public Rools()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opengame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void opengame(object obj)
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openmenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openmenu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
