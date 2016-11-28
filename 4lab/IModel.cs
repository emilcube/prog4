using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4lab
{
    interface IModel
    {
        void AddNode(string text);
        void RemoveLastNode();
        int Count { get; }



    }
}
