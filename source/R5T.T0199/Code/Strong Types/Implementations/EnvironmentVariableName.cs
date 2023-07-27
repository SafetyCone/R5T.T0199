using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0199
{
    /// <inheritdoc cref="IEnvironmentVariableName"/>
    [StrongTypeImplementationMarker]
    public class EnvironmentVariableName : TypedBase<string>, IStrongTypeMarker,
        IEnvironmentVariableName
    {
        public EnvironmentVariableName(string value)
            : base(value)
        {
        }
    }
}