using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0199
{
    /// <inheritdoc cref="ISearchPattern"/>
    [StrongTypeImplementationMarker]
    public class SearchPattern : TypedBase<string>, IStrongTypeMarker,
        ISearchPattern
    {
        public SearchPattern(string value)
            : base(value)
        {
        }
    }
}