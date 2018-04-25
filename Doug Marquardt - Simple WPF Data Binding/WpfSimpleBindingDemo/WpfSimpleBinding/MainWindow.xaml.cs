using System.Windows;
using WpfSimpleBinding.Models;

namespace WpfSimpleBinding
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddMorePeopleWithoutNotifications_Click(object sender, RoutedEventArgs e)
        {

            var dc = DataContext as PeopleDataContext;
            dc?.WithoutNotifications.AddPerson();
        }

        private void AddMorePeopleWithNotifications_Click(object sender, RoutedEventArgs e)
        {

            var dc = DataContext as PeopleDataContext;
            dc?.WithNotifications.AddPerson();
        }
    }
}
