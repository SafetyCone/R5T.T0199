using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <summary>
    /// A year as a strongly-typed integer.
    /// </summary>
    [StrongTypeMarker]
    public interface IYear : IStrongTypeMarker,
        ITyped<int>
    {
    }
}
