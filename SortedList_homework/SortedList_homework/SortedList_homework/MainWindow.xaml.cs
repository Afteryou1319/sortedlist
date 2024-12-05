using System.Collections;
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

namespace SortedList_homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedlistl;
        public MainWindow()
        {
            InitializeComponent();
            sortedlistl = new SortedList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            sortedlistl.Add(int.Parse(keytxt.Text) , valuetxt.Text);
            ICollection collection = sortedlistl.Keys;
            string allItems = "Current SortedList items:\n";
            foreach (var a in sortedlistl.Keys)
            {
                allItems += $"Key: {a}, Value: {sortedlistl[a]}\n";
            }
            MessageBox.Show(allItems, "SortedList Items", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}