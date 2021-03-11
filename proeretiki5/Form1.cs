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

namespace proeretiki5
{
    
    public partial class Form1 : Form
    {
        long count;
        public Stopwatch watch = new Stopwatch();
        string v = "Χρειάζεται για να υπολογίσει" ;
        string s = " seconds!";
        double devil = 666;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            watch.Start();
            for (int i = 0; i < int.MaxValue; i++)
                count++;
            watch.Stop();
            MessageBox.Show(v + " έναν μεγάλο θετικό αριθμό, " + watch.Elapsed.TotalSeconds.ToString() + s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            watch.Start();
            for (int i = 0; i > int.MinValue; i--)
                count--;
            watch.Stop();
            MessageBox.Show(v + " έναν μεγάλο αρνητικό αριθμό, " + watch.Elapsed.TotalSeconds.ToString() + s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            watch.Start();
            Math.Sin(devil);
            watch.Stop();
            MessageBox.Show(v + " τo sin του 666, " + watch.Elapsed.TotalMilliseconds.ToString() + " milli" + s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            watch.Start();
            Math.Cos(devil);
            watch.Stop();
            MessageBox.Show(v + " το cos του 666, " +watch.Elapsed.TotalMilliseconds.ToString() + " milli" + s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            watch.Start();
            Math.Tan(devil);
            watch.Stop();
            MessageBox.Show(v + " το tan του 666, " + watch.Elapsed.TotalMilliseconds.ToString() + " milli" + s);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            watch.Start();
            Math.Sqrt(devil);
            watch.Stop();
            MessageBox.Show(v + " την ρίζα του 666, " + watch.Elapsed.TotalMilliseconds.ToString() + " milli" + s);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            watch.Start();
            Math.Pow(devil, 69);
            watch.Stop();
            MessageBox.Show(v + " το 666^69, " + watch.Elapsed.TotalMilliseconds.ToString() + " milli" + s);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(exit == DialogResult.No)
            {
                e.Cancel = true;
            }
               
            
        }
    }
}
