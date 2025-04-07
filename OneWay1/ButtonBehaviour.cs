using Baby_Thesis_Test;
using OneWay;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWayUI
{
    class ButtonBehaviour
    {
        //FrmFullScale frmFullScale = new FrmFullScale();
        public void buttonStatus(string space, Button butt)
        {
            if (butt.BackColor == Color.FromArgb(255, 193, 94))//yellow
            {
                // Button properties (you can change it)
                butt.BackColor = Color.Red;
                butt.Text = "Occupied\n" + DateTime.Now.ToLongTimeString();
                butt.ForeColor = Color.White;
                //frmFullScale.count++;
                

                // this code is for the form to input details
                inputInfo inputInfo = new inputInfo();
                inputInfo.Show();

                //get
                inputInfo.Instance.parkSpace.Text = space;
            }
            else if(butt.BackColor == Color.Red)
            {
                butt.BackColor = Color.FromArgb(255, 193, 94);
                butt.Text = "Available";
                butt.ForeColor = Color.FromArgb(16, 52, 84);
                
                //frmFullScale.count--;
                //timeOut.Text = DateTime.Now.ToLongTimeString();
                //Will put in the button... or nah?

                MessageBox.Show("Cleared Space!" + Environment.NewLine + inputInfo.Instance.parkSpace.Text);
            }
            
        } 

    }
}
