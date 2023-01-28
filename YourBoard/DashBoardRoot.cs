using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace YourBoard
{
    internal class DashBoardRoot
    {
        public static double createdPersonX;
        public static double createdPersonY;
        public static List<DashBoardElement> Persons = new List<DashBoardElement>();
        public static Canvas MainCanvas = new Canvas();
        public static bool isMousePressedinPerson = false;
        public DashBoardRoot()
        {
            MainCanvas.Background = new SolidColorBrush(Color.FromRgb(69, 94, 131));
            ContextMenu canvasMenu = new ContextMenu();
            MenuItem createPerson = new MenuItem();
            createPerson.Header = "Create a person";
            canvasMenu.Items.Add(createPerson);
            MainCanvas.ContextMenu = canvasMenu;
            createPerson.PreviewMouseUp += CreatePersonMenuOpen;
            MainCanvas.PreviewMouseMove += OnMouseMove;
            MainCanvas.PreviewMouseLeftButtonUp += OnMouseUp;
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {

        }

        private void CreatePersonMenuOpen(object sender, MouseButtonEventArgs e)
        {
        }
    }
}
