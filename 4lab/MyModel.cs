using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4lab
{
    class MyModel : IModel
    {
       LinkedList<MyNode> nodes = new LinkedList<MyNode>();
        public int Count
        {
            get
            {
                return nodes.Count;
            }
        }

        static Random r = new Random();
        public void AddNode(string text)
        {
            nodes.AddFirst(new MyNode(text,
                r.Next(10),
                r.Next(10)
                ));
        }

        public void RemoveLastNode()
        {
            nodes.RemoveLast();
        }
    }
}
