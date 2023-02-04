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
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string PerssonPatronymic { get; set; }
        public string PerssonBornDate { get; set; }
        public string PerssonEmail{ get; set; }
        public string PerssonAdress { get; set; }
        public string PerssonWork { get; set; }
        public string PerssonUniver { get; set; }
        public string PerssonPhone{ get; set; }
        public string PerssonPost { get; set; }
        public string PerssonSpec { get; set; }
        public string PerssonVk{ get; set; }
        public string PerssonTg{ get; set; }
        public TextRange PersonComm { get; set; }
        public string PerssonOtherInfo1 { get; set; }
        public string PerssonOtherInfo2 { get; set; }
        public string PerssonOtherInfo3 { get; set; }
        public string PerssonOtherInfo4 { get; set; }
        public string PerssonOtherInfo5 { get; set; }
        public string PerssonOtherInfo6 { get; set; }
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
