using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4lab
{
    class LabelView : IView

    {
        IModel model;
        Label l;
        public void SetModel(IModel m)
        {
            model = m;
        }

        public void UpdateView()
        {
            l.Text = model.Count.ToString();
        }

        public LabelView(IModel m, Label l)
        {
            SetModel(m); this.l = l;
        }

    }
}
