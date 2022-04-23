using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFalarmaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayedTime.Text = DateTime.Now.ToString("hh:mm:ss:f-dd/MM/yyyy");

            if (radioButtonActivateAlarm.Checked)
            {
                if (displayedTime.Text == textBoxAlarm.Text)
                {
                    System.Diagnostics.Process.Start("alarma.mp3");
                    MessageBox.Show("Alarma!!!");
                }
            }
        }
    }
}
