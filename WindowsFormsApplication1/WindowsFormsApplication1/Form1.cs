using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сельхозDataSet.dobavki". При необходимости она может быть перемещена или удалена.
            this.dobavkiTableAdapter.Fill(this.сельхозDataSet.dobavki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сельхозDataSet.uchot". При необходимости она может быть перемещена или удалена.
            this.uchotTableAdapter.Fill(this.сельхозDataSet.uchot);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сельхозDataSet.predpr". При необходимости она может быть перемещена или удалена.
            this.predprTableAdapter.Fill(this.сельхозDataSet.predpr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Predpr f3 = new Predpr();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uchot f4 = new Uchot();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dobavki f2 = new Dobavki();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report f5 = new Report();
            f5.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.predprTableAdapter.Update(сельхозDataSet);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.uchotTableAdapter.Update(сельхозDataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.dobavkiTableAdapter.Update(сельхозDataSet);
        }
    }
}
