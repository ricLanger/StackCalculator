using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Calculator.Library.RechenOperationen
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class OperationClassAttribute : Attribute
    {
    }
}
