using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <inheritdoc cref="IFormatted"/>
    [StrongTypeImplementationMarker]
    public sealed class Formatted : TypedBase<string>, IStrongTypeMarker,
        IFormatted
    {
        public Formatted(string value)
            : base(value)
        {
        }
    }
}
