using Baby_Thesis_Test;
using OneWay;
using OneWayUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWay
{
    public partial class FrmFullScale : Form
    {
        public static FrmFullScale Instance;
        //FrmHome frmHome = new FrmHome();
        // eh baka burahin na mga to kung di magawa lmao
        public Label front;
        public Label back;
        public Label gazebo;
        public Label motors;
        public Label side;
        public Label bikes;
        public int count = 0;
        public FrmFullScale()
        {
            InitializeComponent();
            Instance = this;
            front = lblFront;
            back = lblBack;
            gazebo = lblGazebo;
            motors = lblMotor;
            side = lblSide;
            bikes = lblBikes;

        }

        
    }
}
