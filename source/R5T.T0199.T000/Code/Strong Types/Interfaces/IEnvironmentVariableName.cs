using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <summary>
    /// Strongly-types a string as the name of an operating system environment variable.
    /// <para>
    /// Note: no assumption is made about whether the name is a Windows or Non-Windows environment variable name.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IEnvironmentVariableName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}