using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4lab
{
    public partial class Form1 : Form
    {
        IController controller;
        public Form1()
        {
            IModel model=null;
            IView labView;
            controller = new Controller();
            controller.SetModel(model);
            labView = new LabelView(model, label1);
            controller.AddView(labView);
            model = new MyModel();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.Remove();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
