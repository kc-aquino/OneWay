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
        inputInfo inputI;
        private Button butt1;

        public void buttonStatus(string space, Button butt)
        {
           /* show form2
            if(form2.button1.clicked)
            {
            form1.parkbutton = red
            occupy text
           }
            if form1.parkbutton = red
           {
            form1.parkbutton = yellow
            }
            */

            if (butt.BackColor == Color.FromArgb(255, 193, 94))//yellow
            {
                butt1 = butt;

                // this code is for the form to input details
                inputI = new inputInfo();
                inputI.Show();
                inputI.buttOccupy.Click += InputInfo_ButtonClicked;

                //get
                inputInfo.Instance.parkSpace.Text = space;
            }
            else if(butt.BackColor == Color.Red)
            {
                butt.BackColor = Color.FromArgb(255, 193, 94);
                butt.Text = "Available";
                butt.ForeColor = Color.FromArgb(16, 52, 84);
                //timeOut.Text = DateTime.Now.ToLongTimeString();
                //Will put in the button... or nah?

                MessageBox.Show("Cleared Space!" + Environment.NewLine + inputInfo.Instance.parkSpace.Text);
            }
        }
        private void InputInfo_ButtonClicked(object sender, EventArgs e)
        {
            if (inputI.buttOccupy.Enabled)
            {
                // Button properties (you can change it) *Auq nga -Kc
                butt1.BackColor = Color.Red;
                butt1.Text = "Occupied\n" + DateTime.Now.ToLongTimeString();
                butt1.ForeColor = Color.White;
            }
        }
    }
}

