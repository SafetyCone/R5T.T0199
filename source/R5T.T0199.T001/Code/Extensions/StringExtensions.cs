using System;

using Instances = R5T.T0199.T001.Instances;


namespace R5T.N0003.Extensions
{
    public static class StringExtensions
    {
        public static ICompanyName ToCompanyName(this string value)
        {
            return Instances.StringOperator_Extensions.ToCompanyName(value);
        }

        public static IDescription ToDescription(this string value)
        {
            return Instances.StringOperator_Extensions.ToDescription(value);
        }
    }
}
