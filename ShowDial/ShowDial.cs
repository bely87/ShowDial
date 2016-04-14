using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDial
{
    public partial class ShowDial : Form
    {
        public ShowDial()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void ShowDial_Load(object sender, EventArgs e)
        {
            Con1c card = new Con1c();
            card.connect(nom1.Text);
            this.name.Text = card.cn;
            this.otdel.Text=card.department;
            this.dolj.Text=card.title;
            this.kompa.Text=card.company;
            this.kab.Text=card.physicalDeliveryOfficeName;

            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height);
            Timer tm = new Timer();
            var times = Properties.Settings.Default.time * 1000;
            tm.Interval = times;
            tm.Tick += tm_Tick;
            tm.Enabled = true;
        }
        private void tm_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
