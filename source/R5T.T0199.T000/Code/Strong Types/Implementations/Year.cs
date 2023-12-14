using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <inheritdoc cref="IYear"/>
    [StrongTypeImplementationMarker]
    public sealed class Year : TypedBase<int>, IStrongTypeMarker,
        IYear
    {
        public Year(int value)
            : base(value)
        {
        }
    }
}
