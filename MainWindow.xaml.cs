using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using System.Reflection.Metadata;

namespace DesignerClientApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ContactManager contactManager;
        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            contactManager = new ContactManager();

            btnGeneratePDF.Visibility = Visibility.Hidden;
            lblAddressOutput.Visibility = Visibility.Hidden;
            lblOutputEmail.Visibility = Visibility.Hidden;
            lblOutputImage.Visibility = Visibility.Hidden;
            lblOutputPhone.Visibility = Visibility.Hidden;
            txtAddressOutput.Visibility = Visibility.Hidden;
            txtEmailOutput.Visibility = Visibility.Hidden;
            txtPhoneOutput.Visibility = Visibility.Hidden;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ClientInfoWindow newClientWindow = new ClientInfoWindow();
            newClientWindow.ShowDialog();

            if(newClientWindow.DialogResult == false)
            {
                contactManager.AddContact(newClientWindow.ContactData);
                UpdateGUI();

                btnGeneratePDF.Visibility = Visibility.Visible;
                lblAddressOutput.Visibility = Visibility.Visible;
                lblOutputEmail.Visibility = Visibility.Visible;
                lblOutputImage.Visibility = Visibility.Visible;
                lblOutputPhone.Visibility = Visibility.Visible;
                txtAddressOutput.Visibility = Visibility.Visible;
                txtEmailOutput.Visibility = Visibility.Visible;
                txtPhoneOutput.Visibility = Visibility.Visible;
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int index = lstClients.SelectedIndex;

            Contact contact = contactManager.GetContact(index);

            string title = "Edit Client";

            ClientInfoWindow clientInfoWindow = new ClientInfoWindow(title, contact);
            clientInfoWindow.ShowDialog();

            if(clientInfoWindow.DialogResult == false)
            {
                contactManager.ChangeContact(contact, index);
                UpdateGUI();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = lstClients.SelectedIndex;

            if (index >= 0)
            {
                contactManager.DeleteContact(index);
                UpdateGUI();
            }
                
        }

        private void UpdateGUI() 
        {
            lstClients.Items.Clear();

            string[] strClients = contactManager.GetClientInfoString();

            for(int i = 0; i < strClients.Length; i++)
            {
                string str = strClients[i];
                lstClients.Items.Add(str);
            }
        }

        private void lstClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int index = lstClients.SelectedIndex;

            if(index >= 0)
            {
                Contact contact = contactManager.GetContact(index);

                UpdateImage(contact);
                
                txtAddressOutput.Text = contact.Address.ToString();
                txtEmailOutput.Text = contact.Comms.Email.ToString();
                txtPhoneOutput.Text = contact.Comms.Phone.ToString();
            }
        }

        private void UpdateImage(Contact contact)
        {
            BitmapImage myBitmapImage = new BitmapImage();

            string source = contact.Image.FilePath;

            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@source);

            myBitmapImage.DecodePixelWidth = 300;
            myBitmapImage.EndInit();

            imgFloorPlan.Source = myBitmapImage;
        }

        private void btnGeneratePDF_Click(object sender, RoutedEventArgs e)
        {
            int index = lstClients.SelectedIndex;

            if (index >= 0)
            {
                FlowDocWindow flowDocWindow = new FlowDocWindow(index, contactManager);
                flowDocWindow.Show();
            }
            else
                MessageBox.Show("Choose a Client");
            
        }
    }
}