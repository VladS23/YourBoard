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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YourBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DashBoardRoot dashBoardRoot = new DashBoardRoot();
            MainGrid.Children.Add(DashBoardRoot.MainCanvas);

            StackPanel view = new StackPanel();
            StackPanel mystackPanel = new StackPanel();
            Button myButton = new Button();
            BitmapImage myBitmapImage = new BitmapImage();
            Image PersonImage = new Image();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@"C:\Users\Vlad\Desktop\photo_2023-01-18_13-40-30.jpg");
            myBitmapImage.EndInit();
            PersonImage.Source = myBitmapImage;
            PersonImage.Stretch = Stretch.Fill;
            //myButton.Content = PersonImage;
            myButton.Width = 500;
            myButton.Height = 500;
            Canvas.SetLeft(mystackPanel, 100);
            Canvas.SetTop(mystackPanel, 100);
            mystackPanel.Children.Add(myButton);
            view = mystackPanel;
            Canvas.SetZIndex(view, 150);
            DashBoardRoot.MainCanvas.Children.Add(view);

            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.LightGray, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 1));

            // добавление ресурса в словарь ресурсов окна
            this.Resources.Add("buttonGradientBrush", gradientBrush);

            // установка ресурса у кнопки
            myButton.Background = (Brush)this.TryFindResource("buttonGradientBrush");
        }
    }
}
