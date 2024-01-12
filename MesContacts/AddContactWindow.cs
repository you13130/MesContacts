using System;
using System.Windows.Forms;

namespace MesContacts
{
    public partial class AddContactWindow : Form
    {
        public AddContactWindow()
        {
            InitializeComponent();

            LoadGroup();
        }

        private void AddContactWindow_Load(object sender, EventArgs e)
        {


        }

        private void LB_City_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LB_LastName_Click(object sender, EventArgs e)
        {

        }

        private void LB_PhoneNumber_Click(object sender, EventArgs e)
        {

        }

        public void LoadGroup()
        {
            this.CB_Group.Items.Clear();
            this.CB_Group.Items.AddRange(Global.contactsGroup.ToArray());

            if(this.CB_Group.Items.Count > 0)
            { 
            this.CB_Group.SelectedIndex = 0;
            }


        }
    }
}
