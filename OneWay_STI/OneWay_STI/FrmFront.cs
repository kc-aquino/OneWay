using OneWay;
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
    public partial class FrmFront : Form
    {
        public static FrmFront Instance;
        ButtonBehaviour buttStatus = new ButtonBehaviour();
        // balak ko kunin ung label sa full scale at baguhin kada click sa button para dumagdag ung "space occupied"
        public FrmFront()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnF1_Click_1(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label2.Text, btnF1);
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label3.Text, btnF2);
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label4.Text, btnF3);
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label5.Text, btnF4);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label6.Text, btnF5);
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label7.Text, btnF6);
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label8.Text, btnF7);
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label9.Text, btnF8);
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label10.Text, btnF9);
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label11.Text, btnF10);
        }

        private void btnF11_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label12.Text, btnF11);
        }

        private void btnF12_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label1.Text, btnF12);
        }

        private void btnF13_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label13.Text, btnF13);
        }

        private void btnF14_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label14.Text, btnF14);
        }

        private void btnF15_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label15.Text, btnF15);
        }

        private void btnF16_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label16.Text, btnF16);
        }

        private void btnF17_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label17.Text, btnF17);
        }

        private void btnF18_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label18.Text, btnF18);
        }

        private void btnF19_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label19.Text, btnF19);
        }

        private void btnF20_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label20.Text, btnF20);
        }

        private void btnF21_Click(object sender, EventArgs e)
        {
            buttStatus.buttonStatus(label21.Text, btnF21);
        }
    }
}
