using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls.Pages
{
    public abstract class Page
    {
        public Page PreviousPage;
        public List<Page> NextPages;
        protected JsonDatabaseContext jsonDatabaseContext;
        protected Marker Marker;
        protected List<Control> DrawControls;
        protected List<Control> UseControls;
        public Page(JsonDatabaseContext jsonDatabaseContext)
        {
            this.jsonDatabaseContext = jsonDatabaseContext;
            DrawControls = new List<Control>();
            UseControls = new List<Control>();
            SetGraphics();
        }

        public Page(Page page, JsonDatabaseContext jsonDatabaseContext) : this(jsonDatabaseContext)
        {
            PreviousPage = page;
        }
        public abstract void SetGraphics();

        public virtual void Draw()
        {
            foreach (var control in DrawControls)
            {
                control.Draw();
            }

            foreach (var control in UseControls)
            {
                control.Draw();
            }
        }

        public virtual void Action()
        {
            Marker marker = new Marker(UseControls[0], "*");
            marker.Action();
            Console.Clear();
        }

        public virtual void SetUseVerticalControlNavs()
        {
            for (int i = 0; i < UseControls.Count; i++)
            {
                UseControls[i].SetVertricalControlsNav(UseControls[i <= 0 ? UseControls.Count-1: i-1], UseControls[i >= UseControls.Count-1? 0: i+1]);
            }
        }
    }
}
