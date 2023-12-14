using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <inheritdoc cref="IFormat"/>
    [StrongTypeImplementationMarker]
    public sealed class Format : TypedBase<string>, IStrongTypeMarker,
        IFormat
    {
        public Format(string value)
            : base(value)
        {
        }
    }
}
