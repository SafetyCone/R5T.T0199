using System;


namespace R5T.T0199.Extensions
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
    }
}
