using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrafficApp
{
    public static class EnumHelper
    {

        public static string GetEnumDes(this Enum enumVal)
        {
            //01.获取枚举值所在的枚举的类型;
            Type enumType = enumVal.GetType();
            //02.获取当前枚举值的字段信息;
            var fieldInfo = enumType.GetField(enumVal.ToString());
            //03.获取当前枚举值字段信息中的描述属性信息;
            var des = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

            if (des == null)
            {
                return string.Empty;
            }
            
            DescriptionAttribute desAttribute = des as DescriptionAttribute;

            return desAttribute.Description;
        }

    }
}
