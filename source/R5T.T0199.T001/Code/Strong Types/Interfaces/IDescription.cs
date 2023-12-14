using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <summary>
    /// A description.
    /// </summary>
    [StrongTypeMarker]
    public interface IDescription : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
