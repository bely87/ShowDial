using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDial
{
    class Con1c
    {
        public string cn;
        public string department;
        public string title;
        public string physicalDeliveryOfficeName;
        public string company;

        public void connect(string nom)
        {
            try
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + Properties.Settings.Default.ldap);
                DirectorySearcher dSearch = new DirectorySearcher(entry);
                dSearch.Filter = "(&(objectCategory=person)(objectClass=user)(telephoneNumber=" + nom + "))";
                dSearch.PropertiesToLoad.Add("cn");
            foreach (SearchResult result in dSearch.FindAll())
            {

                try
                {
                    this.company = result.GetDirectoryEntry().Properties["company"].Value.ToString();
                }
                catch
                {
                    this.company = "";
                }
                try
                {
               this.cn=result.GetDirectoryEntry().Properties["cn"].Value.ToString();
                }
                catch
                {
                    this.cn = "";
                }
                 try
                {
               this.department = result.GetDirectoryEntry().Properties["department"].Value.ToString();
                }
                 catch
                 {
                     this.department = "";
                 }
                 try
                {
               this.title = result.GetDirectoryEntry().Properties["title"].Value.ToString();
                }
                 catch
                 {
                     this.title = "";
                 }
                 try
                {
               this.physicalDeliveryOfficeName = result.GetDirectoryEntry().Properties["physicalDeliveryOfficeName"].Value.ToString();
                }
                 catch
                 {
                     this.physicalDeliveryOfficeName = "";
                 }}

                 }
            catch
            {
                MessageBox.Show("Ошибка подключения к LDAP");
            
            }
           
          
        }
      




    }
}
