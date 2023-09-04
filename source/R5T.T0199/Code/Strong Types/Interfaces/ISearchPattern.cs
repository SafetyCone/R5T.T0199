using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0199
{
    /// <summary>
    /// <para>Strongly-types a string as a seach pattern.</para>
    /// <inheritdoc cref="Y0000.Documentation.For_SearchPattern" path="/summary"/>
    /// </summary>
    /// <inheritdoc cref="Y0000.Documentation.For_SearchPattern" path="/remarks"/>
    [StrongTypeMarker]
    public interface ISearchPattern : IStrongTypeMarker,
        ITyped<string>
    {
    }
}