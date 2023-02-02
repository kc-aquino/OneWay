using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baby_Thesis_Test;

namespace OneWayUI
{
    public partial class FrmBack : Form
    {
        public static FrmBack Instance;
        ButtonBehaviour buttStatus = new ButtonBehaviour();
        public FrmBack()
        {
            InitializeComponent();
            Instance = this;
        }
        
        private void btnB1_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label2.Text, btnB1);          
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label3.Text, btnB2);

        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label4.Text, btnB3);

        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label5.Text, btnB4);

        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label6.Text, btnB5);
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label7.Text, btnB6);
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label8.Text, btnB7);
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label9.Text, btnB8);
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label10.Text, btnB9);
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label11.Text, btnB10);
        }

        private void btnB11_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label12.Text, btnB11);
        }

        private void btnB12_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label13.Text, btnB12);
        }

        private void btnB13_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label14.Text, btnB13);
        }

        private void btnB14_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label15.Text, btnB14);
        }

        private void btnB15_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label16.Text, btnB15);
        }

        private void btnB16_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label17.Text, btnB16);
        }

        private void btnB17_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label18.Text, btnB17);
        }

        private void btnB18_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label19.Text, btnB18);
        }
    }
}
