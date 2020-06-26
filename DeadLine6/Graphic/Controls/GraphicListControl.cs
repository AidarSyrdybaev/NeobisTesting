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
        public GraphicListControl(Point point, List<String> _controlsTxt, ControlType controlType, ListLine line) : this(point)
        {
            InitializeControls(_controlsTxt, controlType);
            InitializeControl();
            ListLine = line;
        }

        private void InitializeControls(List<String> controlsTxt, ControlType controlType)
        {
            int XCount = ListLine == ListLine.Horizontal ? 1 : 0;
            int YCount = ListLine == ListLine.Vertical ? 1 : 0;
            Controls = Enumerable.Range(0, controlsTxt.Count).Select(i =>
                ControlExtensions.GetControlTypeObject(controlType, new Point(Point.PositionX + i * XCount, Point.PositionX + i * YCount))).ToList();
            int Count = 0;
            foreach (var text in controlsTxt)
            {
                Controls[Count].TxtValue = text;
                Count++;
            }

        }
        public override void InitializeControl()
        {
            ActiveControl = Controls[0];
            if (ListLine == ListLine.Vertical)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].SetControlsNav(Controls[i], Controls[i], Controls[i == 0 ? Controls.Count - 1 : i-1],
                        Controls[(i+1) % Controls.Count]);
                }

            }
            else
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].SetControlsNav(Controls[i == 0 ? Controls.Count - 1 : i - 1],
                        Controls[i % (Controls.Count - 1)], Controls[i], Controls[i]);
                }
            }
        }

        public override void Action()
        {
            Marker marker = new Marker(Controls[0], "*");
            marker.Action();
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

        public void AddActionToChildrenControl(string ControlTxtValue, Action action)
        {
            foreach (var control in Controls)
            {
                if (control.TxtValue == ControlTxtValue)
                    control.ActionEvent = action;
            }
        }
    }
}
