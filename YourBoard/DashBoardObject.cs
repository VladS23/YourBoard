using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace YourBoard
{
    public abstract class DashBoardObject: DashBoardElement
    {
        public StackPanel view = new StackPanel();
        public static bool isMousePressedinObject = false;
        public List<Relation> Relations = new List<Relation>();
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
        public void CreateView(string imageAdr, double X_, double Y_)
        {
            X = X_;
            Y = Y_;
            Button myButton = new Button();
            BitmapImage myBitmapImage = new BitmapImage();
            Image PersonImage = new Image();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(imageAdr);
            myBitmapImage.EndInit();
            PersonImage.Source = myBitmapImage;
            PersonImage.Stretch = Stretch.Fill;
            RectangleGeometry roundedImage = new RectangleGeometry();
            roundedImage.RadiusX = 4;
            roundedImage.RadiusY = 4;
            roundedImage.Rect = new Rect(new Size(50, 50));
            PersonImage.Clip = roundedImage;
            myButton.Content = PersonImage;
            myButton.Width = 50;
            myButton.Height = 50;
            Canvas.SetLeft(view, X_);
            Canvas.SetTop(view, Y_);
            view.Children.Add(myButton);
            Panel.SetZIndex(view, 150);
            DashBoardRoot.MainCanvas.Children.Add(view);
            myButton.PreviewMouseMove += OnMouseMove;
            myButton.PreviewMouseLeftButtonUp += OnMouseUp;
            myButton.PreviewMouseLeftButtonDown += OnMouseDown;
        }
        public override void Delete()
        {

        }
        public override void Move(Point curPos, Point pressedPos)
        {
            X = X + curPos.X - pressedPos.X;
            Y = Y + curPos.Y - pressedPos.Y;
        }

        System.Windows.Point pressedPos;
        System.Windows.Point curPos;
        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            isMousePressedinObject = true;
            pressedPos = e.GetPosition((System.Windows.IInputElement)view.Parent);
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            isMousePressedinObject = false;
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            curPos = e.GetPosition((System.Windows.IInputElement)view.Parent);
            if (isMousePressedinObject)
            {
                Move(curPos, pressedPos);
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
            foreach (Relation rel in Relations)
            {
                rel.Move(curPos, pressedPos);
            }
            pressedPos = curPos;
        }
    }
}
