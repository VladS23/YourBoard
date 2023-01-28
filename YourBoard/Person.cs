using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Resources;
using System.Windows.Controls;

namespace YourBoard
{
    internal class Person:DashBoardObject
    {
        public Person(string avatar, string surname, string name, string patronymic)
        {
            CreateView(avatar);
            Button btn = view.Children.OfType<Button>().FirstOrDefault();
            btn.Style = (Style)Resources["TitleText"];
            {
                TextBlock surnameTextBlock=new TextBlock();
                surnameTextBlock.Text=surname;
                surnameTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(surnameTextBlock);
            }
            if (name != "")
            {
                TextBlock nameTextBlock = new TextBlock();
                nameTextBlock.Text = name;
                nameTextBlock.HorizontalAlignment=HorizontalAlignment.Center;
                view.Children.Add(nameTextBlock);
            }
            if (patronymic != "")
            {
                TextBlock patronymicTextBlock = new TextBlock();
                patronymicTextBlock.Text = patronymic;
                patronymicTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(patronymicTextBlock);
            }
        }

    }
}
