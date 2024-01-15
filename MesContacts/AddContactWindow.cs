using System;
using System.Drawing;
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

            if (this.CB_Group.Items.Count > 0)
            {
                this.CB_Group.SelectedIndex = 0;
            }


        }

        private void BT_AddContact_Click(object sender, EventArgs e)
        {
            // Récupérer les champs saisies 

            string firstName = this.TB_FirstName.Text;
            string lastName = this.TB_LastName.Text;
            string email = this.TB_Email.Text;
            string phoneNumber = this.TB_PhoneNumber.Text;
            string address = this.TB_Address.Text;
            string city = this.TB_City.Text;
            Group group = (Group)this.CB_Group.SelectedItem;
            Image photo = this.PB_Pictures.Image;

            //Vérification des champs

            if (CheckInput(firstName, lastName, email, phoneNumber, address, city, group))
            {

                //Création d'un nouveau contact 

                Contact contact = new Contact(firstName, lastName, email, phoneNumber, address, city, photo);

                //Ajout du contact dans le groupe 

                group.Contacts.Add(contact);

                // Fermer la fenêtre 

                DialogResult = DialogResult.OK;

            }

                else
                {

                    MessageBox.Show("Veuillez entrer tous les champs !", "Mes Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                


            

        }

        private bool CheckInput(string firstName, string lastName, string email, string phoneNumber, string address, string city, Group group)

        {


            return !string.IsNullOrEmpty(firstName)
                && !string.IsNullOrEmpty(lastName)
                && !string.IsNullOrEmpty(email) 
                && !string.IsNullOrEmpty(phoneNumber) 
                && !string.IsNullOrEmpty(address) 
                && !string.IsNullOrEmpty(city)
                && group !=null;
        }
    }
}
