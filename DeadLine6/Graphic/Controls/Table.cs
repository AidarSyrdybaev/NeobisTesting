using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DeadLine6.Graphic.Controls
{
    public class Table<T>: Control
    {   
        public int ColumnIntevral { get; set; }
        public int RowInterval { get; set; }
        public Action<object, int, int> ActionDrawRows;
        public List<string> ColumnNames { get; set; }
        public List<T> objects { get; set; }
        public Table(Point point):base (point)
        { 
        
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
                base.Draw(0, RowIntervalCount * RowInterval);
                ActionDrawRows?.Invoke(element, ColumnIntevral, RowInterval);
                RowIntervalCount++;
            }
            

        }

        public void SetColumnName(params string[] names)
        {
            ColumnNames = names.ToList();
        }

        

        private void ColumnsDraw()
        {
            Console.SetCursorPosition(Point.PositionX, Point.PositionY+3);
            var ColumnNamesText = ColumnsFormat();
            Console.Write(ColumnNamesText.Trim());
        }

        private string ColumnsFormat()
        {
            string Text = string.Empty;
            foreach (var Name in ColumnNames)
                Text += Name + new string(' ', ColumnIntevral - Name.Length);
            return Text;
        }
    }
}
