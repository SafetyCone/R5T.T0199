using System;

using R5T.T0132;


namespace R5T.T0199.Extensions
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
    }
}
