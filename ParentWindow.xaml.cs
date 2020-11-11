using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MidTermAssignment
{
    /// <summary>
    /// Interaction logic for ParentWindow.xaml
    /// </summary>
    public partial class ParentWindow : Window
    {
        public ParentWindow()
        {
            InitializeComponent();
        }

        int countChild = 0;
        private void parentWindowButton_Click(object sender, RoutedEventArgs e)
        {
            if (countChild == 0)
            {
                ChildWindow childWindow = new ChildWindow();
                childWindow.Show();
                countChild++;
            }
            else
            {
                MessageBox.Show("Child window already exists!", "Child Window Exists", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
