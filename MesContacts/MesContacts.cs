using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MesContacts
{
    public partial class LB_Group : Form
    {
        public LB_Group()
        {
            InitializeComponent();
            LoadGroup();

            
        }

        public void LoadGroup()
        {
            this.CB_MyContacts.Items.Clear();
            this.CB_MyContacts.Items.AddRange(Global.contactsGroup.ToArray());

            if (this.CB_MyContacts.Items.Count > 0)
            {
                this.CB_MyContacts.SelectedIndex = 0;
            }

        }

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LB_PhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BT_AddContact_Click(object sender, EventArgs e)
        {
            AddContactWindow acw =  new AddContactWindow();
            acw.ShowDialog();

        }


    }
}
