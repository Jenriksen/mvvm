using System.Windows;
using System.Windows.Controls;
using mvvm.ViewModels;

namespace mvvm.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            txtFirstName.Text = mainViewModel.currentPerson.FirstName;
            txtLastName.Text = mainViewModel.currentPerson.LastName;
            txtFullName.Text = mainViewModel.currentPerson.FullName;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.currentPerson.FirstName = txtFirstName.Text;
            mainViewModel.currentPerson.LastName = txtLastName.Text;
            txtFullName.Text = mainViewModel.currentPerson.FullName;
        }

        private void TxtFirstName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            mainViewModel.currentPerson.FirstName = txtFirstName.Text;
            txtFullName.Text = mainViewModel.currentPerson.FullName;
        }

        private void TxtLastName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            mainViewModel.currentPerson.LastName = txtLastName.Text;
            txtFullName.Text = mainViewModel.currentPerson.FullName;
        }
    }
}
