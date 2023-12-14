using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <summary>
    /// Strongly-types a int as a an exclusive index.
    /// (Where the indexed item is <em>not</em> included.)
    /// </summary>
    [StrongTypeMarker]
    public interface IExclusiveIndex : IStrongTypeMarker,
        ITyped<int>
    {
    }
}