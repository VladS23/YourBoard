using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Resources;
using System.Windows.Controls;
using System.IO;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Documents;

namespace YourBoard
{
    public class Person:DashBoardObject
    {
        public string PersonName
        { get
            {
                return name;
            }
            set
            {
                name = value;
                nameTextBlock.Text = value;
            } 
        }
        public string PersonSurname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                surnameTextBlock.Text = value;
            }
        }
        public string PersonPatronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
                patronymicTextBlock.Text = value;
            }
        }
        public string PersonBornDate { get; set; } = "";
        public string PersonEmail{ get; set; } = "";
        public string PersonAdress { get; set; } = "";
        public string PersonWork { get; set; } = "";
        public string PersonUniver { get; set; } = "";
        public string PersonPhone{ get; set; } = "";
        public string PersonPost { get; set; } = "";
        public string PersonSpec { get; set; } = "";
        public string PersonVk{ get; set; } = "";
        public string PersonTg{ get; set; } = "";
        public string PersonComm { get; set; } = "";
        public string PersonOtherInfo1 { get; set; } = "";
        public string PersonOtherInfo2 { get; set; } = "";
        public string PersonOtherInfo3 { get; set; } = "";
        public string PersonOtherInfo4 { get; set; } = "";
        public string PersonOtherInfo5 { get; set; } = "";
        public string PersonOtherInfo6 { get; set; } = "";
        private string name;
        private string surname;
        private string patronymic;
        TextBlock nameTextBlock = new TextBlock();
        TextBlock surnameTextBlock = new TextBlock();
        TextBlock patronymicTextBlock = new TextBlock();
        public Person(string avatar, string personSurname, string personName, string personPatronymic, double X, double Y)
        {
            try
            {
                CreateView(avatar, X, Y);
            }
            catch
            {
                CreateView(Directory.GetCurrentDirectory() + @"\Icons\person.png", X, Y);
            }
            Button btn = view.Children.OfType<Button>().FirstOrDefault();
            btn.Style = (Style)btn.FindResource("PersonButStyle");
            {
                surnameTextBlock.FontWeight = System.Windows.FontWeights.Bold;
                surnameTextBlock.Text = personSurname;
                PersonSurname = personSurname;
                surnameTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(surnameTextBlock);
            }
            if (personName != "")
            {
                nameTextBlock.FontWeight = System.Windows.FontWeights.Bold;
                nameTextBlock.Text = personName;
                PersonName = personName;
                nameTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(nameTextBlock);
            }
            if (personPatronymic != "")
            {
                patronymicTextBlock.FontWeight = System.Windows.FontWeights.Bold;
                patronymicTextBlock.Text = personPatronymic;
                PersonPatronymic = personPatronymic;
                patronymicTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(patronymicTextBlock);
            }
            myButton.MouseDoubleClick += DoubleClick;
        }

        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            PersonWindow p = new PersonWindow(MainWindow.WindowType.Update, this, new Point(10000, 10000));
            p.Show();
        }
    }
}
