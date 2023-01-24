using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionShapes
{
    public class BaseShape
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public BaseShape(string name)
        {
            Name = name;
        }
    }
}
