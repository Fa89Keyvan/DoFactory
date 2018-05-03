using System.Diagnostics;

namespace DoFactory.AbstractFactory.Paint.Colors
{
    class Blue : IColor
    {
        public void Fill()
        {
            Debug.WriteLine("Fill with blue color");
        }
    }
}
