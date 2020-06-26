using System;
using System.Collections.Generic;
using System.Linq;
using DeadLine6.Graphic.Elements;
using System.Text;
using DeadLine6.Utils;

namespace DeadLine6.Graphic.Controls
{
    public enum ListLine
    {
        Horizontal,
        Vertical
    }

    public class GraphicListControl: Control
    {
        public ListLine ListLine = ListLine.Vertical;
        public int RowInterval { get; set; }
        private Control ActiveControl;
        private List<Control> Controls { get; set; }
        public GraphicListControl(Point point) : base(point)
        {
            
        }
        public GraphicListControl(Point point, List<String> _controlsTxt, ControlType controlType) : this(point)
        {
            
        }

        private void InitializeControls(List<String> controlsTxt, ControlType controlType)
        {
            int XCount = ListLine == ListLine.Vertical ? 1 : 0;
            int YCount = ListLine == ListLine.Horizontal ? 1 : 0;
            foreach (var text in controlsTxt)
            {

                Controls = Enumerable.Range(0, controlsTxt.Count).Select(i =>
                    ControlExtensions.GetControlTypeObject(controlType, new Point(Point.PositionX + i * XCount, Point.PositionX + i * YCount))).ToList();
            }

        }
        public override void InitializeControl()
        {
            ActiveControl = Controls[0];
            if (ListLine == ListLine.Vertical)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].SetControlsNav(Controls[i], Controls[i], Controls[i == 0 ? Controls.Count - 2 : i - 1],
                        Controls[i % (Controls.Count - 1) + 1]);
                }

            }
            else
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].SetControlsNav(Controls[i == 0 ? Controls.Count - 2 : i - 1],
                        Controls[i % (Controls.Count - 1) + 1], Controls[i], Controls[i]);
                }
            }
        }

        public override void Action()
        {

        }

        public override void Draw()
        {
            base.Draw();
            Console.Write(TxtValue);
            int Index = 1;
            foreach (var Control in Controls)
            {   
                Control.Draw(-3,0);
                Console.Write(Index);
                Control.Draw();
                Index++;
            }
            base.Draw();
        }
    }
}
