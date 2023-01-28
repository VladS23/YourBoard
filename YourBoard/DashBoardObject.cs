using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace YourBoard
{
    public abstract class DashBoardObject: DashBoardElement
    {
        public StackPanel view = new StackPanel();
        public override void CreateView(string imageAdr)
        {
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
            Canvas.SetLeft(view, 100);
            Canvas.SetTop(view, 100);
            view.Children.Add(myButton);
            Panel.SetZIndex(view, 150);
            DashBoardRoot.MainCanvas.Children.Add(view);
        }
        public override void Delete()
        {

        }
        public override void Move()
        {

        }
    }
}
