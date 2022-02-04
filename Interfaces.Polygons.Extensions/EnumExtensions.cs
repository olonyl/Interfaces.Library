using System.ComponentModel;
using System.Linq;

namespace System
{
    public static class EnumExtensions
    {
        public static string GetName(this Enum element)
        {
            return Enum.GetName(element.GetType(), element);
        }

        public static string GetDescription(this Enum element)
        {
            var fieldInfo = element.GetType().GetField(element.GetName());
            var descriptionAttribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

            return descriptionAttribute == null ? element.GetName() : descriptionAttribute.Description;
        }
    }
}
