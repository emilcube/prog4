using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4lab
{
    interface IController
    {

        void SetModel(IModel m);
        void AddView();
    }
}
