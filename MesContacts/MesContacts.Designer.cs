namespace MesContacts
{
    partial class LB_Group
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Left = new System.Windows.Forms.Panel();
            this.Group_ContactsList = new System.Windows.Forms.GroupBox();
            this.Group_SearchContacts = new System.Windows.Forms.GroupBox();
            this.TB_SearchContacts = new System.Windows.Forms.TextBox();
            this.BT_AddContact = new System.Windows.Forms.Button();
            this.LB_Contact = new System.Windows.Forms.ListBox();
            this.CB_MyContacts = new System.Windows.Forms.ComboBox();
            this.Pnl_Right = new System.Windows.Forms.Panel();
            this.LB_PhoneNumberData = new System.Windows.Forms.Label();
            this.LB_AddressData = new System.Windows.Forms.Label();
            this.LB_CityData = new System.Windows.Forms.Label();
            this.LB_City = new System.Windows.Forms.Label();
            this.LB_EmailData = new System.Windows.Forms.Label();
            this.LB_Email = new System.Windows.Forms.Label();
            this.LB_PhoneNumber = new System.Windows.Forms.Label();
            this.LB_address = new System.Windows.Forms.Label();
            this.LB_Name_FisrtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_DeleteContact = new System.Windows.Forms.Button();
            this.PB_Pictures = new System.Windows.Forms.PictureBox();
            this.Pnl_Left.SuspendLayout();
            this.Group_ContactsList.SuspendLayout();
            this.Group_SearchContacts.SuspendLayout();
            this.Pnl_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Left
            // 
            this.Pnl_Left.Controls.Add(this.Group_ContactsList);
            this.Pnl_Left.Location = new System.Drawing.Point(12, 2);
            this.Pnl_Left.Name = "Pnl_Left";
            this.Pnl_Left.Size = new System.Drawing.Size(230, 425);
            this.Pnl_Left.TabIndex = 0;
            // 
            // Group_ContactsList
            // 
            this.Group_ContactsList.Controls.Add(this.Group_SearchContacts);
            this.Group_ContactsList.Controls.Add(this.BT_AddContact);
            this.Group_ContactsList.Controls.Add(this.LB_Contact);
            this.Group_ContactsList.Controls.Add(this.CB_MyContacts);
            this.Group_ContactsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_ContactsList.Location = new System.Drawing.Point(3, 10);
            this.Group_ContactsList.Name = "Group_ContactsList";
            this.Group_ContactsList.Size = new System.Drawing.Size(224, 410);
            this.Group_ContactsList.TabIndex = 0;
            this.Group_ContactsList.TabStop = false;
            this.Group_ContactsList.Text = "Mes contacts";
            // 
            // Group_SearchContacts
            // 
            this.Group_SearchContacts.Controls.Add(this.TB_SearchContacts);
            this.Group_SearchContacts.Location = new System.Drawing.Point(6, 343);
            this.Group_SearchContacts.Name = "Group_SearchContacts";
            this.Group_SearchContacts.Size = new System.Drawing.Size(212, 58);
            this.Group_SearchContacts.TabIndex = 1;
            this.Group_SearchContacts.TabStop = false;
            this.Group_SearchContacts.Text = "Rechercher :";
            // 
            // TB_SearchContacts
            // 
            this.TB_SearchContacts.Location = new System.Drawing.Point(6, 26);
            this.TB_SearchContacts.Name = "TB_SearchContacts";
            this.TB_SearchContacts.Size = new System.Drawing.Size(200, 22);
            this.TB_SearchContacts.TabIndex = 1;
            // 
            // BT_AddContact
            // 
            this.BT_AddContact.Location = new System.Drawing.Point(6, 315);
            this.BT_AddContact.Name = "BT_AddContact";
            this.BT_AddContact.Size = new System.Drawing.Size(212, 23);
            this.BT_AddContact.TabIndex = 2;
            this.BT_AddContact.Text = "Ajouter";
            this.BT_AddContact.UseVisualStyleBackColor = true;
            this.BT_AddContact.Click += new System.EventHandler(this.BT_AddContact_Click);
            // 
            // LB_Contact
            // 
            this.LB_Contact.FormattingEnabled = true;
            this.LB_Contact.ItemHeight = 16;
            this.LB_Contact.Location = new System.Drawing.Point(6, 49);
            this.LB_Contact.Name = "LB_Contact";
            this.LB_Contact.Size = new System.Drawing.Size(212, 260);
            this.LB_Contact.Sorted = true;
            this.LB_Contact.TabIndex = 1;
            // 
            // CB_MyContacts
            // 
            this.CB_MyContacts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MyContacts.FormattingEnabled = true;
            this.CB_MyContacts.Location = new System.Drawing.Point(6, 19);
            this.CB_MyContacts.Name = "CB_MyContacts";
            this.CB_MyContacts.Size = new System.Drawing.Size(212, 24);
            this.CB_MyContacts.TabIndex = 1;
            // 
            // Pnl_Right
            // 
            this.Pnl_Right.Controls.Add(this.BT_DeleteContact);
            this.Pnl_Right.Controls.Add(this.LB_PhoneNumberData);
            this.Pnl_Right.Controls.Add(this.LB_AddressData);
            this.Pnl_Right.Controls.Add(this.LB_CityData);
            this.Pnl_Right.Controls.Add(this.LB_City);
            this.Pnl_Right.Controls.Add(this.LB_EmailData);
            this.Pnl_Right.Controls.Add(this.LB_Email);
            this.Pnl_Right.Controls.Add(this.LB_PhoneNumber);
            this.Pnl_Right.Controls.Add(this.LB_address);
            this.Pnl_Right.Controls.Add(this.LB_Name_FisrtName);
            this.Pnl_Right.Controls.Add(this.label1);
            this.Pnl_Right.Controls.Add(this.PB_Pictures);
            this.Pnl_Right.Location = new System.Drawing.Point(260, 2);
            this.Pnl_Right.Name = "Pnl_Right";
            this.Pnl_Right.Size = new System.Drawing.Size(318, 425);
            this.Pnl_Right.TabIndex = 1;
            // 
            // LB_PhoneNumberData
            // 
            this.LB_PhoneNumberData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumberData.Location = new System.Drawing.Point(90, 319);
            this.LB_PhoneNumberData.Name = "LB_PhoneNumberData";
            this.LB_PhoneNumberData.Size = new System.Drawing.Size(216, 23);
            this.LB_PhoneNumberData.TabIndex = 10;
            this.LB_PhoneNumberData.Text = "06 xx xx xx xx";
            this.LB_PhoneNumberData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_AddressData
            // 
            this.LB_AddressData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AddressData.Location = new System.Drawing.Point(89, 353);
            this.LB_AddressData.Name = "LB_AddressData";
            this.LB_AddressData.Size = new System.Drawing.Size(216, 23);
            this.LB_AddressData.TabIndex = 9;
            this.LB_AddressData.Text = "3 Boulevard Test";
            this.LB_AddressData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_AddressData.Click += new System.EventHandler(this.label4_Click);
            // 
            // LB_CityData
            // 
            this.LB_CityData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CityData.Location = new System.Drawing.Point(89, 388);
            this.LB_CityData.Name = "LB_CityData";
            this.LB_CityData.Size = new System.Drawing.Size(216, 23);
            this.LB_CityData.TabIndex = 8;
            this.LB_CityData.Text = "Marseille";
            this.LB_CityData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_City
            // 
            this.LB_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_City.Location = new System.Drawing.Point(13, 388);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(75, 23);
            this.LB_City.TabIndex = 7;
            this.LB_City.Text = "Ville :";
            this.LB_City.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_EmailData
            // 
            this.LB_EmailData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EmailData.Location = new System.Drawing.Point(89, 287);
            this.LB_EmailData.Name = "LB_EmailData";
            this.LB_EmailData.Size = new System.Drawing.Size(216, 23);
            this.LB_EmailData.TabIndex = 6;
            this.LB_EmailData.Text = "you130@gmail.com";
            this.LB_EmailData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Email
            // 
            this.LB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.Location = new System.Drawing.Point(29, 287);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(59, 23);
            this.LB_Email.TabIndex = 5;
            this.LB_Email.Text = "Email : ";
            this.LB_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_PhoneNumber
            // 
            this.LB_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumber.Location = new System.Drawing.Point(2, 319);
            this.LB_PhoneNumber.Name = "LB_PhoneNumber";
            this.LB_PhoneNumber.Size = new System.Drawing.Size(86, 23);
            this.LB_PhoneNumber.TabIndex = 4;
            this.LB_PhoneNumber.Text = "Téléphone :";
            this.LB_PhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_PhoneNumber.Click += new System.EventHandler(this.LB_PhoneNumber_Click);
            // 
            // LB_address
            // 
            this.LB_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_address.Location = new System.Drawing.Point(13, 353);
            this.LB_address.Name = "LB_address";
            this.LB_address.Size = new System.Drawing.Size(75, 23);
            this.LB_address.TabIndex = 3;
            this.LB_address.Text = "Adresse :";
            this.LB_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Name_FisrtName
            // 
            this.LB_Name_FisrtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name_FisrtName.Location = new System.Drawing.Point(7, 253);
            this.LB_Name_FisrtName.Name = "LB_Name_FisrtName";
            this.LB_Name_FisrtName.Size = new System.Drawing.Size(308, 23);
            this.LB_Name_FisrtName.TabIndex = 2;
            this.LB_Name_FisrtName.Text = "Nom Prénom";
            this.LB_Name_FisrtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Groupe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BT_DeleteContact
            // 
            this.BT_DeleteContact.BackColor = System.Drawing.Color.Transparent;
            this.BT_DeleteContact.BackgroundImage = global::MesContacts.Properties.Resources.delete1;
            this.BT_DeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_DeleteContact.Location = new System.Drawing.Point(266, 9);
            this.BT_DeleteContact.Name = "BT_DeleteContact";
            this.BT_DeleteContact.Size = new System.Drawing.Size(32, 32);
            this.BT_DeleteContact.TabIndex = 11;
            this.BT_DeleteContact.UseVisualStyleBackColor = false;
            // 
            // PB_Pictures
            // 
            this.PB_Pictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Pictures.Image = global::MesContacts.Properties.Resources.logo_user_21;
            this.PB_Pictures.Location = new System.Drawing.Point(5, 5);
            this.PB_Pictures.Name = "PB_Pictures";
            this.PB_Pictures.Size = new System.Drawing.Size(296, 229);
            this.PB_Pictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Pictures.TabIndex = 0;
            this.PB_Pictures.TabStop = false;
            // 
            // LB_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 436);
            this.Controls.Add(this.Pnl_Right);
            this.Controls.Add(this.Pnl_Left);
            this.Name = "LB_Group";
            this.Text = "MesContacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl_Left.ResumeLayout(false);
            this.Group_ContactsList.ResumeLayout(false);
            this.Group_SearchContacts.ResumeLayout(false);
            this.Group_SearchContacts.PerformLayout();
            this.Pnl_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Left;
        private System.Windows.Forms.GroupBox Group_ContactsList;
        private System.Windows.Forms.GroupBox Group_SearchContacts;
        private System.Windows.Forms.Button BT_AddContact;
        private System.Windows.Forms.ListBox LB_Contact;
        private System.Windows.Forms.ComboBox CB_MyContacts;
        private System.Windows.Forms.TextBox TB_SearchContacts;
        private System.Windows.Forms.Panel Pnl_Right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_EmailData;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LB_PhoneNumber;
        private System.Windows.Forms.Label LB_address;
        private System.Windows.Forms.Label LB_Name_FisrtName;
        private System.Windows.Forms.Label LB_PhoneNumberData;
        private System.Windows.Forms.Label LB_AddressData;
        private System.Windows.Forms.Label LB_CityData;
        private System.Windows.Forms.Label LB_City;
        private System.Windows.Forms.Button BT_DeleteContact;
        private System.Windows.Forms.PictureBox PB_Pictures;
    }
}

