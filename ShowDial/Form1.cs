using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsterNET.Manager;
using AsterNET.Manager.Action;
using AsterNET.Manager.Response;
using AsterNET.FastAGI;
using AsterNET.Manager.Event;
using AsterNET.FastAGI.MappingStrategies;


namespace ShowDial
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
                 Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          this.server.Text= Properties.Settings.Default.server;
          this.port.Text = Properties.Settings.Default.port.ToString();
          this.login.Text = Properties.Settings.Default.login;
          this.password.Text = Properties.Settings.Default.password;
          this.nom.Text = Properties.Settings.Default.nom.ToString();
          this.nom2.Text = Properties.Settings.Default.nom2.ToString();
          this.time.Text = Properties.Settings.Default.time.ToString();
          this.ldap.Text = Properties.Settings.Default.ldap;
            displayQueue();
        }
        private static ManagerConnection manager;
        public void displayQueue()
        {
            manager = new ManagerConnection(this.server.Text, int.Parse(this.port.Text), this.login.Text, this.password.Text);

            try
            {

                manager.Login();

                Console.ReadLine();
                manager.PingInterval = 0;
                manager.FireAllEvents = true;
                manager.NewState += manager_NewState;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press ENTER to next test or CTRL-C to exit.");
                Console.ReadLine();
                return;
            }
        }

        void manager_NewState(object sender, NewStateEvent e)
        {
            if (Convert.ToDouble(e.Attributes["exten"].ToString()) == Convert.ToDouble(Properties.Settings.Default.nom.ToString()) | Convert.ToDouble(e.Attributes["exten"].ToString()) == Convert.ToDouble(Properties.Settings.Default.nom2.ToString()))
            {
                if (Convert.ToDouble(e.CallerIdNum.ToString()) != Convert.ToDouble(Properties.Settings.Default.nom.ToString()))
                {
                    if (e.ChannelStateDesc.ToString() == "Ring")
                    {
                        ShowDial ShowCARD = new ShowDial();
                        ShowCARD.nom1.Text = e.CallerIdNum.ToString();
                        ShowCARD.ShowDialog();
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = this.server.Text;
            Properties.Settings.Default.port = int.Parse(this.port.Text);
            Properties.Settings.Default.login =this.login.Text;
           Properties.Settings.Default.password =this.password.Text;
           Properties.Settings.Default.nom = Convert.ToDouble(this.nom.Text);
           Properties.Settings.Default.nom2 = Convert.ToDouble(this.nom2.Text);
           Properties.Settings.Default.time = int.Parse(this.time.Text);
           Properties.Settings.Default.ldap = this.ldap.Text;
           Properties.Settings.Default.Save();

           Tray.Visible = true;
           this.Hide();
         

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HelpDesk helpdesk = new HelpDesk();
            helpdesk.ShowDialog();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDial ShowDial = new ShowDial();
            ShowDial.ShowDialog();
        }

      
    }
}