﻿using System;
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
        protected List<Control> controls;
        public Page(JsonDatabaseContext jsonDatabaseContext)
        {
            controls = new List<Control>();
            SetGraphics();
        }

        public Page(Page page, JsonDatabaseContext jsonDatabaseContext) : this(jsonDatabaseContext)
        {
            PreviousPage = page;
        }
        public abstract void SetGraphics();
        public abstract void Draw();
        public abstract void Action();
    }
}
