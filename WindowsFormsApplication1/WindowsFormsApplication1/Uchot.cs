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
    public partial class Uchot : Form
    {
        public Uchot()
        {
            InitializeComponent();
        }

        private void Uchot_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сельхозDataSet.uchot". При необходимости она может быть перемещена или удалена.
            this.uchotTableAdapter.Fill(this.сельхозDataSet.uchot);

        }
    }
}
