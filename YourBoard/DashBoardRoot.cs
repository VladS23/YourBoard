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
        public static List<DashBoardElement> Elements = new List<DashBoardElement>();
        public static Canvas MainCanvas = new Canvas();
        public static bool isMousePressedinPerson = false;
        bool isMousePressed = false;
        Point pressedPos;
        Point curPos;
        public DashBoardRoot()
        {
            MainCanvas.Background = new SolidColorBrush(Color.FromRgb(255,255,255));
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
            if (!DashBoardObject.isMousePressedinObject)
            {
                isMousePressed = false;
            }
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!DashBoardObject.isMousePressedinObject)
            {
                curPos = e.GetPosition(MainCanvas);
                if (Mouse.LeftButton == MouseButtonState.Pressed)
                {
                    foreach (DashBoardElement element in Elements)
                    {
                        if (element is DashBoardObject)
                        {
                            ((DashBoardObject)element).Move(curPos, pressedPos);
                        }
                    }
                }
                pressedPos = curPos;
            }
        }

        private void CreatePersonMenuOpen(object sender, MouseButtonEventArgs e)
        {
        }
    }
}
