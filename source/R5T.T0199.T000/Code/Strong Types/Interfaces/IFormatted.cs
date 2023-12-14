using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <summary>
    /// Typed string for strings containing formatted representations of other objects.
    /// </summary>
    [StrongTypeMarker]
    public interface IFormatted : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
