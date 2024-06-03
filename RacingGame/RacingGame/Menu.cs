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
    public partial class Menu : Form
    {
        Thread th;
        public Menu()
        {
            InitializeComponent();
            form1 = new Form1();
        }
        Form1 form1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //form1.Show();
            //this.Hide();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void open(object obj)
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openr);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openr(object obj)
        {
            Application.Run(new Rools());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
