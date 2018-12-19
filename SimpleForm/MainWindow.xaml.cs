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

namespace SimpleForm
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name: ");
            sb.Append(Name.Text);
            sb.Append(" Sex? ");
            sb.Append((bool)Male.IsChecked ? "Male" : "Female");
            sb.Append(" Computer: ");
            sb.Append((bool)DesktopCheck.IsChecked ? "Desktop " : "");
            sb.Append((bool)LaptopCheck.IsChecked ? "Laptop " : "");
            sb.Append((bool)TabletCheck.IsChecked ? "Tablet " : "");
            sb.Append(" Your job: ");
            sb.Append(Occupation.Text);
            sb.Append(" Delivery Date: ");
            sb.Append(Calendar.SelectedDate.ToString());
            MessageBox.Show(sb.ToString());

        }
    }
}
