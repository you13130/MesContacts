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
