using System.Windows;

namespace WPFDemo1
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

        private void saySomethingButton_Click(object sender, RoutedEventArgs e)
        {
            // THIS IS A COMMENT
            outputLabel.Content = "Hello, " + nameTextBox.Text;
            
            
        }

    }
}
