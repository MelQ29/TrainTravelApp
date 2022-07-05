using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTravelApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            String loginEmployee = loginTB.Text; // переменная которая берет данные Логина из текст бокса
            String passEmployee = passTB.Text; // переменная которая берет данные Пароля из текст бокса

            //DB
        }
    }
}
