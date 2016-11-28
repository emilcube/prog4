using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4lab
{
    class Controller : IController
    {
        IModel model;
        List<IView> views = new List<IView>();
        public void Add()
        {
            model.AddNode("Node " + model.Count);
        }

        public void AddView(IView v)
        {
            views.Add(v);
        }

        public void Remove()
        {
            model.RemoveLastNode();
        }

        public void SetModel(IModel m)
        {
            model = m;
        }
    }
}
