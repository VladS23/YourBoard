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
        public enum WindowType
        {
            Create=0,
            Update=1
        }
        public MainWindow()
        {
            InitializeComponent();
            Random rand = new Random();
            string[] surname = { "Смирнов", "Иванов", "Кузнецов", "Соколов", "Попов", "Лебедев", "Козлов", "Новиков", "Морозов", "Петров", "Волков", "Соловьёв", "Васильев", "Зайцев", "Павлов", "Семёнов", "Голубев", "Виноградов", "Богданов", "Воробьёв" };
            string[] name = { "Александр", "Михаил", "Сергей", "Дмитрий", "Андрей", "Алексей", "Максим", "Евгений", "Владимир", "Иван" };
            string[] patronymic = { "Александрович", "Михайлович", "Сергеевич", "Дмитриевич", "Андреевич", "Алексеевич", "Максимович", "Евгеньевич", "Владимирович", "Иванович" };
            DashBoardRoot dashBoardRoot = new DashBoardRoot();
            MainGrid.Children.Add(DashBoardRoot.MainCanvas);
            for (int i=0; i<10; i++)
            {
                DashBoardRoot.Elements.Add(new Person("Incorrect Path", surname[rand.Next(20)], name[rand.Next(10)], patronymic[rand.Next(10)], rand.Next(2560), rand.Next(1440)));
            }
            for (int i = 0; i < 5; i++)
            {
                DashBoardRoot.Elements.Add(new Relation((Relation.RelationTypes)(rand.Next(5)), (DashBoardObject)DashBoardRoot.Elements[rand.Next(10)], (DashBoardObject)DashBoardRoot.Elements[rand.Next(10)]));
            }
            YourBoard.PersonWindow personWindow = new YourBoard.PersonWindow(WindowType.Update,  new Person("фвы", "Иванов", "Иван", "Иванович", 100000, 100000), new Point(10000, 10000));
            personWindow.Show();
        }
    }
}
