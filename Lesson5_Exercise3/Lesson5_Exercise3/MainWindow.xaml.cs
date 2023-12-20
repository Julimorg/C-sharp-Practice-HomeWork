using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson5_Exercise3
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

        private void Tab_Clicck_Click(object sender, RoutedEventArgs e)
        {
            TabItem ti = Tabs1.SelectedItem as TabItem;
            if (ti != null)
            {
                MessageBox.Show("This is " + ti.Header + " tab");
            }
            else
            {
                MessageBox.Show("No tab selected or the selected item is not a TabItem.");
            }

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}