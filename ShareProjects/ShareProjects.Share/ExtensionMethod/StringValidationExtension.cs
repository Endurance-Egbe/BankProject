using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ShareProjects.Share.ExtensionMethod
{
    public static class StringValidationExtension
    {
        public static bool IsValid(this string text)
        {
            return !string.IsNullOrWhiteSpace(text) && !string.IsNullOrEmpty(text);
        }
        public static bool IsNotValid(this string text)
        {
            return string.IsNullOrWhiteSpace(text) || string.IsNullOrEmpty(text);
        }
        public static bool IsValidEmailString(this string emailString)
        {
            if (string.IsNullOrEmpty(emailString)) return false;

            var patternRule = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                  + "@"
                                  + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
            return new Regex(patternRule)
                     .IsMatch(emailString);

        }
        public static bool IsNotValidEmailString(this string emailString)
        {
            return !emailString.IsValidEmailString();
        }
        public static bool IsNullOrEmpty(this Guid guid)
        {
            return guid == null || guid == Guid.Empty;
        }
    }
}
