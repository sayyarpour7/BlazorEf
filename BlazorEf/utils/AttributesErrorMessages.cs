using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEf.utils
{
    public static class AttributesErrorMessages
    {
        public const string RequiredMessage = "لطفا {0} را وارد نمایید";
        public const string MinLengthMessage = "{0} نباید کمتر از {1} کاراکتر باشد";
        public const string MaxLengthMessage = "{0} نباید بیشتر از {1} کاراکتر باشد";
        public const string RegularExpressionMessage = "{0} را به درستی وارد نمایید";
        public const string StringLengthMessage = "{0} باید بین {2} کاراکتر و {1} کاراکتر باشد";
        public const string RemoteMessage = "با این {0} قبلا ثبت نام شده است";
    }
}
