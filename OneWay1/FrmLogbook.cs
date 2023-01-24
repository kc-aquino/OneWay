using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWay1
{
    public partial class FrmLogbook : Form
    {
        public FrmLogbook()
        {
            InitializeComponent();
        }

        private void FrmLogbook_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ParkingInfo";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kc\Desktop\OneWay1-20230120T174530Z-001\OneWay1\OneWay1\dbAccountsDatabase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand= cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
