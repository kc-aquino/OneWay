namespace Baby_Thesis_Test
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnLogBook = new System.Windows.Forms.Button();
            this.btnP_Back = new System.Windows.Forms.Button();
            this.btnP_FullScale = new System.Windows.Forms.Button();
            this.btnP_Front = new System.Windows.Forms.Button();
            this.btnP_GazeMoto = new System.Windows.Forms.Button();
            this.btnP_Side = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(84)))));
            this.pnlTabs.Controls.Add(this.pbLogout);
            this.pnlTabs.Controls.Add(this.pbMinimize);
            this.pnlTabs.Controls.Add(this.pbClose);
            this.pnlTabs.Controls.Add(this.btnLogBook);
            this.pnlTabs.Controls.Add(this.btnP_Back);
            this.pnlTabs.Controls.Add(this.btnP_FullScale);
            this.pnlTabs.Controls.Add(this.btnP_Front);
            this.pnlTabs.Controls.Add(this.btnP_GazeMoto);
            this.pnlTabs.Controls.Add(this.btnP_Side);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1238, 110);
            this.pnlTabs.TabIndex = 1;
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::OneWay_STI.Properties.Resources.logout;
            this.pbLogout.Location = new System.Drawing.Point(1062, 0);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(48, 48);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogout.TabIndex = 19;
            this.pbLogout.TabStop = false;
            this.toolTip1.SetToolTip(this.pbLogout, "LOGOUT / Go back to LOGIN");
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            this.pbLogout.MouseLeave += new System.EventHandler(this.pbLogout_MouseLeave);
            this.pbLogout.MouseHover += new System.EventHandler(this.pbLogout_MouseHover);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::OneWay_STI.Properties.Resources.minimize;
            this.pbMinimize.Location = new System.Drawing.Point(1127, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(48, 48);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 18;
            this.pbMinimize.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMinimize, "Minimize Application");
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            this.pbMinimize.MouseHover += new System.EventHandler(this.pbMinimize_MouseHover);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::OneWay_STI.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(1190, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(48, 48);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.toolTip1.SetToolTip(this.pbClose, "Exit Application");
            this.pbClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbClose_MouseClick);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            this.pbClose.MouseHover += new System.EventHandler(this.pbClose_MouseHover);
            // 
            // btnLogBook
            // 
            this.btnLogBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(84)))));
            this.btnLogBook.FlatAppearance.BorderSize = 0;
            this.btnLogBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogBook.Font = new System.Drawing.Font("Cooper Black", 22F);
            this.btnLogBook.ForeColor = System.Drawing.Color.White;
            this.btnLogBook.Location = new System.Drawing.Point(1048, 55);
            this.btnLogBook.Name = "btnLogBook";
            this.btnLogBook.Size = new System.Drawing.Size(187, 49);
            this.btnLogBook.TabIndex = 16;
            this.btnLogBook.Text = "E-LogBook";
            this.btnLogBook.UseVisualStyleBackColor = true;
            this.btnLogBook.Click += new System.EventHandler(this.btnLogBook_Click);
            // 
            // btnP_Back
            // 
            this.btnP_Back.FlatAppearance.BorderSize = 0;
            this.btnP_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP_Back.Font = new System.Drawing.Font("Cooper Black", 22F);
            this.btnP_Back.ForeColor = System.Drawing.Color.White;
            this.btnP_Back.Location = new System.Drawing.Point(841, 55);
            this.btnP_Back.Name = "btnP_Back";
            this.btnP_Back.Size = new System.Drawing.Size(193, 49);
            this.btnP_Back.TabIndex = 15;
            this.btnP_Back.Text = "Back View";
            this.btnP_Back.UseVisualStyleBackColor = true;
            this.btnP_Back.Click += new System.EventHandler(this.btnP_Back_Click_1);
            // 
            // btnP_FullScale
            // 
            this.btnP_FullScale.FlatAppearance.BorderSize = 0;
            this.btnP_FullScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP_FullScale.Font = new System.Drawing.Font("Cooper Black", 22F);
            this.btnP_FullScale.ForeColor = System.Drawing.Color.White;
            this.btnP_FullScale.Location = new System.Drawing.Point(5, 55);
            this.btnP_FullScale.Name = "btnP_FullScale";
            this.btnP_FullScale.Size = new System.Drawing.Size(167, 49);
            this.btnP_FullScale.TabIndex = 11;
            this.btnP_FullScale.Text = "Full scale";
            this.btnP_FullScale.UseVisualStyleBackColor = true;
            this.btnP_FullScale.Click += new System.EventHandler(this.btnP_FullScale_Click_1);
            // 
            // btnP_Front
            // 
            this.btnP_Front.FlatAppearance.BorderSize = 0;
            this.btnP_Front.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP_Front.Font = new System.Drawing.Font("Cooper Black", 22F);
            this.btnP_Front.ForeColor = System.Drawing.Color.White;
            this.btnP_Front.Location = new System.Drawing.Point(177, 55);
            this.btnP_Front.Name = "btnP_Front";
            this.btnP_Front.Size = new System.Drawing.Size(202, 49);
            this.btnP_Front.TabIndex = 12;
            this.btnP_Front.Text = "Front View";
            this.btnP_Front.UseVisualStyleBackColor = true;
            this.btnP_Front.Click += new System.EventHandler(this.btnP_Front_Click_1);
            // 
            // btnP_GazeMoto
            // 
            this.btnP_GazeMoto.FlatAppearance.BorderSize = 0;
            this.btnP_GazeMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP_GazeMoto.Font = new System.Drawing.Font("Cooper Black", 22F);
            this.btnP_GazeMoto.ForeColor = System.Drawing.Color.White;
            this.btnP_GazeMoto.Location = new System.Drawing.Point(487, 55);
            this.btnP_GazeMoto.Name = "btnP_GazeMoto";
            this.btnP_GazeMoto.Size = new System.Drawing.Size(349, 49);
            this.btnP_GazeMoto.TabIndex = 14;
            this.btnP_GazeMoto.Text = "Gazebo / Motorcycles";
            this.btnP_GazeMoto.UseVisualStyleBackColor = true;
            this.btnP_GazeMoto.Click += new System.EventHandler(this.btnP_GazeMoto_Click);
            // 
            // btnP_Side
            // 
            this.btnP_Side.FlatAppearance.BorderSize = 0;
            this.btnP_Side.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP_Side.Font = new System.Drawing.Font("Cooper Black", 22F);
            this.btnP_Side.ForeColor = System.Drawing.Color.White;
            this.btnP_Side.Location = new System.Drawing.Point(384, 55);
            this.btnP_Side.Name = "btnP_Side";
            this.btnP_Side.Size = new System.Drawing.Size(98, 49);
            this.btnP_Side.TabIndex = 13;
            this.btnP_Side.Text = "Side";
            this.btnP_Side.UseVisualStyleBackColor = true;
            this.btnP_Side.Click += new System.EventHandler(this.btnP_Side_Click_1);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(142)))), ((int)(((byte)(184)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1238, 548);
            this.pnlContent.TabIndex = 2;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 658);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnlTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnP_Back;
        private System.Windows.Forms.Button btnP_FullScale;
        private System.Windows.Forms.Button btnP_Front;
        private System.Windows.Forms.Button btnP_GazeMoto;
        private System.Windows.Forms.Button btnP_Side;
        private System.Windows.Forms.Button btnLogBook;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbLogout;
    }
}