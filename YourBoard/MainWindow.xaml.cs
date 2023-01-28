﻿using System;
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
            Person p1 = new Person(@"C:\Users\Vlad\Desktop\person.png", "surname", "name", "patronymic");
        }
    }
}
