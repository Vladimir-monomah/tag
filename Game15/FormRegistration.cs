using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game15
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        double cl;

        private void button1_Click(object sender, EventArgs e)
        {
            var student = this.игрокиDataSet.Игроки.NewИгрокиRow();
            student.ФИО = this.userNameTextBox.Text;

            this.игрокиDataSet.Игроки.AddИгрокиRow(student);

            this.игрокиTableAdapter.Adapter.Update(this.игрокиDataSet.Игроки);

            FormGame15 открыть = new FormGame15();
            открыть.ShowDialog();
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

    }
}
