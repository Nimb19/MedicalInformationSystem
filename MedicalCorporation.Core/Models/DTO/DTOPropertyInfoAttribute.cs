using System;

namespace MedicalCorporation.Core.Models.DTO
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DTOPropertyInfoAttribute : Attribute
    {
        public string DisplayedName { get; set; }

        public DTOPropertyInfoAttribute(string displayedName)
        {
            DisplayedName = displayedName;
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DTOLocalizablePropertyInfo : DTOPropertyInfoAttribute
    {
        public DTOLocalizablePropertyInfo(Type resourceProvider, string displayedNameResource) 
            : base(CoreExtensions.GetResourceValue(resourceProvider, displayedNameResource).ToString())  
        {
        }
    }
}
