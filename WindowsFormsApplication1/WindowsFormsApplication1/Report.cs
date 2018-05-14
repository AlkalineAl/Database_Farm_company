using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(@"Data Source=ALKALINEAL\ALKALINEAL;Initial Catalog=Сельхоз;Integrated Security=True");
            con.Open();
            da.SelectCommand = new SqlCommand(@"Select predpr.predpr, uchot.id_svin_ferm From  predpr INNER JOIN uchot ON predpr.id = uchot.id_predpr Where uchot.Prirost_vesa >" + a + " ", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
