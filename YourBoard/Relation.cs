﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace YourBoard
{
    internal class Relation : DashBoardElement
    {
        public enum RelationTypes
        {
            Friends
        }
        Dictionary<RelationTypes, System.Windows.Media.SolidColorBrush> typeToColor = new Dictionary<RelationTypes, System.Windows.Media.SolidColorBrush>()
{
            {RelationTypes.Friends, System.Windows.Media.Brushes.Green }
};
        DashBoardObject DashBoardObject1 { get; set; }
        DashBoardObject DashBoardObject2 { get; set; }
        RelationTypes RelationType { get; set; }
        public Line l1 = new Line();
        public Relation(RelationTypes type, DashBoardObject dbobj1, DashBoardObject dbobj2)
        {
            RelationType = type;
            DashBoardObject1 = dbobj1;
            DashBoardObject2 = dbobj2;
            CreateView(typeToColor[type], dbobj1, dbobj2);
            
        }
        public void CreateView(System.Windows.Media.SolidColorBrush colour, DashBoardObject dbobj1, DashBoardObject dbobj2)
        {
            Canvas.SetZIndex(l1, 0);
            l1.StrokeThickness = 2;
            l1.Stroke = colour;
            l1.X1 = dbobj1.X + 25;
            l1.Y1 = dbobj1.Y + 25;
            l1.X2 = dbobj2.X + 25;
            l1.Y2 = dbobj2.Y + 25;
            DashBoardRoot.MainCanvas.Children.Add(l1);
        }
        public override void Delete()
        {

        }
        public override void Move(Point curpos, Point pressedpos)
        {

        }
    }
}