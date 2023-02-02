using OneWayUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using OneWay_STI;

namespace Baby_Thesis_Test
{   
    public partial class inputInfo : Form
    {
        public static inputInfo Instance;
        public TextBox parkSpace;
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Kay Cee\\Documents\\OneWayDB.mdf\";Integrated Security=True;Connect Timeout=30";
        int countID;
        public Button buttOccupy;

        public inputInfo()
        {
            InitializeComponent();

            Instance = this;
            parkSpace = txtLot;
            this.ControlBox = false;
            buttOccupy = btnOccupy;
            
        }

        private void inputInfo_Load(object sender, EventArgs e)
        {
            txtTimeIn.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            //So user cannot change the time and parking lot
            txtTimeIn.ReadOnly = true;
            txtLot.ReadOnly = true;
            txtPlateNo.Text = "";
            txtName.Text = "";
        }
        private void btnOccupy_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPlateNo.Text == "" || cbPurpose.SelectedIndex.Equals(null))
            {
                MessageBox.Show("Please input information! Or CLOSE(X) this window.", "Empty information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnOccupy.Enabled = false;
            }
            else
            {
                string strID = countID.ToString();
                String parkingLot = txtLot.Text;
                String timeIn = DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day +
                   " " + DateTime.Now.Hour + (":") + DateTime.Now.Minute + (":") + DateTime.Now.Second;
                String driverName = txtName.Text;
                String plateNo = txtPlateNo.Text;
                String purpose = cbPurpose.SelectedItem.ToString();
                // input to form 1 label variable'
                btnOccupy.Enabled = true;

                String query = "INSERT INTO STI_OneWay VALUES ((Select ISNULL(Max(ID)+1,1) From STI_OneWay), @ParkingLot, @Name, @PlateNo, @Purpose, @TimeIn)";
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", countID);
                cmd.Parameters.AddWithValue("@Name", driverName);
                cmd.Parameters.AddWithValue("@ParkingLot", parkingLot);
                cmd.Parameters.AddWithValue("@PlateNo", plateNo);
                cmd.Parameters.AddWithValue("@Purpose", purpose);
                cmd.Parameters.AddWithValue("@TimeIn", timeIn);

                MessageBox.Show("Successfully inserted into the OneWay Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //So user cannot escape with inputting the data, it will only minimize the tab
                //this.FormClosed += (_s, _e) => this.Enabled = true;
                this.Close();
            }
        
        }

        private void pbClose_MouseHover_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void pbClose_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }

    
}
