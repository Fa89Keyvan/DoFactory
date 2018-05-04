using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DoFactory.FactoryMethod.Shapes
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Debug.WriteLine("Circle has drawed");
        }
    }
}
