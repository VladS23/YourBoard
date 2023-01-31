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
            DashBoardRoot.Elements.Add (new Person("incorrectPath", "Петров", "Петр", "", 100, 100));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "Иванов", "Иван", "Иванович", 243, 342));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "Лисин", "Генадий", "Михайлович", 243, 543));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "Пирсов", "Даниил", "Сергеевич", 46, 786));
            DashBoardRoot.Elements.Add(new Person("incorrectPath", "Кротов", "Василий", "Петрович", 254, 987));
            DashBoardRoot.Elements.Add(new Relation(Relation.RelationTypes.Friends, (DashBoardObject)DashBoardRoot.Elements[0], (DashBoardObject)DashBoardRoot.Elements[1]));
            DashBoardRoot.Elements.Add(new Relation(Relation.RelationTypes.Friends, (DashBoardObject)DashBoardRoot.Elements[2], (DashBoardObject)DashBoardRoot.Elements[1]));
            DashBoardRoot.Elements.Add(new Relation(Relation.RelationTypes.Friends, (DashBoardObject)DashBoardRoot.Elements[0], (DashBoardObject)DashBoardRoot.Elements[4]));
            DashBoardRoot.Elements.Add(new Relation(Relation.RelationTypes.Friends, (DashBoardObject)DashBoardRoot.Elements[3], (DashBoardObject)DashBoardRoot.Elements[1]));
            DashBoardRoot.Elements.Add(new Relation(Relation.RelationTypes.Friends, (DashBoardObject)DashBoardRoot.Elements[2], (DashBoardObject)DashBoardRoot.Elements[3]));




        }
    }
}
