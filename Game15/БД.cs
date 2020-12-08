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
    public partial class БД : Form
    {
        public БД()
        {
            InitializeComponent();
        }

        private void БД_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "игрокиDataSet.Игроки". При необходимости она может быть перемещена или удалена.
            this.игрокиTableAdapter.Fill(this.игрокиDataSet.Игроки);

        }
    }
}
