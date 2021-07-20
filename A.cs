using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class A
    {
        // class A is dependent on class B
        // class B is a dependency of A
        B b;

        public A()
        {
            b = Factory.GetObjectOfB();
        }

        public void Task1()
        {
            // do something here..
            b.SomeMethod();
            // do something here..
        }
    }
}
