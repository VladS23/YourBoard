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
        public PersonWindow(MainWindow.WindowType type, Person person)
        {
            InitializeComponent();
            nameTextBox.GotFocus += nameTextBoxGotFocus;
            nameTextBox.LostFocus += nameTextBoxLostFocus;
            surnameTextBox.GotFocus += surnameTextBoxGotFocus;
            surnameTextBox.LostFocus += surnameTextBoxLostFocus;
            patronymicTextBox.GotFocus += patronymicTextBoxGotFocus;
            patronymicTextBox.LostFocus += patronymicTextBoxLostFocus;
            dateTextBox.GotFocus += dateTextBoxGotFocus;
            dateTextBox.LostFocus += dateTextBoxLostFocus;
            emailTextBox.GotFocus += emailTextBoxGotFocus;
            emailTextBox.LostFocus += emailTextBoxLostFocus;
            adressTextBox.GotFocus += adressTextBoxGotFocus;
            adressTextBox.LostFocus += adressTextBoxLostFocus;
            workTextBox.GotFocus += workTextBoxGotFocus;
            workTextBox.LostFocus += workTextBoxLostFocus;
            univerTextBox.GotFocus += univerTextBoxGotFocus;
            univerTextBox.LostFocus += univerTextBoxLostFocus;
            phoneTextBox.GotFocus += phoneTextBoxGotFocus;
            phoneTextBox.LostFocus += phoneTextBoxLostFocus;
            postTextBox.GotFocus += postTextBoxGotFocus;
            postTextBox.LostFocus += postTextBoxLostFocus;
            specTextBox.GotFocus += specTextBoxGotFocus;
            specTextBox.LostFocus += specTextBoxLostFocus;
            VkTextBox.GotFocus += VkTextBoxGotFocus;
            VkTextBox.LostFocus += VkTextBoxLostFocus;
            other1TextBox.GotFocus += other1TextBoxGotFocus;
            other1TextBox.LostFocus += other1TextBoxLostFocus;
            other2TextBox.GotFocus += other2TextBoxGotFocus;
            other2TextBox.LostFocus += other2TextBoxLostFocus;
            other3TextBox.GotFocus += other3TextBoxGotFocus;
            other3TextBox.LostFocus += other3TextBoxLostFocus;
            TgTextBox.GotFocus += TgTextBoxGotFocus;
            TgTextBox.LostFocus += TgTextBoxLostFocus;
            other4TextBox.GotFocus += other4TextBoxGotFocus;
            other4TextBox.LostFocus += other4TextBoxLostFocus;
            other5TextBox.GotFocus += other5TextBoxGotFocus;
            other5TextBox.LostFocus += other5TextBoxLostFocus;
            other6TextBox.GotFocus += other6TextBoxGotFocus;
            other6TextBox.LostFocus += other6TextBoxLostFocus;
            commTextBox.GotFocus += commTextBoxGotFocus;
            commTextBox.LostFocus += commTextBoxLostFocus;


        }
        private void commTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (new TextRange(commTextBox.Document.ContentStart, commTextBox.Document.ContentEnd).Text.Trim() == "")
            {
                commTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void commTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            commTextBlock.Visibility = Visibility.Hidden;
        }
        private void other6TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (other6TextBox.Text == "")
            {
                other6TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void other6TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            other6TextBlock.Visibility = Visibility.Hidden;
        }
        private void other5TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (other5TextBox.Text == "")
            {
                other5TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void other5TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            other5TextBlock.Visibility = Visibility.Hidden;
        }
        private void other4TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (other4TextBox.Text == "")
            {
                other4TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void other4TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            other4TextBlock.Visibility = Visibility.Hidden;
        }
        private void TgTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (TgTextBox.Text == "")
            {
                TgTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void TgTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            TgTextBlock.Visibility = Visibility.Hidden;
        }
        private void other3TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (other3TextBox.Text == "")
            {
                other3TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void other3TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            other3TextBlock.Visibility = Visibility.Hidden;
        }
        private void other2TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (other2TextBox.Text == "")
            {
                other2TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void other2TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            other2TextBlock.Visibility = Visibility.Hidden;
        }
        private void other1TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (other1TextBox.Text == "")
            {
                other1TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void other1TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            other1TextBlock.Visibility = Visibility.Hidden;
        }
        private void VkTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (VkTextBox.Text == "")
            {
                VkTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void VkTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            VkTextBlock.Visibility = Visibility.Hidden;
        }
        private void specTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (specTextBox.Text == "")
            {
                specTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void specTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            specTextBlock.Visibility = Visibility.Hidden;
        }
        private void postTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (postTextBox.Text == "")
            {
                postTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void postTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            postTextBlock.Visibility = Visibility.Hidden;
        }
        private void phoneTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text == "")
            {
                phoneTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void phoneTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            phoneTextBlock.Visibility = Visibility.Hidden;
        }
        private void univerTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (univerTextBox.Text == "")
            {
                univerTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void univerTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            univerTextBlock.Visibility = Visibility.Hidden;
        }
        private void workTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (workTextBox.Text == "")
            {
                workTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void workTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            workTextBlock.Visibility = Visibility.Hidden;
        }
        private void adressTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (adressTextBox.Text == "")
            {
                adressTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void adressTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            adressTextBlock.Visibility = Visibility.Hidden;
        }
        private void emailTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void emailTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            emailTextBlock.Visibility = Visibility.Hidden;
        }
        private void dateTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (dateTextBox.Text == "")
            {
                dateTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void dateTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            dateTextBlock.Visibility = Visibility.Hidden;
        }
        private void patronymicTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (patronymicTextBox.Text == "")
            {
                patronymicTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void patronymicTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            patronymicTextBlock.Visibility = Visibility.Hidden;
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
