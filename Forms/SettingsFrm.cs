using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTravelApp.Forms
{
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm mainFrm = new MainFrm();
            mainFrm.Show();
        }

        private void engBtn_Click(object sender, EventArgs e)
        {
            rusBtn.Text = "Rus";
            engBtn.Text = "Eng";
        }

        private void SettingsFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm mainFrm = new MainFrm();
            mainFrm.Show();
        }
    }
}
