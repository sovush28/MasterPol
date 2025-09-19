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

namespace MasterPol
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Partner currentPartner = new Partner();

        public AddEditPage(Partner selectedPartner)
        {
            InitializeComponent();

            if(selectedPartner!= null)
            {
                currentPartner = selectedPartner;
                PartnerTypeCB.SelectedIndex = currentPartner.PartnerTypeID - 1;
            }
            DataContext = currentPartner;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
