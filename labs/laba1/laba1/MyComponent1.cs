using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public partial class MyComponent1 : Component
    {
        public event EventHandler Tick;
        public MyComponent1()
        {
            InitializeComponent();
            Init();
        }

        public MyComponent1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Init();
        }

        private void Init()
        {
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Tick?.Invoke(this, EventArgs.Empty);
            Debug.WriteLine($"{DateTime.Now}");
        }
    }
}
