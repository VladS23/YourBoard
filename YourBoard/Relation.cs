using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace YourBoard
{
    public class Relation : DashBoardElement
    {
        public enum RelationTypes
        {
            Friends=0,
            Familiar, 
            Сolleagues, 
            Love, 
            Family,
        }
        Dictionary<RelationTypes, System.Windows.Media.SolidColorBrush> typeToColor = new Dictionary<RelationTypes, System.Windows.Media.SolidColorBrush>()
{
            {RelationTypes.Friends, System.Windows.Media.Brushes.Green },
            {RelationTypes.Familiar, System.Windows.Media.Brushes.Gray },
            {RelationTypes.Сolleagues, System.Windows.Media.Brushes.CadetBlue },
            {RelationTypes.Love, System.Windows.Media.Brushes.HotPink },
            {RelationTypes.Family, System.Windows.Media.Brushes.Orange }
};
        Dictionary<RelationTypes, string> typeToText = new Dictionary<RelationTypes, string>()
{
            {RelationTypes.Friends, "Друзья" },
            {RelationTypes.Familiar, "Знакомые"},
            {RelationTypes.Сolleagues, "Коллеги"},
            {RelationTypes.Love, "В отношениях" },
            {RelationTypes.Family, "Семья"}
};
        DashBoardObject DashBoardObject1 { get; set; }
        DashBoardObject DashBoardObject2 { get; set; }
        RelationTypes RelationType { get; set; }
        public Line l1 = new Line();
        public ToolTip toolTip = new ToolTip();
        public Relation(RelationTypes type, DashBoardObject dbobj1, DashBoardObject dbobj2)
        {
            RelationType = type;
            DashBoardObject1 = dbobj1;
            DashBoardObject2 = dbobj2;
            dbobj1.Relations.Add(this);
            dbobj2.Relations.Add(this);
            CreateView(typeToColor[type], dbobj1, dbobj2);
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = typeToText[type] });
            toolTip.Content = toolTipPanel;
            l1.ToolTip = toolTip;
        }

        public void CreateView(System.Windows.Media.SolidColorBrush colour, DashBoardObject dbobj1, DashBoardObject dbobj2)
        {
            Panel.SetZIndex(l1, 0);
            l1.StrokeThickness = 3;
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
            l1.X1 = DashBoardObject1.X + 25;
            l1.Y1 = DashBoardObject1.Y + 25;
            l1.X2 = DashBoardObject2.X + 25;
            l1.Y2 = DashBoardObject2.Y + 25;
        }
    }
}
