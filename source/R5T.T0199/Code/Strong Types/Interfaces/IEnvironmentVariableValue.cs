using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0199
{
    /// <summary>
    /// Strongly-types a string as a %%%.
    /// </summary>
    [StrongTypeMarker]
    public interface IEnvironmentVariableValue : IStrongTypeMarker,
        ITyped<string>
    {
    }
}