using DeadLine6.Graphic.Controls.Figures;
using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace DeadLine6.Graphic.Controls
{
    public class Table<T>: Control
    {   
        public int ColumnInterval { get; set; }
        public int RowInterval { get; set; }
        public Action<object, int, int> ActionDrawRows;
        public List<string> ColumnNames { get; set; }
        public List<T> objects { get; set; }
        private Square Square { get; set; }
        public List<Line> Lines { get; set; }
        public int SquareSpaceX = 5;
        public int SquareSpaceY = 2;
        public Table(Point point):base (point)
        { 
        
        }

        public void fill(List<T> _objects,int ColumnInterval, int RowInterval)
        {
            this.ColumnInterval = ColumnInterval;
            this.RowInterval = RowInterval;
            objects = _objects;
            Square = new Square(Point, (RowInterval) * (objects.Count+1), (ColumnInterval) * ColumnNames.Count);
            Lines = Enumerable.Range(1, objects.Count).Select(x => new Line(new Point(Point.PositionX, Point.PositionY + RowInterval * x), LineType.Horizontal, (ColumnInterval) * ColumnNames.Count, "-")).ToList();
            foreach (int i in Enumerable.Range(1, ColumnNames.Count-1))
            {
                Lines.Add(new Line(new Point(Point.PositionX + ColumnInterval * i, Point.PositionY), LineType.Vertical, (RowInterval) * (objects.Count+1), "|"));
            }
        }

        public override void Clear()
        {
            base.Clear();
        }

        public override void Draw()
        {
            int RowIntervalCount = 1;
            
            ColumnsDraw();
            foreach (var element in objects)
            {
                base.Draw(SquareSpaceX/2, RowIntervalCount * RowInterval+ SquareSpaceY);
                ActionDrawRows?.Invoke(element, ColumnInterval, RowInterval);
                RowIntervalCount++;
            }
            Square.Draw();
            foreach (var line in Lines)
            {
                line.Draw();
            }


        }

        public void SetColumnName(params string[] names)
        {
            ColumnNames = names.ToList();
        }

        

        private void ColumnsDraw()
        {
            Console.SetCursorPosition(Point.PositionX+ SquareSpaceX / 2, Point.PositionY+3);
            var ColumnNamesText = ColumnsFormat();
            Console.Write(ColumnNamesText.Trim());
        }

        private string ColumnsFormat()
        {
            string Text = string.Empty;
            foreach (var Name in ColumnNames)
                Text += Name + new string(' ', ColumnInterval - Name.Length);
            return Text;
        }
    }
}
