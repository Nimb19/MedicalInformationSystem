using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCorporation.Core.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class DisplayedName : Attribute
    {
        public string Name { get; set; }

        public DisplayedName(string name)
        {
            Name = name;
        }
    }
}
