using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DesignerClientApplication
{
    public partial class FlowDocWindow : Window
    {
        public FlowDocWindow(int index, ContactManager contactManager)
        {
            InitializeComponent();
            InitializeGUI(index, contactManager);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            //Printing the flowdocument to Pdf. In order to create pdf the user must indicate the "microsoft print to pdf" option

            PrintDialog pd = new PrintDialog();
            if(pd.ShowDialog() == true)
            {
                IDocumentPaginatorSource idp = ClientFlowDoc;

                pd.PrintDocument(idp.DocumentPaginator, "Flow Document");
            }
        }

        private void InitializeGUI(int index, ContactManager contactManager)
        {
            //Setting the content for the flow document

            Contact contact = contactManager.GetContact(index);

            pName.Inlines.Add(" " + contact.FullName());
            pAddress.Inlines.Add(" " + contact.Address.ToString());
            pPhone.Inlines.Add(" " + contact.Comms.Phone.ToString());
            pEmail.Inlines.Add(" " + contact.Comms.Email.ToString());

            UpdateImage(contact);

        }

        private void UpdateImage(Contact contact)
        {
            BitmapImage myBitmapImage = new BitmapImage();

            string source = contact.Image.FilePath;

            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@source);

            myBitmapImage.DecodePixelWidth = 300;
            myBitmapImage.EndInit();

            pFloorPlanImg.Source = myBitmapImage;
        }
    }
}
