﻿using OneWayUI;
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
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Laptop_Codes\Github\OneWay\OneWay1\dbAccountsDatabase.mdf;Integrated Security=True";
        int countID;

        public inputInfo()
        {
            InitializeComponent();

            Instance = this;
            parkSpace = txtLot;
            this.ControlBox = false;
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
            string strID = countID.ToString();
            String parkingLot = txtLot.Text.Trim();
            String timeIn = txtTimeIn.Text.Trim();
            String driverName = txtName.Text.Trim();
            String plateNo = txtPlateNo.Text.Trim();
            String purpose = cbPurpose.SelectedItem != null ? cbPurpose.SelectedItem.ToString() : "";

            if (string.IsNullOrWhiteSpace(driverName) ||
            string.IsNullOrWhiteSpace(plateNo) ||
            string.IsNullOrWhiteSpace(purpose))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // input to form 1 label variable'
            //Instance.parkSpace.Text = txtLot.Text + ": " + txtPlateNo.Text;
            Instance.Enabled = true;

            String query = "INSERT INTO ParkingInfo VALUES (@ParkingLot, @Name, @PlateNo, @Purpose, @TimeIn)";
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", driverName);
            cmd.Parameters.AddWithValue("@ParkingLot", parkingLot);
            cmd.Parameters.AddWithValue("@PlateNo", plateNo);
            cmd.Parameters.AddWithValue("@Purpose", purpose);
            cmd.Parameters.AddWithValue("@TimeIn", timeIn.ToString());

            MessageBox.Show("Successfully inserted into the OneWay Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //So user cannot escape with inputting the data, it will only minimize the tab
            this.FormClosed += (_s, _e) => this.Enabled = true;
            this.Close();
        }

    }
}
