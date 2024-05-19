using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggHunt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            difficulty.SelectedIndex = 1; //to prevent sending null to Form1
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedDifficulty = difficulty.SelectedIndex.ToString();
            Form1 form1 = new Form1(selectedDifficulty); //funfact: when sending this form without sending difficulty property, the timer in the form1 was running and calling functions all the time
            form1.ShowDialog();
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
