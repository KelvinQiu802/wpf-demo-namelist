using System.Windows;

namespace wpf_demo_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
            }
            else
            {
                MessageBox.Show(GetWindow(this), "Please enter a name or the name already exists", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            txtName.Clear();
        }

    }
}