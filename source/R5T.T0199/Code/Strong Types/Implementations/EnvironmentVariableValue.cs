using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0199
{
    /// <inheritdoc cref="IEnvironmentVariableValue"/>
    [StrongTypeImplementationMarker]
    public class EnvironmentVariableValue : TypedBase<string>, IStrongTypeMarker,
        IEnvironmentVariableValue
    {
        public EnvironmentVariableValue(string value)
            : base(value)
        {
        }
    }
}