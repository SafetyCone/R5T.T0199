using System;

using R5T.T0199.T000.Extensions;

using Instances = R5T.T0199.T000.Instances;


namespace R5T.N0003.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToEnvironmentVariableName(string)"/>
        public static IEnvironmentVariableName ToEnvironmentVariableName(this string value)
        {
            return Instances.StringOperator_Extensions.ToEnvironmentVariableName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToEnvironmentVariableValue(string)"/>
        public static IEnvironmentVariableValue ToEnvironmentVariableValue(this string value)
        {
            return Instances.StringOperator_Extensions.ToEnvironmentVariableValue(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSearchPattern(string)"/>
        public static ISearchPattern ToSearchPattern(this string value)
        {
            return Instances.StringOperator_Extensions.ToSearchPattern(value);
        }

        public static IDateTimeFormat ToDateTimeFormat(this string value)
        {
            return Instances.StringOperator_Extensions.ToDateTimeFormat(value);
        }

        public static IDateTimeFormatTemplate ToDateTimeFormatTemplate(this string value)
        {
            return Instances.StringOperator_Extensions.ToDateTimeFormatTemplate(value);
        }

        public static IFormatted ToFormatted(this string value)
        {
            return Instances.StringOperator_Extensions.ToFormatted(value);
        }

        public static IFormattedDateTime ToFormattedDateTime(this string value)
        {
            return Instances.StringOperator_Extensions.ToFormattedDateTime(value);
        }

        public static IVersionString ToVersionString(this string value)
        {
            return Instances.StringOperator_Extensions.ToVersionString(value);
        }
    }
}
