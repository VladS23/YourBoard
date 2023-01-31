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

namespace YourBoard
{
    internal class Person:DashBoardObject
    {
        public string PersonName;
        public string PersonSurname;
        public string PerssonPatronymic;
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
                TextBlock surnameTextBlock = new TextBlock();
                surnameTextBlock.FontWeight = System.Windows.FontWeights.Bold;
                surnameTextBlock.Text = personSurname;
                surnameTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(surnameTextBlock);
            }
            if (personName != "")
            {
                TextBlock nameTextBlock = new TextBlock();
                nameTextBlock.FontWeight = System.Windows.FontWeights.Bold;
                nameTextBlock.Text = personName;
                nameTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(nameTextBlock);
            }
            if (personPatronymic != "")
            {
                TextBlock patronymicTextBlock = new TextBlock();
                patronymicTextBlock.FontWeight = System.Windows.FontWeights.Bold;
                patronymicTextBlock.Text = personPatronymic;
                patronymicTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(patronymicTextBlock);
            }

        }
    }
}
