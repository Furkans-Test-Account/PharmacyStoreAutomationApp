using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgProject
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();

            labelLoading.Text = "Saving/Updating...";
            timer1.Start();

        }
    
        // Yukleme formu icin timer 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 50; // Saniyede 50 arttırma
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Success!");
                this.Close();
            }
        }

        private void LoadingForm_Load_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 saniye 
            // progress bar verileri
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
        }
    }
}
