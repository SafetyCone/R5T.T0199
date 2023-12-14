using System;

using R5T.N0003;

using R5T.T0132;


namespace R5T.T0199.T000.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IEnvironmentVariableName"/>
        public IEnvironmentVariableName ToEnvironmentVariableName(string value)
        {
            var output = new EnvironmentVariableName(value);
            return output;
        }

        /// <inheritdoc cref="IEnvironmentVariableValue"/>
        public IEnvironmentVariableValue ToEnvironmentVariableValue(string value)
        {
            var output = new EnvironmentVariableValue(value);
            return output;
        }

        /// <inheritdoc cref="ISearchPattern"/>
        public ISearchPattern ToSearchPattern(string value)
        {
            var output = new SearchPattern(value);
            return output;
        }

        public IDateTimeFormat ToDateTimeFormat(string value)
        {
            var output = new DateTimeFormat(value);
            return output;
        }

        public IDateTimeFormatTemplate ToDateTimeFormatTemplate(string value)
        {
            var output = new DateTimeFormatTemplate(value);
            return output;
        }

        public IFormatted ToFormatted(string value)
        {
            var output = new Formatted(value);
            return output;
        }

        public IFormattedDateTime ToFormattedDateTime(string value)
        {
            var output = new FormattedDateTime(value);
            return output;
        }

        public IVersionString ToVersionString(string value)
        {
            var output = new VersionString(value);
            return output;
        }
    }
}
