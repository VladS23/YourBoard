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

namespace YourBoard
{
    internal class Person:DashBoardObject
    {
        public bool isMousePressedinPerson = false;
        public string PersonName;
        public string PersonSurname;
        public string PerssonPatronymic;
        public double X
        {
            get { return x; }
            set { x = value; Canvas.SetLeft(view, value); }
        }
        public double Y
        {
            get { return y; }
            set { y = value; Canvas.SetTop(view, value); }
        }

        private double x = 0;
        private double y = 0;
        public Person(string avatar, string personSurname, string personName, string personPatronymic)
        {
            try
            {
                CreateView(avatar);
            }
            catch
            {
                CreateView(Directory.GetCurrentDirectory() + @"\Icons\person.png");
            }
            Button btn = view.Children.OfType<Button>().FirstOrDefault();
            btn.Style = (Style)btn.FindResource("PersonButStyle");
            {
                TextBlock surnameTextBlock=new TextBlock();
                surnameTextBlock.Text=personSurname;
                surnameTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(surnameTextBlock);
            }
            if (personName != "")
            {
                TextBlock nameTextBlock = new TextBlock();
                nameTextBlock.Text = personName;
                nameTextBlock.HorizontalAlignment=HorizontalAlignment.Center;
                view.Children.Add(nameTextBlock);
            }
            if (personPatronymic != "")
            {
                TextBlock patronymicTextBlock = new TextBlock();
                patronymicTextBlock.Text = personPatronymic;
                patronymicTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
                view.Children.Add(patronymicTextBlock);
            }
            btn.PreviewMouseMove += OnMouseMove;
            btn.PreviewMouseLeftButtonUp += OnMouseUp;
            btn.PreviewMouseLeftButtonDown += OnMouseDown;
        }

        System.Windows.Point pressedPos;
        System.Windows.Point curPos;
        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            isMousePressedinPerson = true;
            pressedPos = e.GetPosition((System.Windows.IInputElement)view.Parent);
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            isMousePressedinPerson = false;
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            curPos = e.GetPosition((System.Windows.IInputElement)view.Parent);
            if (isMousePressedinPerson)
            {
               /* foreach (Connection connection in CanvasRoot.Connections)
                {
                    if (connection.person1 == this || connection.person2 == this)
                    {
                        connection.UpdateConnection();
                    }
                }*/
                X = X + curPos.X - pressedPos.X;
                Y = Y + curPos.Y - pressedPos.Y;
                if (X < 0)
                {
                    X = 0;
                }
                else if (Y < 0)
                {
                    Y = 0;
                }
                else if (Y > DashBoardRoot.MainCanvas.ActualHeight - view.ActualHeight)
                {
                    Y = DashBoardRoot.MainCanvas.ActualHeight - view.ActualHeight;
                }
                else if (X > DashBoardRoot.MainCanvas.ActualWidth - view.ActualWidth)
                {
                    X = DashBoardRoot.MainCanvas.ActualWidth - view.ActualWidth;
                }
            }
            pressedPos = curPos;
        }

    }
}
