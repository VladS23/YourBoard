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
using System.Windows.Shapes;

namespace YourBoard
{
    /// <summary>
    /// Логика взаимодействия для PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        public PersonWindow()
        {
            InitializeComponent();
            nameTextBox.GotFocus += nameTextBoxGotFocus;
            nameTextBox.LostFocus += nameTextBoxLostFocus;
            surnameTextBox.GotFocus += surnameTextBoxGotFocus;
            surnameTextBox.LostFocus += surnameTextBoxLostFocus;

        }

        private void surnameTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (surnameTextBox.Text == "")
            {
                surnameTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void surnameTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
                surnameTextBlock.Visibility = Visibility.Hidden;
        }

        private void nameTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void nameTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            nameTextBlock.Visibility = Visibility.Hidden;
        }
    }
}
