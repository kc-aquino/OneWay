using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWayUI
{
    public partial class FrmSide : Form
    {
        
        public static FrmSide Instance;
        ButtonBehaviour buttStatus = new ButtonBehaviour();
        public FrmSide()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label2.Text, btnS1);
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label3.Text, btnS2);
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label4.Text, btnS3);
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label5.Text, btnS4);
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label6.Text, btnS5);
        }

        private void btnS6_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label7.Text, btnS6);
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label8.Text, btnS7);
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label9.Text, btnS8);
        }
    }
}
