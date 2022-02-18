using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace BlazorEf.utils
{
    public class MyHelper
    {
        public static string GetDisplayName<T>( string propertyname)
        {
            MemberInfo myprop = typeof(T).GetProperty(propertyname) as MemberInfo;
            var dd = myprop.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
            return dd?.Name ?? "";
        }
    }
}
