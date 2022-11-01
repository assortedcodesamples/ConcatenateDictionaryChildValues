using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenatedictionarychildvalues
{
    public static class ChildrenExtensionMethods
    {
        public static string ExternalToString(this Child child)
        {
            return $"Name is {child.Name} and age is {child.Age}";
        }
        public static string ExternalToString(this IEnumerable<Child> children)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int childCounter = 1;
            foreach (Child child in children)
            {
                stringBuilder.AppendLine($"Child {childCounter} {child.ExternalToString()}");
                childCounter++;
            }
            return stringBuilder.ToString();
        }

    }
}
