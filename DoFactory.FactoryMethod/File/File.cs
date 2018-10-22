using System;
using System.Diagnostics;

namespace DoFactory.FactoryMethod.File
{
    public abstract class File
    {
        public abstract string FileExtention { get; }

        public void ShowExtention()
        {
            Debug.WriteLine(this.FileExtention);
        }
    }
}
