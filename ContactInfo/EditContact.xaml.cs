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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactInfo
{
    /// <summary>
    /// Interaction logic for EditContact.xaml
    /// </summary>
    public partial class EditContact : UserControl
    {
        IContactManager contactManager;

        public EditContact()
        {
            InitializeComponent();
            contactManager = Factory.CreateContactManager();

        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            String firstname = FirstNameInput.Text;
            String lastname = LastNameInput.Text;
            String mobilenumber = MobileNumberInput.Text;
            String description = DescriptionInput.Text;
            Contact contact;
            contactManager.CreateContact()
        }
    }
}
