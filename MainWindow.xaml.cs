using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MidTermAssignment
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

        private void buttonPage1_Click(object sender, RoutedEventArgs e)
        {
            tabPage2.Focus();
        }

        private void checkBoxPage1_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)checkBoxPage1.IsChecked)
                statusPage1_1.Content = "CheckBox Checked";
            if (!(bool)checkBoxPage1.IsChecked)
                statusPage1_1.Content = "CheckBox Not Checked";
        }

        private void expanderSlider_Expanded(object sender, RoutedEventArgs e)
        {
            if (expanderSlider.IsExpanded)
                expanderImage.IsExpanded = false;
        }

        private void expanderImage_Expanded(object sender, RoutedEventArgs e)
        {
            if (expanderImage.IsExpanded)
                expanderSlider.IsExpanded = false;
        }

        private void sliderPage3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = sliderPage3.Value;
            this.labelSlider.Content = "Value: " + value.ToString("0.0");
        }

        int countParent = 0; 
        private void button1Page4_Click(object sender, RoutedEventArgs e)
        {
            if (countParent == 0)
            {
                ParentWindow parentWindow = new ParentWindow();
                parentWindow.Show();
                countParent++;
            }
            else 
            {
                MessageBox.Show("Parent window already exists!", "Parent Window Exists", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        int countChild = 0;
        private void button2Page4_Click(object sender, RoutedEventArgs e)
        {
            if (countParent == 0)
            {
                MessageBox.Show("Parent window doesn't exist!", "Parent Window Doesn't Exists", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (countChild > 0 && countParent > 0)
            {
                MessageBox.Show("Child and Parent window already exist!", "Parent and Child Window Exists", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else 
            {
                ChildWindow childWindow = new ChildWindow();
                childWindow.Show();
                countChild++;
            }
        }

        private void textBoxPage1_KeyDown(object sender, KeyEventArgs e)
        {
            var ignoreKey = "QqYyZz";
            if (ignoreKey.IndexOf(e.Key.ToString()) != -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxPage1_KeyUp(object sender, KeyEventArgs e)
        {
            statusPage1_2.Content = textBoxPage1.Text;
        }
    }
}
