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
using System.IO;

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
            DashBoardRoot.Elements.Add (new Person("incorrectPath", "surname", "name", "patronymic", 100, 100));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "surname", "name", "patronymic", 243, 342));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "surname", "name", "patronymic", 243, 543));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "surname", "name", "patronymic", 46, 786));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "surname", "name", "patronymic", 254, 987));
        }
    }
}
