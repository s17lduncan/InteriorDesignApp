using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace DesignerClientApplication
{
    public partial class ClientInfoWindow : Window
    {
        private Image currImage;
        private Contact currContact;
        public ClientInfoWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public ClientInfoWindow(string title, Contact contact)
        {
            InitializeComponent();
            InitializeEdit(title, contact);
        }

        private void InitializeGUI()
        {
            this.Height = 500;
            this.Width = 350;

            currContact = new Contact();

            cmbState.ItemsSource = Enum.GetValues(typeof(State));
        }

        private void InitializeEdit(string title, Contact contact)
        {
            this.Height = 500;
            this.Width = 350;

            lblTitle.Content = title;

            txtCityInput.Text = contact.Address.City;
            txtStreetInput.Text = contact.Address.Street;
            txtZipInput.Text = contact.Address.ZipCode;

            cmbState.ItemsSource = Enum.GetValues(typeof(State));
            contact.Address.State = (State)cmbState.SelectedIndex;

            txtFirstNameInput.Text = contact.FirstName;
            txtLastNameInput.Text = contact.LastName;

            txtPhoneInput.Text = contact.Comms.Phone;
            txtEmailInput.Text = contact.Comms.Email;

            currImage = contact.Image;

            lblFileName.Content = contact.Image.FileName;
            

            currContact = contact;

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {

            if (ReadInput())
            {
                MessageBox.Show(currContact.FullName() + " is added!");
                this.Close();
            }
        }
        private bool ReadInput()
        {
            bool namesOk = ReadNames();
            ReadAddress();
            bool imageOk = ReadImage();
            bool commsOk = ReadComms();

            return namesOk && commsOk && imageOk;
        }

        private bool ReadImage()
        {
            bool ok = false;

            if (currImage != null)
            {
                ok = true;
                currContact.Image = currImage;
            }

            return ok;
        }

        private bool ReadNames()
        {
            bool ok = false;

            string firstName = txtFirstNameInput.Text;
            string lastName = txtLastNameInput.Text;

            if(firstName != null && lastName != null)
            {
                currContact.FirstName = firstName;
                currContact.LastName = lastName;
                ok =  true;
            }

            return ok;

        }

        private void ReadAddress()
        {
            Address address = new Address();

            address.City = txtCityInput.Text;
            address.Street = txtStreetInput.Text;
            address.ZipCode = txtZipInput.Text;

            address.State = (State)cmbState.SelectedIndex;

            currContact.Address = address;
        }

        private bool ReadComms()
        {
            bool ok = false;

            Comms comms = new Comms();

            comms.Phone = txtPhoneInput.Text;

            if (!txtEmailInput.Text.Contains("@"))
            {
                MessageBox.Show("Invalid Email");
                ok = false;
            }
            else
            {
                comms.Email = txtEmailInput.Text;
                ok = true;
            }

            currContact.Comms = comms;

            return ok;
        }

        public Contact ContactData
        {
            get { return currContact; }
            set
            {
                currContact = value;
            }
        }
        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Images only. | *.jpg; *.jpeg; *.png;";

            bool? response = openFileDialog.ShowDialog();

            Image image = new Image();

            if (response == true)
            {
                image.FilePath = openFileDialog.FileName;
                image.FileName = openFileDialog.FileName;
                MessageBox.Show(openFileDialog.SafeFileName + " is added");

                lblFileName.Content = openFileDialog.SafeFileName;
            }
            else
                MessageBox.Show("Ensure the file is an image file. Only .jpg, .jpeg, .png are accepted");

            currImage = image;
        }
    }
}
