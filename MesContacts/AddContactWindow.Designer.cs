namespace MesContacts
{
    partial class AddContactWindow
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
            this.LB_City = new System.Windows.Forms.Label();
            this.LB_Email = new System.Windows.Forms.Label();
            this.LB_PhoneNumber = new System.Windows.Forms.Label();
            this.LB_Address = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Group = new System.Windows.Forms.ComboBox();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.TB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.LB_Group = new System.Windows.Forms.Label();
            this.LB_FirstName = new System.Windows.Forms.Label();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.BT_AddContact = new System.Windows.Forms.Button();
            this.BT_ChooseImage = new System.Windows.Forms.Button();
            this.PB_Pictures = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_City
            // 
            this.LB_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_City.Location = new System.Drawing.Point(19, 229);
            this.LB_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(100, 28);
            this.LB_City.TabIndex = 11;
            this.LB_City.Text = "Ville :";
            this.LB_City.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_City.Click += new System.EventHandler(this.LB_City_Click);
            // 
            // LB_Email
            // 
            this.LB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.Location = new System.Drawing.Point(40, 100);
            this.LB_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(79, 28);
            this.LB_Email.TabIndex = 10;
            this.LB_Email.Text = "Email : ";
            this.LB_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_PhoneNumber
            // 
            this.LB_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumber.Location = new System.Drawing.Point(4, 140);
            this.LB_PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_PhoneNumber.Name = "LB_PhoneNumber";
            this.LB_PhoneNumber.Size = new System.Drawing.Size(115, 28);
            this.LB_PhoneNumber.TabIndex = 9;
            this.LB_PhoneNumber.Text = "Téléphone :";
            this.LB_PhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_PhoneNumber.Click += new System.EventHandler(this.LB_PhoneNumber_Click);
            // 
            // LB_Address
            // 
            this.LB_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Address.Location = new System.Drawing.Point(19, 181);
            this.LB_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(100, 28);
            this.LB_Address.TabIndex = 8;
            this.LB_Address.Text = "Adresse :";
            this.LB_Address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CB_Group);
            this.panel1.Controls.Add(this.TB_City);
            this.panel1.Controls.Add(this.TB_Address);
            this.panel1.Controls.Add(this.TB_PhoneNumber);
            this.panel1.Controls.Add(this.TB_Email);
            this.panel1.Controls.Add(this.TB_LastName);
            this.panel1.Controls.Add(this.TB_FirstName);
            this.panel1.Controls.Add(this.LB_Group);
            this.panel1.Controls.Add(this.LB_FirstName);
            this.panel1.Controls.Add(this.LB_LastName);
            this.panel1.Controls.Add(this.LB_City);
            this.panel1.Controls.Add(this.LB_Address);
            this.panel1.Controls.Add(this.LB_Email);
            this.panel1.Controls.Add(this.LB_PhoneNumber);
            this.panel1.Location = new System.Drawing.Point(16, 338);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 310);
            this.panel1.TabIndex = 13;
            // 
            // CB_Group
            // 
            this.CB_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Group.FormattingEnabled = true;
            this.CB_Group.Location = new System.Drawing.Point(127, 273);
            this.CB_Group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_Group.Name = "CB_Group";
            this.CB_Group.Size = new System.Drawing.Size(279, 24);
            this.CB_Group.TabIndex = 21;
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(127, 231);
            this.TB_City.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(279, 22);
            this.TB_City.TabIndex = 20;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(127, 185);
            this.TB_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(279, 22);
            this.TB_Address.TabIndex = 19;
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.Location = new System.Drawing.Point(127, 144);
            this.TB_PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(279, 22);
            this.TB_PhoneNumber.TabIndex = 18;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(127, 103);
            this.TB_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(279, 22);
            this.TB_Email.TabIndex = 17;
            // 
            // TB_LastName
            // 
            this.TB_LastName.Location = new System.Drawing.Point(127, 63);
            this.TB_LastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(279, 22);
            this.TB_LastName.TabIndex = 16;
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Location = new System.Drawing.Point(127, 22);
            this.TB_FirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(279, 22);
            this.TB_FirstName.TabIndex = 15;
            // 
            // LB_Group
            // 
            this.LB_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Group.Location = new System.Drawing.Point(19, 271);
            this.LB_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Group.Name = "LB_Group";
            this.LB_Group.Size = new System.Drawing.Size(100, 28);
            this.LB_Group.TabIndex = 14;
            this.LB_Group.Text = "Groupe :";
            this.LB_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FirstName.Location = new System.Drawing.Point(28, 20);
            this.LB_FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(91, 28);
            this.LB_FirstName.TabIndex = 13;
            this.LB_FirstName.Text = "Prénom : ";
            this.LB_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_FirstName.Click += new System.EventHandler(this.label3_Click);
            // 
            // LB_LastName
            // 
            this.LB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LastName.Location = new System.Drawing.Point(40, 60);
            this.LB_LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(79, 28);
            this.LB_LastName.TabIndex = 12;
            this.LB_LastName.Text = "Nom :";
            this.LB_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LB_LastName.Click += new System.EventHandler(this.LB_LastName_Click);
            // 
            // BT_AddContact
            // 
            this.BT_AddContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BT_AddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddContact.Location = new System.Drawing.Point(0, 656);
            this.BT_AddContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_AddContact.Name = "BT_AddContact";
            this.BT_AddContact.Size = new System.Drawing.Size(452, 28);
            this.BT_AddContact.TabIndex = 15;
            this.BT_AddContact.Text = "Ajouter";
            this.BT_AddContact.UseVisualStyleBackColor = true;
            this.BT_AddContact.Click += new System.EventHandler(this.BT_AddContact_Click);
            // 
            // BT_ChooseImage
            // 
            this.BT_ChooseImage.Location = new System.Drawing.Point(28, 288);
            this.BT_ChooseImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_ChooseImage.Name = "BT_ChooseImage";
            this.BT_ChooseImage.Size = new System.Drawing.Size(395, 28);
            this.BT_ChooseImage.TabIndex = 16;
            this.BT_ChooseImage.Text = "Choisir une image";
            this.BT_ChooseImage.UseVisualStyleBackColor = true;
            // 
            // PB_Pictures
            // 
            this.PB_Pictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Pictures.Image = global::MesContacts.Properties.Resources.logo_user_21;
            this.PB_Pictures.Location = new System.Drawing.Point(28, 15);
            this.PB_Pictures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB_Pictures.Name = "PB_Pictures";
            this.PB_Pictures.Size = new System.Drawing.Size(394, 265);
            this.PB_Pictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Pictures.TabIndex = 14;
            this.PB_Pictures.TabStop = false;
            // 
            // AddContactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 684);
            this.Controls.Add(this.BT_ChooseImage);
            this.Controls.Add(this.BT_AddContact);
            this.Controls.Add(this.PB_Pictures);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddContactWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un contact";
            this.Load += new System.EventHandler(this.AddContactWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_City;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LB_PhoneNumber;
        private System.Windows.Forms.Label LB_Address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_Pictures;
        private System.Windows.Forms.Label LB_FirstName;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.ComboBox CB_Group;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.TextBox TB_PhoneNumber;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.Label LB_Group;
        private System.Windows.Forms.Button BT_AddContact;
        private System.Windows.Forms.Button BT_ChooseImage;
    }
}