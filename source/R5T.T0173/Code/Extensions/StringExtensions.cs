﻿using System;


namespace R5T.T0173.Extensions
{
    public static class StringExtensions
    {
        public static IDescriptionXml ToDescriptionXml(this string value)
        {
            return Instances.StringOperator.ToDescriptionXml(value);
        }
    }
}
