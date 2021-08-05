using Microsoft.EntityFrameworkCore;
using System;

namespace ShopWebData
{
    public class StringExtensions
    {
        [DbFunction(Name = "TRANSLATE", IsBuiltIn = true)]
        public static string Translate(string NormalString, string ToReplace, string ReplaceWith)
        {
            throw new NotImplementedException();
        }
    }
}