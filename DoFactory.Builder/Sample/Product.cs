using System.Collections.Generic;
using System.Diagnostics;

namespace DoFactory.Builder.Sample
{
    class Product
    {
        private List<string> _parts = new List<string>();

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public void ShowParts()
        {
            Debug.WriteLine("\nProduct Parts -------");
            _parts.ForEach((c) => Debug.WriteLine(c));
        }
    }
}
