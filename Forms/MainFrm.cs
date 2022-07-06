using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM refEmployee WHERE Login = @uL AND Password = @uP", db.getConnection());
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginEmployee;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = passEmployee;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Успешная авторизация!");
            else
                MessageBox.Show("Введен неверный логин или пароль.");
        }
    }
}
