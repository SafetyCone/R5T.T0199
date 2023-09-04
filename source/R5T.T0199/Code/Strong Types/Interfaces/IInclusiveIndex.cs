using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0199
{
    /// <summary>
    /// Strongly-types a int as a an inclusive index.
    /// (Where the indexed item <em>is</em> included.)
    /// </summary>
    [StrongTypeMarker]
    public interface IInclusiveIndex : IStrongTypeMarker,
        ITyped<int>
    {
    }
}